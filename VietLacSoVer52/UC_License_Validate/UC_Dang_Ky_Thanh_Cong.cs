using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VietLacSoVer52.UC_License_Validate;

namespace VietLacSoVer52.UC_License_Validate
{
    public partial class UC_Dang_Ky_Thanh_Cong : UserControl
    {
        public UC_Dang_Ky_Thanh_Cong()
        {
            InitializeComponent();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_Dang_Ky_Thong_Tin uC_Dang_Ky_Thong_Tin = new UC_Dang_Ky_Thong_Tin();
            ShowUserControl(uC_Dang_Ky_Thong_Tin);
        }

        private void ShowUserControl(UserControl userControl)
        {
            this.Controls.Clear();

            // Hiển thị UserControl mới
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            this.Controls.Add(userControl);
        }

        private void dropDownLoaiLicense_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn trong Dropdown
            string selectedValue = dropDownLoaiLicense.SelectedItem.ToString();

            // Thực hiện các thao tác dựa trên giá trị được chọn, ví dụ:
            if (selectedValue.Equals("Miễn phí"))
            {
                dropDownHanLicense.Enabled = false;
                dropDownLuuDuLieu.Enabled = false;
            }
            else
            {
                dropDownHanLicense.Enabled = true;
                dropDownLuuDuLieu.Enabled = true;
            }

        }
        private void btnGiaHanNgay_Click(object sender, EventArgs e)
        {
            UC_Tai_Kich_Hoat_Thanh_Cong uC_Tai_Kich_Hoat_Thanh_Cong = new UC_Tai_Kich_Hoat_Thanh_Cong();
            Form_Thong_Tin_License.GetInstance().VisiblePanelLogo(false);
            this.ShowUserControl(uC_Tai_Kich_Hoat_Thanh_Cong);
        }
    }
}
