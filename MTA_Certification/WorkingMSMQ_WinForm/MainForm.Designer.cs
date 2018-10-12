namespace WorkingMSMQ_WinForm
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
         this.gbxSender = new System.Windows.Forms.GroupBox();
         this.btnSaveQueue = new System.Windows.Forms.Button();
         this.gbxSendMessage = new System.Windows.Forms.GroupBox();
         this.rbtCustom = new System.Windows.Forms.RadioButton();
         this.rbtNormal = new System.Windows.Forms.RadioButton();
         this.btnSendMessage = new System.Windows.Forms.Button();
         this.txtMessage = new System.Windows.Forms.TextBox();
         this.lblMessage = new System.Windows.Forms.Label();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnAddQueue = new System.Windows.Forms.Button();
         this.lblQueues = new System.Windows.Forms.Label();
         this.txtQueueName = new System.Windows.Forms.TextBox();
         this.gvwQueues = new System.Windows.Forms.DataGridView();
         this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.lblMsmq = new System.Windows.Forms.Label();
         this.gbxReceiver = new System.Windows.Forms.GroupBox();
         this.lblCurrentQueue = new System.Windows.Forms.Label();
         this.lblQueueName = new System.Windows.Forms.Label();
         this.lblQueueMessages = new System.Windows.Forms.Label();
         this.lblNroMessages = new System.Windows.Forms.Label();
         this.btnReadAllMsg = new System.Windows.Forms.Button();
         this.btnReadNextMsg = new System.Windows.Forms.Button();
         this.lvwMessages = new System.Windows.Forms.ListView();
         this.colMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.gbxSender.SuspendLayout();
         this.gbxSendMessage.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gvwQueues)).BeginInit();
         this.gbxReceiver.SuspendLayout();
         this.SuspendLayout();
         // 
         // gbxSender
         // 
         this.gbxSender.Controls.Add(this.btnSaveQueue);
         this.gbxSender.Controls.Add(this.gbxSendMessage);
         this.gbxSender.Controls.Add(this.btnDelete);
         this.gbxSender.Controls.Add(this.btnAddQueue);
         this.gbxSender.Controls.Add(this.lblQueues);
         this.gbxSender.Controls.Add(this.txtQueueName);
         this.gbxSender.Controls.Add(this.gvwQueues);
         this.gbxSender.Controls.Add(this.lblMsmq);
         this.gbxSender.Location = new System.Drawing.Point(12, 12);
         this.gbxSender.Name = "gbxSender";
         this.gbxSender.Size = new System.Drawing.Size(457, 426);
         this.gbxSender.TabIndex = 0;
         this.gbxSender.TabStop = false;
         this.gbxSender.Text = "Sender";
         // 
         // btnSaveQueue
         // 
         this.btnSaveQueue.Enabled = false;
         this.btnSaveQueue.Location = new System.Drawing.Point(18, 215);
         this.btnSaveQueue.Name = "btnSaveQueue";
         this.btnSaveQueue.Size = new System.Drawing.Size(422, 23);
         this.btnSaveQueue.TabIndex = 5;
         this.btnSaveQueue.Text = "Create";
         this.btnSaveQueue.UseVisualStyleBackColor = true;
         this.btnSaveQueue.Click += new System.EventHandler(this.btnSaveQueue_Click);
         // 
         // gbxSendMessage
         // 
         this.gbxSendMessage.Controls.Add(this.rbtCustom);
         this.gbxSendMessage.Controls.Add(this.rbtNormal);
         this.gbxSendMessage.Controls.Add(this.btnSendMessage);
         this.gbxSendMessage.Controls.Add(this.txtMessage);
         this.gbxSendMessage.Controls.Add(this.lblMessage);
         this.gbxSendMessage.Location = new System.Drawing.Point(18, 249);
         this.gbxSendMessage.Name = "gbxSendMessage";
         this.gbxSendMessage.Size = new System.Drawing.Size(422, 164);
         this.gbxSendMessage.TabIndex = 4;
         this.gbxSendMessage.TabStop = false;
         this.gbxSendMessage.Text = "Send message";
         // 
         // rbtCustom
         // 
         this.rbtCustom.AutoSize = true;
         this.rbtCustom.Enabled = false;
         this.rbtCustom.Location = new System.Drawing.Point(350, 19);
         this.rbtCustom.Name = "rbtCustom";
         this.rbtCustom.Size = new System.Drawing.Size(60, 17);
         this.rbtCustom.TabIndex = 5;
         this.rbtCustom.TabStop = true;
         this.rbtCustom.Text = "Custom";
         this.rbtCustom.UseVisualStyleBackColor = true;
         // 
         // rbtNormal
         // 
         this.rbtNormal.AutoSize = true;
         this.rbtNormal.Checked = true;
         this.rbtNormal.Location = new System.Drawing.Point(286, 19);
         this.rbtNormal.Name = "rbtNormal";
         this.rbtNormal.Size = new System.Drawing.Size(58, 17);
         this.rbtNormal.TabIndex = 4;
         this.rbtNormal.TabStop = true;
         this.rbtNormal.Text = "Normal";
         this.rbtNormal.UseVisualStyleBackColor = true;
         // 
         // btnSendMessage
         // 
         this.btnSendMessage.Location = new System.Drawing.Point(10, 128);
         this.btnSendMessage.Name = "btnSendMessage";
         this.btnSendMessage.Size = new System.Drawing.Size(400, 23);
         this.btnSendMessage.TabIndex = 3;
         this.btnSendMessage.Text = "Send Message";
         this.btnSendMessage.UseVisualStyleBackColor = true;
         this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
         // 
         // txtMessage
         // 
         this.txtMessage.Location = new System.Drawing.Point(10, 56);
         this.txtMessage.Multiline = true;
         this.txtMessage.Name = "txtMessage";
         this.txtMessage.Size = new System.Drawing.Size(400, 66);
         this.txtMessage.TabIndex = 1;
         // 
         // lblMessage
         // 
         this.lblMessage.AutoSize = true;
         this.lblMessage.Location = new System.Drawing.Point(7, 40);
         this.lblMessage.Name = "lblMessage";
         this.lblMessage.Size = new System.Drawing.Size(53, 13);
         this.lblMessage.TabIndex = 0;
         this.lblMessage.Text = "Message:";
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(365, 14);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(75, 23);
         this.btnDelete.TabIndex = 3;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnAddQueue
         // 
         this.btnAddQueue.Location = new System.Drawing.Point(287, 14);
         this.btnAddQueue.Name = "btnAddQueue";
         this.btnAddQueue.Size = new System.Drawing.Size(75, 23);
         this.btnAddQueue.TabIndex = 3;
         this.btnAddQueue.Text = "Add";
         this.btnAddQueue.UseVisualStyleBackColor = true;
         this.btnAddQueue.Click += new System.EventHandler(this.btnAddQueue_Click);
         // 
         // lblQueues
         // 
         this.lblQueues.AutoSize = true;
         this.lblQueues.Location = new System.Drawing.Point(15, 27);
         this.lblQueues.Name = "lblQueues";
         this.lblQueues.Size = new System.Drawing.Size(44, 13);
         this.lblQueues.TabIndex = 2;
         this.lblQueues.Text = "Queues";
         // 
         // txtQueueName
         // 
         this.txtQueueName.Location = new System.Drawing.Point(140, 190);
         this.txtQueueName.Name = "txtQueueName";
         this.txtQueueName.ReadOnly = true;
         this.txtQueueName.Size = new System.Drawing.Size(300, 20);
         this.txtQueueName.TabIndex = 1;
         // 
         // gvwQueues
         // 
         this.gvwQueues.AllowUserToAddRows = false;
         this.gvwQueues.AllowUserToDeleteRows = false;
         this.gvwQueues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.gvwQueues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName});
         this.gvwQueues.Location = new System.Drawing.Point(18, 43);
         this.gvwQueues.MultiSelect = false;
         this.gvwQueues.Name = "gvwQueues";
         this.gvwQueues.ReadOnly = true;
         this.gvwQueues.RowHeadersVisible = false;
         this.gvwQueues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.gvwQueues.Size = new System.Drawing.Size(422, 134);
         this.gvwQueues.TabIndex = 1;
         this.gvwQueues.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvwQueues_RowEnter);
         // 
         // colName
         // 
         this.colName.DataPropertyName = "Label";
         this.colName.HeaderText = "Name";
         this.colName.Name = "colName";
         this.colName.ReadOnly = true;
         this.colName.Width = 300;
         // 
         // lblMsmq
         // 
         this.lblMsmq.AutoSize = true;
         this.lblMsmq.Location = new System.Drawing.Point(15, 193);
         this.lblMsmq.Name = "lblMsmq";
         this.lblMsmq.Size = new System.Drawing.Size(119, 13);
         this.lblMsmq.TabIndex = 0;
         this.lblMsmq.Text = "Message Queue Name:";
         // 
         // gbxReceiver
         // 
         this.gbxReceiver.Controls.Add(this.lvwMessages);
         this.gbxReceiver.Controls.Add(this.btnReadNextMsg);
         this.gbxReceiver.Controls.Add(this.btnReadAllMsg);
         this.gbxReceiver.Controls.Add(this.lblNroMessages);
         this.gbxReceiver.Controls.Add(this.lblQueueMessages);
         this.gbxReceiver.Controls.Add(this.lblQueueName);
         this.gbxReceiver.Controls.Add(this.lblCurrentQueue);
         this.gbxReceiver.Location = new System.Drawing.Point(475, 12);
         this.gbxReceiver.Name = "gbxReceiver";
         this.gbxReceiver.Size = new System.Drawing.Size(401, 426);
         this.gbxReceiver.TabIndex = 1;
         this.gbxReceiver.TabStop = false;
         this.gbxReceiver.Text = "Receiver";
         // 
         // lblCurrentQueue
         // 
         this.lblCurrentQueue.AutoSize = true;
         this.lblCurrentQueue.Location = new System.Drawing.Point(20, 27);
         this.lblCurrentQueue.Name = "lblCurrentQueue";
         this.lblCurrentQueue.Size = new System.Drawing.Size(79, 13);
         this.lblCurrentQueue.TabIndex = 0;
         this.lblCurrentQueue.Text = "Current Queue:";
         // 
         // lblQueueName
         // 
         this.lblQueueName.AutoSize = true;
         this.lblQueueName.Location = new System.Drawing.Point(105, 27);
         this.lblQueueName.Name = "lblQueueName";
         this.lblQueueName.Size = new System.Drawing.Size(35, 13);
         this.lblQueueName.TabIndex = 1;
         this.lblQueueName.Text = "label1";
         // 
         // lblQueueMessages
         // 
         this.lblQueueMessages.AutoSize = true;
         this.lblQueueMessages.Location = new System.Drawing.Point(20, 48);
         this.lblQueueMessages.Name = "lblQueueMessages";
         this.lblQueueMessages.Size = new System.Drawing.Size(77, 13);
         this.lblQueueMessages.TabIndex = 2;
         this.lblQueueMessages.Text = "Nro messages:";
         // 
         // lblNroMessages
         // 
         this.lblNroMessages.AutoSize = true;
         this.lblNroMessages.Location = new System.Drawing.Point(105, 48);
         this.lblNroMessages.Name = "lblNroMessages";
         this.lblNroMessages.Size = new System.Drawing.Size(35, 13);
         this.lblNroMessages.TabIndex = 3;
         this.lblNroMessages.Text = "label1";
         // 
         // btnReadAllMsg
         // 
         this.btnReadAllMsg.Location = new System.Drawing.Point(205, 78);
         this.btnReadAllMsg.Name = "btnReadAllMsg";
         this.btnReadAllMsg.Size = new System.Drawing.Size(176, 23);
         this.btnReadAllMsg.TabIndex = 4;
         this.btnReadAllMsg.Text = "Read all messages";
         this.btnReadAllMsg.UseVisualStyleBackColor = true;
         this.btnReadAllMsg.Click += new System.EventHandler(this.btnReadAllMsg_Click);
         // 
         // btnReadNextMsg
         // 
         this.btnReadNextMsg.Location = new System.Drawing.Point(23, 78);
         this.btnReadNextMsg.Name = "btnReadNextMsg";
         this.btnReadNextMsg.Size = new System.Drawing.Size(176, 23);
         this.btnReadNextMsg.TabIndex = 5;
         this.btnReadNextMsg.Text = "Read next message";
         this.btnReadNextMsg.UseVisualStyleBackColor = true;
         this.btnReadNextMsg.Click += new System.EventHandler(this.btnReadNextMsg_Click);
         // 
         // lvwMessages
         // 
         this.lvwMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMessage});
         this.lvwMessages.Location = new System.Drawing.Point(23, 113);
         this.lvwMessages.Name = "lvwMessages";
         this.lvwMessages.Size = new System.Drawing.Size(358, 300);
         this.lvwMessages.TabIndex = 6;
         this.lvwMessages.UseCompatibleStateImageBehavior = false;
         this.lvwMessages.View = System.Windows.Forms.View.Details;
         // 
         // colMessage
         // 
         this.colMessage.Text = "Message";
         this.colMessage.Width = 300;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(888, 447);
         this.Controls.Add(this.gbxReceiver);
         this.Controls.Add(this.gbxSender);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Working MSMQ";
         this.Load += new System.EventHandler(this.MainForm_Load);
         this.gbxSender.ResumeLayout(false);
         this.gbxSender.PerformLayout();
         this.gbxSendMessage.ResumeLayout(false);
         this.gbxSendMessage.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gvwQueues)).EndInit();
         this.gbxReceiver.ResumeLayout(false);
         this.gbxReceiver.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox gbxSender;
      private System.Windows.Forms.Label lblMsmq;
      private System.Windows.Forms.TextBox txtQueueName;
      private System.Windows.Forms.DataGridView gvwQueues;
      private System.Windows.Forms.Button btnAddQueue;
      private System.Windows.Forms.Label lblQueues;
      private System.Windows.Forms.GroupBox gbxSendMessage;
      private System.Windows.Forms.Button btnSaveQueue;
      private System.Windows.Forms.Button btnSendMessage;
      private System.Windows.Forms.TextBox txtMessage;
      private System.Windows.Forms.Label lblMessage;
      private System.Windows.Forms.RadioButton rbtNormal;
      private System.Windows.Forms.RadioButton rbtCustom;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.DataGridViewTextBoxColumn colName;
      private System.Windows.Forms.GroupBox gbxReceiver;
      private System.Windows.Forms.Label lblQueueName;
      private System.Windows.Forms.Label lblCurrentQueue;
      private System.Windows.Forms.Label lblNroMessages;
      private System.Windows.Forms.Label lblQueueMessages;
      private System.Windows.Forms.Button btnReadAllMsg;
      private System.Windows.Forms.Button btnReadNextMsg;
      private System.Windows.Forms.ListView lvwMessages;
      private System.Windows.Forms.ColumnHeader colMessage;
   }
}

