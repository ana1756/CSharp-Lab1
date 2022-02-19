using Lab1.ViewModels;
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

namespace Lab1.Views
{
    /// <summary>
    /// Interaction logic for DateControl.xaml
    /// </summary>
    /// 



    public partial class Date : UserControl
    {
        string[] wZodiac = new string[] { "Aries", "Taurus", "Gemini", "Cancer", 
            "Leo", "Virgo", "Libra", "Scorpio", 
            "Sagittarius", "Capricorn", "Aquarius", "Pisces" };

        static string[] cZodiac = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", 
            "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };

        DateViewModel _dateViewModel;

        public Date()
        {
            InitializeComponent();
            DataContext = _dateViewModel = new DateViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            userAgeCaption.Text = "Your age: " + CalculateUserAge();
            if (!userAgeCaption.Text.Equals("Your age: "))
            {
                westernZodiacSign.Text = "Your Western zodiac sign: " + CalculateWesternZodiacSign();
                chineseZodiacSign.Text = "Your Chinese zodiac sign: " + CalculateChineseZodiacSign();
            }
        }

        private string CalculateChineseZodiacSign()
        {
            int y = datePicker.SelectedDate.Value.Year;
            return  cZodiac[(y - 4) % 12];
        }

        private string CalculateWesternZodiacSign()
        {
            int m = datePicker.SelectedDate.Value.Month;
            int d = datePicker.SelectedDate.Value.Day;
            switch(m)
            {
                case 1:
                    return (d <= 20) ? wZodiac[9] : wZodiac[10];
                case 2:
                    return (d <= 19) ? wZodiac[10] : wZodiac[11];
                case 3:
                    return (d <= 20) ? wZodiac[11] : wZodiac[0];
                case 4:
                    return (d <= 20) ? wZodiac[0] : wZodiac[1];
                case 5:
                    return (d <= 21) ? wZodiac[1] : wZodiac[2];
                case 6:
                    return (d <= 21) ? wZodiac[2] : wZodiac[3];
                case 7:
                    return (d <= 22) ? wZodiac[3] : wZodiac[4];
                case 8:
                    return (d <= 21) ? wZodiac[4] : wZodiac[5];
                case 9:
                    return (d <= 23) ? wZodiac[5] : wZodiac[6];
                case 10:
                    return (d <= 23) ? wZodiac[6] : wZodiac[7];
                case 11:
                    return (d <= 22) ? wZodiac[7] : wZodiac[8];
                case 12:
                    return (d <= 22) ? wZodiac[8] : wZodiac[9];
                default:
                    throw new ArgumentException();
            }
        }

        private string CalculateUserAge()
        {
            try
            {
                DateTime now = DateTime.Now;
                DateTime date = datePicker.SelectedDate.Value;
                int years = new DateTime(DateTime.Now.Subtract(date).Ticks).Year - 1;
                if (years > 135) MessageBox.Show("Your date is incorrect");
                return String.Format("{0} year(s)", years);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your date is incorrect");
            }
            return "";

        }
    }
}
