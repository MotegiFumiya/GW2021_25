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


namespace CountDiary {
    public partial class Form1 : Form {

        

        public Form1() {
            InitializeComponent();
        }
        //string[] diary = new string[] { "11111" };
        
        private void textBox1_TextChanged(object sender, EventArgs e) {
            
        }
        
        private void 木を見るToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("日記を閉じますか？", "終了", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                Close();
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            //はじめに「ファイル名」で表示される文字列を指定する
            sfd.FileName = "日木.csv";
            ////はじめに表示されるフォルダを指定する
            //sfd.InitialDirectory = @"C:\Users\infosys\source\repos\GW2021_25\Diary.csv";

            //sfd.Filter = "HTMLファイル(*.html;*.htm)|*.html;*.htm|すべてのファイル(*.*)|*.*";
            sfd.ShowDialog();
            
            StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.ASCII);
            sw.Write(TextDiary.Text);
            sw.Close();


        }

        private void 日木一覧ToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = @"C:\Users\infosys\source\repos\GW2021_25\Diary.csv";

            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK) {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                Console.WriteLine(ofd.FileName);
            }
        }


        private void Form1_Load(object sender, EventArgs e) {
            this.MaximizeBox = false;

            //ユーザ側は入力不可
            countchara.ReadOnly = true;
        }

        private void countchara_TextChanged(object sender, EventArgs e) {
            //int tlength = this.TextDiary.TextLength;
            int tlength = this.TextDiary.Text.Length;
            //countchara.Show(tlength.ToString);

        }

        
    }
}
