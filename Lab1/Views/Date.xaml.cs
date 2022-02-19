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

    public partial class Date : UserControl
    {


        DateViewModel _dateViewModel;

        public Date()
        {
            InitializeComponent();
            DataContext = _dateViewModel = new DateViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userAgeCaption.Text = ""+_dateViewModel.CalculateUserAge();
            if (!userAgeCaption.Text.Equals(""))
            {
                westernZodiacSign.Text = _dateViewModel.CalculateWesternZodiacSign();
                chineseZodiacSign.Text = _dateViewModel.CalculateChineseZodiacSign();
            }
        }

        private void datePicker_LostFocus(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate!=null)
            _dateViewModel.Date = datePicker.SelectedDate.Value;
        }
    }
}
