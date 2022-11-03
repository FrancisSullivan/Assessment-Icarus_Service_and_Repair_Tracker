namespace Icarus_Service_and_Repair_Tracker
{
    partial class Icarus_Service_and_Repair_Tracker
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
            this.components = new System.ComponentModel.Container();
            this.ListViewRegularQueue = new System.Windows.Forms.ListView();
            this.clientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.droneModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serviceProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serviceCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serviceTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelClientName = new System.Windows.Forms.Label();
            this.LabelServiceProblem = new System.Windows.Forms.Label();
            this.ListBoxFinishedItems = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelServiceCost = new System.Windows.Forms.Label();
            this.LabelServiceTag = new System.Windows.Forms.Label();
            this.LabelDroneModel = new System.Windows.Forms.Label();
            this.TextBoxClientName = new System.Windows.Forms.TextBox();
            this.TextBoxServiceProblem = new System.Windows.Forms.TextBox();
            this.GroupBoxServicePriority = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.TextBoxDroneModel = new System.Windows.Forms.TextBox();
            this.ButtonDequeueRegular = new System.Windows.Forms.Button();
            this.ButtonDequeueExpress = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TextBoxServiceCost = new System.Windows.Forms.TextBox();
            this.ListViewExpressQueue = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumericUpDownServiceTag = new System.Windows.Forms.NumericUpDown();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBoxServicePriority.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownServiceTag)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewRegularQueue
            // 
            this.ListViewRegularQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clientName,
            this.droneModel,
            this.serviceProblem,
            this.serviceCost,
            this.serviceTag});
            this.ListViewRegularQueue.FullRowSelect = true;
            this.ListViewRegularQueue.HideSelection = false;
            this.ListViewRegularQueue.Location = new System.Drawing.Point(29, 190);
            this.ListViewRegularQueue.Name = "ListViewRegularQueue";
            this.ListViewRegularQueue.Size = new System.Drawing.Size(964, 280);
            this.ListViewRegularQueue.TabIndex = 0;
            this.ListViewRegularQueue.UseCompatibleStateImageBehavior = false;
            this.ListViewRegularQueue.View = System.Windows.Forms.View.Details;
            this.ListViewRegularQueue.Click += new System.EventHandler(this.ListViewRegularQueue_Click);
            this.ListViewRegularQueue.MouseHover += new System.EventHandler(this.ListViewRegularQueue_MouseHover);
            // 
            // clientName
            // 
            this.clientName.Text = "Client Name";
            this.clientName.Width = 90;
            // 
            // droneModel
            // 
            this.droneModel.Text = "Drone Model";
            this.droneModel.Width = 80;
            // 
            // serviceProblem
            // 
            this.serviceProblem.Text = "Service Problem";
            this.serviceProblem.Width = 160;
            // 
            // serviceCost
            // 
            this.serviceCost.Text = "Service Cost";
            this.serviceCost.Width = 75;
            // 
            // serviceTag
            // 
            this.serviceTag.Text = "Service Tag";
            this.serviceTag.Width = 75;
            // 
            // LabelClientName
            // 
            this.LabelClientName.AutoSize = true;
            this.LabelClientName.Location = new System.Drawing.Point(24, 31);
            this.LabelClientName.Name = "LabelClientName";
            this.LabelClientName.Size = new System.Drawing.Size(129, 25);
            this.LabelClientName.TabIndex = 2;
            this.LabelClientName.Text = "Client Name";
            // 
            // LabelServiceProblem
            // 
            this.LabelServiceProblem.AutoSize = true;
            this.LabelServiceProblem.Location = new System.Drawing.Point(373, 27);
            this.LabelServiceProblem.Name = "LabelServiceProblem";
            this.LabelServiceProblem.Size = new System.Drawing.Size(169, 25);
            this.LabelServiceProblem.TabIndex = 3;
            this.LabelServiceProblem.Text = "Service Problem";
            // 
            // ListBoxFinishedItems
            // 
            this.ListBoxFinishedItems.FormattingEnabled = true;
            this.ListBoxFinishedItems.ItemHeight = 25;
            this.ListBoxFinishedItems.Location = new System.Drawing.Point(1029, 165);
            this.ListBoxFinishedItems.Name = "ListBoxFinishedItems";
            this.ListBoxFinishedItems.Size = new System.Drawing.Size(389, 704);
            this.ListBoxFinishedItems.TabIndex = 4;
            this.ListBoxFinishedItems.SelectedIndexChanged += new System.EventHandler(this.ListBoxFinishedItems_SelectedIndexChanged);
            this.ListBoxFinishedItems.DoubleClick += new System.EventHandler(this.ListBoxFinishedItems_DoubleClick);
            this.ListBoxFinishedItems.MouseHover += new System.EventHandler(this.ListBoxFinishedItems_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Express Queue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1024, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Finished Service Items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Regular Queue";
            // 
            // LabelServiceCost
            // 
            this.LabelServiceCost.AutoSize = true;
            this.LabelServiceCost.Location = new System.Drawing.Point(683, 27);
            this.LabelServiceCost.Name = "LabelServiceCost";
            this.LabelServiceCost.Size = new System.Drawing.Size(134, 25);
            this.LabelServiceCost.TabIndex = 8;
            this.LabelServiceCost.Text = "Service Cost";
            // 
            // LabelServiceTag
            // 
            this.LabelServiceTag.AutoSize = true;
            this.LabelServiceTag.Location = new System.Drawing.Point(832, 27);
            this.LabelServiceTag.Name = "LabelServiceTag";
            this.LabelServiceTag.Size = new System.Drawing.Size(127, 25);
            this.LabelServiceTag.TabIndex = 9;
            this.LabelServiceTag.Text = "Service Tag";
            // 
            // LabelDroneModel
            // 
            this.LabelDroneModel.AutoSize = true;
            this.LabelDroneModel.Location = new System.Drawing.Point(208, 27);
            this.LabelDroneModel.Name = "LabelDroneModel";
            this.LabelDroneModel.Size = new System.Drawing.Size(135, 25);
            this.LabelDroneModel.TabIndex = 11;
            this.LabelDroneModel.Text = "Drone Model";
            // 
            // TextBoxClientName
            // 
            this.TextBoxClientName.Location = new System.Drawing.Point(29, 66);
            this.TextBoxClientName.Name = "TextBoxClientName";
            this.TextBoxClientName.Size = new System.Drawing.Size(178, 31);
            this.TextBoxClientName.TabIndex = 1;
            this.TextBoxClientName.DoubleClick += new System.EventHandler(this.TextBoxClientName_DoubleClick);
            this.TextBoxClientName.MouseHover += new System.EventHandler(this.TextBoxClientName_MouseHover);
            // 
            // TextBoxServiceProblem
            // 
            this.TextBoxServiceProblem.Location = new System.Drawing.Point(378, 66);
            this.TextBoxServiceProblem.Multiline = true;
            this.TextBoxServiceProblem.Name = "TextBoxServiceProblem";
            this.TextBoxServiceProblem.Size = new System.Drawing.Size(304, 81);
            this.TextBoxServiceProblem.TabIndex = 3;
            // 
            // GroupBoxServicePriority
            // 
            this.GroupBoxServicePriority.Controls.Add(this.radioButton1);
            this.GroupBoxServicePriority.Controls.Add(this.radioButton2);
            this.GroupBoxServicePriority.Location = new System.Drawing.Point(1029, 24);
            this.GroupBoxServicePriority.Name = "GroupBoxServicePriority";
            this.GroupBoxServicePriority.Size = new System.Drawing.Size(255, 73);
            this.GroupBoxServicePriority.TabIndex = 57;
            this.GroupBoxServicePriority.TabStop = false;
            this.GroupBoxServicePriority.Text = "Service Priority ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 29);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Regular";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(130, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(121, 29);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Express";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // TextBoxDroneModel
            // 
            this.TextBoxDroneModel.Location = new System.Drawing.Point(213, 66);
            this.TextBoxDroneModel.Name = "TextBoxDroneModel";
            this.TextBoxDroneModel.Size = new System.Drawing.Size(161, 31);
            this.TextBoxDroneModel.TabIndex = 2;
            // 
            // ButtonDequeueRegular
            // 
            this.ButtonDequeueRegular.Location = new System.Drawing.Point(837, 476);
            this.ButtonDequeueRegular.Name = "ButtonDequeueRegular";
            this.ButtonDequeueRegular.Size = new System.Drawing.Size(156, 41);
            this.ButtonDequeueRegular.TabIndex = 9;
            this.ButtonDequeueRegular.Text = "Dequeue";
            this.ButtonDequeueRegular.UseVisualStyleBackColor = true;
            this.ButtonDequeueRegular.Click += new System.EventHandler(this.ButtonDequeueRegular_Click);
            // 
            // ButtonDequeueExpress
            // 
            this.ButtonDequeueExpress.Location = new System.Drawing.Point(837, 846);
            this.ButtonDequeueExpress.Name = "ButtonDequeueExpress";
            this.ButtonDequeueExpress.Size = new System.Drawing.Size(156, 41);
            this.ButtonDequeueExpress.TabIndex = 10;
            this.ButtonDequeueExpress.Text = "Dequeue";
            this.ButtonDequeueExpress.UseVisualStyleBackColor = true;
            this.ButtonDequeueExpress.Click += new System.EventHandler(this.ButtonDequeueExpress_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(1310, 35);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(108, 67);
            this.ButtonAdd.TabIndex = 8;
            this.ButtonAdd.Text = "Add to Queue";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 924);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1449, 22);
            this.statusStrip.TabIndex = 63;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TextBoxServiceCost
            // 
            this.TextBoxServiceCost.Location = new System.Drawing.Point(688, 66);
            this.TextBoxServiceCost.Name = "TextBoxServiceCost";
            this.TextBoxServiceCost.Size = new System.Drawing.Size(143, 31);
            this.TextBoxServiceCost.TabIndex = 4;
            this.TextBoxServiceCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxServiceCost_KeyPress);
            // 
            // ListViewExpressQueue
            // 
            this.ListViewExpressQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListViewExpressQueue.FullRowSelect = true;
            this.ListViewExpressQueue.HideSelection = false;
            this.ListViewExpressQueue.Location = new System.Drawing.Point(29, 560);
            this.ListViewExpressQueue.Name = "ListViewExpressQueue";
            this.ListViewExpressQueue.Size = new System.Drawing.Size(964, 280);
            this.ListViewExpressQueue.TabIndex = 66;
            this.ListViewExpressQueue.UseCompatibleStateImageBehavior = false;
            this.ListViewExpressQueue.View = System.Windows.Forms.View.Details;
            this.ListViewExpressQueue.Click += new System.EventHandler(this.ListViewExpressQueue_Click);
            this.ListViewExpressQueue.MouseHover += new System.EventHandler(this.ListViewExpressQueue_MouseHover);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client Name";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Drone Model";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Service Problem";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Service Cost";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Service Tag";
            this.columnHeader5.Width = 75;
            // 
            // NumericUpDownServiceTag
            // 
            this.NumericUpDownServiceTag.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownServiceTag.Location = new System.Drawing.Point(839, 66);
            this.NumericUpDownServiceTag.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.NumericUpDownServiceTag.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDownServiceTag.Name = "NumericUpDownServiceTag";
            this.NumericUpDownServiceTag.Size = new System.Drawing.Size(120, 31);
            this.NumericUpDownServiceTag.TabIndex = 5;
            this.NumericUpDownServiceTag.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 12);
            // 
            // Icarus_Service_and_Repair_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 946);
            this.Controls.Add(this.NumericUpDownServiceTag);
            this.Controls.Add(this.ListViewExpressQueue);
            this.Controls.Add(this.TextBoxServiceCost);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonDequeueExpress);
            this.Controls.Add(this.ButtonDequeueRegular);
            this.Controls.Add(this.TextBoxDroneModel);
            this.Controls.Add(this.GroupBoxServicePriority);
            this.Controls.Add(this.TextBoxServiceProblem);
            this.Controls.Add(this.TextBoxClientName);
            this.Controls.Add(this.LabelDroneModel);
            this.Controls.Add(this.LabelServiceTag);
            this.Controls.Add(this.LabelServiceCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListBoxFinishedItems);
            this.Controls.Add(this.LabelServiceProblem);
            this.Controls.Add(this.LabelClientName);
            this.Controls.Add(this.ListViewRegularQueue);
            this.Name = "Icarus_Service_and_Repair_Tracker";
            this.Text = "Icarus_Service_and_Repair_Tracker";
            this.GroupBoxServicePriority.ResumeLayout(false);
            this.GroupBoxServicePriority.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownServiceTag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewRegularQueue;
        private System.Windows.Forms.Label LabelClientName;
        private System.Windows.Forms.Label LabelServiceProblem;
        private System.Windows.Forms.ListBox ListBoxFinishedItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelServiceCost;
        private System.Windows.Forms.Label LabelServiceTag;
        private System.Windows.Forms.Label LabelDroneModel;
        private System.Windows.Forms.TextBox TextBoxClientName;
        private System.Windows.Forms.TextBox TextBoxServiceProblem;
        private System.Windows.Forms.GroupBox GroupBoxServicePriority;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox TextBoxDroneModel;
        private System.Windows.Forms.Button ButtonDequeueRegular;
        private System.Windows.Forms.Button ButtonDequeueExpress;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox TextBoxServiceCost;
        private System.Windows.Forms.ColumnHeader clientName;
        private System.Windows.Forms.ColumnHeader droneModel;
        private System.Windows.Forms.ColumnHeader serviceProblem;
        private System.Windows.Forms.ColumnHeader serviceCost;
        private System.Windows.Forms.ColumnHeader serviceTag;
        private System.Windows.Forms.ListView ListViewExpressQueue;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.NumericUpDown NumericUpDownServiceTag;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

