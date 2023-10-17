using Bunifu.UI.WinForms;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VietLacSoVer52;
using VietLacSoVer52.Model.DTO_Validation;

namespace VietLacSoVer52.UC_License_Validate
{
    public partial class UC_Dang_Ky_Thong_Tin : UserControl
    {

        private  Form_Dang_Ky_License form_Dang_Ky_License ;
        public UC_Dang_Ky_Thong_Tin()
        {
            InitializeComponent();
            form_Dang_Ky_License = Form_Dang_Ky_License.GetInstance();
            txtTenNguoiDung.Text = form_Dang_Ky_License.TenNguoiDung;
            txtSDT.Text = form_Dang_Ky_License.SoDienThoai;
            txtDiaChi.Text = form_Dang_Ky_License.DiaChi;
            txtEmail.Text = form_Dang_Ky_License.Email;
            txtLoiNhan.Text = form_Dang_Ky_License.LoiNhan;
        }

        private void btnSentInfo_Click(object sender, EventArgs e)
        {
            if (!this.isNotNullFormRegister())
            {
                return;
            }

            form_Dang_Ky_License.TenNguoiDung = txtTenNguoiDung.Text;
            form_Dang_Ky_License.SoDienThoai = txtSDT.Text;
            form_Dang_Ky_License.DiaChi = txtDiaChi.Text;
            form_Dang_Ky_License.Email = txtEmail.Text;
            form_Dang_Ky_License.LoiNhan = txtLoiNhan.Text;

            UC_Dang_Ky_Thanh_Cong uC_Dang_Ky_Thanh_Cong = new UC_Dang_Ky_Thanh_Cong();
            ShowUserControl(uC_Dang_Ky_Thanh_Cong);
        }

        private void ShowUserControl(UserControl userControl)
        {
            // Xóa tất cả các UserControl trong Controls của UserControl hiện tại
            this.Controls.Clear();

            // Hiển thị UserControl mới
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            this.Controls.Add(userControl);
        }

        private bool isTextNull(BunifuTextBox textObject)
        {
            return textObject.Text.Equals("");
        }
        private bool isNotNullFormRegister()
        {

            if (isTextNull(txtTenNguoiDung))
            {
                XtraMessageBox.Show("Tên người dùng không được để trống", "Cảnh báo", MessageBoxButtons.OK);
                return false;
            }
            else if (isTextNull(txtSDT))
            {
                XtraMessageBox.Show("Số điện thoại người dùng không được để trống", "Cảnh báo", MessageBoxButtons.OK);
                return false;
            }
            else if (isTextNull(txtEmail))
            {
                XtraMessageBox.Show("Email người dùng không được để trống", "Cảnh báo", MessageBoxButtons.OK);
                return false;
            }
            else if (isTextNull(txtDiaChi))
            {
                XtraMessageBox.Show("Địa chỉ người dùng không được để trống", "Cảnh báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }


    }
}
