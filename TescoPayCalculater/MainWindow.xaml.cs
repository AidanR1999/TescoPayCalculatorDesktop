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

        //gets values from window and converts them to doubles
        public Logic GetValues(Logic l)
        {
            l.HourlyPay = Helper.ToDoubleDefaultZero(txtHourly.Text);
            l.WeekStandHours = Helper.ToDoubleDefaultZero(txtWeeklyStand.Text);
            l.WeekPremHours = Helper.ToDoubleDefaultZero(txtWeeklyPrem.Text);
            l.OverStandHours = Helper.ToDoubleDefaultZero(txtOverStand.Text);
            l.OverPremHours = Helper.ToDoubleDefaultZero(txtOverPrem.Text);

            return l;
        }

        //displays answer to user
        public void DisplayOutput(double pay)
        {
            lblAnswer.Content = "£" + Math.Round(pay, 2);
        }

        //on calc weekly clicked
        private void CmdCalcWeekly_Click(object sender, RoutedEventArgs e)
        {
            //get values
            Logic l = new Logic();
            l = GetValues(l);

            //calculate answer and display
            var pay = l.CalcWeeklyPay();
            DisplayOutput(pay);
        }

        //on calc monthly clicked
        private void CmdCalcMonth_Click(object sender, RoutedEventArgs e)
        {
            //get values
            Logic l = new Logic();
            l = GetValues(l);

            //calculate answer and display
            var pay = l.CalcMonthlyPay();
            DisplayOutput(pay);
        }

        //on calc annual clicked
        private void CmdCalcAnnual_Click(object sender, RoutedEventArgs e)
        {
            //get values
            Logic l = new Logic();
            l = GetValues(l);

            //calculate answer and display
            var pay = l.CalcAnnualPay();
            DisplayOutput(pay);
        }
    }
}
