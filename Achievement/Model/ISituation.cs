using Achievement.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achievement.Model
{
    public interface ISituation
    {
        string Name { get; set; }

        LevelEnum Level { get; set; }

        bool IsConformTo(Realtor realtor);
    }
}
