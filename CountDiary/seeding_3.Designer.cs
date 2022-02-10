
namespace CountDiary {
    partial class seeding_3 {
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
            this.woodpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.woodpic)).BeginInit();
            this.SuspendLayout();
            // 
            // woodpic
            // 
            this.woodpic.Location = new System.Drawing.Point(12, 12);
            this.woodpic.Name = "woodpic";
            this.woodpic.Size = new System.Drawing.Size(450, 550);
            this.woodpic.TabIndex = 0;
            this.woodpic.TabStop = false;
            // 
            // seeding_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 581);
            this.Controls.Add(this.woodpic);
            this.Name = "seeding_3";
            this.Text = "Wood";
            this.Load += new System.EventHandler(this.seeding_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.woodpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox woodpic;
    }
}