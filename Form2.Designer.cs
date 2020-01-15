namespace VP_11
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbUserid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Viewbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbPassword.HintText = "";
            this.tbPassword.isPassword = true;
            this.tbPassword.LineFocusedColor = System.Drawing.Color.Orange;
            this.tbPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPassword.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.tbPassword.LineThickness = 4;
            this.tbPassword.Location = new System.Drawing.Point(120, 152);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(208, 32);
            this.tbPassword.TabIndex = 29;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUserid
            // 
            this.tbUserid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbUserid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserid.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUserid.HintForeColor = System.Drawing.Color.Empty;
            this.tbUserid.HintText = "";
            this.tbUserid.isPassword = false;
            this.tbUserid.LineFocusedColor = System.Drawing.Color.Orange;
            this.tbUserid.LineIdleColor = System.Drawing.Color.Gray;
            this.tbUserid.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.tbUserid.LineThickness = 4;
            this.tbUserid.Location = new System.Drawing.Point(120, 83);
            this.tbUserid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUserid.Name = "tbUserid";
            this.tbUserid.Size = new System.Drawing.Size(208, 32);
            this.tbUserid.TabIndex = 28;
            this.tbUserid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "User ID:";
            // 
            // Viewbtn
            // 
            this.Viewbtn.ActiveBorderThickness = 1;
            this.Viewbtn.ActiveCornerRadius = 20;
            this.Viewbtn.ActiveFillColor = System.Drawing.Color.Orange;
            this.Viewbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Viewbtn.ActiveLineColor = System.Drawing.Color.Orange;
            this.Viewbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Viewbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Viewbtn.BackgroundImage")));
            this.Viewbtn.ButtonText = "LogIn";
            this.Viewbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Viewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbtn.ForeColor = System.Drawing.Color.Orange;
            this.Viewbtn.IdleBorderThickness = 1;
            this.Viewbtn.IdleCornerRadius = 20;
            this.Viewbtn.IdleFillColor = System.Drawing.SystemColors.ButtonFace;
            this.Viewbtn.IdleForecolor = System.Drawing.Color.Orange;
            this.Viewbtn.IdleLineColor = System.Drawing.Color.Orange;
            this.Viewbtn.Location = new System.Drawing.Point(181, 236);
            this.Viewbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(106, 42);
            this.Viewbtn.TabIndex = 30;
            this.Viewbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Orange;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Orange;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Close";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Orange;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Orange;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Orange;
            this.bunifuThinButton21.Location = new System.Drawing.Point(65, 236);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(106, 42);
            this.bunifuThinButton21.TabIndex = 31;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Log In";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUserid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 Viewbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label1;
    }
}