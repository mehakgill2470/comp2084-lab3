using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
        
        public Phone()
        {
            PhoneName = "";
            Manufacturer = "";
            DateReleased = DateTime.Now;
        }

        public int PhoneID { get; set; }
        public string PhoneName { get; set; }
        public string Manufacturer { get; set; }
        public int MSRP { get; set; }
        public int ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }


    }
}