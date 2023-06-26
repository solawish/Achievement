using Achievement.Enum;
using Achievement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achievement.Service
{
    public interface IAchievementService
    {
        LevelEnum GetLevel(Realtor realtor);
    }
}
