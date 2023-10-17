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

namespace VietLacSoVer52.UC_License_Validate
{
    public partial class UC_Tai_Kich_Hoat_Thanh_Cong : UserControl
    {
        private bool isHaveLicense;
        public UC_Tai_Kich_Hoat_Thanh_Cong(bool isHaveLicense = false)
        {
            InitializeComponent();
            this.isHaveLicense = isHaveLicense;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isHaveLicense)
            {
                UC_Khoi_Phuc_License uC_Khoi_Phuc_License = new UC_Khoi_Phuc_License();
                Form_Thong_Tin_License.GetInstance().VisiblePanelLogo(true);
                this.ShowUserControl(uC_Khoi_Phuc_License);
            }
            else
            {
                UC_Dang_Ky_Thanh_Cong uC_Dang_Ky_Thanh_Cong = new UC_Dang_Ky_Thanh_Cong();
                Form_Thong_Tin_License.GetInstance().VisiblePanelLogo(true);
                this.ShowUserControl(uC_Dang_Ky_Thanh_Cong);
            }

        }
        private void ShowUserControl(UserControl userControl)
        {
            this.Controls.Clear();

            // Thêm UserControl mới vào ngăn xếp

            // Hiển thị UserControl mới
            userControl.Dock = DockStyle.Fill;

            this.Controls.Add(userControl);
        }

   

        //private void UC_Tai_Kich_Hoat_Thanh_Cong_Load(object sender, EventArgs e)
        //{
        //    BunifuTransition transition = new BunifuTransition();
        //    transition.ShowSync(lbLicense, true,
        //        Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizBlind);
        //    transition.ShowSync(bunifuCards, true,
        //       Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizBlind);
        //    transition.ShowSync(btnBack, true,
        //       Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.VertBlind);
        //}

        private void btnGiaHanLicense_Click(object sender, EventArgs e)
        {
            UC_Dang_Ky_Thanh_Cong uC_Dang_Ky_Thanh_Cong = new UC_Dang_Ky_Thanh_Cong();
            Form_Thong_Tin_License.GetInstance().VisiblePanelLogo(true);
            this.ShowUserControl(uC_Dang_Ky_Thanh_Cong);
        }
    }
}
