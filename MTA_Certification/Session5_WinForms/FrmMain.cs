using System;
using System.Windows.Forms;

namespace Session5_WinForms
{
   public partial class FrmMain : Form
   {
      public FrmMain()
      {
         InitializeComponent();
         lblSelectedDate.Text = string.Empty;
      }

      private void dpkDate_ValueChanged(object sender, EventArgs e)
      {
         lblSelectedDate.Text = dpkDate.Value.ToLongDateString();
      }
   }
}