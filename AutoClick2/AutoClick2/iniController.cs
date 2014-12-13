using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;

namespace AutoClick2
{
    class iniController
    {
        string confFilePath = "";
        public Boolean existSettings;   //settings.iniはあるか？

        public iniController()
        {
            confFilePath = getCurrentFolderPath() + "\\settings.ini";

            if (File.Exists(confFilePath))
            {
                existSettings = true;
            }
            else
            {
                existSettings = false;
            }

        }

        private string getCurrentFolderPath()
        {
            string path = Application.ExecutablePath;

            int point = path.LastIndexOf("\\");
            
            path = path.Substring(0, point);
            
            return path;
        }

        /// <summary>
        /// settings.iniへ情報を保存する。
        /// </summary>
        /// <param name="pointX">X座標</param>
        /// <param name="pointY">Y座標</param>
        /// <param name="second">周期の秒数</param>
        /// <param name="running">自動クリックONなら1、OFFなら0</param>
        public void saveIni(string pointX, string pointY, string second,string running)
        {
            

            //フォーマットは　X座標,Y座標,周期秒数
            string message = pointX + "," + pointY + "," + second + "," + running;

            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(confFilePath, false, System.Text.Encoding.GetEncoding("shift_jis"));

                sw.Write(message);

                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("設定を保存できませんでした");
            }
        }

        /// <summary>
        /// settings.iniを読み込む
        /// </summary>
        /// <returns></returns>
        public setting loadIni()
        {
            try
            {
                
                System.IO.StreamReader sr = new System.IO.StreamReader(confFilePath, System.Text.Encoding.GetEncoding("shift_jis"));

                string s = sr.ReadToEnd();

                sr.Close(); 
                
                // System.IO.StreamReader file = new System.IO.StreamReader(confFilePath);
                // string s = file.ReadLine();

                string[] separated = s.Split(',');

                setting mySetting = new setting();
                mySetting.pointX = separated[0]; //ひとつめはX
                mySetting.pointY = separated[1]; //ふたつめはY
                mySetting.second = separated[2]; //みっつめは周期
                
                if(separated[3].Equals("1")){    //よっつめは自動クリックON/OFF
                    mySetting.running = true;
                }else{
                    mySetting.running = false;
                }



                return mySetting;
            }
            catch (Exception ex)
            {
                // Do nothing.
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public class setting
        {
            public string pointX;
            public string pointY;
            public string second;
            public Boolean running;
        }
    }
}
