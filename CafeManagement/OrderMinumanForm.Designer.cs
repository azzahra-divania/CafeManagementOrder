namespace CafeManagement
{
    partial class OrderMinumanForm
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



            this.SuspendLayout();




            // 
            // OrderMinumanForm
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(base.winFormWidth, 640);



            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Spesifikasi Order";
            this.Text = "OrderMinumanForm";
            this.Load += new System.EventHandler(this.OrderMinumanForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbTumblr;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton[] radioButtonSizeList;
        private System.Windows.Forms.RadioButton[] radioButtonToppingList;
    }
}