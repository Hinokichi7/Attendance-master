using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_APP
{
    class InputFiles
    {
        public List<string> ReadLines { get; set; } 

        private void ReadCsv(string fileName)
        {
            using(StreamReader reader = new StreamReader(fileName))
            {
                //Console.WriteLine(reader.ReadToEnd());
                while(reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    //Console.WriteLine(line);
                    this.ReadLines = new List<string>();
                    this.ReadLines.Add(line);
                }

            }
        }

        public void OpenFileDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\user\Desktop\test";
            ofd.Filter = "TXTファイル|*.txt|CSVファイル|*.csv|すべてのファイル|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "読み込むファイルを選択してください";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.ReadCsv(ofd.FileName);
            }
        }
    }
}
