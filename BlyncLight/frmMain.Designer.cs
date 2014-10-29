namespace BlyncN
{
  partial class frmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.lblStatus = new System.Windows.Forms.Label();
      this.timerColor = new System.Windows.Forms.Timer(this.components);
      this.btnChristmas = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.btnHanukkah = new System.Windows.Forms.Button();
      this.btnBreak = new System.Windows.Forms.Button();
      this.btnAllColors = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.tbInterval = new System.Windows.Forms.TrackBar();
      this.btnCustom = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).BeginInit();
      this.SuspendLayout();
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(12, 9);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(128, 13);
      this.lblStatus.TabIndex = 0;
      this.lblStatus.Text = "Number of Blync devices:";
      // 
      // timerColor
      // 
      this.timerColor.Interval = 10;
      this.timerColor.Tick += new System.EventHandler(this.timerColor_Tick);
      // 
      // btnChristmas
      // 
      this.btnChristmas.Location = new System.Drawing.Point(15, 38);
      this.btnChristmas.Name = "btnChristmas";
      this.btnChristmas.Size = new System.Drawing.Size(257, 23);
      this.btnChristmas.TabIndex = 1;
      this.btnChristmas.Text = "Merry Christmas";
      this.btnChristmas.UseVisualStyleBackColor = true;
      this.btnChristmas.Click += new System.EventHandler(this.btnChristmas_Click);
      // 
      // btnStop
      // 
      this.btnStop.Location = new System.Drawing.Point(12, 247);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(257, 23);
      this.btnStop.TabIndex = 2;
      this.btnStop.Text = "Make It STOP!";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // btnHanukkah
      // 
      this.btnHanukkah.Location = new System.Drawing.Point(15, 67);
      this.btnHanukkah.Name = "btnHanukkah";
      this.btnHanukkah.Size = new System.Drawing.Size(257, 23);
      this.btnHanukkah.TabIndex = 3;
      this.btnHanukkah.Text = "Happy Hanukkah";
      this.btnHanukkah.UseVisualStyleBackColor = true;
      this.btnHanukkah.Click += new System.EventHandler(this.btnHanukkah_Click);
      // 
      // btnBreak
      // 
      this.btnBreak.Location = new System.Drawing.Point(12, 218);
      this.btnBreak.Name = "btnBreak";
      this.btnBreak.Size = new System.Drawing.Size(257, 23);
      this.btnBreak.TabIndex = 4;
      this.btnBreak.Text = "Break Test";
      this.btnBreak.UseVisualStyleBackColor = true;
      this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
      // 
      // btnAllColors
      // 
      this.btnAllColors.Location = new System.Drawing.Point(15, 96);
      this.btnAllColors.Name = "btnAllColors";
      this.btnAllColors.Size = new System.Drawing.Size(257, 23);
      this.btnAllColors.TabIndex = 5;
      this.btnAllColors.Text = "All Colors";
      this.btnAllColors.UseVisualStyleBackColor = true;
      this.btnAllColors.Click += new System.EventHandler(this.btnAllColors_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(15, 125);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(257, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "All Colors (Off)";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // tbInterval
      // 
      this.tbInterval.AutoSize = false;
      this.tbInterval.LargeChange = 100;
      this.tbInterval.Location = new System.Drawing.Point(15, 189);
      this.tbInterval.Maximum = 2000;
      this.tbInterval.Minimum = 10;
      this.tbInterval.Name = "tbInterval";
      this.tbInterval.Size = new System.Drawing.Size(254, 23);
      this.tbInterval.TabIndex = 7;
      this.tbInterval.TickFrequency = 10;
      this.tbInterval.TickStyle = System.Windows.Forms.TickStyle.None;
      this.tbInterval.Value = 1000;
      this.tbInterval.Scroll += new System.EventHandler(this.tbInterval_Scroll);
      // 
      // btnCustom
      // 
      this.btnCustom.Location = new System.Drawing.Point(15, 154);
      this.btnCustom.Name = "btnCustom";
      this.btnCustom.Size = new System.Drawing.Size(257, 23);
      this.btnCustom.TabIndex = 8;
      this.btnCustom.Text = "Custom";
      this.btnCustom.UseVisualStyleBackColor = true;
      this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 282);
      this.Controls.Add(this.btnCustom);
      this.Controls.Add(this.tbInterval);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnAllColors);
      this.Controls.Add(this.btnBreak);
      this.Controls.Add(this.btnHanukkah);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.btnChristmas);
      this.Controls.Add(this.lblStatus);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmMain";
      this.Text = "Blync";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
      this.Load += new System.EventHandler(this.frmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Timer timerColor;
    private System.Windows.Forms.Button btnChristmas;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Button btnHanukkah;
    private System.Windows.Forms.Button btnBreak;
    private System.Windows.Forms.Button btnAllColors;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TrackBar tbInterval;
    private System.Windows.Forms.Button btnCustom;
  }
}

