using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO
{
    public class Developers
    {
        private List<Developer> _listOfDevelopers = new List<Developer>();

        public void AddDeveloperToTeam(Developer developer)
        {
            _listOfDevelopers.Add(developer);

        }

        public List<Developer> GetDevelopersList()
        {
            return _listOfDevelopers;
        }






        private Developers GetDeveloperByID(string userID)
        {
            foreach(Developer developer in _listOfDevelopers)
            {
                if (developer.UserID = )
                {
                    return developer;
                }
            }
        }
    }
}
