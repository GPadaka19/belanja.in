namespace COBA_COBA_UTS
{
    partial class UserControl5
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Jumlah = new System.Windows.Forms.NumericUpDown();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.Harga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddToCartButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Jumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 74);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 21);
            this.comboBox1.TabIndex = 51;
            // 
            // Jumlah
            // 
            this.Jumlah.Enabled = false;
            this.Jumlah.Location = new System.Drawing.Point(273, 75);
            this.Jumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.ReadOnly = true;
            this.Jumlah.Size = new System.Drawing.Size(53, 20);
            this.Jumlah.TabIndex = 50;
            this.Jumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Jumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Foto
            // 
            this.Foto.BackColor = System.Drawing.Color.White;
            this.Foto.Location = new System.Drawing.Point(48, 34);
            this.Foto.Margin = new System.Windows.Forms.Padding(2);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(64, 79);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Foto.TabIndex = 49;
            this.Foto.TabStop = false;
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.Harga.Location = new System.Drawing.Point(376, 68);
            this.Harga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(102, 26);
            this.Harga.TabIndex = 45;
            this.Harga.Text = "Rp300.000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(269, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Jumlah";
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.Nama.Location = new System.Drawing.Point(141, 49);
            this.Nama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(99, 23);
            this.Nama.TabIndex = 44;
            this.Nama.Text = "Jeans Pants";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(34, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 104);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.AddToCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToCartButton.FlatAppearance.BorderSize = 0;
            this.AddToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToCartButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddToCartButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(194)))), ((int)(((byte)(80)))));
            this.AddToCartButton.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.AddToCartButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.AddToCartButton.IconSize = 30;
            this.AddToCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddToCartButton.Location = new System.Drawing.Point(502, 63);
            this.AddToCartButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Rotation = 0D;
            this.AddToCartButton.Size = new System.Drawing.Size(183, 31);
            this.AddToCartButton.TabIndex = 52;
            this.AddToCartButton.Tag = "Keranjang";
            this.AddToCartButton.Text = "Beli lagi ?";
            this.AddToCartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddToCartButton.UseVisualStyleBackColor = false;
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(685, 150);
            ((System.ComponentModel.ISupportInitialize)(this.Jumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown Jumlah;
        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton AddToCartButton;
    }
}
