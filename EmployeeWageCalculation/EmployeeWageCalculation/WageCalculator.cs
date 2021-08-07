using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{
    
    public class WageCalculator
    {
        public static double BASE_HOURS = 40.0;
        public static double OVERTIME_RATE = 1.5;
        public double hours, pay;



        public void setHours(double hours)
            {
                this.hours = hours;
            }
            public void setHourlyPay(double pay)
            {
                this.pay = pay;
            }
            public double calculateGrossPay()
            {
                return hours > 40 ?
                       (pay * BASE_HOURS) + ((pay * OVERTIME_RATE) * (hours - BASE_HOURS)) :
                       hours * pay;
            }
        }
    }

