using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlyncN
{
  public partial class frmCustom : Form
  {
    private List<LightColor> _recipe;

    public frmCustom(ColorController con)
    {
      _recipe = con.Recipe;
      InitializeComponent();
    }

    public List<LightColor> Recipe
    {
      get { return _recipe; }
    }

    private void frmCustom_Load(object sender, EventArgs e)
    {
      ListController();
    }

    private void ListController()
    {
      int index = lstColors.SelectedIndex;

      lstColors.Items.Clear();
      foreach (LightColor color in _recipe)
        lstColors.Items.Add(color.ToString());

      if (lstColors.Items.Count > 0)
        lstColors.SelectedIndex = index;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      _recipe.Clear();
      ListController();
    }

    private void btnBlue_Click(object sender, EventArgs e)
    {
      _recipe.Add(LightColor.Blue);
      ListController();
    }

    private void btnCyan_Click(object sender, EventArgs e)
    {
      _recipe.Add(LightColor.Cyan);
      ListController();
    }

    private void btnGreen_Click(object sender, EventArgs e)
    {
      _recipe.Add(LightColor.Green);
      ListController();
    }

    private void btnPurple_Click(object sender, EventArgs e)
    {
      _recipe.Add(LightColor.Purple);
      ListController();
    }

    private void btnRed_Click(object sender, EventArgs e)
    {
      _recipe.Add(LightColor.Red);
      ListController();
    }

    private void btnWhite_Click(object sender, EventArgs e)
    {
      _recipe.Add(LightColor.White);
      ListController();
    }

    private void btnYellow_Click(object sender, EventArgs e)
    {
      _recipe.Add(LightColor.Yellow);
      ListController();
    }

    private void btnOff_Click(object sender, EventArgs e)
    {
      _recipe.Add(LightColor.Off);
      ListController();
    }

    private void btnUp_Click(object sender, EventArgs e)
    {
      int oldIndex = lstColors.SelectedIndex;
      int newIndex = oldIndex - 1;
      if (newIndex >= 0 && newIndex <= _recipe.Count -1)
      {
        LightColor item = _recipe[oldIndex];
        _recipe.RemoveAt(oldIndex);
        _recipe.Insert(newIndex, item);
        lstColors.SelectedIndex = newIndex;
      }
      ListController();
    }

    private void btnDown_Click(object sender, EventArgs e)
    {
      int oldIndex = lstColors.SelectedIndex;
      int newIndex = oldIndex + 1;
      if (newIndex >= 0 && newIndex <= _recipe.Count -1)
      {
        LightColor item = _recipe[oldIndex];
        _recipe.RemoveAt(oldIndex);
        _recipe.Insert(newIndex, item);
        lstColors.SelectedIndex = newIndex;
      }
      ListController();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      int index = lstColors.SelectedIndex;
      if (index >= 0 && index <= _recipe.Count - 1)
      {
        _recipe.RemoveAt(index);
        if (index - 1 >= 0) lstColors.SelectedIndex = index - 1;
        ListController();
      }
    }
  }
}
