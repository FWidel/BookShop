namespace Book_Shop
{
    partial class BookControl
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
            this.BookNameControl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BookPriceLabelControl = new System.Windows.Forms.Label();
            this.PriceNameLabelControl = new System.Windows.Forms.Label();
            this.BookControlpictureBox = new System.Windows.Forms.PictureBox();
            this.BookControlID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookControlpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BookNameControl
            // 
            this.BookNameControl.AutoSize = true;
            this.BookNameControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BookNameControl.Location = new System.Drawing.Point(14, 23);
            this.BookNameControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookNameControl.Name = "BookNameControl";
            this.BookNameControl.Size = new System.Drawing.Size(57, 21);
            this.BookNameControl.TabIndex = 0;
            this.BookNameControl.Text = "label1";
            this.BookNameControl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookPriceLabelControl
            // 
            this.BookPriceLabelControl.AutoSize = true;
            this.BookPriceLabelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BookPriceLabelControl.Location = new System.Drawing.Point(64, 332);
            this.BookPriceLabelControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookPriceLabelControl.Name = "BookPriceLabelControl";
            this.BookPriceLabelControl.Size = new System.Drawing.Size(47, 24);
            this.BookPriceLabelControl.TabIndex = 3;
            this.BookPriceLabelControl.Text = "30zł";
            // 
            // PriceNameLabelControl
            // 
            this.PriceNameLabelControl.AutoSize = true;
            this.PriceNameLabelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PriceNameLabelControl.Location = new System.Drawing.Point(10, 332);
            this.PriceNameLabelControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceNameLabelControl.Name = "PriceNameLabelControl";
            this.PriceNameLabelControl.Size = new System.Drawing.Size(58, 24);
            this.PriceNameLabelControl.TabIndex = 4;
            this.PriceNameLabelControl.Text = "Price:";
            // 
            // BookControlpictureBox
            // 
            this.BookControlpictureBox.Location = new System.Drawing.Point(7, 47);
            this.BookControlpictureBox.Name = "BookControlpictureBox";
            this.BookControlpictureBox.Size = new System.Drawing.Size(183, 228);
            this.BookControlpictureBox.TabIndex = 5;
            this.BookControlpictureBox.TabStop = false;
            // 
            // BookControlID
            // 
            this.BookControlID.AutoSize = true;
            this.BookControlID.Location = new System.Drawing.Point(96, 16);
            this.BookControlID.Name = "BookControlID";
            this.BookControlID.Size = new System.Drawing.Size(35, 13);
            this.BookControlID.TabIndex = 6;
            this.BookControlID.Text = "label1";
            this.BookControlID.Visible = false;
            // 
            // BookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.BookControlID);
            this.Controls.Add(this.BookControlpictureBox);
            this.Controls.Add(this.PriceNameLabelControl);
            this.Controls.Add(this.BookPriceLabelControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BookNameControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookControl";
            this.Size = new System.Drawing.Size(193, 363);
            this.Load += new System.EventHandler(this.BookControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookControlpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookNameControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BookPriceLabelControl;
        private System.Windows.Forms.Label PriceNameLabelControl;
        private System.Windows.Forms.PictureBox BookControlpictureBox;
        private System.Windows.Forms.Label BookControlID;
    }
}
