namespace MDIApplication
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
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.menuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
         this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuItemArrange = new System.Windows.Forms.ToolStripMenuItem();
         this.menuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
         this.menuItemHorizontal = new System.Windows.Forms.ToolStripMenuItem();
         this.menuItemVertical = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemWindow});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.MdiWindowListItem = this.menuItemWindow;
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(677, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // menuItemWindow
         // 
         this.menuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.menuItemArrange});
         this.menuItemWindow.Name = "menuItemWindow";
         this.menuItemWindow.Size = new System.Drawing.Size(63, 20);
         this.menuItemWindow.Text = "&Window";
         // 
         // newWindowToolStripMenuItem
         // 
         this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
         this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.newWindowToolStripMenuItem.Text = "&New Window";
         this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
         // 
         // menuItemArrange
         // 
         this.menuItemArrange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCascade,
            this.menuItemHorizontal,
            this.menuItemVertical});
         this.menuItemArrange.Name = "menuItemArrange";
         this.menuItemArrange.Size = new System.Drawing.Size(180, 22);
         this.menuItemArrange.Text = "&Arrange";
         // 
         // menuItemCascade
         // 
         this.menuItemCascade.Name = "menuItemCascade";
         this.menuItemCascade.Size = new System.Drawing.Size(180, 22);
         this.menuItemCascade.Text = "&Cascade";
         this.menuItemCascade.Click += new System.EventHandler(this.menuItemCascade_Click);
         // 
         // menuItemHorizontal
         // 
         this.menuItemHorizontal.Name = "menuItemHorizontal";
         this.menuItemHorizontal.Size = new System.Drawing.Size(180, 22);
         this.menuItemHorizontal.Text = "&Horizontal";
         this.menuItemHorizontal.Click += new System.EventHandler(this.menuItemHorizontal_Click);
         // 
         // menuItemVertical
         // 
         this.menuItemVertical.Name = "menuItemVertical";
         this.menuItemVertical.Size = new System.Drawing.Size(180, 22);
         this.menuItemVertical.Text = "&Vertical";
         this.menuItemVertical.Click += new System.EventHandler(this.menuItemVertical_Click);
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(677, 340);
         this.Controls.Add(this.menuStrip1);
         this.IsMdiContainer = true;
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "FrmMain";
         this.Text = "Session 5 - MDI Application";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem menuItemWindow;
      private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem menuItemArrange;
      private System.Windows.Forms.ToolStripMenuItem menuItemCascade;
      private System.Windows.Forms.ToolStripMenuItem menuItemHorizontal;
      private System.Windows.Forms.ToolStripMenuItem menuItemVertical;
   }
}

