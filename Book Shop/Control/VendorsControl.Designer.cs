namespace Book_Shop
{
    partial class VendorsControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label13434 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label13434
            // 
            this.label13434.AutoSize = true;
            this.label13434.Location = new System.Drawing.Point(403, 212);
            this.label13434.Name = "label13434";
            this.label13434.Size = new System.Drawing.Size(46, 17);
            this.label13434.TabIndex = 0;
            this.label13434.Text = "label1";
            // 
            // VendorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13434);
            this.Name = "VendorsControl";
            this.Size = new System.Drawing.Size(1042, 574);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13434;
    }
}
