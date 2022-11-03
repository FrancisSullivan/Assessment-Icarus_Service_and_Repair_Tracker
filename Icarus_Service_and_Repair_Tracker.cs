#region Imports
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
#endregion
// Francis Sullivan 30034007
// AT3 2022.11.
namespace Icarus_Service_and_Repair_Tracker
{
    public partial class Icarus_Service_and_Repair_Tracker : Form
    {
        #region Initialise Form
        public Icarus_Service_and_Repair_Tracker()
        {
            InitializeComponent();
        }
        #endregion
        #region 6.02 List of class (finished list)
        List<Drone> FinishedList = new List<Drone>();
        #endregion
        #region 6.03 Queue of class (regular service)
        Queue<Drone> RegularService = new Queue<Drone>();
        #endregion
        #region 6.04 Queue of class (express service)
        Queue<Drone> ExpressService = new Queue<Drone>();
        #endregion
        #region 6.05 Add new service item + 6.06 Express service by 15%
        private void AddNewItem()
        {
            Drone addDrone = new Drone();
            addDrone.SetClientName(TextBoxClientName.Text);
            addDrone.SetDroneModel(TextBoxDroneModel.Text);
            addDrone.SetServiceProblem(TextBoxServiceProblem.Text);
            addDrone.SetServiceCost(TextBoxServiceCost.Text);
            addDrone.SetServiceTag(NumericUpDownServiceTag.Text);
            IncrementServiceTag();
            switch (GetServicePriority())
            {
                case "Regular":
                    RegularService.Enqueue(addDrone);
                    UpdateListViewRegularQueue();
                    break;
                case "Express":
                    addDrone.SetServiceCost(
                        (((double) Convert.ToDouble(TextBoxServiceCost.Text))
                        * 1.15).ToString());
                    ExpressService.Enqueue(addDrone);
                    UpdateListViewExpressQueue();
                    break;
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (BlankCheck() == true)
            {
                MessageBox.Show("One of the input fields are blank, " +
                   "please try again",
                   "Duplication Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AddNewItem();
            ClearTextBoxes();
            toolStripStatusLabel.Text = "Record added";
        }
        private Boolean BlankCheck()
        {
            Boolean inputError = false;
            if (TextBoxClientName.Text == "")
            {
                return true;
            }
            if (TextBoxDroneModel.Text == "")
            {
                return true;
            }
            if (TextBoxServiceProblem.Text == "")
            {
                return true;
            }
            if (TextBoxServiceCost.Text == "")
            {
                return true;
            }
            if (GetServicePriority() == "")
            {
                return true;
            }
            return inputError;
        }
        #endregion
        #region 6.07 Return radio button priority
        private string GetServicePriority()
        {
            string rbValue = "";
            foreach (RadioButton rb in
                GroupBoxServicePriority.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    rbValue = rb.Text;
                    break;
                }
                else
                {
                    rbValue = "";
                }
            }
            return rbValue;
        }
        #endregion
        #region 6.08 Display regular service queue in ListView
        private void UpdateListViewRegularQueue()
        {
            ListViewUpdate(RegularService, ListViewRegularQueue);
        }
        private void ListViewUpdate(Queue<Drone> selectedQueue,
            System.Windows.Forms.ListView selectedListView)
        {
            selectedListView.Items.Clear();
            foreach (var item in selectedQueue)
            {
                ListViewItem lvi = new ListViewItem(item.GetClientName());
                lvi.SubItems.Add(item.GetDroneModel());
                lvi.SubItems.Add(item.GetServiceProblem());
                lvi.SubItems.Add(item.GetServiceCost());
                lvi.SubItems.Add(item.GetServiceTag());
                selectedListView.Items.Add(lvi);
            }
        }
        #endregion
        #region 6.09 Display express service queue in ListView
        private void UpdateListViewExpressQueue()
        {
            ListViewUpdate(ExpressService, ListViewExpressQueue);
        }
        #endregion
        #region 6.10 Keypress method for service cost
        private void TextBoxServiceCost_KeyPress(object sender, 
            KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar)
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') 
                && ((sender as System.Windows.Forms.TextBox)
                .Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region 6.11 Increment service tag control
        private void IncrementServiceTag()
        {
            NumericUpDownServiceTag.Text =
            (((int) Convert.ToInt16(NumericUpDownServiceTag.Text)) 
                + 10).ToString();
        }
        #endregion
        #region 6.12 Click to populate textbox from regular service ListView
        private void ListViewRegularQueue_Click(object sender, EventArgs e)
        {
            TextBoxUpdate(RegularService, ListViewRegularQueue);
            toolStripStatusLabel.Text =
                "Record selected. Attributes displayed above.";
        }
        private void TextBoxUpdate(Queue<Drone> selectedQueue,
            System.Windows.Forms.ListView selectedListView)
        {
            int currentItem = selectedListView.SelectedIndices[0];
            TextBoxClientName.Text =
                selectedQueue.ElementAt(currentItem).GetClientName();
            TextBoxDroneModel.Text =
                selectedQueue.ElementAt(currentItem).GetDroneModel();
            TextBoxServiceProblem.Text =
                selectedQueue.ElementAt(currentItem).GetServiceProblem();
            TextBoxServiceCost.Text =
                selectedQueue.ElementAt(currentItem).GetServiceCost();
        }
        private void ListViewRegularQueue_MouseHover(
            object sender, EventArgs e)
        {
            ToolTip.SetToolTip(ListViewRegularQueue,
                "Click to display info in relevant TextBoxes");
        }
        #endregion
        #region 6.13 Click to populate textbox from express service ListView
        private void ListViewExpressQueue_Click(object sender, EventArgs e)
        {
            TextBoxUpdate(ExpressService, ListViewExpressQueue);
            toolStripStatusLabel.Text =
                "Record selected. Attributes displayed above.";
        }
        private void ListViewExpressQueue_MouseHover(
            object sender, EventArgs e)
        {
            ToolTip.SetToolTip(ListViewExpressQueue,
                "Click to display info in relevant TextBoxes");
        }
        #endregion
        #region 6.14 Button dequeue regular data structure, add item to list
        private void ButtonDequeueRegular_Click(object sender, EventArgs e)
        {
            MoveToListBox(RegularService);
            UpdateListViewRegularQueue();
            toolStripStatusLabel.Text =
                "Record dequeued. Moved to 'Finished Service Items'.";
        }
        private void MoveToListBox(Queue<Drone> selectedQueue)
        {
            Drone addDrone = new Drone();
            addDrone.SetClientName(selectedQueue.Peek().GetClientName());
            addDrone.SetDroneModel(selectedQueue.Peek().GetDroneModel());
            addDrone.SetServiceProblem(
                selectedQueue.Peek().GetServiceProblem());
            addDrone.SetServiceCost(selectedQueue.Peek().GetServiceCost());
            FinishedList.Add(addDrone);
            UpdateListBox();
            selectedQueue.Dequeue();
        }
        #endregion
        #region 6.15 Button dequeue express data structure, add item to list
        private void ButtonDequeueExpress_Click(object sender, EventArgs e)
        {
            MoveToListBox(ExpressService);
            UpdateListViewExpressQueue();
            toolStripStatusLabel.Text =
                "Record dequeued. Moved to 'Finished Service Items'.";
        }
        #endregion
        #region 6.16 Double-click remove item from listbox and list
        private void ListBoxFinishedItems_DoubleClick(
            object sender, EventArgs e)
        {
            int currentItem = ListBoxFinishedItems.SelectedIndices[0];
            ListBoxFinishedItems.Items.RemoveAt(currentItem);
            FinishedList.RemoveAt(currentItem);
            UpdateListBox();
            toolStripStatusLabel.Text = "Item removed";
        }
        private void ListBoxFinishedItems_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(ListBoxFinishedItems,
                "Double-click to remove item");
        }
        private void ListBoxFinishedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text =
                "Item selected. 'Double-click' to remove.";
        }
        #endregion
        #region 6.17 Method to clear textboxes
        private void ClearTextBoxes()
        {
            TextBoxClientName.Clear();
            TextBoxDroneModel.Clear();
            TextBoxServiceProblem.Clear();
            TextBoxServiceCost.Clear();
            //NumericUpDownServiceTag.ResetText();
            foreach (RadioButton rb in
                GroupBoxServicePriority.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
        }
        #endregion
        #region 'Clear' DoubleClick Event
        private void TextBoxClientName_MouseHover(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(TextBoxClientName,
                "Double-click to clear all attributes");
        }
        private void TextBoxClientName_DoubleClick(object sender, EventArgs e)
        {
            ClearTextBoxes();
            toolStripStatusLabel.Text = "Fields cleared";
        }
        #endregion
        #region UpdateListBox
        private void UpdateListBox()
        {
            ListBoxFinishedItems.Items.Clear();
            foreach (var item in FinishedList)
            {
                ListBoxFinishedItems.Items.Add((item.GetClientName()) +
                    "\t " + (item.GetServiceCost()));
            }
        }
        #endregion
    }
}
