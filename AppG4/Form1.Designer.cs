﻿namespace AppG4
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bổSungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnvan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnvatly = new System.Windows.Forms.ToolStripMenuItem();
            this.btncntt = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvListSV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDTB = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabVan = new System.Windows.Forms.TabPage();
            this.txtVanhochd = new System.Windows.Forms.TextBox();
            this.txtVanhoccd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabVatly = new System.Windows.Forms.TabPage();
            this.txtQuanghoc = new System.Windows.Forms.TextBox();
            this.txtVLhatnhan = new System.Windows.Forms.TextBox();
            this.txtDien = new System.Windows.Forms.TextBox();
            this.txtCokhi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCntt = new System.Windows.Forms.TabPage();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.txtCsharp = new System.Windows.Forms.TextBox();
            this.txtPascal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpkNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.checkboxGioitinh = new System.Windows.Forms.CheckBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBinding1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListSV)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabVan.SuspendLayout();
            this.tabVatly.SuspendLayout();
            this.tabCntt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBinding1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDữLiệuToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.bổSungToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(863, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileDữLiệuToolStripMenuItem
            // 
            this.fileDữLiệuToolStripMenuItem.Name = "fileDữLiệuToolStripMenuItem";
            this.fileDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.fileDữLiệuToolStripMenuItem.Text = "File dữ liệu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::AppG4.Properties.Resources.save_file;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // bổSungToolStripMenuItem
            // 
            this.bổSungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnvan,
            this.btnvatly,
            this.btncntt});
            this.bổSungToolStripMenuItem.Image = global::AppG4.Properties.Resources.add;
            this.bổSungToolStripMenuItem.Name = "bổSungToolStripMenuItem";
            this.bổSungToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.bổSungToolStripMenuItem.Text = "Bổ sung";
            // 
            // btnvan
            // 
            this.btnvan.Name = "btnvan";
            this.btnvan.Size = new System.Drawing.Size(180, 22);
            this.btnvan.Text = "SV Văn";
            this.btnvan.Click += new System.EventHandler(this.sVVănToolStripMenuItem_Click);
            // 
            // btnvatly
            // 
            this.btnvatly.Name = "btnvatly";
            this.btnvatly.Size = new System.Drawing.Size(180, 22);
            this.btnvatly.Text = "SV Vật lý";
            this.btnvatly.Click += new System.EventHandler(this.sVVậtLýToolStripMenuItem_Click);
            // 
            // btncntt
            // 
            this.btncntt.Name = "btncntt";
            this.btncntt.Size = new System.Drawing.Size(180, 22);
            this.btncntt.Text = "SV CNTT";
            this.btncntt.Click += new System.EventHandler(this.sVCNTTToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::AppG4.Properties.Resources.delete;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Image = global::AppG4.Properties.Resources.edit;
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvListSV);
            this.panel1.Location = new System.Drawing.Point(6, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 415);
            this.panel1.TabIndex = 1;
            // 
            // dtgvListSV
            // 
            this.dtgvListSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListSV.Location = new System.Drawing.Point(4, 9);
            this.dtgvListSV.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvListSV.Name = "dtgvListSV";
            this.dtgvListSV.RowHeadersWidth = 51;
            this.dtgvListSV.RowTemplate.Height = 24;
            this.dtgvListSV.Size = new System.Drawing.Size(493, 400);
            this.dtgvListSV.TabIndex = 0;
            this.dtgvListSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListSV_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lbDTB);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Controls.Add(this.dtpkNgaysinh);
            this.panel2.Controls.Add(this.checkboxGioitinh);
            this.panel2.Controls.Add(this.txtHoten);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(522, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 414);
            this.panel2.TabIndex = 2;
            // 
            // lbDTB
            // 
            this.lbDTB.AutoSize = true;
            this.lbDTB.Location = new System.Drawing.Point(77, 375);
            this.lbDTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDTB.Name = "lbDTB";
            this.lbDTB.Size = new System.Drawing.Size(0, 13);
            this.lbDTB.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 376);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "ĐTB:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVan);
            this.tabControl.Controls.Add(this.tabVatly);
            this.tabControl.Controls.Add(this.tabCntt);
            this.tabControl.Location = new System.Drawing.Point(6, 153);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(319, 204);
            this.tabControl.TabIndex = 5;
            // 
            // tabVan
            // 
            this.tabVan.Controls.Add(this.txtVanhochd);
            this.tabVan.Controls.Add(this.txtVanhoccd);
            this.tabVan.Controls.Add(this.label5);
            this.tabVan.Controls.Add(this.label4);
            this.tabVan.Location = new System.Drawing.Point(4, 22);
            this.tabVan.Margin = new System.Windows.Forms.Padding(2);
            this.tabVan.Name = "tabVan";
            this.tabVan.Padding = new System.Windows.Forms.Padding(2);
            this.tabVan.Size = new System.Drawing.Size(311, 178);
            this.tabVan.TabIndex = 0;
            this.tabVan.Text = "Văn";
            this.tabVan.UseVisualStyleBackColor = true;
            // 
            // txtVanhochd
            // 
            this.txtVanhochd.Location = new System.Drawing.Point(100, 63);
            this.txtVanhochd.Margin = new System.Windows.Forms.Padding(2);
            this.txtVanhochd.Name = "txtVanhochd";
            this.txtVanhochd.Size = new System.Drawing.Size(194, 20);
            this.txtVanhochd.TabIndex = 1;
            // 
            // txtVanhoccd
            // 
            this.txtVanhoccd.Location = new System.Drawing.Point(100, 29);
            this.txtVanhoccd.Margin = new System.Windows.Forms.Padding(2);
            this.txtVanhoccd.Name = "txtVanhoccd";
            this.txtVanhoccd.Size = new System.Drawing.Size(194, 20);
            this.txtVanhoccd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Văn học HĐ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Văn học CĐ:";
            // 
            // tabVatly
            // 
            this.tabVatly.Controls.Add(this.txtQuanghoc);
            this.tabVatly.Controls.Add(this.txtVLhatnhan);
            this.tabVatly.Controls.Add(this.txtDien);
            this.tabVatly.Controls.Add(this.txtCokhi);
            this.tabVatly.Controls.Add(this.label9);
            this.tabVatly.Controls.Add(this.label8);
            this.tabVatly.Controls.Add(this.label7);
            this.tabVatly.Controls.Add(this.label6);
            this.tabVatly.Location = new System.Drawing.Point(4, 22);
            this.tabVatly.Margin = new System.Windows.Forms.Padding(2);
            this.tabVatly.Name = "tabVatly";
            this.tabVatly.Padding = new System.Windows.Forms.Padding(2);
            this.tabVatly.Size = new System.Drawing.Size(311, 178);
            this.tabVatly.TabIndex = 1;
            this.tabVatly.Text = "Vật lý";
            this.tabVatly.UseVisualStyleBackColor = true;
            // 
            // txtQuanghoc
            // 
            this.txtQuanghoc.Location = new System.Drawing.Point(96, 52);
            this.txtQuanghoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuanghoc.Name = "txtQuanghoc";
            this.txtQuanghoc.Size = new System.Drawing.Size(165, 20);
            this.txtQuanghoc.TabIndex = 1;
            // 
            // txtVLhatnhan
            // 
            this.txtVLhatnhan.Location = new System.Drawing.Point(96, 108);
            this.txtVLhatnhan.Margin = new System.Windows.Forms.Padding(2);
            this.txtVLhatnhan.Name = "txtVLhatnhan";
            this.txtVLhatnhan.Size = new System.Drawing.Size(165, 20);
            this.txtVLhatnhan.TabIndex = 1;
            // 
            // txtDien
            // 
            this.txtDien.Location = new System.Drawing.Point(96, 79);
            this.txtDien.Margin = new System.Windows.Forms.Padding(2);
            this.txtDien.Name = "txtDien";
            this.txtDien.Size = new System.Drawing.Size(165, 20);
            this.txtDien.TabIndex = 1;
            // 
            // txtCokhi
            // 
            this.txtCokhi.Location = new System.Drawing.Point(96, 24);
            this.txtCokhi.Margin = new System.Windows.Forms.Padding(2);
            this.txtCokhi.Name = "txtCokhi";
            this.txtCokhi.Size = new System.Drawing.Size(165, 20);
            this.txtCokhi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "VL hạt nhân:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điện:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quang học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cơ khí:";
            // 
            // tabCntt
            // 
            this.tabCntt.Controls.Add(this.txtSql);
            this.tabCntt.Controls.Add(this.txtCsharp);
            this.tabCntt.Controls.Add(this.txtPascal);
            this.tabCntt.Controls.Add(this.label12);
            this.tabCntt.Controls.Add(this.label11);
            this.tabCntt.Controls.Add(this.label10);
            this.tabCntt.Location = new System.Drawing.Point(4, 22);
            this.tabCntt.Margin = new System.Windows.Forms.Padding(2);
            this.tabCntt.Name = "tabCntt";
            this.tabCntt.Padding = new System.Windows.Forms.Padding(2);
            this.tabCntt.Size = new System.Drawing.Size(311, 178);
            this.tabCntt.TabIndex = 2;
            this.tabCntt.Text = "CNTT";
            this.tabCntt.UseVisualStyleBackColor = true;
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(84, 113);
            this.txtSql.Margin = new System.Windows.Forms.Padding(2);
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(157, 20);
            this.txtSql.TabIndex = 2;
            // 
            // txtCsharp
            // 
            this.txtCsharp.Location = new System.Drawing.Point(84, 78);
            this.txtCsharp.Margin = new System.Windows.Forms.Padding(2);
            this.txtCsharp.Name = "txtCsharp";
            this.txtCsharp.Size = new System.Drawing.Size(157, 20);
            this.txtCsharp.TabIndex = 2;
            // 
            // txtPascal
            // 
            this.txtPascal.Location = new System.Drawing.Point(84, 40);
            this.txtPascal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPascal.Name = "txtPascal";
            this.txtPascal.Size = new System.Drawing.Size(157, 20);
            this.txtPascal.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 117);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "SQL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "C# :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pascal:";
            // 
            // dtpkNgaysinh
            // 
            this.dtpkNgaysinh.Checked = false;
            this.dtpkNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaysinh.Location = new System.Drawing.Point(79, 102);
            this.dtpkNgaysinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkNgaysinh.Name = "dtpkNgaysinh";
            this.dtpkNgaysinh.Size = new System.Drawing.Size(225, 20);
            this.dtpkNgaysinh.TabIndex = 4;
            // 
            // checkboxGioitinh
            // 
            this.checkboxGioitinh.AutoSize = true;
            this.checkboxGioitinh.Location = new System.Drawing.Point(18, 77);
            this.checkboxGioitinh.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxGioitinh.Name = "checkboxGioitinh";
            this.checkboxGioitinh.Size = new System.Drawing.Size(89, 17);
            this.checkboxGioitinh.TabIndex = 3;
            this.checkboxGioitinh.Text = "Giới tính nam";
            this.checkboxGioitinh.UseVisualStyleBackColor = true;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(76, 41);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(228, 20);
            this.txtHoten.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin chi tiết";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListSV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabVan.ResumeLayout(false);
            this.tabVan.PerformLayout();
            this.tabVatly.ResumeLayout(false);
            this.tabVatly.PerformLayout();
            this.tabCntt.ResumeLayout(false);
            this.tabCntt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBinding1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bổSungToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvListSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabVan;
        private System.Windows.Forms.TabPage tabVatly;
        private System.Windows.Forms.TabPage tabCntt;
        private System.Windows.Forms.DateTimePicker dtpkNgaysinh;
        private System.Windows.Forms.CheckBox checkboxGioitinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVanhochd;
        private System.Windows.Forms.TextBox txtVanhoccd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuanghoc;
        private System.Windows.Forms.TextBox txtVLhatnhan;
        private System.Windows.Forms.TextBox txtDien;
        private System.Windows.Forms.TextBox txtCokhi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.TextBox txtCsharp;
        private System.Windows.Forms.TextBox txtPascal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem btnvan;
        private System.Windows.Forms.ToolStripMenuItem btnvatly;
        private System.Windows.Forms.ToolStripMenuItem btncntt;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.BindingSource dataBinding1;
        private System.Windows.Forms.Label lbDTB;
    }
}