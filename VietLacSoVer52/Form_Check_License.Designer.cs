namespace VietLacSoVer52
{
    partial class Form_Check_License
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Check_License));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnHaveNotLicense = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnHaveLicense = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnHaveNotLicense);
            this.panel1.Controls.Add(this.btnHaveLicense);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 358);
            this.panel1.TabIndex = 1;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("SVN-Artful Beauty", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel1.Location = new System.Drawing.Point(122, 90);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(330, 48);
            this.bunifuLabel1.TabIndex = 14;
            this.bunifuLabel1.Text = "KÍCH HOẠT SẢN PHẨM";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 30;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(24, 12);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuPictureBox1.Size = new System.Drawing.Size(60, 60);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 13;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnHaveNotLicense
            // 
            this.btnHaveNotLicense.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHaveNotLicense.BackColor = System.Drawing.Color.Firebrick;
            this.btnHaveNotLicense.color = System.Drawing.Color.Firebrick;
            this.btnHaveNotLicense.colorActive = System.Drawing.Color.Red;
            this.btnHaveNotLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHaveNotLicense.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnHaveNotLicense.ForeColor = System.Drawing.Color.White;
            this.btnHaveNotLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnHaveNotLicense.Image")));
            this.btnHaveNotLicense.ImagePosition = 5;
            this.btnHaveNotLicense.ImageZoom = 22;
            this.btnHaveNotLicense.LabelPosition = 30;
            this.btnHaveNotLicense.LabelText = "Chưa có license";
            this.btnHaveNotLicense.Location = new System.Drawing.Point(314, 174);
            this.btnHaveNotLicense.Margin = new System.Windows.Forms.Padding(6);
            this.btnHaveNotLicense.Name = "btnHaveNotLicense";
            this.btnHaveNotLicense.Size = new System.Drawing.Size(189, 84);
            this.btnHaveNotLicense.TabIndex = 18;
            this.btnHaveNotLicense.Click += new System.EventHandler(this.btnHaveNotLicense_Click_1);
            // 
            // btnHaveLicense
            // 
            this.btnHaveLicense.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHaveLicense.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHaveLicense.color = System.Drawing.Color.SeaGreen;
            this.btnHaveLicense.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnHaveLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHaveLicense.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnHaveLicense.ForeColor = System.Drawing.Color.White;
            this.btnHaveLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnHaveLicense.Image")));
            this.btnHaveLicense.ImagePosition = 5;
            this.btnHaveLicense.ImageZoom = 22;
            this.btnHaveLicense.LabelPosition = 30;
            this.btnHaveLicense.LabelText = "Đã có license";
            this.btnHaveLicense.Location = new System.Drawing.Point(58, 174);
            this.btnHaveLicense.Margin = new System.Windows.Forms.Padding(6);
            this.btnHaveLicense.Name = "btnHaveLicense";
            this.btnHaveLicense.Size = new System.Drawing.Size(186, 84);
            this.btnHaveLicense.TabIndex = 17;
            this.btnHaveLicense.Click += new System.EventHandler(this.btnHaveLicense_Click_1);
            // 
            // Form_Check_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 358);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Check_License";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.Framework.UI.BunifuTileButton btnHaveNotLicense;
        private Bunifu.Framework.UI.BunifuTileButton btnHaveLicense;
    }
}

