namespace WorkingDatabase_WinForm
{
   partial class GetTotalSalesForm
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
         this.gbxParameters = new System.Windows.Forms.GroupBox();
         this.lblCustomerId = new System.Windows.Forms.Label();
         this.txtCustomerId = new System.Windows.Forms.TextBox();
         this.btnExecute = new System.Windows.Forms.Button();
         this.lblTotalSales = new System.Windows.Forms.Label();
         this.gbxParameters.SuspendLayout();
         this.SuspendLayout();
         // 
         // gbxParameters
         // 
         this.gbxParameters.Controls.Add(this.lblTotalSales);
         this.gbxParameters.Controls.Add(this.btnExecute);
         this.gbxParameters.Controls.Add(this.txtCustomerId);
         this.gbxParameters.Controls.Add(this.lblCustomerId);
         this.gbxParameters.Location = new System.Drawing.Point(12, 12);
         this.gbxParameters.Name = "gbxParameters";
         this.gbxParameters.Size = new System.Drawing.Size(200, 130);
         this.gbxParameters.TabIndex = 0;
         this.gbxParameters.TabStop = false;
         this.gbxParameters.Text = "Parameters";
         // 
         // lblCustomerId
         // 
         this.lblCustomerId.AutoSize = true;
         this.lblCustomerId.Location = new System.Drawing.Point(6, 29);
         this.lblCustomerId.Name = "lblCustomerId";
         this.lblCustomerId.Size = new System.Drawing.Size(66, 13);
         this.lblCustomerId.TabIndex = 1;
         this.lblCustomerId.Text = "Customer Id:";
         // 
         // txtCustomerId
         // 
         this.txtCustomerId.Location = new System.Drawing.Point(6, 45);
         this.txtCustomerId.Name = "txtCustomerId";
         this.txtCustomerId.Size = new System.Drawing.Size(188, 20);
         this.txtCustomerId.TabIndex = 1;
         // 
         // btnExecute
         // 
         this.btnExecute.Location = new System.Drawing.Point(6, 71);
         this.btnExecute.Name = "btnExecute";
         this.btnExecute.Size = new System.Drawing.Size(188, 23);
         this.btnExecute.TabIndex = 1;
         this.btnExecute.Text = "Execute";
         this.btnExecute.UseVisualStyleBackColor = true;
         this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
         // 
         // lblTotalSales
         // 
         this.lblTotalSales.AutoSize = true;
         this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalSales.Location = new System.Drawing.Point(6, 105);
         this.lblTotalSales.Name = "lblTotalSales";
         this.lblTotalSales.Size = new System.Drawing.Size(41, 13);
         this.lblTotalSales.TabIndex = 1;
         this.lblTotalSales.Text = "label2";
         // 
         // GetTotalSalesForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(224, 154);
         this.Controls.Add(this.gbxParameters);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "GetTotalSalesForm";
         this.Text = "Get Total Sales";
         this.gbxParameters.ResumeLayout(false);
         this.gbxParameters.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox gbxParameters;
      private System.Windows.Forms.Label lblTotalSales;
      private System.Windows.Forms.Button btnExecute;
      private System.Windows.Forms.TextBox txtCustomerId;
      private System.Windows.Forms.Label lblCustomerId;
   }
}