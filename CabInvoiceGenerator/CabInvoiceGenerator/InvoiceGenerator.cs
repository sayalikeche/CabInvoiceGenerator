using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        readonly private double DIS;
        readonly private double TIME;
        readonly private double MINFARE = 5.0;
        readonly private double COSTPERKM = 10.0;
        readonly private double COSTPERMIN = 1.0;

        public InvoiceGenerator()
        {
        }

        public InvoiceGenerator(double runningDistance, double runningTime)
        {
            this.Dis = runningDistance;
            this.TIME = runningTime;
        }

        public double Dis { get; }

        public double CalculateCabFare()
        {


            double TotalFare = (DIS * COSTPERKM) + (TIME * COSTPERMIN);
            if (TotalFare < MINFARE)
            {
                return MINFARE;
            }
            else
            {
                return TotalFare;
            }
        }
        public double CalculateMultipleRideFair(Ride[] ride)
        {
            double totalFare = 0;
            foreach (var data in ride)
            {
                totalFare += (data.DISTANCE * COSTPERKM) + (data.TIME * COSTPERMIN);
            }
            if (totalFare < MINFARE)
            {
                return MINFARE;
            }
            else
            {
                return totalFare;
            }
        }
    }
}
        
    

