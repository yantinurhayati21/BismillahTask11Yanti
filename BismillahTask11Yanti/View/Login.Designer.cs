namespace BismillahTask11Yanti.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUs = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.BackColor = System.Drawing.Color.Transparent;
            this.lblUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUs.Location = new System.Drawing.Point(296, 214);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(43, 20);
            this.lblUs.TabIndex = 1;
            this.lblUs.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(268, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "FORM LOGIN";
            // 
            // txtUs
            // 
            this.txtUs.Location = new System.Drawing.Point(345, 211);
            this.txtUs.Multiline = true;
            this.txtUs.Name = "txtUs";
            this.txtUs.Size = new System.Drawing.Size(131, 32);
            this.txtUs.TabIndex = 4;
            this.txtUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUs_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 65);
            this.panel1.TabIndex = 6;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnLog.Location = new System.Drawing.Point(345, 249);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(82, 32);
            this.btnLog.TabIndex = 7;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUs);
            this.Controls.Add(this.lblUs);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLog;
    }
}