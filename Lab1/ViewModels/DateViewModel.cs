using Lab1.Models;
using System;
using System.Windows;

namespace Lab1.ViewModels
{
    public class DateViewModel
    {

        private User _user = new User();

       

        
        public DateTime Date
        {
            get { return _user.Date; }
            set { _user.Date = value; }
        }

        public String Age
        {
            get { return _user.Age; }
            set { _user.Age = value; }
        }


        public string WZodiac
        {
            get { return _user.WZodiac; }
            set { _user.WZodiac = value; }
        }

        public string CZodiac
        {
            get { return _user.CZodiac; }
            set { _user.CZodiac = value; }
        }

     




        public string CalculateWesternZodiacSign()
        {
            string[] wZodiac = new string[] { "Aries", "Taurus", "Gemini", "Cancer",
            "Leo", "Virgo", "Libra", "Scorpio",
            "Sagittarius", "Capricorn", "Aquarius", "Pisces" };
            int m = Date.Month;
            int d = Date.Day;
            switch (m)
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

        public string CalculateChineseZodiacSign()
        {
             string[] cZodiac = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon",
            "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };
            int y = Date.Year;
            return cZodiac[(y - 4) % 12];
        }

        public string CalculateUserAge()
        {
            try
            {
                DateTime now = DateTime.Now;
                DateTime date = Date;
                int years = new DateTime(DateTime.Now.Subtract(date).Ticks).Year - 1;
                if (years > 135)
                    MessageBox.Show("Your date is incorrect");
                return years+"";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Your date is incorrect");
            }
            return "";
        }

    }
}
