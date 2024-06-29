namespace COBA_COBA_UTS
{
    partial class UserControl1
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
            this.Harga = new System.Windows.Forms.Label();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Nama = new System.Windows.Forms.Label();
            this.AddToCartButton = new FontAwesome.Sharp.IconButton();
            this.Stok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harga.Location = new System.Drawing.Point(145, 239);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(105, 26);
            this.Harga.TabIndex = 20;
            this.Harga.Text = "Rp??????????";
            // 
            // Foto
            // 
            this.Foto.BackColor = System.Drawing.Color.White;
            this.Foto.Location = new System.Drawing.Point(67, 32);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(110, 177);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Foto.TabIndex = 19;
            this.Foto.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = global::COBA_COBA_UTS.Properties.Resources.Keranjang;
            this.pictureBox6.Location = new System.Drawing.Point(193, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.Location = new System.Drawing.Point(6, 208);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(84, 28);
            this.Nama.TabIndex = 18;
            this.Nama.Text = "?????????";
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
            this.AddToCartButton.Location = new System.Drawing.Point(3, 275);
            this.AddToCartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Rotation = 0D;
            this.AddToCartButton.Size = new System.Drawing.Size(244, 38);
            this.AddToCartButton.TabIndex = 16;
            this.AddToCartButton.Tag = "Keranjang";
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddToCartButton.UseVisualStyleBackColor = false;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // Stok
            // 
            this.Stok.AutoSize = true;
            this.Stok.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stok.Location = new System.Drawing.Point(65, 243);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(33, 20);
            this.Stok.TabIndex = 21;
            this.Stok.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Stock :";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.Stok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.AddToCartButton);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(251, 316);
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Nama;
        private FontAwesome.Sharp.IconButton AddToCartButton;
        private System.Windows.Forms.Label Stok;
        private System.Windows.Forms.Label label2;
    }
}
