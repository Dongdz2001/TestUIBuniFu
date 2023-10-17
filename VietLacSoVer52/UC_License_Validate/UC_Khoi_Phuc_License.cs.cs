using Bunifu.UI.WinForms;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VietLacSoVer52.Model.DTO_Validation;

namespace VietLacSoVer52.UC_License_Validate
{
    public partial class UC_Khoi_Phuc_License : UserControl
    {
        private UC_Tai_Kich_Hoat_Thanh_Cong uC_Tai_Kich_Hoat_Thanh_Cong;
        private Form_Dang_Ky_License form_Dang_Ky_License;

        public UC_Khoi_Phuc_License()
        {
            InitializeComponent();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (!isNotNullFormTaiKichHoat())
            {
                return;
            }

            // gán lại giá trị từ textbox để lưu lại
            form_Dang_Ky_License.SoDienThoai = txtSDT.Text;
            form_Dang_Ky_License.MaBaoMat = txtMaBaoMat.Text;
            form_Dang_Ky_License.LicenseKey = txtLicenseKey.Text;

            uC_Tai_Kich_Hoat_Thanh_Cong = new UC_Tai_Kich_Hoat_Thanh_Cong(true);
            Form_Thong_Tin_License.GetInstance().VisiblePanelLogo(false);
            this.ShowUserControl(uC_Tai_Kich_Hoat_Thanh_Cong);
        }

        private void ShowUserControl(UserControl userControl)
        {
            this.Controls.Clear();

            // Thêm UserControl mới vào ngăn xếp

            // Hiển thị UserControl mới
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            this.Controls.Add(userControl);
        }

        private bool isTextNull(BunifuTextBox textObject)
        {
            return textObject.Text.Equals(String.Empty);
        }

        private bool isNotNullFormTaiKichHoat()
        {
            if (isTextNull(txtSDT))
            {
                XtraMessageBox.Show("Số điện thoại không được để trống", "Cảnh báo", MessageBoxButtons.OK);
                return false;
            }
            if (isTextNull(txtMaBaoMat))
            {
                XtraMessageBox.Show("Mã bảo mật không được để trống", "Cảnh báo", MessageBoxButtons.OK);
                return false;
            }
            if (isTextNull(txtLicenseKey))
            {
                XtraMessageBox.Show("License không được để trống", "Cảnh báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void UC_Khoi_Phuc_License_Load(object sender, EventArgs e)
        {
            // đọc giá trị đã lưu lên màn hình
            form_Dang_Ky_License = Form_Dang_Ky_License.GetInstance();
            txtSDT.Text = form_Dang_Ky_License.SoDienThoai;
            txtMaBaoMat.Text = form_Dang_Ky_License.MaBaoMat;
            txtLicenseKey.Text = form_Dang_Ky_License.LicenseKey;
        }
    }
}
