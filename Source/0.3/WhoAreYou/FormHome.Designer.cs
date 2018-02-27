namespace WhoAreYou
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.gbWhoAreYou = new System.Windows.Forms.GroupBox();
            this.btnCopyRemote_IP = new System.Windows.Forms.Button();
            this.btnCopyLocal_IP = new System.Windows.Forms.Button();
            this.btnResolve = new System.Windows.Forms.Button();
            this.txtRemote_IP = new System.Windows.Forms.TextBox();
            this.lblRemote_IP = new System.Windows.Forms.Label();
            this.txtLocal_IP = new System.Windows.Forms.TextBox();
            this.lblLocal_IP = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.gbHostIsHe = new System.Windows.Forms.GroupBox();
            this.btnCopyIP = new System.Windows.Forms.Button();
            this.btnResolve_IP = new System.Windows.Forms.Button();
            this.txt_IP_He = new System.Windows.Forms.TextBox();
            this.lbl_IP_He = new System.Windows.Forms.Label();
            this.txtHostHe = new System.Windows.Forms.TextBox();
            this.lblHostHe = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.gbWhoAreYou.SuspendLayout();
            this.gbHostIsHe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbWhoAreYou
            // 
            this.gbWhoAreYou.BackColor = System.Drawing.Color.Transparent;
            this.gbWhoAreYou.Controls.Add(this.btnCopyRemote_IP);
            this.gbWhoAreYou.Controls.Add(this.btnCopyLocal_IP);
            this.gbWhoAreYou.Controls.Add(this.btnResolve);
            this.gbWhoAreYou.Controls.Add(this.txtRemote_IP);
            this.gbWhoAreYou.Controls.Add(this.lblRemote_IP);
            this.gbWhoAreYou.Controls.Add(this.txtLocal_IP);
            this.gbWhoAreYou.Controls.Add(this.lblLocal_IP);
            this.gbWhoAreYou.Controls.Add(this.txtHost);
            this.gbWhoAreYou.Controls.Add(this.lblHost);
            this.gbWhoAreYou.ForeColor = System.Drawing.Color.Cyan;
            this.gbWhoAreYou.Location = new System.Drawing.Point(12, 12);
            this.gbWhoAreYou.Name = "gbWhoAreYou";
            this.gbWhoAreYou.Size = new System.Drawing.Size(263, 125);
            this.gbWhoAreYou.TabIndex = 0;
            this.gbWhoAreYou.TabStop = false;
            this.gbWhoAreYou.Text = "Who Are You ?";
            // 
            // btnCopyRemote_IP
            // 
            this.btnCopyRemote_IP.BackColor = System.Drawing.SystemColors.Control;
            this.btnCopyRemote_IP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopyRemote_IP.Location = new System.Drawing.Point(179, 89);
            this.btnCopyRemote_IP.Name = "btnCopyRemote_IP";
            this.btnCopyRemote_IP.Size = new System.Drawing.Size(75, 23);
            this.btnCopyRemote_IP.TabIndex = 11;
            this.btnCopyRemote_IP.Text = "Copy";
            this.btnCopyRemote_IP.UseVisualStyleBackColor = false;
            this.btnCopyRemote_IP.Click += new System.EventHandler(this.btnCopyRemote_IP_Click);
            // 
            // btnCopyLocal_IP
            // 
            this.btnCopyLocal_IP.BackColor = System.Drawing.SystemColors.Control;
            this.btnCopyLocal_IP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopyLocal_IP.Location = new System.Drawing.Point(179, 62);
            this.btnCopyLocal_IP.Name = "btnCopyLocal_IP";
            this.btnCopyLocal_IP.Size = new System.Drawing.Size(75, 23);
            this.btnCopyLocal_IP.TabIndex = 10;
            this.btnCopyLocal_IP.Text = "Copy";
            this.btnCopyLocal_IP.UseVisualStyleBackColor = false;
            this.btnCopyLocal_IP.Click += new System.EventHandler(this.btnCopyLocal_IP_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.BackColor = System.Drawing.SystemColors.Control;
            this.btnResolve.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResolve.Location = new System.Drawing.Point(179, 29);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(75, 23);
            this.btnResolve.TabIndex = 9;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = false;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // txtRemote_IP
            // 
            this.txtRemote_IP.BackColor = System.Drawing.Color.Black;
            this.txtRemote_IP.ForeColor = System.Drawing.Color.Cyan;
            this.txtRemote_IP.Location = new System.Drawing.Point(73, 91);
            this.txtRemote_IP.Name = "txtRemote_IP";
            this.txtRemote_IP.ReadOnly = true;
            this.txtRemote_IP.Size = new System.Drawing.Size(100, 20);
            this.txtRemote_IP.TabIndex = 5;
            // 
            // lblRemote_IP
            // 
            this.lblRemote_IP.AutoSize = true;
            this.lblRemote_IP.Location = new System.Drawing.Point(9, 91);
            this.lblRemote_IP.Name = "lblRemote_IP";
            this.lblRemote_IP.Size = new System.Drawing.Size(66, 13);
            this.lblRemote_IP.TabIndex = 4;
            this.lblRemote_IP.Text = "Remote IP : ";
            // 
            // txtLocal_IP
            // 
            this.txtLocal_IP.BackColor = System.Drawing.Color.Black;
            this.txtLocal_IP.ForeColor = System.Drawing.Color.Cyan;
            this.txtLocal_IP.Location = new System.Drawing.Point(73, 64);
            this.txtLocal_IP.Name = "txtLocal_IP";
            this.txtLocal_IP.ReadOnly = true;
            this.txtLocal_IP.Size = new System.Drawing.Size(100, 20);
            this.txtLocal_IP.TabIndex = 3;
            // 
            // lblLocal_IP
            // 
            this.lblLocal_IP.AutoSize = true;
            this.lblLocal_IP.Location = new System.Drawing.Point(9, 62);
            this.lblLocal_IP.Name = "lblLocal_IP";
            this.lblLocal_IP.Size = new System.Drawing.Size(52, 13);
            this.lblLocal_IP.TabIndex = 2;
            this.lblLocal_IP.Text = "Local IP :";
            // 
            // txtHost
            // 
            this.txtHost.BackColor = System.Drawing.Color.Black;
            this.txtHost.ForeColor = System.Drawing.Color.Cyan;
            this.txtHost.Location = new System.Drawing.Point(56, 32);
            this.txtHost.Name = "txtHost";
            this.txtHost.ReadOnly = true;
            this.txtHost.Size = new System.Drawing.Size(117, 20);
            this.txtHost.TabIndex = 1;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(12, 32);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(38, 13);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host : ";
            // 
            // gbHostIsHe
            // 
            this.gbHostIsHe.BackColor = System.Drawing.Color.Transparent;
            this.gbHostIsHe.Controls.Add(this.btnCopyIP);
            this.gbHostIsHe.Controls.Add(this.btnResolve_IP);
            this.gbHostIsHe.Controls.Add(this.txt_IP_He);
            this.gbHostIsHe.Controls.Add(this.lbl_IP_He);
            this.gbHostIsHe.Controls.Add(this.txtHostHe);
            this.gbHostIsHe.Controls.Add(this.lblHostHe);
            this.gbHostIsHe.ForeColor = System.Drawing.Color.Cyan;
            this.gbHostIsHe.Location = new System.Drawing.Point(12, 143);
            this.gbHostIsHe.Name = "gbHostIsHe";
            this.gbHostIsHe.Size = new System.Drawing.Size(263, 96);
            this.gbHostIsHe.TabIndex = 1;
            this.gbHostIsHe.TabStop = false;
            this.gbHostIsHe.Text = "Who Is He ?";
            // 
            // btnCopyIP
            // 
            this.btnCopyIP.BackColor = System.Drawing.SystemColors.Control;
            this.btnCopyIP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopyIP.Location = new System.Drawing.Point(179, 58);
            this.btnCopyIP.Name = "btnCopyIP";
            this.btnCopyIP.Size = new System.Drawing.Size(75, 23);
            this.btnCopyIP.TabIndex = 7;
            this.btnCopyIP.Text = "Copy";
            this.btnCopyIP.UseVisualStyleBackColor = false;
            this.btnCopyIP.Click += new System.EventHandler(this.btnCopyIP_Click);
            // 
            // btnResolve_IP
            // 
            this.btnResolve_IP.BackColor = System.Drawing.SystemColors.Control;
            this.btnResolve_IP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResolve_IP.Location = new System.Drawing.Point(179, 29);
            this.btnResolve_IP.Name = "btnResolve_IP";
            this.btnResolve_IP.Size = new System.Drawing.Size(75, 23);
            this.btnResolve_IP.TabIndex = 6;
            this.btnResolve_IP.Text = "Resolve IP";
            this.btnResolve_IP.UseVisualStyleBackColor = false;
            this.btnResolve_IP.Click += new System.EventHandler(this.btnResolve_IP_Click);
            // 
            // txt_IP_He
            // 
            this.txt_IP_He.BackColor = System.Drawing.Color.Black;
            this.txt_IP_He.ForeColor = System.Drawing.Color.Cyan;
            this.txt_IP_He.Location = new System.Drawing.Point(41, 60);
            this.txt_IP_He.Name = "txt_IP_He";
            this.txt_IP_He.ReadOnly = true;
            this.txt_IP_He.Size = new System.Drawing.Size(132, 20);
            this.txt_IP_He.TabIndex = 3;
            // 
            // lbl_IP_He
            // 
            this.lbl_IP_He.AutoSize = true;
            this.lbl_IP_He.Location = new System.Drawing.Point(9, 60);
            this.lbl_IP_He.Name = "lbl_IP_He";
            this.lbl_IP_He.Size = new System.Drawing.Size(26, 13);
            this.lbl_IP_He.TabIndex = 2;
            this.lbl_IP_He.Text = "IP : ";
            // 
            // txtHostHe
            // 
            this.txtHostHe.BackColor = System.Drawing.Color.Black;
            this.txtHostHe.ForeColor = System.Drawing.Color.Cyan;
            this.txtHostHe.Location = new System.Drawing.Point(41, 29);
            this.txtHostHe.Name = "txtHostHe";
            this.txtHostHe.Size = new System.Drawing.Size(132, 20);
            this.txtHostHe.TabIndex = 1;
            this.txtHostHe.Text = "www.youtube.com";
            // 
            // lblHostHe
            // 
            this.lblHostHe.AutoSize = true;
            this.lblHostHe.Location = new System.Drawing.Point(7, 32);
            this.lblHostHe.Name = "lblHostHe";
            this.lblHostHe.Size = new System.Drawing.Size(38, 13);
            this.lblHostHe.TabIndex = 0;
            this.lblHostHe.Text = "Host : ";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.ForeColor = System.Drawing.Color.Cyan;
            this.lblCopyRight.Location = new System.Drawing.Point(16, 257);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(253, 16);
            this.lblCopyRight.TabIndex = 2;
            this.lblCopyRight.Text = "© Ismael Heredia , Argentina , 2017 ";
            this.lblCopyRight.Click += new System.EventHandler(this.lblCopyRight_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(286, 289);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.gbHostIsHe);
            this.Controls.Add(this.gbWhoAreYou);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = " - Who Are You 0.3 -";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.gbWhoAreYou.ResumeLayout(false);
            this.gbWhoAreYou.PerformLayout();
            this.gbHostIsHe.ResumeLayout(false);
            this.gbHostIsHe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWhoAreYou;
        private System.Windows.Forms.GroupBox gbHostIsHe;
        private System.Windows.Forms.TextBox txtRemote_IP;
        private System.Windows.Forms.Label lblRemote_IP;
        private System.Windows.Forms.TextBox txtLocal_IP;
        private System.Windows.Forms.Label lblLocal_IP;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txt_IP_He;
        private System.Windows.Forms.Label lbl_IP_He;
        private System.Windows.Forms.TextBox txtHostHe;
        private System.Windows.Forms.Label lblHostHe;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnCopyLocal_IP;
        private System.Windows.Forms.Button btnCopyRemote_IP;
        private System.Windows.Forms.Button btnResolve_IP;
        private System.Windows.Forms.Button btnCopyIP;

    }
}

