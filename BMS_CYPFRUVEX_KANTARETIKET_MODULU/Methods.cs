using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MAMULSABITKIYMET {

    class Methods {
        private SqlDatabase sqlBMSDB;
        public void WRITELOG(string hata, Exception E) {
            try {
                string directory = AppDomain.CurrentDomain.BaseDirectory + "logs\\";
                Directory.CreateDirectory(directory);
                string path = directory + DateTime.Now.ToString("yyyy.MM.dd") + ".txt";
                if (!File.Exists(path))
                    File.Create(path).Close();
                else
                    File.AppendAllText(path, Environment.NewLine + Environment.NewLine +
                        Environment.NewLine + Environment.NewLine + Environment.NewLine);
                File.AppendAllText(path, DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss") + " : " + hata +
                    Environment.NewLine + (E != null ? " ----- HATA : ----- " + E.ToString() : ""));
            } catch { }
        }

    }
}
