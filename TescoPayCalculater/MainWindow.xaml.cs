using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TescoPayCalculater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Logic GetValues(Logic l)
        {
            try
            {
                l.HourlyPay = Convert.ToDouble(txtHourly.Text);
                l.WeekStandHours = Convert.ToDouble(txtWeeklyStand.Text);
                l.WeekPremHours = Convert.ToDouble(txtWeeklyPrem.Text);
                l.OverStandHours = Convert.ToDouble(txtOverStand.Text);
                l.OverPremHours = Convert.ToDouble(txtOverPrem.Text);
            }
            catch (Exception e)
            {
                return null;
            }
            
            return l;
        }

        public void DisplayOutput(double pay)
        {
            lblAnswer.Content = "£" + Math.Round(pay, 2);
        }

        private void CmdCalcWeekly_Click(object sender, RoutedEventArgs e)
        {
            Logic l = new Logic();
            l = GetValues(l);

            var pay = l.CalcWeeklyPay();
            DisplayOutput(pay);
        }

        private void CmdCalcMonth_Click(object sender, RoutedEventArgs e)
        {
            Logic l = new Logic();
            l = GetValues(l);

            var pay = l.CalcMonthlyPay();
            DisplayOutput(pay);
        }

        private void CmdCalcAnnual_Click(object sender, RoutedEventArgs e)
        {
            Logic l = new Logic();
            l = GetValues(l);

            var pay = l.CalcAnnualPay();
            DisplayOutput(pay);
        }
    }
}
