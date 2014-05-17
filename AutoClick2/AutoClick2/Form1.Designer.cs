namespace AutoClick2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerAutoClick = new System.Windows.Forms.Timer(this.components);
            this.btnLockAndClick = new System.Windows.Forms.Button();
            this.txtPointX = new System.Windows.Forms.TextBox();
            this.txtPointY = new System.Windows.Forms.TextBox();
            this.btnStartAtEditedPoint = new System.Windows.Forms.Button();
            this.timerGetPoint = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripPoint = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAutoClick
            // 
            this.timerAutoClick.Interval = 5000;
            this.timerAutoClick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLockAndClick
            // 
            this.btnLockAndClick.BackColor = System.Drawing.SystemColors.Control;
            this.btnLockAndClick.Location = new System.Drawing.Point(28, 19);
            this.btnLockAndClick.Name = "btnLockAndClick";
            this.btnLockAndClick.Size = new System.Drawing.Size(186, 52);
            this.btnLockAndClick.TabIndex = 1;
            this.btnLockAndClick.Text = "自動クリック開始";
            this.btnLockAndClick.UseVisualStyleBackColor = false;
            this.btnLockAndClick.Click += new System.EventHandler(this.btnLockAndClick_Click);
            // 
            // txtPointX
            // 
            this.txtPointX.Location = new System.Drawing.Point(41, 22);
            this.txtPointX.Name = "txtPointX";
            this.txtPointX.Size = new System.Drawing.Size(67, 19);
            this.txtPointX.TabIndex = 3;
            this.txtPointX.Text = "0";
            // 
            // txtPointY
            // 
            this.txtPointY.Location = new System.Drawing.Point(143, 22);
            this.txtPointY.Name = "txtPointY";
            this.txtPointY.Size = new System.Drawing.Size(68, 19);
            this.txtPointY.TabIndex = 6;
            this.txtPointY.Text = "0";
            // 
            // btnStartAtEditedPoint
            // 
            this.btnStartAtEditedPoint.Location = new System.Drawing.Point(28, 47);
            this.btnStartAtEditedPoint.Name = "btnStartAtEditedPoint";
            this.btnStartAtEditedPoint.Size = new System.Drawing.Size(186, 52);
            this.btnStartAtEditedPoint.TabIndex = 7;
            this.btnStartAtEditedPoint.Text = "上記座標を自動クリック開始";
            this.btnStartAtEditedPoint.UseVisualStyleBackColor = true;
            this.btnStartAtEditedPoint.Click += new System.EventHandler(this.btnStartAtEditedPoint_Click);
            // 
            // timerGetPoint
            // 
            this.timerGetPoint.Enabled = true;
            this.timerGetPoint.Interval = 1000;
            this.timerGetPoint.Tick += new System.EventHandler(this.timerGetPoint_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPoint});
            this.statusStrip1.Location = new System.Drawing.Point(0, 232);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(261, 23);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripPoint
            // 
            this.toolStripPoint.Name = "toolStripPoint";
            this.toolStripPoint.Size = new System.Drawing.Size(45, 18);
            this.toolStripPoint.Text = "X:   Y:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLockAndClick);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "現在のカーソル位置で自動クリック";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnStartAtEditedPoint);
            this.groupBox2.Controls.Add(this.txtPointX);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPointY);
            this.groupBox2.Location = new System.Drawing.Point(6, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "カーソル位置を指定して自動クリック";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "X:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 255);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoClick";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerAutoClick;
        private System.Windows.Forms.Button btnLockAndClick;
        private System.Windows.Forms.TextBox txtPointX;
        private System.Windows.Forms.TextBox txtPointY;
        private System.Windows.Forms.Button btnStartAtEditedPoint;
        private System.Windows.Forms.Timer timerGetPoint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

