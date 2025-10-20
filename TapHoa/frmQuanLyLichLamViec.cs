using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using TapHoa.DAL;

namespace TapHoa
{
    public partial class frmQuanLyLichLamViec : Form
    {
        private DataTable dtLichLamViec;
        private string action = "";
        private int selectedMaLich = 0;

        public frmQuanLyLichLamViec()
        {
            InitializeComponent();
        }

        private void frmQuanLyLichLamViec_Load(object sender, EventArgs e)
        {
            // Thiết lập ngôn ngữ tiếng Việt cho MonthCalendar
            CultureInfo viVN = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = viVN;
            Thread.CurrentThread.CurrentUICulture = viVN;
            
            LoadNhanVien();
            LoadLichLamViec();
            EnableInput(false);
            
            // Chỉ cho phép chọn ngày từ ngày mai trở đi (không cho chọn ngày hiện tại và quá khứ)
            dtpNgayLam.MinDate = DateTime.Today.AddDays(1);
            dtpNgayLam.Value = DateTime.Today.AddDays(1);
            
            dtpGioBatDau.Value = DateTime.Today.AddHours(8);
            dtpGioKetThuc.Value = DateTime.Today.AddHours(17);
        }

        private void LoadNhanVien()
        {
            try
            {
                string query = "SELECT MaNhanVien, TenNhanVien FROM NHANVIEN ORDER BY TenNhanVien";
                DataTable dt = DataAccess.ExecuteQuery(query);

                lstNhanVien.Items.Clear();
                cboNhanVienTrongCa.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string display = row["TenNhanVien"].ToString();
                    int maNV = Convert.ToInt32(row["MaNhanVien"]);
                    
                    lstNhanVien.Items.Add(new NhanVienItem 
                    { 
                        MaNhanVien = maNV, 
                        TenNhanVien = display 
                    });
                    
                    cboNhanVienTrongCa.Items.Add(new NhanVienItem 
                    { 
                        MaNhanVien = maNV, 
                        TenNhanVien = display 
                    });
                }

                for (int i = 0; i < lstNhanVien.Items.Count; i++)
                {
                    lstNhanVien.SetItemChecked(i, true);
                }

                if (cboNhanVienTrongCa.Items.Count > 0)
                {
                    cboNhanVienTrongCa.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLichLamViec()
        {
            try
            {
                DateTime startDate = monthCalendar.SelectionStart;
                DateTime endDate = monthCalendar.SelectionEnd;

                string maNhanVienFilter = GetSelectedNhanVienFilter();

                string query = @"SELECT l.MaLich, nv.TenNhanVien, l.NgayLamViec, 
                                CONVERT(VARCHAR(5), l.GioBatDau, 108) AS GioBatDau,
                                CONVERT(VARCHAR(5), l.GioKetThuc, 108) AS GioKetThuc,
                                l.MoTa, l.MaNhanVien
                                FROM LICHLAMVIEC l
                                INNER JOIN NHANVIEN nv ON l.MaNhanVien = nv.MaNhanVien
                                WHERE l.NgayLamViec BETWEEN @StartDate AND @EndDate";

                if (!string.IsNullOrEmpty(maNhanVienFilter))
                {
                    query += $" AND l.MaNhanVien IN ({maNhanVienFilter})";
                }

                query += " ORDER BY l.NgayLamViec, l.GioBatDau";

                SqlParameter[] parameters = {
                    new SqlParameter("@StartDate", startDate.Date),
                    new SqlParameter("@EndDate", endDate.Date)
                };

                dtLichLamViec = DataAccess.ExecuteQuery(query, parameters);
                dgvLichLamViec.DataSource = dtLichLamViec;

                if (dgvLichLamViec.Columns.Count > 0)
                {
                    dgvLichLamViec.Columns["MaLich"].HeaderText = "Mã";
                    dgvLichLamViec.Columns["MaLich"].Width = 50;
                    dgvLichLamViec.Columns["MaNhanVien"].Visible = false;
                    dgvLichLamViec.Columns["TenNhanVien"].HeaderText = "Nhân viên";
                    dgvLichLamViec.Columns["NgayLamViec"].HeaderText = "Ngày làm";
                    dgvLichLamViec.Columns["NgayLamViec"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvLichLamViec.Columns["GioBatDau"].HeaderText = "Giờ bắt đầu";
                    dgvLichLamViec.Columns["GioBatDau"].Width = 100;
                    dgvLichLamViec.Columns["GioKetThuc"].HeaderText = "Giờ kết thúc";
                    dgvLichLamViec.Columns["GioKetThuc"].Width = 100;
                    dgvLichLamViec.Columns["MoTa"].HeaderText = "Ghi chú";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch làm việc: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSelectedNhanVienFilter()
        {
            string filter = "";
            for (int i = 0; i < lstNhanVien.CheckedItems.Count; i++)
            {
                NhanVienItem item = (NhanVienItem)lstNhanVien.CheckedItems[i];
                if (i > 0) filter += ",";
                filter += item.MaNhanVien.ToString();
            }
            return filter;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadLichLamViec();
        }

        private void lstNhanVien_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(new Action(() => LoadLichLamViec()));
        }

        private void dgvLichLamViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && action == "")
            {
                DataGridViewRow row = dgvLichLamViec.Rows[e.RowIndex];
                selectedMaLich = Convert.ToInt32(row.Cells["MaLich"].Value);
                
                int maNhanVien = Convert.ToInt32(row.Cells["MaNhanVien"].Value);
                for (int i = 0; i < cboNhanVienTrongCa.Items.Count; i++)
                {
                    NhanVienItem item = (NhanVienItem)cboNhanVienTrongCa.Items[i];
                    if (item.MaNhanVien == maNhanVien)
                    {
                        cboNhanVienTrongCa.SelectedIndex = i;
                        break;
                    }
                }

                // Tạm thời bỏ MinDate để có thể hiển thị ngày cũ
                DateTime ngayLamViec = Convert.ToDateTime(row.Cells["NgayLamViec"].Value);
                dtpNgayLam.MinDate = DateTimePicker.MinimumDateTime;
                dtpNgayLam.Value = ngayLamViec;
                // Set lại MinDate sau khi load xong
                dtpNgayLam.MinDate = DateTime.Today.AddDays(1);
                
                // Parse giờ từ string "HH:mm"
                string gioBatDauStr = row.Cells["GioBatDau"].Value?.ToString() ?? "08:00";
                string gioKetThucStr = row.Cells["GioKetThuc"].Value?.ToString() ?? "17:00";
                
                DateTime today = DateTime.Today;
                string[] gioBatDauParts = gioBatDauStr.Split(':');
                string[] gioKetThucParts = gioKetThucStr.Split(':');
                
                dtpGioBatDau.Value = today.AddHours(int.Parse(gioBatDauParts[0])).AddMinutes(int.Parse(gioBatDauParts[1]));
                dtpGioKetThuc.Value = today.AddHours(int.Parse(gioKetThucParts[0])).AddMinutes(int.Parse(gioKetThucParts[1]));
                
                txtGhiChu.Text = row.Cells["MoTa"].Value?.ToString() ?? "";
            }
        }

        private void btnThemCa_Click(object sender, EventArgs e)
        {
            action = "ADD";
            EnableInput(true);
            ClearInput();
            btnLuuCa.Enabled = true;
            btnBoQua.Enabled = true;
            btnThemCa.Enabled = false;
            btnXoaCa.Enabled = false;
        }

        private void btnLuuCa_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                NhanVienItem selectedNV = (NhanVienItem)cboNhanVienTrongCa.SelectedItem;
                
                if (action == "ADD")
                {
                    string query = @"INSERT INTO LICHLAMVIEC (MaNhanVien, NgayLamViec, GioBatDau, GioKetThuc, MoTa) 
                                   VALUES (@MaNhanVien, @NgayLamViec, @GioBatDau, @GioKetThuc, @MoTa)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@MaNhanVien", selectedNV.MaNhanVien),
                        new SqlParameter("@NgayLamViec", dtpNgayLam.Value.Date),
                        new SqlParameter("@GioBatDau", dtpGioBatDau.Value.TimeOfDay),
                        new SqlParameter("@GioKetThuc", dtpGioKetThuc.Value.TimeOfDay),
                        new SqlParameter("@MoTa", txtGhiChu.Text.Trim())
                    };

                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Thêm ca làm việc thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (action == "EDIT")
                {
                    string query = @"UPDATE LICHLAMVIEC SET 
                                   MaNhanVien = @MaNhanVien, 
                                   NgayLamViec = @NgayLamViec, 
                                   GioBatDau = @GioBatDau, 
                                   GioKetThuc = @GioKetThuc, 
                                   MoTa = @MoTa 
                                   WHERE MaLich = @MaLich";
                    SqlParameter[] parameters = {
                        new SqlParameter("@MaNhanVien", selectedNV.MaNhanVien),
                        new SqlParameter("@NgayLamViec", dtpNgayLam.Value.Date),
                        new SqlParameter("@GioBatDau", dtpGioBatDau.Value.TimeOfDay),
                        new SqlParameter("@GioKetThuc", dtpGioKetThuc.Value.TimeOfDay),
                        new SqlParameter("@MoTa", txtGhiChu.Text.Trim()),
                        new SqlParameter("@MaLich", selectedMaLich)
                    };

                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Cập nhật ca làm việc thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadLichLamViec();
                btnBoQua_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            if (dgvLichLamViec.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn ca làm việc cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ca làm việc này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM LICHLAMVIEC WHERE MaLich = @MaLich";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaLich", selectedMaLich)
                };

                try
                {
                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Xóa ca làm việc thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLichLamViec();
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            action = "";
            EnableInput(false);
            ClearInput();
            btnLuuCa.Enabled = false;
            btnBoQua.Enabled = false;
            btnThemCa.Enabled = true;
            btnXoaCa.Enabled = true;
        }

        private bool ValidateInput()
        {
            if (cboNhanVienTrongCa.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhanVienTrongCa.Focus();
                return false;
            }

            if (dtpGioBatDau.Value.TimeOfDay >= dtpGioKetThuc.Value.TimeOfDay)
            {
                MessageBox.Show("Giờ kết thúc phải sau giờ bắt đầu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpGioKetThuc.Focus();
                return false;
            }

            return true;
        }

        private void EnableInput(bool enabled)
        {
            cboNhanVienTrongCa.Enabled = enabled;
            dtpNgayLam.Enabled = enabled;
            dtpGioBatDau.Enabled = enabled;
            dtpGioKetThuc.Enabled = enabled;
            txtGhiChu.Enabled = enabled;
        }

        private void ClearInput()
        {
            if (cboNhanVienTrongCa.Items.Count > 0)
            {
                cboNhanVienTrongCa.SelectedIndex = 0;
            }
            // Set ngày mặc định là ngày mai (vì MinDate = ngày mai)
            dtpNgayLam.Value = DateTime.Today.AddDays(1);
            dtpGioBatDau.Value = DateTime.Today.AddHours(8);
            dtpGioKetThuc.Value = DateTime.Today.AddHours(17);
            txtGhiChu.Clear();
            selectedMaLich = 0;
        }
    }

    public class NhanVienItem
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }

        public override string ToString()
        {
            return TenNhanVien;
        }
    }
}
