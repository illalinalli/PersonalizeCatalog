
namespace WindowsFormsApp2
{
    partial class Shema_Bashnya2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shema_Bashnya2));
            this.Sh_nazad_bashnya2 = new System.Windows.Forms.Button();
            this.Sh_next_bashnya2 = new System.Windows.Forms.Button();
            this.Sh_bash2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Sh_nazad_bashnya2
            // 
            this.Sh_nazad_bashnya2.BackColor = System.Drawing.Color.BlueViolet;
            this.Sh_nazad_bashnya2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sh_nazad_bashnya2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sh_nazad_bashnya2.Location = new System.Drawing.Point(26, 294);
            this.Sh_nazad_bashnya2.Name = "Sh_nazad_bashnya2";
            this.Sh_nazad_bashnya2.Size = new System.Drawing.Size(82, 30);
            this.Sh_nazad_bashnya2.TabIndex = 8;
            this.Sh_nazad_bashnya2.Text = "Назад";
            this.Sh_nazad_bashnya2.UseVisualStyleBackColor = false;
            this.Sh_nazad_bashnya2.Click += new System.EventHandler(this.Sh_nazad_bashnya2_Click);
            // 
            // Sh_next_bashnya2
            // 
            this.Sh_next_bashnya2.BackColor = System.Drawing.Color.BlueViolet;
            this.Sh_next_bashnya2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sh_next_bashnya2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sh_next_bashnya2.Location = new System.Drawing.Point(240, 294);
            this.Sh_next_bashnya2.Name = "Sh_next_bashnya2";
            this.Sh_next_bashnya2.Size = new System.Drawing.Size(82, 30);
            this.Sh_next_bashnya2.TabIndex = 7;
            this.Sh_next_bashnya2.Text = "Далее";
            this.Sh_next_bashnya2.UseVisualStyleBackColor = false;
            this.Sh_next_bashnya2.Click += new System.EventHandler(this.Sh_next_bashnya2_Click);
            // 
            // Sh_bash2
            // 
            this.Sh_bash2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sh_bash2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sh_bash2.Location = new System.Drawing.Point(33, 21);
            this.Sh_bash2.Name = "Sh_bash2";
            this.Sh_bash2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sh_bash2.Size = new System.Drawing.Size(289, 47);
            this.Sh_bash2.TabIndex = 6;
            this.Sh_bash2.Text = "Расположите фигуры так же, как показано на рисунке.";
            this.Sh_bash2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 201);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Shema_Bashnya2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 352);
            this.Controls.Add(this.Sh_nazad_bashnya2);
            this.Controls.Add(this.Sh_next_bashnya2);
            this.Controls.Add(this.Sh_bash2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Shema_Bashnya2";
            this.Text = "Shema_Bashnya2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sh_nazad_bashnya2;
        private System.Windows.Forms.Button Sh_next_bashnya2;
        private System.Windows.Forms.Label Sh_bash2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}