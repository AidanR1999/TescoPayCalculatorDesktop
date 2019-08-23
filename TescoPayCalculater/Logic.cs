using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TescoPayCalculater
{
    public class Logic
    {
        //hourly pay
        public double HourlyPay { get; set; }

        //contract hours
        public double WeekStandHours { get; set; }
        public double WeekPremHours { get; set; }

        //overtime hours
        public double OverStandHours { get; set; }
        public double OverPremHours { get; set; }

        private const double PREMIUM_RATE = 1.25;

        //constructors
        public Logic() { }
        public Logic(double hourlyPay, double weekStandHours, double weekPremHours, double overStandHours, double overPremHours)
        {
            HourlyPay = hourlyPay;
            WeekStandHours = weekStandHours;
            WeekPremHours = weekPremHours;
            OverStandHours = overStandHours;
            OverPremHours = overPremHours;
        }

        //calculates the weekly pay of a person
        public double CalcWeeklyPay()
        {
            //find standard pay
            var pay = HourlyPay * (WeekStandHours + OverStandHours);

            //add premium pay
            pay += (HourlyPay * PREMIUM_RATE) * (WeekPremHours + OverPremHours);

            return pay;
        }

        //calculates the monthly pay of a person
        public double CalcMonthlyPay()
        {
            //find standard pay
            var pay = HourlyPay * WeekStandHours;
            pay += (HourlyPay * PREMIUM_RATE) * WeekPremHours;
            pay *= 4;

            //add overtime pay
            pay += HourlyPay * OverStandHours;
            pay += (HourlyPay * PREMIUM_RATE) * OverPremHours;

            return pay;
        }

        //calculates the annual pay of a person
        public double CalcAnnualPay()
        {
            return CalcMonthlyPay() * 12;
        }
    }
}
