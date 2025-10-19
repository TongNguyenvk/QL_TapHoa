using System;
using System.Data;
using System.Windows.Forms;
using TapHoa.DAL;

namespace TapHoa
{
    public partial class frmLichSuHoaDon : Form
    {
        public frmLichSuHoaDon()
        {
            InitializeComponent();
        }

        private void frmLichSuHoaDon_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;
            LoadLichSuHoaDon();
        }

        private void LoadLichSuHoaDon()
        {
            try
            {
                string query = @"SELECT HD.MaHoaDon, HD.NgayBan, NV.TenNhanVien, HD.TongTien
                                FROM HOADON HD
                                INNER JOIN NHANVIEN NV ON HD.MaNhanVien = NV.MaNhanVien
                                WHERE HD.NgayBan BETWEEN @TuNgay AND @DenNgay
                                ORDER BY HD.NgayBan DESC";
                
                DataTable dt = DataAccess.ExecuteQuery(query,
                    new System.Data.SqlClient.SqlParameter[] {
                        new System.Data.SqlClient.SqlParameter("@TuNgay", dtpTuNgay.Value.Date),
                        new System.Data.SqlClient.SqlParameter("@DenNgay", dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1))
                    });

                dgvLichSu.DataSource = dt;

                if (dgvLichSu.Columns.Count > 0)
                {
                    dgvLichSu.Columns["MaHoaDon"].HeaderText = "Mã HĐ";
                    dgvLichSu.Columns["MaHoaDon"].Width = 80;
                    dgvLichSu.Columns["NgayBan"].HeaderText = "Ngày bán";
                    dgvLichSu.Columns["NgayBan"].Width = 150;
                    dgvLichSu.Columns["NgayBan"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvLichSu.Columns["TenNhanVien"].HeaderText = "Nhân viên";
                    dgvLichSu.Columns["TenNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvLichSu.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dgvLichSu.Columns["TongTien"].Width = 120;
                    dgvLichSu.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                    dgvLichSu.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                lblTongSo.Text = $"Tổng số: {dt.Rows.Count} hóa đơn";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch sử: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpDenNgay.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadLichSuHoaDon();
        }

        private void dgvLichSu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maHoaDon = Convert.ToInt32(dgvLichSu.Rows[e.RowIndex].Cells["MaHoaDon"].Value);
                frmXemTruocIn form = new frmXemTruocIn(maHoaDon, "HoaDon");
                form.ShowDialog();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
