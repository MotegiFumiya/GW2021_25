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
            int tlength = this.TextDiary.TextLength;

            var tlen = tlength.ToString();

            countchara.Text = tlen;
            
            //仮
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();

            
            if (tlength < 15) {
                f2.Show();
            } else {
                f3.Show();
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
#if false
        //private void 過去の日記を開くToolStripMenuItem_Click(object sender, EventArgs e) {
        //    OpenFileDialog ofd = new OpenFileDialog();

        //    ofd.InitialDirectory= @"C:\Users\infosys\source\repos\GW2021_25\Diary.csv";

        //    //タイトルを設定する
        //    ofd.Title= "開くファイルを選択してください";

        //    //ダイアログを表示する
        //    if (ofd.ShowDialog() == DialogResult.OK) {
        //        //OKボタンがクリックされたとき、選択されたファイル名を表示する
        //        Console.WriteLine(ofd.FileName);
        //    }
        //}
#endif


        //文字削除
        private void 文字全削除ToolStripMenuItem_Click(object sender, EventArgs e) {
            ClearTextBox(this);
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
            
        }

        //累計文字数リセット
        private void Resetb_Click(object sender, EventArgs e) {
            DialogResult reset = MessageBox.Show("本当にリセットしますか？", "文字数リセット", MessageBoxButtons.YesNo);
            if (reset == DialogResult.Yes) {
                countchara.Text = "0";
            }
        }

        //文字数保存
        private void save_Click(object sender, EventArgs e) {

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                using (var writer = new StreamWriter("C:/Users/infosys/source/repos/GW2021_25/test.csv")) {
                    writer.WriteLine(countchara.Text);
                } 

#if false
                data d = new data();
                d.name = new byte[32];
                System.Text.Encoding.UTF8.GetBytes(countchara.Text);

                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                //BinaryWriter bw = new BinaryWriter(fs);
                TextWriter tw = new TextWriter(tw);
                d.count = tlength;

                bw.Write(d.count);

                bw.Close();
                fs.Close();
                MessageBox.Show("保存しました");
#endif
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
            DialogResult check = MessageBox.Show("文字数を更新しますか？", "更新", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes) {
                countchara.Text = ans.ToString();
            }
            
        }

        

        //保存した文字数呼出し
        private void call_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                
                using (var reader = new StreamReader("C:/Users/infosys/source/repos/GW2021_25/test.csv")) {
                    string count = reader.ReadToEnd();
                    countchara.Text = count;
                }
#if false
                data d = new data();

                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                d.name = br.ReadBytes(32);
                string text = System.Text.Encoding.ASCII.GetString(d.name);
                text = text.TrimEnd('\0');

                //d.count = br.ReadDecimal();

                MessageBox.Show("読み込みが完了しました");
                countchara.Text += string.Format(text);
                //countchara.Text += string.Format("{0:g}\r\n",d.count);
#endif
            }
        }

    }
}
