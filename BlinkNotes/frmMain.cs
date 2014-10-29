using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlinkNotes
{
  public partial class frmMain : Form
  {
    BlinkNote C;
    BlinkNote D;
    BlinkNote Dh;
    BlinkNote E;
    BlinkNote Eh;
    BlinkNote Ew;
    BlinkNote F;
    BlinkNote G;
    BlinkNote Gh;

    BlinkNote Rest;

    public frmMain()
    {
      InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      int duration = 300;
      C = new BlinkNote(ColorNote.C, 262, duration);
      D = new BlinkNote(ColorNote.D, 294, duration);
      Dh = new BlinkNote(ColorNote.D, 294, duration * 2);
      E = new BlinkNote(ColorNote.E, 330, duration);
      Eh = new BlinkNote(ColorNote.E, 330, duration * 2);
      Ew = new BlinkNote(ColorNote.E, 330, (duration * 2) * 2);
      F = new BlinkNote(ColorNote.F, 349, duration);
      G = new BlinkNote(ColorNote.G, 392, duration);
      Gh = new BlinkNote(ColorNote.G, 392, duration * 2);

      Rest = new BlinkNote(ColorNote.Rest, 0, duration / 2);
    }

    private void btnJingleBells_Click(object sender, EventArgs e)
    {
      BlinkSong song = new BlinkSong();
      song.Add(E);
      song.Add(E);
      song.Add(Eh);
      song.Add(Rest);
      
      song.Add(E);
      song.Add(E);
      song.Add(Eh);
      song.Add(Rest);

      song.Add(E);
      song.Add(G);
      song.Add(C);
      song.Add(D);
      song.Add(Ew);
      song.Add(Rest);

      song.Add(F);
      song.Add(F);
      song.Add(F);
      song.Add(F);
      song.Add(F);
      song.Add(E);
      song.Add(E);
      song.Add(E);
      
      song.Add(E);
      song.Add(D);
      song.Add(D);
      song.Add(E);
      song.Add(Dh);

      song.Add(Gh);
      //song.Add(Rest);
      
      song.Play();
    }
  }
}
