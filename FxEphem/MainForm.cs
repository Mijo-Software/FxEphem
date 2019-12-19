using System;
using System.Windows.Forms;

namespace FxEphem
{
  public partial class MainForm : Form
  {
    public MainForm() => InitializeComponent();

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("JD: " + FxEphemClass.CalcJulianDate().ToString());
      MessageBox.Show("MJD: " + FxEphemClass.CalcModifiedJulianDate().ToString());
      MessageBox.Show("Centuries since 2000: " + FxEphemClass.CalcCenturiesSince2000().ToString());
    }
  }
}
