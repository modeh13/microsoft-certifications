namespace WorkingDatabase_WinForm
{
   partial class FlatFilesForm
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
         this.btnTextFiles = new System.Windows.Forms.Button();
         this.lblResult = new System.Windows.Forms.Label();
         this.lvwContent = new System.Windows.Forms.ListView();
         this.btnReadFile = new System.Windows.Forms.Button();
         this.colLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.SuspendLayout();
         // 
         // btnTextFiles
         // 
         this.btnTextFiles.Location = new System.Drawing.Point(12, 12);
         this.btnTextFiles.Name = "btnTextFiles";
         this.btnTextFiles.Size = new System.Drawing.Size(170, 23);
         this.btnTextFiles.TabIndex = 0;
         this.btnTextFiles.Text = "Text Files";
         this.btnTextFiles.UseVisualStyleBackColor = true;
         this.btnTextFiles.Click += new System.EventHandler(this.btnTextFiles_Click);
         // 
         // lblResult
         // 
         this.lblResult.AutoSize = true;
         this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblResult.Location = new System.Drawing.Point(9, 219);
         this.lblResult.Name = "lblResult";
         this.lblResult.Size = new System.Drawing.Size(41, 13);
         this.lblResult.TabIndex = 1;
         this.lblResult.Text = "label1";
         // 
         // lvwContent
         // 
         this.lvwContent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLine});
         this.lvwContent.Location = new System.Drawing.Point(12, 41);
         this.lvwContent.Name = "lvwContent";
         this.lvwContent.Size = new System.Drawing.Size(347, 175);
         this.lvwContent.TabIndex = 2;
         this.lvwContent.UseCompatibleStateImageBehavior = false;
         this.lvwContent.View = System.Windows.Forms.View.Details;
         // 
         // btnReadFile
         // 
         this.btnReadFile.Location = new System.Drawing.Point(188, 12);
         this.btnReadFile.Name = "btnReadFile";
         this.btnReadFile.Size = new System.Drawing.Size(170, 23);
         this.btnReadFile.TabIndex = 3;
         this.btnReadFile.Text = "Read File";
         this.btnReadFile.UseVisualStyleBackColor = true;
         this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
         // 
         // colLine
         // 
         this.colLine.Text = "Line";
         this.colLine.Width = 300;
         // 
         // FlatFilesForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(371, 241);
         this.Controls.Add(this.btnReadFile);
         this.Controls.Add(this.lvwContent);
         this.Controls.Add(this.lblResult);
         this.Controls.Add(this.btnTextFiles);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FlatFilesForm";
         this.Text = "FlatFilesForm";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnTextFiles;
      private System.Windows.Forms.Label lblResult;
      private System.Windows.Forms.ListView lvwContent;
      private System.Windows.Forms.Button btnReadFile;
      private System.Windows.Forms.ColumnHeader colLine;
   }
}