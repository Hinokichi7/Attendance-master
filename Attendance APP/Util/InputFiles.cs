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
        public List<string> ReadLines;

        public void ReadFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\user\Desktop\test";
            ofd.Filter = "TXTファイル|*.txt|CSVファイル|*.csv|すべてのファイル|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "読み込むファイルを選択してください";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.ReadCsv(ofd.FileName);
            }
        }

        private void ReadCsv(string fileName)
        {
            using(StreamReader reader = new StreamReader(fileName))
            {
                this.ReadLines = new List<string>();
                while(reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    this.ReadLines.Add(line);
                }
            }
        }

        public List<string> GetReadLines()
        {
            if (this.ReadLines == null)
            {
                Console.WriteLine("error");
                return null;
            }
            else
            {
                return this.ReadLines;
            }
        }

    }
}
