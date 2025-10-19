using System;
using System.Data;
using System.Windows.Forms;
using TapHoa.DAL;

namespace TapHoa
{
    public partial class frmLichSuPhieuNhap : Form
    {
        public frmLichSuPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmLichSuPhieuNhap_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;
            LoadLichSuPhieuNhap();
        }

        private void LoadLichSuPhieuNhap()
        {
            try
            {
                string query = @"SELECT PN.MaPhieuNhap, PN.NgayNhap, NV.TenNhanVien, 
                                NCC.TenNhaCungCap, PN.TongTienNhap
                                FROM PHIEUNHAP PN
                                INNER JOIN NHANVIEN NV ON PN.MaNhanVien = NV.MaNhanVien
                                INNER JOIN NHACUNGCAP NCC ON PN.MaNhaCungCap = NCC.MaNhaCungCap
                                WHERE PN.NgayNhap BETWEEN @TuNgay AND @DenNgay
                                ORDER BY PN.NgayNhap DESC";
                
                DataTable dt = DataAccess.ExecuteQuery(query,
                    new System.Data.SqlClient.SqlParameter[] {
                        new System.Data.SqlClient.SqlParameter("@TuNgay", dtpTuNgay.Value.Date),
                        new System.Data.SqlClient.SqlParameter("@DenNgay", dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1))
                    });

                dgvLichSu.DataSource = dt;

                if (dgvLichSu.Columns.Count > 0)
                {
                    dgvLichSu.Columns["MaPhieuNhap"].HeaderText = "Mã PN";
                    dgvLichSu.Columns["MaPhieuNhap"].Width = 70;
                    dgvLichSu.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                    dgvLichSu.Columns["NgayNhap"].Width = 140;
                    dgvLichSu.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvLichSu.Columns["TenNhanVien"].HeaderText = "Nhân viên";
                    dgvLichSu.Columns["TenNhanVien"].Width = 150;
                    dgvLichSu.Columns["TenNhaCungCap"].HeaderText = "Nhà cung cấp";
                    dgvLichSu.Columns["TenNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvLichSu.Columns["TongTienNhap"].HeaderText = "Tổng tiền";
                    dgvLichSu.Columns["TongTienNhap"].Width = 120;
                    dgvLichSu.Columns["TongTienNhap"].DefaultCellStyle.Format = "N0";
                    dgvLichSu.Columns["TongTienNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                lblTongSo.Text = $"Tổng số: {dt.Rows.Count} phiếu nhập";
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
            LoadLichSuPhieuNhap();
        }

        private void dgvLichSu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maPhieuNhap = Convert.ToInt32(dgvLichSu.Rows[e.RowIndex].Cells["MaPhieuNhap"].Value);
                frmXemTruocIn form = new frmXemTruocIn(maPhieuNhap, "PhieuNhap");
                form.ShowDialog();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
