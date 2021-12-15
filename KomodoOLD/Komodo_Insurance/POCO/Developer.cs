using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserID { get; set; }
        public bool HasPluralsight { get; set; }

        public Developer() { }

        public Developer(string firstName, string lastName, int userID, bool hasPluralsight )
        {
            FirstName = firstName;
            LastName = lastName;
            UserID = userID;
            HasPluralsight = hasPluralsight;
        }
    }
}
