
namespace WindowsFormsApp2
{
    partial class Shema_Bashnya3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shema_Bashnya3));
            this.Sh_nazad_bashnya3 = new System.Windows.Forms.Button();
            this.Sh_next_bashnya3 = new System.Windows.Forms.Button();
            this.Sh_bash3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Sh_nazad_bashnya3
            // 
            this.Sh_nazad_bashnya3.BackColor = System.Drawing.Color.BlueViolet;
            this.Sh_nazad_bashnya3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sh_nazad_bashnya3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sh_nazad_bashnya3.Location = new System.Drawing.Point(12, 303);
            this.Sh_nazad_bashnya3.Name = "Sh_nazad_bashnya3";
            this.Sh_nazad_bashnya3.Size = new System.Drawing.Size(82, 30);
            this.Sh_nazad_bashnya3.TabIndex = 12;
            this.Sh_nazad_bashnya3.Text = "Назад";
            this.Sh_nazad_bashnya3.UseVisualStyleBackColor = false;
            this.Sh_nazad_bashnya3.Click += new System.EventHandler(this.Sh_nazad_bashnya3_Click);
            // 
            // Sh_next_bashnya3
            // 
            this.Sh_next_bashnya3.BackColor = System.Drawing.Color.BlueViolet;
            this.Sh_next_bashnya3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sh_next_bashnya3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sh_next_bashnya3.Location = new System.Drawing.Point(243, 303);
            this.Sh_next_bashnya3.Name = "Sh_next_bashnya3";
            this.Sh_next_bashnya3.Size = new System.Drawing.Size(82, 30);
            this.Sh_next_bashnya3.TabIndex = 11;
            this.Sh_next_bashnya3.Text = "Далее";
            this.Sh_next_bashnya3.UseVisualStyleBackColor = false;
            this.Sh_next_bashnya3.Click += new System.EventHandler(this.Sh_next_bashnya3_Click);
            // 
            // Sh_bash3
            // 
            this.Sh_bash3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sh_bash3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sh_bash3.Location = new System.Drawing.Point(26, 20);
            this.Sh_bash3.Name = "Sh_bash3";
            this.Sh_bash3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sh_bash3.Size = new System.Drawing.Size(289, 47);
            this.Sh_bash3.TabIndex = 10;
            this.Sh_bash3.Text = "Расположите фигуры так же, как показано на рисунке.";
            this.Sh_bash3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(47, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(239, 227);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // Shema_Bashnya3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 358);
            this.Controls.Add(this.Sh_nazad_bashnya3);
            this.Controls.Add(this.Sh_next_bashnya3);
            this.Controls.Add(this.Sh_bash3);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Shema_Bashnya3";
            this.Text = "Shema_Bashnya3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sh_nazad_bashnya3;
        private System.Windows.Forms.Button Sh_next_bashnya3;
        private System.Windows.Forms.Label Sh_bash3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}