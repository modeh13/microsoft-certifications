namespace Session5_WinForms
{
   partial class FrmMain
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
         this.dpkDate = new System.Windows.Forms.DateTimePicker();
         this.gbxMain = new System.Windows.Forms.GroupBox();
         this.lblSelectedDate = new System.Windows.Forms.Label();
         this.lblDate = new System.Windows.Forms.Label();
         this.gbxMain.SuspendLayout();
         this.SuspendLayout();
         // 
         // dpkDate
         // 
         this.dpkDate.Location = new System.Drawing.Point(17, 47);
         this.dpkDate.Name = "dpkDate";
         this.dpkDate.Size = new System.Drawing.Size(230, 20);
         this.dpkDate.TabIndex = 0;
         this.dpkDate.ValueChanged += new System.EventHandler(this.dpkDate_ValueChanged);
         // 
         // gbxMain
         // 
         this.gbxMain.Controls.Add(this.lblSelectedDate);
         this.gbxMain.Controls.Add(this.lblDate);
         this.gbxMain.Controls.Add(this.dpkDate);
         this.gbxMain.Location = new System.Drawing.Point(12, 12);
         this.gbxMain.Name = "gbxMain";
         this.gbxMain.Size = new System.Drawing.Size(270, 128);
         this.gbxMain.TabIndex = 1;
         this.gbxMain.TabStop = false;
         this.gbxMain.Text = "Main";
         // 
         // lblSelectedDate
         // 
         this.lblSelectedDate.AutoSize = true;
         this.lblSelectedDate.Location = new System.Drawing.Point(17, 102);
         this.lblSelectedDate.Name = "lblSelectedDate";
         this.lblSelectedDate.Size = new System.Drawing.Size(72, 13);
         this.lblSelectedDate.TabIndex = 2;
         this.lblSelectedDate.Text = "SelectedDate";
         // 
         // lblDate
         // 
         this.lblDate.AutoSize = true;
         this.lblDate.Location = new System.Drawing.Point(14, 31);
         this.lblDate.Name = "lblDate";
         this.lblDate.Size = new System.Drawing.Size(33, 13);
         this.lblDate.TabIndex = 1;
         this.lblDate.Text = "Date:";
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(291, 149);
         this.Controls.Add(this.gbxMain);
         this.Name = "FrmMain";
         this.Text = "Session 5 - Windows Forms";
         this.gbxMain.ResumeLayout(false);
         this.gbxMain.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      protected System.Windows.Forms.DateTimePicker dpkDate;
      private System.Windows.Forms.GroupBox gbxMain;
      private System.Windows.Forms.Label lblDate;
      protected System.Windows.Forms.Label lblSelectedDate;
   }
}