namespace Buoi4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dgvStudents;

        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalNamTitle;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblTotalNuTitle;
        private System.Windows.Forms.Label lblNu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.lblDiem = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalNamTitle = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblTotalNuTitle = new System.Windows.Forms.Label();
            this.lblNu = new System.Windows.Forms.Label();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(240, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(353, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblMSSV);
            this.groupBoxInfo.Controls.Add(this.txtMSSV);
            this.groupBoxInfo.Controls.Add(this.lblHoTen);
            this.groupBoxInfo.Controls.Add(this.txtHoTen);
            this.groupBoxInfo.Controls.Add(this.lblGioiTinh);
            this.groupBoxInfo.Controls.Add(this.rbNam);
            this.groupBoxInfo.Controls.Add(this.rbNu);
            this.groupBoxInfo.Controls.Add(this.lblDiem);
            this.groupBoxInfo.Controls.Add(this.txtDiem);
            this.groupBoxInfo.Controls.Add(this.lblKhoa);
            this.groupBoxInfo.Controls.Add(this.cbKhoa);
            this.groupBoxInfo.Controls.Add(this.btnAddUpdate);
            this.groupBoxInfo.Controls.Add(this.btnDelete);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 50);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(230, 320);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông Tin Sinh Viên";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(12, 28);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(70, 13);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Mã Sinh Viên";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(15, 45);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(190, 20);
            this.txtMSSV.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(12, 75);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 13);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(15, 92);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(190, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(12, 125);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(51, 13);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(15, 142);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 5;
            this.rbNam.Text = "Nam";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(85, 142);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 6;
            this.rbNu.Text = "Nữ";
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(12, 175);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(48, 13);
            this.lblDiem.TabIndex = 7;
            this.lblDiem.Text = "Điểm TB";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(15, 192);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 20);
            this.txtDiem.TabIndex = 8;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(12, 225);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(78, 13);
            this.lblKhoa.TabIndex = 9;
            this.lblKhoa.Text = "Chuyên Ngành";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Location = new System.Drawing.Point(15, 242);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(190, 21);
            this.cbKhoa.TabIndex = 10;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(15, 280);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(85, 28);
            this.btnAddUpdate.TabIndex = 11;
            this.btnAddUpdate.Text = "Thêm / Sửa";
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 28);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(260, 50);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(540, 320);
            this.dgvStudents.TabIndex = 2;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Location = new System.Drawing.Point(260, 375);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(0, 13);
            this.lblTotalTitle.TabIndex = 3;
            // 
            // lblTotalNamTitle
            // 
            this.lblTotalNamTitle.AutoSize = true;
            this.lblTotalNamTitle.Location = new System.Drawing.Point(420, 375);
            this.lblTotalNamTitle.Name = "lblTotalNamTitle";
            this.lblTotalNamTitle.Size = new System.Drawing.Size(74, 13);
            this.lblTotalNamTitle.TabIndex = 4;
            this.lblTotalNamTitle.Text = "Tổng SV Nam";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNam.Location = new System.Drawing.Point(500, 375);
            this.lblNam.Name = "lblNam";
            this.lblNam.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblNam.Size = new System.Drawing.Size(27, 19);
            this.lblNam.TabIndex = 5;
            this.lblNam.Text = "0";
            // 
            // lblTotalNuTitle
            // 
            this.lblTotalNuTitle.AutoSize = true;
            this.lblTotalNuTitle.Location = new System.Drawing.Point(550, 375);
            this.lblTotalNuTitle.Name = "lblTotalNuTitle";
            this.lblTotalNuTitle.Size = new System.Drawing.Size(21, 13);
            this.lblTotalNuTitle.TabIndex = 6;
            this.lblTotalNuTitle.Text = "Nữ";
            // 
            // lblNu
            // 
            this.lblNu.AutoSize = true;
            this.lblNu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNu.Location = new System.Drawing.Point(580, 375);
            this.lblNu.Name = "lblNu";
            this.lblNu.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblNu.Size = new System.Drawing.Size(27, 19);
            this.lblNu.TabIndex = 7;
            this.lblNu.Text = "0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(820, 420);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblTotalTitle);
            this.Controls.Add(this.lblTotalNamTitle);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblTotalNuTitle);
            this.Controls.Add(this.lblNu);
            this.Name = "Form1";
            this.Text = "Quản Lý Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}