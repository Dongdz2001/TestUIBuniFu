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

namespace VietLacSoVer52
{
    public partial class Form_Check_License : Form
    {
        private Form_Thong_Tin_License form_Thong_Tin_License;
        public Form_Check_License()
        {
            InitializeComponent();
            form_Thong_Tin_License = Form_Thong_Tin_License.GetInstance();
        }

        private void btnHaveNotLicense_Click(object sender, EventArgs e)
        {
            form_Thong_Tin_License.IsHaveLicense = false;
            form_Thong_Tin_License.LoadUserControls();
            this.OpenFormThongTinLicense();
        }

        private void btnHaveLicense_Click(object sender, EventArgs e)
        {
            form_Thong_Tin_License.IsHaveLicense = true;
            form_Thong_Tin_License.LoadUserControls();
            this.OpenFormThongTinLicense();
        }
        private void OpenFormThongTinLicense()
        {
            if (form_Thong_Tin_License == null || form_Thong_Tin_License.IsDisposed)
            {
                form_Thong_Tin_License = Form_Thong_Tin_License.GetInstance();
            }
            form_Thong_Tin_License.VisiblePanelLogo(true);
            form_Thong_Tin_License.Show();
        }

        private void btnHaveNotLicense_Click_1(object sender, EventArgs e)
        {
            form_Thong_Tin_License.IsHaveLicense = false;
            form_Thong_Tin_License.LoadUserControls();
            this.OpenFormThongTinLicense();
        }

        private void btnHaveLicense_Click_1(object sender, EventArgs e)
        {
            form_Thong_Tin_License.IsHaveLicense = true;
            form_Thong_Tin_License.LoadUserControls();
            this.OpenFormThongTinLicense();
        }
    }
}
