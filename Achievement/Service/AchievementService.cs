using Achievement.Enum;
using Achievement.Model;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achievement.Service
{
    public class AchievementService : IAchievementService
    {
        private readonly IEnumerable<Situation> _situationCollecion;

        public AchievementService(IEnumerable<Situation> situationCollecion)
        {
            _situationCollecion = situationCollecion;
        }

        public LevelEnum GetLevel(Realtor realtor)
        {
            foreach(var situation in _situationCollecion)
            {
                if (situation.IsConformTo(realtor))
                {
                    return situation.Level;
                }
            }

            return LevelEnum.未符合;
        }
    }
}
