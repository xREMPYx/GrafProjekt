using GrafProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Service
{
    public class ServiceFile
    {
        private string fileName = "sample_BRK-A.csv";
        public string GetFilePath()
        {
            string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;

            string filePath = string.Empty;
            string[] parts = path.Split('\\');

            for (int i = 0; i < parts.Length - 3; i++)
            {
                filePath += parts[i] + "\\";
            };

            return Path.Combine(filePath, fileName);
        } 
        
        public IList<ModelRecord> GetAllRecords()
        {
            IList<ModelRecord> records = new List<ModelRecord>();

            using (StreamReader reader = new StreamReader(GetFilePath()))
            {
                reader.ReadLine(); //skips heading

                while (!reader.EndOfStream)
                {
                    records.Add(GetRecord(reader.ReadLine()));
                }
            };

            return records;
        }

        private ModelRecord GetRecord(string line)
        {
            string[] parts = line.Split(',');

            return new ModelRecord()
            {
                Date = DateTime.Parse(parts[0]),
                Price = Convert.ToDouble(parts[1].Replace('.', ',')),
                Volume = Convert.ToInt32(parts[6])
            };
        }

        public string ChangeSourcePath()
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "Yahoo Finance Csv File | *.csv" })
            {                
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string tmp = fileName;
                    fileName = fileDialog.FileName;

                    try
                    {
                        var r = GetAllRecords();
                        MessageBox.Show("Soubor byl ůspěšně nahrán.");                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Zvolený soubor není v pořádku.");
                        fileName = tmp;
                    }                   
                }
                return GetFilePath();
            };
        }
    }
}