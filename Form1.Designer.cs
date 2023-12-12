namespace Responsi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.cbDepKaryawan = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Karyawan : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dep. Karyawan : ";
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.Location = new System.Drawing.Point(178, 80);
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(169, 20);
            this.txtNamaKaryawan.TabIndex = 2;
            // 
            // cbDepKaryawan
            // 
            this.cbDepKaryawan.FormattingEnabled = true;
            this.cbDepKaryawan.Items.AddRange(new object[] {
            "HR",
            "ENG",
            "DEV",
            "PM",
            "FIN"});
            this.cbDepKaryawan.Location = new System.Drawing.Point(178, 111);
            this.cbDepKaryawan.Name = "cbDepKaryawan";
            this.cbDepKaryawan.Size = new System.Drawing.Size(169, 21);
            this.cbDepKaryawan.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(70, 173);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(84, 27);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(205, 173);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 27);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(334, 173);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(84, 27);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(106, 220);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(415, 186);
            this.dgvData.TabIndex = 8;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "ID Departemen:",
            "HR : HR",
            "ENG : Engineer",
            "DEV : Developer",
            "PM : Product Manager",
            "FIN : Finance"});
            this.listBox1.Location = new System.Drawing.Point(430, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "LOGO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbDepKaryawan);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaKaryawan;
        private System.Windows.Forms.ComboBox cbDepKaryawan;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}

