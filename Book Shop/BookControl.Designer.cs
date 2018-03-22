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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BookPriceLabelControl = new System.Windows.Forms.Label();
            this.PriceNameLabelControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookNameControl
            // 
            this.BookNameControl.AutoSize = true;
            this.BookNameControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BookNameControl.Location = new System.Drawing.Point(18, 28);
            this.BookNameControl.Name = "BookNameControl";
            this.BookNameControl.Size = new System.Drawing.Size(72, 23);
            this.BookNameControl.TabIndex = 0;
            this.BookNameControl.Text = "label1";
            this.BookNameControl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(14, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 260);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookPriceLabelControl
            // 
            this.BookPriceLabelControl.AutoSize = true;
            this.BookPriceLabelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BookPriceLabelControl.Location = new System.Drawing.Point(86, 408);
            this.BookPriceLabelControl.Name = "BookPriceLabelControl";
            this.BookPriceLabelControl.Size = new System.Drawing.Size(59, 29);
            this.BookPriceLabelControl.TabIndex = 3;
            this.BookPriceLabelControl.Text = "30zł";
            // 
            // PriceNameLabelControl
            // 
            this.PriceNameLabelControl.AutoSize = true;
            this.PriceNameLabelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PriceNameLabelControl.Location = new System.Drawing.Point(14, 408);
            this.PriceNameLabelControl.Name = "PriceNameLabelControl";
            this.PriceNameLabelControl.Size = new System.Drawing.Size(75, 29);
            this.PriceNameLabelControl.TabIndex = 4;
            this.PriceNameLabelControl.Text = "Price:";
            // 
            // BookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.PriceNameLabelControl);
            this.Controls.Add(this.BookPriceLabelControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BookNameControl);
            this.Name = "BookControl";
            this.Size = new System.Drawing.Size(257, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookNameControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BookPriceLabelControl;
        private System.Windows.Forms.Label PriceNameLabelControl;
    }
}
