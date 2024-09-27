using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobayer_alam_24_ICTBD_MVC_Project_2.Models
{
    public class BookLists
    {
        public List<string> BookNames()
        {
            List<string> bookNames = new List<string>()
            {
                "The Catcher in the Rye",
                "The Hobbit",
                "War and Peace",
                "Crime and Punishment",
                "The Odyssey",
                "Brave New World",
                "The Lord of the Rings",
                "The Brothers Karamazov",
                "Great Expectations",
                "The Divine Comedy"
            };
            return bookNames;
        }
    }
}