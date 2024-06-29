namespace COBA_COBA_UTS
{
    partial class Keranjang
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddToPaymentButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(49, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(888, 431);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // AddToPaymentButton
            // 
            this.AddToPaymentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.AddToPaymentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToPaymentButton.FlatAppearance.BorderSize = 0;
            this.AddToPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToPaymentButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddToPaymentButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToPaymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(194)))), ((int)(((byte)(80)))));
            this.AddToPaymentButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.AddToPaymentButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.AddToPaymentButton.IconSize = 30;
            this.AddToPaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddToPaymentButton.Location = new System.Drawing.Point(693, 473);
            this.AddToPaymentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddToPaymentButton.Name = "AddToPaymentButton";
            this.AddToPaymentButton.Rotation = 0D;
            this.AddToPaymentButton.Size = new System.Drawing.Size(244, 38);
            this.AddToPaymentButton.TabIndex = 17;
            this.AddToPaymentButton.Tag = "Payment";
            this.AddToPaymentButton.Text = "Add To Payment";
            this.AddToPaymentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddToPaymentButton.UseVisualStyleBackColor = false;
            this.AddToPaymentButton.Click += new System.EventHandler(this.AddToPaymentButton_Click);
            // 
            // Keranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(971, 541);
            this.Controls.Add(this.AddToPaymentButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Keranjang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keranjang";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton AddToPaymentButton;
    }
}