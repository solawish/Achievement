using Achievement.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achievement.Model
{
    public class Situation
    {
        public string Name { get; set; }

        public LevelEnum Level { get; set; }

        public Func<Realtor, bool> IsConformTo { get; set; }
    }
}
