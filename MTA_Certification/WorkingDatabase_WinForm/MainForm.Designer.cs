namespace WorkingDatabase_WinForm
{
   partial class MainForm
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
         this.txtSqlStatament = new System.Windows.Forms.TextBox();
         this.dgwResult = new System.Windows.Forms.DataGridView();
         this.btnExecute = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
         this.SuspendLayout();
         // 
         // txtSqlStatament
         // 
         this.txtSqlStatament.Location = new System.Drawing.Point(2, 2);
         this.txtSqlStatament.Multiline = true;
         this.txtSqlStatament.Name = "txtSqlStatament";
         this.txtSqlStatament.Size = new System.Drawing.Size(542, 101);
         this.txtSqlStatament.TabIndex = 0;
         // 
         // dgwResult
         // 
         this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgwResult.Location = new System.Drawing.Point(2, 138);
         this.dgwResult.Name = "dgwResult";
         this.dgwResult.Size = new System.Drawing.Size(542, 211);
         this.dgwResult.TabIndex = 1;
         // 
         // btnExecute
         // 
         this.btnExecute.Location = new System.Drawing.Point(2, 109);
         this.btnExecute.Name = "btnExecute";
         this.btnExecute.Size = new System.Drawing.Size(542, 23);
         this.btnExecute.TabIndex = 2;
         this.btnExecute.Text = "Execute SQL";
         this.btnExecute.UseVisualStyleBackColor = true;
         this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(546, 361);
         this.Controls.Add(this.btnExecute);
         this.Controls.Add(this.dgwResult);
         this.Controls.Add(this.txtSqlStatament);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Working Database";
         ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtSqlStatament;
      private System.Windows.Forms.DataGridView dgwResult;
      private System.Windows.Forms.Button btnExecute;
   }
}

