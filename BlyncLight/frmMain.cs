using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Blynclight;

namespace BlyncN
{
  public partial class frmMain : Form
  {
    private ColorController _con;

    public frmMain()
    {
      InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      _con = new ColorController();
      int num = _con.DeviceCount;
      if (num <= 0)
      {
        MessageBox.Show("No Blync devices detected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
      }
      else
      {
        _con.Off();
        lblStatus.Text += " " + num.ToString();
      }

      timerColor.Interval = 1000;
      tbInterval.Value = timerColor.Interval;
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      _con.Off();
      //MessageBox.Show("You will have to use the Blync application to re-sync this with Lync");
    }

    private void timerColor_Tick(object sender, EventArgs e)
    {
      _con.SetColor();
    }

    private void btnChristmas_Click(object sender, EventArgs e)
    {
      _con.Clear();
      _con.Add(LightColor.Red);
      _con.Add(LightColor.Green);
      timerColor.Enabled = true;
    }
    private void btnHanukkah_Click(object sender, EventArgs e)
    {
      _con.Clear();
      _con.Add(LightColor.Blue);
      _con.Add(LightColor.White);
      timerColor.Enabled = true;
    }

    private void btnBreak_Click(object sender, EventArgs e)
    {
      _con.Clear();
      timerColor.Enabled = true;
    }

    private void btnAllColors_Click(object sender, EventArgs e)
    {
      _con.Clear();
      _con.Add(LightColor.Cyan);
      _con.Add(LightColor.White);
      _con.Add(LightColor.Blue);
      _con.Add(LightColor.Yellow);
      _con.Add(LightColor.Green);
      _con.Add(LightColor.Red);
      _con.Add(LightColor.Purple);
      timerColor.Enabled = true;
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
      _con.Clear();
      _con.Add(LightColor.Cyan);
      _con.Add(LightColor.Off);
      _con.Add(LightColor.White);
      _con.Add(LightColor.Off);
      _con.Add(LightColor.Blue);
      _con.Add(LightColor.Off);
      _con.Add(LightColor.Yellow);
      _con.Add(LightColor.Off);
      _con.Add(LightColor.Green);
      _con.Add(LightColor.Off);
      _con.Add(LightColor.Red);
      _con.Add(LightColor.Off);
      _con.Add(LightColor.Purple);
      _con.Add(LightColor.Off);
      timerColor.Enabled = true;
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      timerColor.Enabled = false;
    }

    private void tbInterval_Scroll(object sender, EventArgs e)
    {
      timerColor.Interval = tbInterval.Value;
    }

    private void btnCustom_Click(object sender, EventArgs e)
    {
      frmCustom custom = new frmCustom(_con);
      if (custom.ShowDialog() == DialogResult.OK)
      {
        _con.Recipe = custom.Recipe;
        timerColor.Enabled = true;
      }
      custom.Dispose();
    }

  }
}
