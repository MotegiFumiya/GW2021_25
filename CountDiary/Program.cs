using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace CountDiary {
    static class Program {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



            //ファイルパス
            //var filePath = @"C:\Users\infosys\source\repos\GW2021_25\Diary.csv";

            ////csvに入れるデータ
            //var Diary = new List<List<string>> {
            //    new List<string>{"diary"},
            //};

            //ファイルの書き込み
            //File.WriteAllLines(filePath, Diary.Select(val => string.Join(",", val)));

            //ファイルの読み込み
            //var csvList = File.ReadAllLines(filePath).Where(line =>
            //  !string.IsNullOrWhiteSpace(line)).Skip(1).Select(line => line.Split(',')).ToList();

            //読み込んだファイルのデータ表示
            //csvList.ForEach(line => {
            //    Console.WriteLine(string.Join("", line));
            //});
        }
    }
}
