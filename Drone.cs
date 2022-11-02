#region Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
// Francis Sullivan 30034007
// AT3 2022.11.
namespace Icarus_Service_and_Repair_Tracker
{
    internal class Drone
    {
        #region Local Variables
        private string clientName;
        private string droneModel;
        private string serviceProblem;
        private string serviceCost;
        private string serviceTag;
        #endregion
        #region Setters
        public void SetClientName(string newClientName)
        {
            clientName = newClientName;
        }
        public void SetDroneModel(string newDroneModel)
        {
            droneModel = newDroneModel;
        }
        public void SetServiceProblem(string newServiceProblem)
        {
            serviceProblem = newServiceProblem;
        }
        public void SetServiceCost(string newServiceCost)
        {
            serviceCost = newServiceCost;
        }
        public void SetServiceTag(string newServiceTag)
        {
            serviceTag = newServiceTag;
        }
        #endregion
        #region Getters
        public string GetClientName()
        {
            return clientName;
        }
        public string GetDroneModel()
        {
            return droneModel;
        }
        public string GetServiceProblem()
        {
            return serviceProblem;
        }
        public string GetServiceCost()
        {
            return serviceCost;
        }
        public string GetServiceTag()
        {
            return serviceTag;
        }
        #endregion
    }
}
