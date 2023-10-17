using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietLacSoVer52.Model.DTO_Validation
{
    public class Form_Dang_Ky_License
    {
        // Private static instance of the class
        private static Form_Dang_Ky_License instance;

        // Private constructor to prevent external instantiation
        private Form_Dang_Ky_License()
        {
            // Initialization code (if needed)
        }

        // Public method to access the instance
        public static Form_Dang_Ky_License GetInstance()
        {
            if (instance == null)
            {
                instance = new Form_Dang_Ky_License();
            }
            return instance;
        }
        public string TenNguoiDung { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string LoiNhan {get; set; }
        public string LoaiLicense { get; set; }
        public string HanLicense { get; set; }
        public string LuuTruLicense { get; set; }
        public string MaBaoMat { get; set; }
        public string LicenseKey { get; set;}

        public void ClearDataLicense()
        {
            this.LicenseKey = this.MaBaoMat = this.SoDienThoai = String.Empty;
        }

        public void ClearAllData()
        {
            TenNguoiDung = SoDienThoai = Email = DiaChi = LoiNhan = LoaiLicense = HanLicense = LuuTruLicense = MaBaoMat = LicenseKey = string.Empty;
        }
    }
}

