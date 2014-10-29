namespace BlyncN
{
  partial class frmCustom
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
      this.lstColors = new System.Windows.Forms.ListBox();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnBlue = new System.Windows.Forms.Button();
      this.btnGreen = new System.Windows.Forms.Button();
      this.btnRed = new System.Windows.Forms.Button();
      this.btnYellow = new System.Windows.Forms.Button();
      this.btnCyan = new System.Windows.Forms.Button();
      this.btnPurple = new System.Windows.Forms.Button();
      this.btnOff = new System.Windows.Forms.Button();
      this.btnWhite = new System.Windows.Forms.Button();
      this.btnUp = new System.Windows.Forms.Button();
      this.btnDown = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lstColors
      // 
      this.lstColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lstColors.FormattingEnabled = true;
      this.lstColors.Location = new System.Drawing.Point(12, 12);
      this.lstColors.Name = "lstColors";
      this.lstColors.Size = new System.Drawing.Size(115, 199);
      this.lstColors.TabIndex = 0;
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnClear.Location = new System.Drawing.Point(12, 238);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 1;
      this.btnClear.Text = "Clear &All";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(214, 238);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(133, 238);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 3;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      // 
      // btnBlue
      // 
      this.btnBlue.Location = new System.Drawing.Point(133, 12);
      this.btnBlue.Name = "btnBlue";
      this.btnBlue.Size = new System.Drawing.Size(75, 23);
      this.btnBlue.TabIndex = 4;
      this.btnBlue.Text = "&Blue";
      this.btnBlue.UseVisualStyleBackColor = true;
      this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
      // 
      // btnGreen
      // 
      this.btnGreen.Location = new System.Drawing.Point(133, 41);
      this.btnGreen.Name = "btnGreen";
      this.btnGreen.Size = new System.Drawing.Size(75, 23);
      this.btnGreen.TabIndex = 5;
      this.btnGreen.Text = "&Green";
      this.btnGreen.UseVisualStyleBackColor = true;
      this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
      // 
      // btnRed
      // 
      this.btnRed.Location = new System.Drawing.Point(133, 70);
      this.btnRed.Name = "btnRed";
      this.btnRed.Size = new System.Drawing.Size(75, 23);
      this.btnRed.TabIndex = 6;
      this.btnRed.Text = "&Red";
      this.btnRed.UseVisualStyleBackColor = true;
      this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
      // 
      // btnYellow
      // 
      this.btnYellow.Location = new System.Drawing.Point(133, 99);
      this.btnYellow.Name = "btnYellow";
      this.btnYellow.Size = new System.Drawing.Size(75, 23);
      this.btnYellow.TabIndex = 7;
      this.btnYellow.Text = "&Yellow";
      this.btnYellow.UseVisualStyleBackColor = true;
      this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
      // 
      // btnCyan
      // 
      this.btnCyan.Location = new System.Drawing.Point(214, 12);
      this.btnCyan.Name = "btnCyan";
      this.btnCyan.Size = new System.Drawing.Size(75, 23);
      this.btnCyan.TabIndex = 8;
      this.btnCyan.Text = "&Cyan";
      this.btnCyan.UseVisualStyleBackColor = true;
      this.btnCyan.Click += new System.EventHandler(this.btnCyan_Click);
      // 
      // btnPurple
      // 
      this.btnPurple.Location = new System.Drawing.Point(214, 41);
      this.btnPurple.Name = "btnPurple";
      this.btnPurple.Size = new System.Drawing.Size(75, 23);
      this.btnPurple.TabIndex = 9;
      this.btnPurple.Text = "&Purple";
      this.btnPurple.UseVisualStyleBackColor = true;
      this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
      // 
      // btnOff
      // 
      this.btnOff.Location = new System.Drawing.Point(214, 99);
      this.btnOff.Name = "btnOff";
      this.btnOff.Size = new System.Drawing.Size(75, 23);
      this.btnOff.TabIndex = 10;
      this.btnOff.Text = "&OFF";
      this.btnOff.UseVisualStyleBackColor = true;
      this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
      // 
      // btnWhite
      // 
      this.btnWhite.Location = new System.Drawing.Point(214, 70);
      this.btnWhite.Name = "btnWhite";
      this.btnWhite.Size = new System.Drawing.Size(75, 23);
      this.btnWhite.TabIndex = 11;
      this.btnWhite.Text = "&White";
      this.btnWhite.UseVisualStyleBackColor = true;
      this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
      // 
      // btnUp
      // 
      this.btnUp.Location = new System.Drawing.Point(133, 159);
      this.btnUp.Name = "btnUp";
      this.btnUp.Size = new System.Drawing.Size(75, 23);
      this.btnUp.TabIndex = 12;
      this.btnUp.Text = "&Up";
      this.btnUp.UseVisualStyleBackColor = true;
      this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
      // 
      // btnDown
      // 
      this.btnDown.Location = new System.Drawing.Point(133, 188);
      this.btnDown.Name = "btnDown";
      this.btnDown.Size = new System.Drawing.Size(75, 23);
      this.btnDown.TabIndex = 13;
      this.btnDown.Text = "&Down";
      this.btnDown.UseVisualStyleBackColor = true;
      this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.Location = new System.Drawing.Point(214, 188);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(75, 23);
      this.btnRemove.TabIndex = 14;
      this.btnRemove.Text = "R&emove";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // frmCustom
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(301, 273);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.btnDown);
      this.Controls.Add(this.btnUp);
      this.Controls.Add(this.btnWhite);
      this.Controls.Add(this.btnOff);
      this.Controls.Add(this.btnPurple);
      this.Controls.Add(this.btnCyan);
      this.Controls.Add(this.btnYellow);
      this.Controls.Add(this.btnRed);
      this.Controls.Add(this.btnGreen);
      this.Controls.Add(this.btnBlue);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.lstColors);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmCustom";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Custom Builder";
      this.Load += new System.EventHandler(this.frmCustom_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lstColors;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnBlue;
    private System.Windows.Forms.Button btnGreen;
    private System.Windows.Forms.Button btnRed;
    private System.Windows.Forms.Button btnYellow;
    private System.Windows.Forms.Button btnCyan;
    private System.Windows.Forms.Button btnPurple;
    private System.Windows.Forms.Button btnOff;
    private System.Windows.Forms.Button btnWhite;
    private System.Windows.Forms.Button btnUp;
    private System.Windows.Forms.Button btnDown;
    private System.Windows.Forms.Button btnRemove;
  }
}