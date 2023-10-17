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
using VietLacSoVer52.UC_License_Validate;

namespace VietLacSoVer52
{
    public partial class Form_Thong_Tin_License : Form
    {
        public bool IsHaveLicense {  get; set; }

        // Đây là biến để lưu trữ thể hiện duy nhất của lớp.
        private static Form_Thong_Tin_License instance;

        // Sử dụng constructor riêng tư để ngăn tạo thể hiện bên ngoài lớp.
        private Form_Thong_Tin_License()
        {
            InitializeComponent();
            this.IsHaveLicense = false;
        }

        // Phương thức để truy cập thể hiện duy nhất của lớp.
        public static Form_Thong_Tin_License GetInstance()
        {
            if (instance == null)
            {
                instance = new Form_Thong_Tin_License();
            }
            return instance;
        }

        private void Form_Thong_Tin_License_Load(object sender, EventArgs e)
        {
            this.LoadUserControls();
        }

        public void VisiblePanelLogo(bool switchControl)
        {
            this.panel2.Visible = switchControl;
        }

        private void Form_Thong_Tin_License_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Dang_Ky_License.GetInstance().ClearAllData();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Prevent the form from actually closing
                this.Hide();     // Hide the form instead
            }
        }
        public void LoadUserControls()
        {
            if (IsHaveLicense)
            {
                guna2Panel1.Controls.Clear();
                UC_Khoi_Phuc_License uC_Khoi_Phuc_License = new UC_Khoi_Phuc_License();
                uC_Khoi_Phuc_License.Dock = DockStyle.Fill;
                guna2Panel1.Controls.Add(uC_Khoi_Phuc_License);
            }
            else
            {
                guna2Panel1.Controls.Clear();
                UC_Dang_Ky_Thong_Tin uC_Dang_Ky_Thong_Tin = new UC_Dang_Ky_Thong_Tin();
                uC_Dang_Ky_Thong_Tin.Dock = DockStyle.Fill;
                guna2Panel1.Controls.Add(uC_Dang_Ky_Thong_Tin);

            }
        }
    }
}
