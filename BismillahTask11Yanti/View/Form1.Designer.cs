namespace BismillahTask11Yanti
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
            this.dataGridViewPlt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNm = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTglM = new System.Windows.Forms.Label();
            this.lblTglK = new System.Windows.Forms.Label();
            this.lblInstruktur = new System.Windows.Forms.Label();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtIns = new System.Windows.Forms.TextBox();
            this.txtLks = new System.Windows.Forms.TextBox();
            this.txtHrg = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtMulai = new System.Windows.Forms.DateTimePicker();
            this.dtSelesai = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPlt
            // 
            this.dataGridViewPlt.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlt.Location = new System.Drawing.Point(56, 427);
            this.dataGridViewPlt.Name = "dataGridViewPlt";
            this.dataGridViewPlt.RowHeadersWidth = 62;
            this.dataGridViewPlt.RowTemplate.Height = 28;
            this.dataGridViewPlt.Size = new System.Drawing.Size(1179, 270);
            this.dataGridViewPlt.TabIndex = 0;
            this.dataGridViewPlt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlt_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trainning Center Application";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 59);
            this.panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(1202, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 49);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "X";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(58, 130);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(124, 25);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id Pelatihan";
            // 
            // lblNm
            // 
            this.lblNm.AutoSize = true;
            this.lblNm.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNm.Location = new System.Drawing.Point(58, 184);
            this.lblNm.Name = "lblNm";
            this.lblNm.Size = new System.Drawing.Size(164, 25);
            this.lblNm.TabIndex = 4;
            this.lblNm.Text = "Nama Pelatihan";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(58, 229);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(101, 25);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Deskripsi";
            // 
            // lblTglM
            // 
            this.lblTglM.AutoSize = true;
            this.lblTglM.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTglM.Location = new System.Drawing.Point(573, 123);
            this.lblTglM.Name = "lblTglM";
            this.lblTglM.Size = new System.Drawing.Size(144, 25);
            this.lblTglM.TabIndex = 6;
            this.lblTglM.Text = "Tanggal Mulai";
            // 
            // lblTglK
            // 
            this.lblTglK.AutoSize = true;
            this.lblTglK.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTglK.Location = new System.Drawing.Point(577, 169);
            this.lblTglK.Name = "lblTglK";
            this.lblTglK.Size = new System.Drawing.Size(164, 25);
            this.lblTglK.TabIndex = 7;
            this.lblTglK.Text = "Tanggal Selesai";
            // 
            // lblInstruktur
            // 
            this.lblInstruktur.AutoSize = true;
            this.lblInstruktur.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruktur.Location = new System.Drawing.Point(577, 215);
            this.lblInstruktur.Name = "lblInstruktur";
            this.lblInstruktur.Size = new System.Drawing.Size(98, 25);
            this.lblInstruktur.TabIndex = 8;
            this.lblInstruktur.Text = "Instruktur";
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokasi.Location = new System.Drawing.Point(577, 262);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(75, 25);
            this.lblLokasi.TabIndex = 9;
            this.lblLokasi.Text = "Lokasi";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(577, 312);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(71, 25);
            this.lblHarga.TabIndex = 10;
            this.lblHarga.Text = "Harga";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(253, 123);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(235, 32);
            this.txtId.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(253, 177);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 32);
            this.txtName.TabIndex = 12;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(253, 229);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(235, 115);
            this.txtDesc.TabIndex = 13;
            // 
            // txtIns
            // 
            this.txtIns.Location = new System.Drawing.Point(768, 215);
            this.txtIns.Multiline = true;
            this.txtIns.Name = "txtIns";
            this.txtIns.Size = new System.Drawing.Size(235, 32);
            this.txtIns.TabIndex = 16;
            // 
            // txtLks
            // 
            this.txtLks.Location = new System.Drawing.Point(768, 262);
            this.txtLks.Multiline = true;
            this.txtLks.Name = "txtLks";
            this.txtLks.Size = new System.Drawing.Size(235, 32);
            this.txtLks.TabIndex = 17;
            // 
            // txtHrg
            // 
            this.txtHrg.Location = new System.Drawing.Point(768, 305);
            this.txtHrg.Multiline = true;
            this.txtHrg.Name = "txtHrg";
            this.txtHrg.Size = new System.Drawing.Size(235, 32);
            this.txtHrg.TabIndex = 18;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.GreenYellow;
            this.btnClear.Font = new System.Drawing.Font("Imprint MT Shadow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnClear.Location = new System.Drawing.Point(1111, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 52);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Imprint MT Shadow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdd.Location = new System.Drawing.Point(1111, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 52);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpt
            // 
            this.btnUpt.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpt.Font = new System.Drawing.Font("Imprint MT Shadow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpt.Location = new System.Drawing.Point(1111, 239);
            this.btnUpt.Name = "btnUpt";
            this.btnUpt.Size = new System.Drawing.Size(124, 52);
            this.btnUpt.TabIndex = 21;
            this.btnUpt.Text = "Update";
            this.btnUpt.UseVisualStyleBackColor = false;
            this.btnUpt.Click += new System.EventHandler(this.btnUpt_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Crimson;
            this.btnDel.Font = new System.Drawing.Font("Imprint MT Shadow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDel.Location = new System.Drawing.Point(1111, 297);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(124, 52);
            this.btnDel.TabIndex = 22;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(47, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Pelatihan";
            // 
            // dtMulai
            // 
            this.dtMulai.CustomFormat = " ";
            this.dtMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMulai.Location = new System.Drawing.Point(768, 123);
            this.dtMulai.Name = "dtMulai";
            this.dtMulai.Size = new System.Drawing.Size(235, 26);
            this.dtMulai.TabIndex = 23;
            this.dtMulai.ValueChanged += new System.EventHandler(this.dtMulai_ValueChanged);
            // 
            // dtSelesai
            // 
            this.dtSelesai.CustomFormat = " ";
            this.dtSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSelesai.Location = new System.Drawing.Point(768, 168);
            this.dtSelesai.Name = "dtSelesai";
            this.dtSelesai.Size = new System.Drawing.Size(235, 26);
            this.dtSelesai.TabIndex = 24;
            this.dtSelesai.ValueChanged += new System.EventHandler(this.dtSelesai_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1296, 782);
            this.Controls.Add(this.dtSelesai);
            this.Controls.Add(this.dtMulai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtHrg);
            this.Controls.Add(this.txtLks);
            this.Controls.Add(this.txtIns);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblLokasi);
            this.Controls.Add(this.lblInstruktur);
            this.Controls.Add(this.lblTglK);
            this.Controls.Add(this.lblTglM);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblNm);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewPlt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pelatihan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNm;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTglM;
        private System.Windows.Forms.Label lblTglK;
        private System.Windows.Forms.Label lblInstruktur;
        private System.Windows.Forms.Label lblLokasi;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtIns;
        private System.Windows.Forms.TextBox txtLks;
        private System.Windows.Forms.TextBox txtHrg;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpt;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtMulai;
        private System.Windows.Forms.DateTimePicker dtSelesai;
    }
}

