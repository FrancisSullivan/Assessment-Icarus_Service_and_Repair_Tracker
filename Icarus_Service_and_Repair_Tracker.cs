#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        #region 6.01 Separate class file
        #endregion
        #region 6.02 List of Class
        List<Drone> FinishedList = new List<Drone>();
        #endregion
        #region 6.03 Queue of class (regular service)
        Queue<Drone> RegularService = new Queue<Drone>();
        #endregion
        #region 6.04 Queue of class (express service)
        Queue<Drone> ExpressService = new Queue<Drone>();
        #endregion
        #region 6.05 Add new service item
        private void AddNewItem()
        {
            Drone addDrone = new Drone();
            addDrone.SetClientName(TextBoxClientName.Text);
            addDrone.SetDroneModel(TextBoxDroneModel.Text);
            addDrone.SetServiceProblem(TextBoxServiceProblem.Text);
            addDrone.SetServiceCost(TextBoxServiceCost.Text);
            switch (GetServicePriority())
            {
                case "Regular":
                    RegularService.Enqueue(addDrone);
                    UpdateListViewRegularQueue();
                    break;
                case "Express":
                    ExpressService.Enqueue(addDrone);
                    UpdateListViewExpressQueue();
                    break;
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddNewItem();
            ClearTextBoxes();
        }
        #endregion
        #region 6.06 Increase express service by 15%
        #endregion
        #region 6.07 Method to return radio button priority
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
        #region 6.08 Method to display regular service queue in ListView
        private void UpdateListViewRegularQueue()
        {
            ListViewRegularQueue.Items.Clear();
            foreach (var item in RegularService)
            {
                ListViewItem lvi = new ListViewItem(item.GetClientName());
                lvi.SubItems.Add(item.GetDroneModel());
                lvi.SubItems.Add(item.GetServiceProblem());
                lvi.SubItems.Add(item.GetServiceCost());
                ListViewRegularQueue.Items.Add(lvi);
            }
        }
        #endregion
        #region 6.09 Method to display express service queue in ListView
        private void UpdateListViewExpressQueue()
        {
            ListViewExpressQueue.Items.Clear();
            foreach (var item in ExpressService)
            {
                ListViewItem lvi = new ListViewItem(item.GetClientName());
                lvi.SubItems.Add(item.GetDroneModel());
                lvi.SubItems.Add(item.GetServiceProblem());
                lvi.SubItems.Add(item.GetServiceCost());
                ListViewExpressQueue.Items.Add(lvi);
            }
        }
        #endregion
        #region 6.10 Keypress method for service cost
        private void KeypressFilter()
        {

        }
        #endregion
        #region 6.11 Method to increment service tag control
        private void IncrementServiceTagControl()
        {

        }
        #endregion
        #region 6.12 Click to populate textbox from regular service ListView
        private void ListViewRegularQueue_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region 6.13 Click to populate textbox from express service ListView
        private void ListViewExpressQueue_Click(object sender, EventArgs e)
        {

        }

        #endregion
        #region 6.14 Button dequeue regular data structure, add item to list
        private void ButtonDequeueRegular_Click(object sender, EventArgs e)
        {
            Drone addDrone = new Drone();
            addDrone.SetClientName(RegularService.Peek().GetClientName());
            addDrone.SetDroneModel(RegularService.Peek().GetDroneModel());
            addDrone.SetServiceProblem(
                RegularService.Peek().GetServiceProblem());
            addDrone.SetServiceCost(RegularService.Peek().GetServiceCost());
            FinishedList.Add(addDrone);
            ListBoxFinishedItems.Items.Clear();
            foreach (var item in FinishedList)
            {
                ListBoxFinishedItems.Items.Add((item.GetClientName()) + 
                    "\t " + (item.GetServiceCost()));
            }
            RegularService.Dequeue();
            UpdateListViewRegularQueue();
        }
        #endregion
        #region 6.15 Button dequeue express data structure, add item to list
        private void ButtonDequeueExpress_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region 6.16 Double-click remove item from listbox and list
        private void ListBoxFinishedItems_DoubleClick(object sender, EventArgs e)
        {

        }
        #endregion
        #region 6.17 Method to clear textboxes
        private void ClearTextBoxes()
        {
            TextBoxClientName.Clear();
            TextBoxDroneModel.Clear();
            TextBoxServiceProblem.Clear();
            TextBoxServiceCost.Clear();
            //TextBoxDroneModel.SelectedItem = null;
            //NumericUpDownServiceTag.ResetText();
            foreach (RadioButton rb in
                GroupBoxServicePriority.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
        }
        #endregion
    }
}
