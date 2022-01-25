
namespace CountDiary {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.wood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wood)).BeginInit();
            this.SuspendLayout();
            // 
            // wood
            // 
            this.wood.Location = new System.Drawing.Point(12, 12);
            this.wood.Name = "wood";
            this.wood.Size = new System.Drawing.Size(459, 551);
            this.wood.TabIndex = 0;
            this.wood.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 575);
            this.Controls.Add(this.wood);
            this.Name = "Form2";
            this.Text = "木";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox wood;
    }
}