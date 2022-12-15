namespace WindowsFormsApp2
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Avtorizatia = new System.Windows.Forms.LinkLabel();
            this.repeatPasswordField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Avtorizatia);
            this.panel1.Controls.Add(this.repeatPasswordField);
            this.panel1.Controls.Add(this.userNameField);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.passField);
            this.panel1.Controls.Add(this.loginField);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 282);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Avtorizatia
            // 
            this.Avtorizatia.AutoSize = true;
            this.Avtorizatia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Avtorizatia.LinkColor = System.Drawing.Color.BlueViolet;
            this.Avtorizatia.Location = new System.Drawing.Point(287, 21);
            this.Avtorizatia.Name = "Avtorizatia";
            this.Avtorizatia.Size = new System.Drawing.Size(48, 17);
            this.Avtorizatia.TabIndex = 10;
            this.Avtorizatia.TabStop = true;
            this.Avtorizatia.Text = "Войти";
            this.Avtorizatia.Click += new System.EventHandler(this.Avtorizatia_Click);
            // 
            // repeatPasswordField
            // 
            this.repeatPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.repeatPasswordField.Location = new System.Drawing.Point(24, 177);
            this.repeatPasswordField.Name = "repeatPasswordField";
            this.repeatPasswordField.Size = new System.Drawing.Size(233, 23);
            this.repeatPasswordField.TabIndex = 9;
            this.repeatPasswordField.Enter += new System.EventHandler(this.repeatPasswordField_Enter);
            this.repeatPasswordField.Leave += new System.EventHandler(this.repeatPasswordField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userNameField.Location = new System.Drawing.Point(25, 55);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(232, 23);
            this.userNameField.TabIndex = 8;
            this.userNameField.TextChanged += new System.EventHandler(this.userNameField_TextChanged);
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Регистрация";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNext.Location = new System.Drawing.Point(25, 227);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(278, 36);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passField.Location = new System.Drawing.Point(24, 139);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(233, 23);
            this.passField.TabIndex = 4;
            this.passField.TextChanged += new System.EventHandler(this.passField_TextChanged);
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginField.Location = new System.Drawing.Point(25, 95);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(232, 23);
            this.loginField.TabIndex = 3;
            this.loginField.TextChanged += new System.EventHandler(this.loginField_TextChanged);
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 282);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox repeatPasswordField;
        private System.Windows.Forms.LinkLabel Avtorizatia;
    }
}