using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Windows.Forms;

namespace WorkingMSMQ_WinForm
{
   public partial class MainForm : Form
   {
      const string queuesPath = @".\Private$\";
      const string machineName = "Familia";

      #region Constructors
      public MainForm()
      {
         InitializeComponent();

         gbxSendMessage.Enabled = false;         
      } 
      #endregion

      #region Methods
      private void GridViewDataBinding<T>(DataGridView dgw, List<T> list)
      {
         dgw.DataSource = null;

         if (list != null)
         {
            var bindingList = new BindingList<T>(list);
            var source = new BindingSource(bindingList, null);
            dgw.AutoGenerateColumns = false;
            dgw.DataSource = source;
         }
      }

      private List<MessageQueue> GetMessageQueues()
      {
         return MessageQueue.GetPrivateQueuesByMachine(machineName).ToList();
      }
      #endregion

      #region Events
      private void MainForm_Load(object sender, EventArgs e)
      {         
         GridViewDataBinding(gvwQueues, GetMessageQueues());
      }

      private void btnAddQueue_Click(object sender, EventArgs e)
      {
         btnSaveQueue.Enabled = true;
         txtQueueName.ReadOnly = false;
         txtQueueName.Text = string.Empty;
         gbxSendMessage.Enabled = false;
         gvwQueues.ClearSelection();
      }

      private void btnSaveQueue_Click(object sender, EventArgs e)
      {
         string queueName = txtQueueName.Text.Trim();
         if (!string.IsNullOrEmpty(queueName))
         {
            string queuePath = Path.Combine(queuesPath, queueName);

            if (!MessageQueue.Exists(queuePath))
            {
               using (MessageQueue messageQueue = MessageQueue.Create(queuePath))
               {
                  if (messageQueue != null)
                  {
                     messageQueue.Label = queueName;
                     btnSaveQueue.Enabled = false;
                     txtQueueName.ReadOnly = true;                     
                     GridViewDataBinding(gvwQueues, GetMessageQueues());
                  }
               }
            }
            else
            {
               MessageBox.Show(this, $"The queue {queueName} already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }
         else
         {
            MessageBox.Show(this, "The queue name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         if (gvwQueues.SelectedRows.Count > 0)
         {
            int index = gvwQueues.SelectedRows[0].Index;
            DataGridViewRow row = gvwQueues.Rows[index];
            string queueName = row.Cells["colName"].Value.ToString();
            string queuePath = Path.Combine(queuesPath, queueName);

            if (MessageQueue.Exists(queuePath))
            {               
               MessageQueue.Delete(queuePath);
               txtQueueName.Text = string.Empty;
               gbxSendMessage.Enabled = false;
               GridViewDataBinding(gvwQueues, GetMessageQueues());

               if (gvwQueues.Rows.Count == 0)
               {
                  lblQueueName.Text = string.Empty;
                  lblNroMessages.Text = "0";
                  lvwMessages.Items.Clear();
               }
            }
         }
      }

      private void gvwQueues_RowEnter(object sender, DataGridViewCellEventArgs e)
      {
         if (e.RowIndex >= 0)
         {
            txtQueueName.Text = gvwQueues.Rows[e.RowIndex].Cells["colName"].Value?.ToString();
            gbxSendMessage.Enabled = true;
            btnSaveQueue.Enabled = false;
            txtQueueName.ReadOnly = true;
            lvwMessages.Items.Clear();

            string queuePath = Path.Combine(queuesPath, txtQueueName.Text.Trim());

            using (MessageQueue messageQueue = new MessageQueue(queuePath))
            {
               lblQueueName.Text = messageQueue.Label;
               lblNroMessages.Text = string.Format("{0:D}", messageQueue.GetAllMessages().Length);
            }
         }
      }

      private void btnSendMessage_Click(object sender, EventArgs e)
      {
         if (string.IsNullOrEmpty(txtMessage.Text))
         {
            MessageBox.Show(this, "The Message is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }

         string queueName = txtQueueName.Text.Trim();
         string queuePath = Path.Combine(queuesPath, queueName);

         if (MessageQueue.Exists(queuePath))
         {
            using (MessageQueue messageQueue = new MessageQueue(queuePath))
            {
               messageQueue.Send(txtMessage.Text);
               lblNroMessages.Text = string.Format("{0:D}", messageQueue.GetAllMessages().Length);

               //This line is to send Custom object as message.
               //messageQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(LogMessage) });
               //messageQueue.Send(msg);
            }
            txtMessage.Text = string.Empty;
            MessageBox.Show(this, "Message sent successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private void btnReadNextMsg_Click(object sender, EventArgs e)
      {
         string queueName = lblQueueName.Text.Trim();
         string queuePath = Path.Combine(queuesPath, queueName);

         if (MessageQueue.Exists(queuePath))
         {
            using (MessageQueue messageQueue = new MessageQueue(queuePath))
            {
               if (messageQueue.GetAllMessages().Any())
               {
                  System.Messaging.Message message = messageQueue.Receive();
                  message.Formatter = new XmlMessageFormatter(new String[] { "System.String, mscorlib" });

                  lvwMessages.Items.Insert(0, message.Body.ToString());
               }

               lblNroMessages.Text = string.Format("{0:D}", messageQueue.GetAllMessages().Length);
            }
         }
      }

      private void btnReadAllMsg_Click(object sender, EventArgs e)
      {
         string queueName = lblQueueName.Text.Trim();
         string queuePath = Path.Combine(queuesPath, queueName);

         if (MessageQueue.Exists(queuePath))
         {
            using (MessageQueue messageQueue = new MessageQueue(queuePath))
            {
               while (messageQueue.GetAllMessages().Any())
               {
                  System.Messaging.Message message = messageQueue.Receive();
                  message.Formatter = new XmlMessageFormatter(new String[] { "System.String, mscorlib" });

                  lvwMessages.Items.Insert(0, message.Body.ToString());
               }

               lblNroMessages.Text = string.Format("{0:D}", messageQueue.GetAllMessages().Length);
            }
         }
      }
      #endregion
   }
}