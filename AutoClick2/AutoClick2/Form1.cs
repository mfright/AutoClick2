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
            doRelease();

            currentPointX = System.Windows.Forms.Cursor.Position.X;
            currentPointY = System.Windows.Forms.Cursor.Position.Y;

            setPoint(pointX, pointY);
            doClick();

            setPoint(currentPointX, currentPointY);

        }

        //クリックする
        void doClick()
        {
            //[System.Runtime.InteropServices.DllImport("USER32.DLL")]
            int MOUSEEVENTF_LEFTDOWN = 0x2;
            int MOUSEEVENTF_LEFTUP = 0x4;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);   
        }

        //リリースする
        void doRelease()
        {
            //[System.Runtime.InteropServices.DllImport("USER32.DLL")]
            int MOUSEEVENTF_LEFTUP = 0x4;
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }


        void setPoint(int newX, int newY)
        {
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point(newX, newY);
        }

        private void btnLockAndClick_Click(object sender, EventArgs e)
        {
            if (btnLockAndClick.BackColor != Color.Yellow)
            {
                // インターバルを設定する
                if (!setInterval())
                {
                    return;
                }

                //現在のカーソル位置を表示する
                pointX = System.Windows.Forms.Cursor.Position.X;
                pointY = System.Windows.Forms.Cursor.Position.Y;

                txtPointX.Text = pointX + "";
                txtPointY.Text = pointY + "";

                //タイマーをスタート
                timerAutoClick.Start();

                //ボタンの表示を変更
                btnLockAndClick.BackColor = Color.Yellow;
                btnLockAndClick.Text = "自動クリック実行中。\r\n止めるにはここをクリック";
                btnStartAtEditedPoint.Enabled = false;
            }
            else
            {
                //タイマーをストップ
                timerAutoClick.Stop();

                //ボタンの表示を変更
                btnLockAndClick.BackColor = buttonColor;
                btnLockAndClick.Text = "自動クリック開始";
                btnStartAtEditedPoint.Enabled = true;
            }
            
        }

        private void btnStartAtEditedPoint_Click(object sender, EventArgs e)
        {
            if (btnStartAtEditedPoint.BackColor != Color.Yellow)
            {
                // インターバルを設定する
                if (!setInterval())
                {
                    return;
                }

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
                btnStartAtEditedPoint.Text = "自動クリック実行中。\r\n止めるにはここをクリック";
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

        Boolean setInterval()
        {
            int intervalSecond = 5;
            try
            {
                intervalSecond = int.Parse(txtInterval.Text)*1000;

                timerAutoClick.Interval = intervalSecond;

            }
            catch (Exception ex)
            {
                MessageBox.Show("インターバルの設定が不正です: " + txtInterval.Text, "エラー");

                return false;
            }

            return true;
        }
    }
}
