using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace CountDiary {
    public partial class Form1 : Form {

        

        public Form1() {

            InitializeComponent();

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e) {
            
        }
        
        //ウインドウ遷移
        private void 木を見るToolStripMenuItem_Click_1(object sender, EventArgs e) {
            int tlength = TextDiary.TextLength;

            var tlen = tlength.ToString();

            var count = int.Parse(countchara.Text);
            
            //仮
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            Form4 f4 = new Form4();

            
            if (count <= 10) {
                f2.Show();
            }else if (count  <= 15) {
                f3.Show();
            }else if (count  <= 20) {
                f4.Show();
            }

            
        }

        //終了処理
        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("日記を閉じますか？", "終了", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                Close();
            }
        }

        //日記保存
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            //現在の日付のみ取得
            String now = DateTime.Now.ToString("D");
            
            SaveFileDialog sfd = new SaveFileDialog();
            //はじめに「ファイル名」で表示される文字列を指定する
            //ファイル名〇月〇日.csv
            sfd.FileName = now + ".txt";
                        
            sfd.ShowDialog();
            
            StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8);
            sw.Write(TextDiary.Text);
            //sw.WriteLine(TextDiary.Text);
            sw.Close();

        }

        //文字削除
        private void 文字全削除ToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult reset = MessageBox.Show("本当に削除しますか？", "削除",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reset == DialogResult.Yes) {
                ClearTextBox(this);
            }
            
        }

        //文字削除関数
        public static void ClearTextBox(Control hParent) {
            foreach (Control cControl in hParent.Controls) {
                if (cControl.HasChildren == true) {
                    ClearTextBox(cControl);
                }

                if (cControl is TextBoxBase) {
                    cControl.Text = string.Empty;
                }
            }
        }



        //ウィンドウサイズ変更不可
        private void Form1_Load(object sender, EventArgs e) {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            using (var reader = new StreamReader("C:/Users/infosys/source/repos/GW2021_25/count.txt")) {
                string count = reader.ReadToEnd();
                countchara.Text = count;
            }
        }

        //累計文字数リセット
        private void Resetb_Click(object sender, EventArgs e) {
            DialogResult reset = MessageBox.Show("本当にcountをリセットしますか？", "reset", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (reset == DialogResult.Yes) {
                countchara.Text = "0";
            }
        }

        //文字数保存
        private void save_Click(object sender, EventArgs e) {
                using (var writer = new StreamWriter("C:/Users/infosys/source/repos/GW2021_25/count.txt")) {
                    writer.WriteLine(countchara.Text);
                MessageBox.Show("保存しました");
            }
        }

        //文字数加算（更新）
        private void update_Click(object sender, EventArgs e) {
            //日記本文の文字数
            int tlength = TextDiary.TextLength;

            //count変数　総文字数のテキストを数字へ変換
            var count = int.Parse(countchara.Text);

            //カウントされている文字総数
            var tlen = tlength.ToString();

            //現在の日記本文の文字数＋総文字数
            int ans = tlength += count;

            //更新確認
            DialogResult check = MessageBox.Show("文字数を加算します", "add", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes) {
                countchara.Text = ans.ToString();
            }
            
        }

        
    }
}
