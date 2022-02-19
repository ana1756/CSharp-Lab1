using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Models
{

    public class User
    {
        private DateTime _date;

        private string age;

        private string wZodiac;

        private string cZodiac;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public String Age
        {
            get { return age; }
            set { age = value; }
        }

        public string WZodiac
        {
            get { return wZodiac; }
            set { wZodiac = value; }
        }

        public string CZodiac
        {
            get { return cZodiac; }
            set { cZodiac = value; }
        }
    }
     
}
