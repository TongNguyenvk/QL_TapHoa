using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using TapHoa.DAL;

namespace TapHoa
{
    public partial class frmXemLichLamViec : Form
    {
        private int maNhanVien;

        public frmXemLichLamViec(int maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;
        }

        private void frmXemLichLamViec_Load(object sender, EventArgs e)
        {
            // Thiết lập ngôn ngữ tiếng Việt cho MonthCalendar
            CultureInfo viVN = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = viVN;
            Thread.CurrentThread.CurrentUICulture = viVN;
            
            // Load thông tin nhân viên
            LoadThongTinNhanVien();
            
            // Thiết lập MonthCalendar để chọn tuần hiện tại
            monthCalendar.SelectionStart = DateTime.Today;
            monthCalendar.SelectionEnd = DateTime.Today.AddDays(6);
            
            // Load lịch làm việc của tuần hiện tại
            LoadLichLamViec();
        }

        private void LoadThongTinNhanVien()
        {
            try
            {
                string query = @"SELECT TenNhanVien, vt.TenVaiTro 
                                FROM NHANVIEN nv
                                INNER JOIN VAITRO vt ON nv.MaVaiTro = vt.MaVaiTro
                                WHERE MaNhanVien = @MaNhanVien";

                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@MaNhanVien", maNhanVien)
                };

                DataTable dt = DataAccess.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    lblTenNhanVien.Text = dt.Rows[0]["TenNhanVien"].ToString();
                    lblVaiTro.Text = dt.Rows[0]["TenVaiTro"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLichLamViec()
        {
            try
            {
                DateTime tuNgay = monthCalendar.SelectionStart;
                DateTime denNgay = monthCalendar.SelectionEnd;

                string query = @"SELECT NgayLamViec, 
                                CONVERT(VARCHAR(5), GioBatDau, 108) AS GioBatDau,
                                CONVERT(VARCHAR(5), GioKetThuc, 108) AS GioKetThuc,
                                MoTa
                                FROM LICHLAMVIEC
                                WHERE MaNhanVien = @MaNhanVien 
                                AND NgayLamViec BETWEEN @TuNgay AND @DenNgay
                                ORDER BY NgayLamViec, GioBatDau";

                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@MaNhanVien", maNhanVien),
                    new SqlParameter("@TuNgay", tuNgay.Date),
                    new SqlParameter("@DenNgay", denNgay.Date)
                };

                DataTable dt = DataAccess.ExecuteQuery(query, parameters);
                dgvLichCaNhan.DataSource = dt;

                // Định dạng DataGridView
                if (dgvLichCaNhan.Columns.Count > 0)
                {
                    dgvLichCaNhan.Columns["NgayLamViec"].HeaderText = "Ngày làm việc";
                    dgvLichCaNhan.Columns["NgayLamViec"].Width = 200;
                    dgvLichCaNhan.Columns["NgayLamViec"].DefaultCellStyle.Format = "dd/MM/yyyy (dddd)";

                    dgvLichCaNhan.Columns["GioBatDau"].HeaderText = "Giờ bắt đầu";
                    dgvLichCaNhan.Columns["GioBatDau"].Width = 120;

                    dgvLichCaNhan.Columns["GioKetThuc"].HeaderText = "Giờ kết thúc";
                    dgvLichCaNhan.Columns["GioKetThuc"].Width = 120;

                    dgvLichCaNhan.Columns["MoTa"].HeaderText = "Ghi chú";
                    dgvLichCaNhan.Columns["MoTa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                // Cập nhật label thống kê
                lblThongKe.Text = $"Tìm thấy {dt.Rows.Count} ca làm việc từ {tuNgay:dd/MM/yyyy} đến {denNgay:dd/MM/yyyy}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch làm việc: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadLichLamViec();
        }

        private void btnChonTuanHienTai_Click(object sender, EventArgs e)
        {
            // Chọn tuần hiện tại (từ thứ 2 đến chủ nhật)
            DateTime today = DateTime.Today;
            int daysFromMonday = ((int)today.DayOfWeek - (int)DayOfWeek.Monday + 7) % 7;
            DateTime monday = today.AddDays(-daysFromMonday);
            DateTime sunday = monday.AddDays(6);

            monthCalendar.SelectionStart = monday;
            monthCalendar.SelectionEnd = sunday;
            LoadLichLamViec();
        }

        private void btnChonThangHienTai_Click(object sender, EventArgs e)
        {
            // Chọn tháng hiện tại
            DateTime today = DateTime.Today;
            DateTime firstDay = new DateTime(today.Year, today.Month, 1);
            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

            monthCalendar.SelectionStart = firstDay;
            monthCalendar.SelectionEnd = lastDay;
            LoadLichLamViec();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
