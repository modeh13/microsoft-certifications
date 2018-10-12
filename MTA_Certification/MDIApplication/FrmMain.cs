using System;
using System.Windows.Forms;

namespace MDIApplication
{
   public partial class FrmMain : Form
   {
      public FrmMain()
      {
         InitializeComponent();         
      }

      private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
      {
         ChildForm childForm = new ChildForm() {
            MdiParent = this
         };

         childForm.Show();
      }

      private void menuItemCascade_Click(object sender, EventArgs e)
      {
         LayoutMdi(MdiLayout.Cascade);
      }

      private void menuItemHorizontal_Click(object sender, EventArgs e)
      {
         LayoutMdi(MdiLayout.TileHorizontal);
      }

      private void menuItemVertical_Click(object sender, EventArgs e)
      {
         LayoutMdi(MdiLayout.TileVertical);
      }
   }
}