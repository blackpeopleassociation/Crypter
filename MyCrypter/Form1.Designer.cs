namespace MyCrypter
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAppLaunch = new System.Windows.Forms.RadioButton();
            this.rbInstallUtil = new System.Windows.Forms.RadioButton();
            this.rbRegSvcs = new System.Windows.Forms.RadioButton();
            this.rbRegAsm = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(440, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(89, 27);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.Color.Black;
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFile.Location = new System.Drawing.Point(12, 15);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(422, 23);
            this.txtFile.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAppLaunch);
            this.groupBox1.Controls.Add(this.rbInstallUtil);
            this.groupBox1.Controls.Add(this.rbRegSvcs);
            this.groupBox1.Controls.Add(this.rbRegAsm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payload Injection";
            // 
            // rbAppLaunch
            // 
            this.rbAppLaunch.AutoSize = true;
            this.rbAppLaunch.Location = new System.Drawing.Point(379, 23);
            this.rbAppLaunch.Name = "rbAppLaunch";
            this.rbAppLaunch.Size = new System.Drawing.Size(110, 19);
            this.rbAppLaunch.TabIndex = 6;
            this.rbAppLaunch.TabStop = true;
            this.rbAppLaunch.Text = "AppLaunch.exe";
            this.rbAppLaunch.UseVisualStyleBackColor = true;
            // 
            // rbInstallUtil
            // 
            this.rbInstallUtil.AutoSize = true;
            this.rbInstallUtil.Location = new System.Drawing.Point(271, 23);
            this.rbInstallUtil.Name = "rbInstallUtil";
            this.rbInstallUtil.Size = new System.Drawing.Size(102, 19);
            this.rbInstallUtil.TabIndex = 5;
            this.rbInstallUtil.TabStop = true;
            this.rbInstallUtil.Text = "InstallUtil.exe";
            this.rbInstallUtil.UseVisualStyleBackColor = true;
            // 
            // rbRegSvcs
            // 
            this.rbRegSvcs.AutoSize = true;
            this.rbRegSvcs.Location = new System.Drawing.Point(169, 23);
            this.rbRegSvcs.Name = "rbRegSvcs";
            this.rbRegSvcs.Size = new System.Drawing.Size(96, 19);
            this.rbRegSvcs.TabIndex = 4;
            this.rbRegSvcs.TabStop = true;
            this.rbRegSvcs.Text = "RegSvcs.exe";
            this.rbRegSvcs.UseVisualStyleBackColor = true;
            // 
            // rbRegAsm
            // 
            this.rbRegAsm.AutoSize = true;
            this.rbRegAsm.Checked = true;
            this.rbRegAsm.Location = new System.Drawing.Point(68, 23);
            this.rbRegAsm.Name = "rbRegAsm";
            this.rbRegAsm.Size = new System.Drawing.Size(95, 19);
            this.rbRegAsm.TabIndex = 3;
            this.rbRegAsm.TabStop = true;
            this.rbRegAsm.Text = "RegAsm.exe";
            this.rbRegAsm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process :";
            // 
            // btnCrypt
            // 
            this.btnCrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrypt.Location = new System.Drawing.Point(12, 109);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(517, 32);
            this.btnCrypt.TabIndex = 3;
            this.btnCrypt.Text = "Crypt";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(541, 154);
            this.Controls.Add(this.btnCrypt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnBrowse);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LyoniCriptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAppLaunch;
        private System.Windows.Forms.RadioButton rbInstallUtil;
        private System.Windows.Forms.RadioButton rbRegSvcs;
        private System.Windows.Forms.RadioButton rbRegAsm;
        private System.Windows.Forms.Button btnCrypt;
    }
}

