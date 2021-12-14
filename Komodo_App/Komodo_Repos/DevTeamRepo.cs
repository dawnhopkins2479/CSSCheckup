using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Repos
{
    class DevTeamRepo
    {
        private Dictionary<int, DevTeam> _devTeamList;


        public bool AddDevTeam(DevTeam devTeam)
        {
            bool bReturn = false;

            if (!_devTeamList.ContainsKey(devTeam.TeamID))
            {
                _devTeamList.Add(devTeam.TeamID, devTeam);
                bReturn = true;
            }


            return bReturn;

        }
        public bool RemoveDevTeam(DevTeam devTeam)
        {
            return (_devTeamList.Remove(devTeam.TeamID));
        }
        public bool UpdateDeveloper(DevTeam devTeam)
        {
            bool bReturn = false;

            if (RemoveDevTeam(devTeam))
            {
                bReturn = AddDevTeam(devTeam);

            }


            return bReturn;
        }
    }
}
