using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;


namespace AutoClick2
{

    

    public partial class Form1 : Form
    {
        [DllImport("USER32.DLL")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        int pointX=0, pointY=0, currentPointX, currentPointY; //マウスカーソル位置の設定先
        Color buttonColor;

        public Form1()
        {
            InitializeComponent();

            buttonColor = btnLockAndClick.BackColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentPointX = System.Windows.Forms.Cursor.Position.X;
            currentPointY = System.Windows.Forms.Cursor.Position.Y;

            setPoint(pointX, pointY);
            doClick();

            setPoint(currentPointX, currentPointY);

        }

        void doClick()
        {
            //[System.Runtime.InteropServices.DllImport("USER32.DLL")]
            int MOUSEEVENTF_LEFTDOWN = 0x2;
            int MOUSEEVENTF_LEFTUP = 0x4;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);   
        }

        // 100px以上動かされていたらtrue
        /*
        bool checkPointState(){
            int currentX = System.Windows.Forms.Cursor.Position.X;
            int currentY = System.Windows.Forms.Cursor.Position.Y;

            if (pointX - 100 > currentX || pointX + 100 < currentX || pointY - 100 > currentY || pointY + 100 < currentY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }  */

        //指定座標へカーソルを持っていく
        /*
        void setPoint(){
            StreamReader sr = new StreamReader("settings.ini", Encoding.GetEncoding("Shift_JIS"));

            string text = sr.ReadToEnd();

            sr.Close();

            string[] stArrayData = text.Split(',');

            pointX = int.Parse(stArrayData[0]);
            pointY = int.Parse(stArrayData[1]);

            System.Windows.Forms.Cursor.Position = new System.Drawing.Point(pointX, pointY);
        } */

        void setPoint(int newX, int newY)
        {
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point(newX, newY);
        }

        private void btnLockAndClick_Click(object sender, EventArgs e)
        {
            if (btnLockAndClick.BackColor != Color.Yellow)
            {
                pointX = System.Windows.Forms.Cursor.Position.X;
                pointY = System.Windows.Forms.Cursor.Position.Y;

                txtPointX.Text = pointX + "";
                txtPointY.Text = pointY + "";

                timerAutoClick.Start();
                btnLockAndClick.BackColor = Color.Yellow;
                btnLockAndClick.Text = "クリック停止";
                btnStartAtEditedPoint.Enabled = false;
            }
            else
            {
                timerAutoClick.Stop();
                btnLockAndClick.BackColor = buttonColor;
                btnLockAndClick.Text = "自動クリック開始";
                btnStartAtEditedPoint.Enabled = true;
            }
            
        }

        private void btnStartAtEditedPoint_Click(object sender, EventArgs e)
        {
            if (btnStartAtEditedPoint.BackColor != Color.Yellow)
            {

                try
                {
                    // カーソルを置くべきポイントを取得する
                    pointX = int.Parse(txtPointX.Text);
                    pointY = int.Parse(txtPointY.Text);
                }
                catch (Exception ex)
                {
                    return;
                }

                timerAutoClick.Start();
                btnStartAtEditedPoint.Text = "クリック停止";
                btnStartAtEditedPoint.BackColor = Color.Yellow;
                btnLockAndClick.Enabled = false;
            }
            else
            {
                timerAutoClick.Stop();
                btnStartAtEditedPoint.Text = "上記座標を自動クリック開始";
                btnStartAtEditedPoint.BackColor = buttonColor;
                btnLockAndClick.Enabled = true;
            }
        }

        private void timerGetPoint_Tick(object sender, EventArgs e)
        {
            currentPointX = System.Windows.Forms.Cursor.Position.X;
            currentPointY = System.Windows.Forms.Cursor.Position.Y;
            //txtPointX.Text = pointX + "";
            //txtPointY.Text = pointY + "";
            toolStripPoint.Text = "現在のカーソル位置   X: " + currentPointX + "    Y: " + currentPointY;
        }


    }
}
