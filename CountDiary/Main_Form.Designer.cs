
namespace CountDiary {
    partial class Main_Form {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.TextDiary = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.木を見るToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字全削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.Resetb = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.countchara = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextDiary
            // 
            this.TextDiary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextDiary.BackColor = System.Drawing.Color.Khaki;
            this.TextDiary.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextDiary.Location = new System.Drawing.Point(13, 34);
            this.TextDiary.MaxLength = 500;
            this.TextDiary.Multiline = true;
            this.TextDiary.Name = "TextDiary";
            this.TextDiary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextDiary.Size = new System.Drawing.Size(790, 391);
            this.TextDiary.TabIndex = 0;
            this.TextDiary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.終了ToolStripMenuItem,
            this.木を見るToolStripMenuItem,
            this.文字全削除ToolStripMenuItem});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.保存ToolStripMenuItem.Text = "日記を保存する";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // 木を見るToolStripMenuItem
            // 
            this.木を見るToolStripMenuItem.Name = "木を見るToolStripMenuItem";
            this.木を見るToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.木を見るToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.木を見るToolStripMenuItem.Text = "木を見る";
            this.木を見るToolStripMenuItem.Click += new System.EventHandler(this.木を見るToolStripMenuItem_Click_1);
            // 
            // 文字全削除ToolStripMenuItem
            // 
            this.文字全削除ToolStripMenuItem.Name = "文字全削除ToolStripMenuItem";
            this.文字全削除ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.文字全削除ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.文字全削除ToolStripMenuItem.Text = "文字全削除";
            this.文字全削除ToolStripMenuItem.Click += new System.EventHandler(this.文字全削除ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "total";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.BackColor = System.Drawing.Color.Red;
            this.count.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.count.Location = new System.Drawing.Point(128, 443);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(0, 12);
            this.count.TabIndex = 4;
            // 
            // Resetb
            // 
            this.Resetb.BackColor = System.Drawing.Color.Yellow;
            this.Resetb.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetb.ForeColor = System.Drawing.Color.Black;
            this.Resetb.Location = new System.Drawing.Point(689, 426);
            this.Resetb.Name = "Resetb";
            this.Resetb.Size = new System.Drawing.Size(115, 37);
            this.Resetb.TabIndex = 5;
            this.Resetb.Text = "Reset";
            this.Resetb.UseVisualStyleBackColor = false;
            this.Resetb.Click += new System.EventHandler(this.Resetb_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.White;
            this.save.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.save.Location = new System.Drawing.Point(604, 427);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(79, 35);
            this.save.TabIndex = 6;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // countchara
            // 
            this.countchara.AutoSize = true;
            this.countchara.BackColor = System.Drawing.Color.Transparent;
            this.countchara.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countchara.ForeColor = System.Drawing.Color.White;
            this.countchara.Location = new System.Drawing.Point(96, 428);
            this.countchara.Name = "countchara";
            this.countchara.Size = new System.Drawing.Size(32, 31);
            this.countchara.TabIndex = 7;
            this.countchara.Text = "0";
            this.countchara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.update.Location = new System.Drawing.Point(519, 427);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(79, 35);
            this.update.TabIndex = 9;
            this.update.Text = "add";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(403, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "character";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(815, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.countchara);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Resetb);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextDiary);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "WooDialy";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextDiary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 木を見るToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Button Resetb;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ToolStripMenuItem 文字全削除ToolStripMenuItem;
        private System.Windows.Forms.Label countchara;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label2;
    }
}

