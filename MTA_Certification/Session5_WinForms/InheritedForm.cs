using System;

namespace Session5_WinForms
{
   //Visual INHERIT
   //When we create a new FORM and this one inherits from other Windows.Forms
   public partial class InheritedForm : FrmMain
   {
      public InheritedForm()
      {
         InitializeComponent();
      }

      private void InheritedForm_Load(object sender, EventArgs e)
      {
         lblSelectedDate.Text = dpkDate.Value.ToLongDateString();
      }
   }
}