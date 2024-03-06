namespace baiTapLon
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labHoTen = new System.Windows.Forms.Label();
            this.labSdt = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labDiachi = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbSdt = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.dataGridViewNhap = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.sắpXếpToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // sắpXếpToolStripMenuItem
            // 
            this.sắpXếpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoTênToolStripMenuItem});
            this.sắpXếpToolStripMenuItem.Name = "sắpXếpToolStripMenuItem";
            this.sắpXếpToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.sắpXếpToolStripMenuItem.Text = "Sắp xếp";
            // 
            // theoTênToolStripMenuItem
            // 
            this.theoTênToolStripMenuItem.Name = "theoTênToolStripMenuItem";
            this.theoTênToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.theoTênToolStripMenuItem.Text = "Theo tên";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.thoátToolStripMenuItem.Text = "Thoát ";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHoTen.Location = new System.Drawing.Point(67, 48);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(62, 22);
            this.labHoTen.TabIndex = 1;
            this.labHoTen.Text = "Họ tên";
            // 
            // labSdt
            // 
            this.labSdt.AutoSize = true;
            this.labSdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSdt.Location = new System.Drawing.Point(403, 48);
            this.labSdt.Name = "labSdt";
            this.labSdt.Size = new System.Drawing.Size(114, 22);
            this.labSdt.TabIndex = 2;
            this.labSdt.Text = "Số điện thoại";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmail.Location = new System.Drawing.Point(67, 103);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(57, 22);
            this.labEmail.TabIndex = 3;
            this.labEmail.Text = "Email";
            // 
            // labDiachi
            // 
            this.labDiachi.AutoSize = true;
            this.labDiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDiachi.Location = new System.Drawing.Point(403, 103);
            this.labDiachi.Name = "labDiachi";
            this.labDiachi.Size = new System.Drawing.Size(68, 22);
            this.labDiachi.TabIndex = 4;
            this.labDiachi.Text = "Địa chỉ";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTen.Location = new System.Drawing.Point(135, 40);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(165, 30);
            this.txbHoTen.TabIndex = 5;
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(135, 95);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(165, 30);
            this.txbEmail.TabIndex = 6;
            // 
            // txbSdt
            // 
            this.txbSdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSdt.Location = new System.Drawing.Point(523, 40);
            this.txbSdt.Name = "txbSdt";
            this.txbSdt.Size = new System.Drawing.Size(183, 30);
            this.txbSdt.TabIndex = 7;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiaChi.Location = new System.Drawing.Point(523, 95);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(183, 30);
            this.txbDiaChi.TabIndex = 8;
            // 
            // dataGridViewNhap
            // 
            this.dataGridViewNhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhap.Location = new System.Drawing.Point(12, 151);
            this.dataGridViewNhap.Name = "dataGridViewNhap";
            this.dataGridViewNhap.ReadOnly = true;
            this.dataGridViewNhap.RowHeadersWidth = 51;
            this.dataGridViewNhap.RowTemplate.Height = 24;
            this.dataGridViewNhap.Size = new System.Drawing.Size(779, 257);
            this.dataGridViewNhap.TabIndex = 9;
            this.dataGridViewNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhap_CellClick);
            this.dataGridViewNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhap_CellContentClick);
            this.dataGridViewNhap.SelectionChanged += new System.EventHandler(this.dataGridViewNhap_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(12, 413);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 41);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(336, 414);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 40);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.Location = new System.Drawing.Point(120, 414);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(102, 41);
            this.bntXoa.TabIndex = 13;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(228, 414);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 41);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(444, 414);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 40);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(803, 464);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewNhap);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbSdt);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.labDiachi);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labSdt);
            this.Controls.Add(this.labHoTen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản lý danh bạ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Label labSdt;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labDiachi;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbSdt;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.DataGridView dataGridViewNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ToolStripMenuItem theoTênToolStripMenuItem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
    }
}

