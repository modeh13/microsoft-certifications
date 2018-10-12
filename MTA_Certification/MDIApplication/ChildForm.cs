using System;
using System.Windows.Forms;

namespace MDIApplication
{
   public partial class ChildForm : Form
   {
      public ChildForm()
      {
         InitializeComponent();
      }

      private void ChildForm_Load(object sender, EventArgs e)
      {
         Text = DateTime.Now.ToString();
      }
   }
}