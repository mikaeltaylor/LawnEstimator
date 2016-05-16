using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawnEstimator
{
    class Cost : Lawn
    {
        public double employeeWage;
        public double fuelCost;
        public double timeCost;
        public int profit;

        public double EmployeeWage
        {
            get { return employeeWage; }
            set { this.employeeWage = employeeWage; }
        }
        public double FuelCost
        {

            get { return fuelCost; }
            set { this.fuelCost = fuelCost; }
        }
        public double TimeCost
        {
            get { return timeCost; }
            set { this.timeCost = timeCost; }
        }
        public int Profit
        {
            get { return profit; }
            set { this.profit = 20; }
        }


    }
}
