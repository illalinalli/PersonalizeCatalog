
namespace WindowsFormsApp2
{
    partial class Shema_Bashnya1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shema_Bashnya1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sh_bash1 = new System.Windows.Forms.Label();
            this.Sh_next_bashnya1 = new System.Windows.Forms.Button();
            this.Sh_nazad_bashnya1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Sh_bash1
            // 
            this.Sh_bash1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sh_bash1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sh_bash1.Location = new System.Drawing.Point(32, 9);
            this.Sh_bash1.Name = "Sh_bash1";
            this.Sh_bash1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sh_bash1.Size = new System.Drawing.Size(289, 47);
            this.Sh_bash1.TabIndex = 2;
            this.Sh_bash1.Text = "Расположите фигуры так же, как показано на рисунке.";
            this.Sh_bash1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sh_bash1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sh_next_bashnya1
            // 
            this.Sh_next_bashnya1.BackColor = System.Drawing.Color.BlueViolet;
            this.Sh_next_bashnya1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sh_next_bashnya1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sh_next_bashnya1.Location = new System.Drawing.Point(239, 282);
            this.Sh_next_bashnya1.Name = "Sh_next_bashnya1";
            this.Sh_next_bashnya1.Size = new System.Drawing.Size(82, 30);
            this.Sh_next_bashnya1.TabIndex = 3;
            this.Sh_next_bashnya1.Text = "Далее";
            this.Sh_next_bashnya1.UseVisualStyleBackColor = false;
            this.Sh_next_bashnya1.Click += new System.EventHandler(this.Sh_next_bashnya1_Click);
            // 
            // Sh_nazad_bashnya1
            // 
            this.Sh_nazad_bashnya1.BackColor = System.Drawing.Color.BlueViolet;
            this.Sh_nazad_bashnya1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sh_nazad_bashnya1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sh_nazad_bashnya1.Location = new System.Drawing.Point(25, 282);
            this.Sh_nazad_bashnya1.Name = "Sh_nazad_bashnya1";
            this.Sh_nazad_bashnya1.Size = new System.Drawing.Size(82, 30);
            this.Sh_nazad_bashnya1.TabIndex = 4;
            this.Sh_nazad_bashnya1.Text = "Назад";
            this.Sh_nazad_bashnya1.UseVisualStyleBackColor = false;
            this.Sh_nazad_bashnya1.Click += new System.EventHandler(this.Sh_nazad_bashnya1_Click);
            // 
            // Shema_Bashnya1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 333);
            this.Controls.Add(this.Sh_nazad_bashnya1);
            this.Controls.Add(this.Sh_next_bashnya1);
            this.Controls.Add(this.Sh_bash1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Shema_Bashnya1";
            this.Text = "Shema_Bashnya1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Sh_bash1;
        private System.Windows.Forms.Button Sh_next_bashnya1;
        private System.Windows.Forms.Button Sh_nazad_bashnya1;
    }
}