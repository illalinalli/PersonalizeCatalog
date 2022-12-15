
namespace WindowsFormsApp2
{
    partial class PersonalKabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalKabinet));
            this.personalKab_picture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.change_amount_details = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // personalKab_picture
            // 
            this.personalKab_picture.BackColor = System.Drawing.Color.BlueViolet;
            this.personalKab_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalKab_picture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personalKab_picture.Location = new System.Drawing.Point(25, 230);
            this.personalKab_picture.Name = "personalKab_picture";
            this.personalKab_picture.Size = new System.Drawing.Size(188, 31);
            this.personalKab_picture.TabIndex = 1;
            this.personalKab_picture.Text = "Загрузить изображение";
            this.personalKab_picture.UseVisualStyleBackColor = false;
            this.personalKab_picture.Click += new System.EventHandler(this.personalKab_picture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username_label.Location = new System.Drawing.Point(287, 72);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(0, 18);
            this.username_label.TabIndex = 2;
            this.username_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Данные пользователя";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // change_amount_details
            // 
            this.change_amount_details.BackColor = System.Drawing.Color.BlueViolet;
            this.change_amount_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_amount_details.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.change_amount_details.Location = new System.Drawing.Point(279, 165);
            this.change_amount_details.Name = "change_amount_details";
            this.change_amount_details.Size = new System.Drawing.Size(121, 48);
            this.change_amount_details.TabIndex = 4;
            this.change_amount_details.Text = "Изменить кол-во деталей";
            this.change_amount_details.UseVisualStyleBackColor = false;
            this.change_amount_details.Click += new System.EventHandler(this.change_amount_details_Click);
            // 
            // PersonalKabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 294);
            this.Controls.Add(this.change_amount_details);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.personalKab_picture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PersonalKabinet";
            this.Text = "PersonalKabinet";
            this.Load += new System.EventHandler(this.PersonalKabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button personalKab_picture;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button change_amount_details;
    }
}