namespace COBA_COBA_UTS
{
    partial class UserControl2
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Harga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.Jumlah = new System.Windows.Forms.NumericUpDown();
            this.AddToPaymentButton = new FontAwesome.Sharp.IconButton();
            this.Ukuran = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.AutoSize = true;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(287, -1);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(48, 44);
            this.iconButton1.TabIndex = 33;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.Harga.Location = new System.Drawing.Point(199, 124);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(102, 26);
            this.Harga.TabIndex = 29;
            this.Harga.Text = "Rp300.000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(214, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Jumlah";
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.Nama.Location = new System.Drawing.Point(199, 43);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(99, 23);
            this.Nama.TabIndex = 28;
            this.Nama.Text = "Jeans Pants";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 234);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // Foto
            // 
            this.Foto.BackColor = System.Drawing.Color.White;
            this.Foto.Location = new System.Drawing.Point(33, 26);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(110, 177);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Foto.TabIndex = 34;
            this.Foto.TabStop = false;
            // 
            // Jumlah
            // 
            this.Jumlah.Location = new System.Drawing.Point(211, 191);
            this.Jumlah.Margin = new System.Windows.Forms.Padding(4);
            this.Jumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(71, 22);
            this.Jumlah.TabIndex = 35;
            this.Jumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Jumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Jumlah.ValueChanged += new System.EventHandler(this.Jumlah_ValueChanged);
            // 
            // AddToPaymentButton
            // 
            this.AddToPaymentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.AddToPaymentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToPaymentButton.FlatAppearance.BorderSize = 0;
            this.AddToPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToPaymentButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddToPaymentButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToPaymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(194)))), ((int)(((byte)(80)))));
            this.AddToPaymentButton.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.AddToPaymentButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.AddToPaymentButton.IconSize = 30;
            this.AddToPaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddToPaymentButton.Location = new System.Drawing.Point(38, 239);
            this.AddToPaymentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddToPaymentButton.Name = "AddToPaymentButton";
            this.AddToPaymentButton.Rotation = 0D;
            this.AddToPaymentButton.Size = new System.Drawing.Size(244, 40);
            this.AddToPaymentButton.TabIndex = 36;
            this.AddToPaymentButton.Tag = "Keranjang";
            this.AddToPaymentButton.Text = "Add To Payment";
            this.AddToPaymentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddToPaymentButton.UseVisualStyleBackColor = false;
            this.AddToPaymentButton.Click += new System.EventHandler(this.AddToPaymentButton_Click);
            // 
            // Ukuran
            // 
            this.Ukuran.FormattingEnabled = true;
            this.Ukuran.Location = new System.Drawing.Point(202, 83);
            this.Ukuran.Name = "Ukuran";
            this.Ukuran.Size = new System.Drawing.Size(96, 24);
            this.Ukuran.TabIndex = 37;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.Ukuran);
            this.Controls.Add(this.AddToPaymentButton);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(328, 285);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.NumericUpDown Jumlah;
        private FontAwesome.Sharp.IconButton AddToPaymentButton;
        private System.Windows.Forms.ComboBox Ukuran;
    }
}
