namespace WindowsFormsApplication1
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
            this.q = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_TenNuoc = new System.Windows.Forms.TextBox();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SoLuongVe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_GiaVe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_CLB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_TimKiemCLB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.q.Location = new System.Drawing.Point(137, 21);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(273, 25);
            this.q.TabIndex = 0;
            this.q.Text = "Quản Lý Doanh Thu CLB";
            this.q.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(588, 184);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_TenNuoc);
            this.groupBox1.Controls.Add(this.button_Xoa);
            this.groupBox1.Controls.Add(this.button_Sua);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_SoLuongVe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_GiaVe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_CLB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(606, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Location = new System.Drawing.Point(224, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 120);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(280, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_TenNuoc
            // 
            this.textBox_TenNuoc.Location = new System.Drawing.Point(93, 126);
            this.textBox_TenNuoc.Name = "textBox_TenNuoc";
            this.textBox_TenNuoc.ReadOnly = true;
            this.textBox_TenNuoc.Size = new System.Drawing.Size(121, 20);
            this.textBox_TenNuoc.TabIndex = 11;
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.Color.Lime;
            this.button_Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.button_Xoa.Location = new System.Drawing.Point(199, 235);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 10;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.Color.Black;
            this.button_Sua.ForeColor = System.Drawing.Color.Transparent;
            this.button_Sua.Location = new System.Drawing.Point(118, 235);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 23);
            this.button_Sua.TabIndex = 9;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.Color.RosyBrown;
            this.button_Them.ForeColor = System.Drawing.Color.Transparent;
            this.button_Them.ImageKey = "(none)";
            this.button_Them.Location = new System.Drawing.Point(24, 235);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 23);
            this.button_Them.TabIndex = 8;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Nước";
            // 
            // textBox_SoLuongVe
            // 
            this.textBox_SoLuongVe.Location = new System.Drawing.Point(93, 172);
            this.textBox_SoLuongVe.Name = "textBox_SoLuongVe";
            this.textBox_SoLuongVe.Size = new System.Drawing.Size(100, 20);
            this.textBox_SoLuongVe.TabIndex = 5;
            this.textBox_SoLuongVe.TextChanged += new System.EventHandler(this.comboBox_CLB_SelectedIndexChanged);
            this.textBox_SoLuongVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SoLuongVe_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Lượng Vé";
            // 
            // textBox_GiaVe
            // 
            this.textBox_GiaVe.Location = new System.Drawing.Point(93, 79);
            this.textBox_GiaVe.Name = "textBox_GiaVe";
            this.textBox_GiaVe.ReadOnly = true;
            this.textBox_GiaVe.Size = new System.Drawing.Size(100, 20);
            this.textBox_GiaVe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá Vé";
            // 
            // comboBox_CLB
            // 
            this.comboBox_CLB.FormattingEnabled = true;
            this.comboBox_CLB.Items.AddRange(new object[] {
            "Totenham",
            "Arsenal",
            "Manchester united",
            "Manchester city",
            "Liverpool",
            "Aston villa",
            "Newcastle",
            "Brighton",
            "Công An Hà Nội"});
            this.comboBox_CLB.Location = new System.Drawing.Point(93, 30);
            this.comboBox_CLB.Name = "comboBox_CLB";
            this.comboBox_CLB.Size = new System.Drawing.Size(121, 21);
            this.comboBox_CLB.TabIndex = 1;
            this.comboBox_CLB.SelectedIndexChanged += new System.EventHandler(this.comboBox_CLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên CLB:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_TimKiemCLB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox_TimKiemCLB
            // 
            this.textBox_TimKiemCLB.Location = new System.Drawing.Point(77, 43);
            this.textBox_TimKiemCLB.Name = "textBox_TimKiemCLB";
            this.textBox_TimKiemCLB.Size = new System.Drawing.Size(100, 20);
            this.textBox_TimKiemCLB.TabIndex = 12;
            this.textBox_TimKiemCLB.TextChanged += new System.EventHandler(this.textBox_TimKiemCLB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(11, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên CLB:";
            // 
            // button_Thoat
            // 
            this.button_Thoat.BackColor = System.Drawing.Color.RosyBrown;
            this.button_Thoat.ForeColor = System.Drawing.Color.Transparent;
            this.button_Thoat.ImageKey = "(none)";
            this.button_Thoat.Location = new System.Drawing.Point(682, 21);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.button_Thoat.TabIndex = 12;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Thoat.UseVisualStyleBackColor = false;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 348);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.q);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label q;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_SoLuongVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_GiaVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_CLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_TimKiemCLB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.TextBox textBox_TenNuoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

