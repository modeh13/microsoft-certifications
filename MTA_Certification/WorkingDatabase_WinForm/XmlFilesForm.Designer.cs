namespace WorkingDatabase_WinForm
{
   partial class XmlFilesForm
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
         this.btnReadXml = new System.Windows.Forms.Button();
         this.lvwCustomers = new System.Windows.Forms.ListView();
         this.colLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.SuspendLayout();
         // 
         // btnReadXml
         // 
         this.btnReadXml.Location = new System.Drawing.Point(12, 12);
         this.btnReadXml.Name = "btnReadXml";
         this.btnReadXml.Size = new System.Drawing.Size(317, 23);
         this.btnReadXml.TabIndex = 0;
         this.btnReadXml.Text = "Read XML file";
         this.btnReadXml.UseVisualStyleBackColor = true;
         this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
         // 
         // lvwCustomers
         // 
         this.lvwCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLine});
         this.lvwCustomers.Location = new System.Drawing.Point(12, 41);
         this.lvwCustomers.Name = "lvwCustomers";
         this.lvwCustomers.Size = new System.Drawing.Size(317, 156);
         this.lvwCustomers.TabIndex = 1;
         this.lvwCustomers.UseCompatibleStateImageBehavior = false;
         this.lvwCustomers.View = System.Windows.Forms.View.Details;
         // 
         // colLine
         // 
         this.colLine.Text = "Line";
         this.colLine.Width = 250;
         // 
         // XmlFilesForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(341, 209);
         this.Controls.Add(this.lvwCustomers);
         this.Controls.Add(this.btnReadXml);
         this.Name = "XmlFilesForm";
         this.Text = "XmlFilesForm";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnReadXml;
      private System.Windows.Forms.ListView lvwCustomers;
      private System.Windows.Forms.ColumnHeader colLine;
   }
}