namespace VP_11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnReg = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbLname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbUserid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnReg
            // 
            this.btnReg.ActiveBorderThickness = 1;
            this.btnReg.ActiveCornerRadius = 20;
            this.btnReg.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnReg.ActiveForecolor = System.Drawing.Color.White;
            this.btnReg.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnReg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReg.BackgroundImage")));
            this.btnReg.ButtonText = "Register";
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.Orange;
            this.btnReg.IdleBorderThickness = 1;
            this.btnReg.IdleCornerRadius = 20;
            this.btnReg.IdleFillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReg.IdleForecolor = System.Drawing.Color.Orange;
            this.btnReg.IdleLineColor = System.Drawing.Color.Orange;
            this.btnReg.Location = new System.Drawing.Point(203, 371);
            this.btnReg.Margin = new System.Windows.Forms.Padding(5);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(106, 42);
            this.btnReg.TabIndex = 29;
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.Orange;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.Orange;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Orange;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.IdleForecolor = System.Drawing.Color.Orange;
            this.btnCancel.IdleLineColor = System.Drawing.Color.Orange;
            this.btnCancel.Location = new System.Drawing.Point(319, 371);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 42);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbLname
            // 
            this.tbLname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLname.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLname.HintForeColor = System.Drawing.Color.Empty;
            this.tbLname.HintText = "";
            this.tbLname.isPassword = true;
            this.tbLname.LineFocusedColor = System.Drawing.Color.Orange;
            this.tbLname.LineIdleColor = System.Drawing.Color.Gray;
            this.tbLname.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.tbLname.LineThickness = 4;
            this.tbLname.Location = new System.Drawing.Point(182, 156);
            this.tbLname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(208, 32);
            this.tbLname.TabIndex = 27;
            this.tbLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "LAST NAME:";
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
            this.tbPassword.Location = new System.Drawing.Point(182, 293);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(208, 32);
            this.tbPassword.TabIndex = 25;
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
            this.tbUserid.Location = new System.Drawing.Point(182, 224);
            this.tbUserid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUserid.Name = "tbUserid";
            this.tbUserid.Size = new System.Drawing.Size(208, 32);
            this.tbUserid.TabIndex = 24;
            this.tbUserid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.HintForeColor = System.Drawing.Color.Empty;
            this.tbName.HintText = "";
            this.tbName.isPassword = false;
            this.tbName.LineFocusedColor = System.Drawing.Color.Orange;
            this.tbName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbName.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.tbName.LineThickness = 4;
            this.tbName.Location = new System.Drawing.Point(182, 89);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(208, 32);
            this.tbName.TabIndex = 23;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Register Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 436);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserid);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReg;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbLname;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUserid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

