using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.ViewModels
{
    public class DateViewModel
    {

        private User _user = new User();

        public short Date
        {
            get { return _user.Date; }
            set { _user.Date = value; }
            
        }


    }
}
