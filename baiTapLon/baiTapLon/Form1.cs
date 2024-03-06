using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTapLon
{
    public partial class Form1 : Form
    {
        string isBtn = null;
        int index = -1;
        public Form1()
        {
            InitializeComponent();
        }

        #region Method
        void createColumn()
        {
            //Tạo cột
            var colHoTen = new DataGridViewTextBoxColumn();
            var colSdt = new DataGridViewTextBoxColumn();
            var colEmail = new DataGridViewTextBoxColumn();
            var colDiaChi = new DataGridViewTextBoxColumn();

            //Tên cột
            colHoTen.HeaderText = "Họ và Tên";
            colSdt.HeaderText = "Số điện thoại";
            colEmail.HeaderText = "Email";
            colDiaChi.HeaderText = "Địa chỉ";

            //Chỉnh sửa tên giống DanhSach1
            colHoTen.DataPropertyName = "HoTen1";
            colSdt.DataPropertyName = "Sdt1";
            colEmail.DataPropertyName = "Email1";
            colDiaChi.DataPropertyName = "DiaChi1";
            

            //Kích thước cột
            colHoTen.Width = 150;
            colSdt.Width = 110;
            colEmail.Width = 140;
            colDiaChi.Width = 180;

            dataGridViewNhap.Columns.AddRange(new DataGridViewColumn[] { colHoTen, colSdt, colEmail, colDiaChi });
        }

        void LoadDanhSach()
        {
            dataGridViewNhap.DataSource = null;
            createColumn();
            dataGridViewNhap.DataSource = ListNhap.Vidu.DsNhap;
            dataGridViewNhap.Refresh();
        }

        //Hàm đóng mở trường thông tin và bảng
        void themThanhVien(bool isTestBox, bool isDataGridView)
        {
            txbHoTen.Enabled = txbSdt.Enabled = txbEmail.Enabled = txbDiaChi.Enabled = isTestBox;
            dataGridViewNhap.Enabled = isDataGridView;
        }

        //cập nhập trường thông tin về null
        void resetTxb()
        {
            for(var i = 0; i < this.Controls.Count;i++)
            {
                TextBox item = this.Controls[i] as TextBox;
                if(item != null)
                {
                    item.Clear();
                }
            }
        }

        #endregion

        #region event
        //nút thoát
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            themThanhVien(false, true);

            createColumn();
            LoadDanhSach();

            btnLuu.Enabled = btnHuy.Enabled = false;
        }

        //button Lưu 
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hoTen = txbHoTen.Text;
            string sdt = txbSdt.Text;
            string email = txbEmail.Text;
            string diaChi = txbDiaChi.Text;

            if(isBtn == "them")
            {
                if (txbHoTen.Text == "" || txbSdt.Text == "" || txbDiaChi.Text == "")
                {
                    MessageBox.Show("Có thông tin đang bỏ trống!", "Chú ý");
                    return;
                }
                else
                {
                    ListNhap.Vidu.DsNhap.Add(new DanhSach1(hoTen, sdt, email, diaChi));
                }
            }    

            if(isBtn == "sua")
            {
                if( txbHoTen.Text == "" || txbSdt.Text == "" || txbDiaChi.Text == "")
                {
                    MessageBox.Show("Có thông tin đang bỏ trống!", "Chú ý");
                    return;
                }    
                else
                {
                    ListNhap.Vidu.DsNhap[index].HoTen1 = txbHoTen.Text;
                    ListNhap.Vidu.DsNhap[index].Sdt1 = txbSdt.Text;
                    ListNhap.Vidu.DsNhap[index].Email1 = txbEmail.Text;
                    ListNhap.Vidu.DsNhap[index].DiaChi1 = txbDiaChi.Text;
                }
            }

            themThanhVien(false, true);

            btnThem.Enabled = btnSua.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;

            LoadDanhSach();
            resetTxb(); 
        }

        private void dataGridViewNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Button thêm 
        private void btnThem_Click(object sender, EventArgs e)
        {
            themThanhVien(true, false);

            btnThem.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;

            isBtn = "them";

        }

        #endregion

        //Button sửa 
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(index == -1)
            {
                MessageBox.Show("Hãy chọn trường thông tin", "Cảnh báo");
                return;
            }
            themThanhVien(true, false);

            btnThem.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;

            txbHoTen.Text = ListNhap.Vidu.DsNhap[index].HoTen1;
            txbSdt.Text = ListNhap.Vidu.DsNhap[index].Sdt1;
            txbEmail.Text = ListNhap.Vidu.DsNhap[index].Email1;
            txbDiaChi.Text = ListNhap.Vidu.DsNhap[index].DiaChi1;
     
            isBtn = "sua";
        }

        private void dataGridViewNhap_SelectionChanged(object sender, EventArgs e)
        {

        }

        //Lấy chỉ số thứ tự của danh sách trong Listnhap
        private void dataGridViewNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex; 
        }

        //button xóa
        private void bntXoa_Click(object sender, EventArgs e)
        {
            ListNhap.Vidu.DsNhap.RemoveAt(index);
            LoadDanhSach();
        }

        //button hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetTxb();
            themThanhVien(false, true);

            btnThem.Enabled = btnSua.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiem timKiem = new TimKiem();
            timKiem.Show();
        }
    }
}
