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
    public partial class Main_Form : Form {



        public Main_Form() {

            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        //ウインドウ遷移
        private void 木を見るToolStripMenuItem_Click_1(object sender, EventArgs e) {
            String now = DateTime.Today.Month.ToString();
            
#if true
            int jan = 1; int feb = 2; int mar = 3;
            int apr = 4; int may = 5; int jun = 6;
            int jul = 7; int aug = 8; int sep = 9;
            int oct = 10; int nov = 11; int dec = 12;

            var ja = jan.ToString(); var fe = feb.ToString(); var ma = mar.ToString();
            var ap = apr.ToString(); var m = may.ToString(); var j = jun.ToString();
            var jl = jul.ToString(); var au = aug.ToString(); var se = sep.ToString();
            var oc = oct.ToString(); var no = nov.ToString(); var de = dec.ToString();
#endif

            int tlength = TextDiary.TextLength;

            var tlen = tlength.ToString();

            var count = int.Parse(countchara.Text);

            //仮
            seeding_1 seed1 = new seeding_1();
            seeding_2 seed2 = new seeding_2();
            seeding_3 seed3 = new seeding_3();
            wood_1 wood1 = new wood_1();
            wood_2 wood2 = new wood_2();
            wood_3 wood3 = new wood_3();
            wood_winter winter = new wood_winter();
            wood_spring spring = new wood_spring();
            wood_summer summer = new wood_summer();
            wood_fall fall = new wood_fall();


            //総文字数によって移動するシーンを変更
            if (count >= 0 && count <= 1750) {
                seed1.Show();
            }
            else if (count > 1750 && count <= 3500) {
                seed2.Show();
            }
            else if (count > 3500 && count <= 5250) {
                seed3.Show();
            } 
            else if (count > 5250 && count <= 7000) {
                wood1.Show();
            }
            else if (count > 7000 && count <= 8750) {
                wood2.Show();
            }
            else if (count > 8750 && count <= 12250) {
                wood3.Show();
            }
            else if (count >12250) {
               
                if (now == ja || now == fe || now == de) {
                    winter.Show();
                }
                else if(now == ma || now == ap || now == m) {
                    spring.Show();
                }
                else if (now == j || now == jl || now == au) {
                    summer.Show();
                }
                else if(now == se || now == oc || now == no) {
                    fall.Show();
                }

                
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
        private void Main_Form_Load(object sender, EventArgs e) {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            using (var reader = new StreamReader("C:/Users/infosys/source/repos/GW2021_25/count.txt")) {
                string count = reader.ReadToEnd();
                countchara.Text = count;
            }
        }

        //累計文字数リセット
        private void Resetb_Click(object sender, EventArgs e) {
            DialogResult reset = MessageBox.Show("本当にcountをリセットしますか？", "reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reset == DialogResult.Yes) {
                countchara.Text = "0";
                var count = int.Parse(countchara.Text);
                count = 0;
            }
        }

        //文字数保存
        private void save_Click(object sender, EventArgs e) {
            using (var writer = new StreamWriter("C:/Users/infosys/source/repos/GW2021_25/count.txt")) {
                writer.WriteLine(countchara.Text);
                MessageBox.Show("文字数を保存しました");
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
    
