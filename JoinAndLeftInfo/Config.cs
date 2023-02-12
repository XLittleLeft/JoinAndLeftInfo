using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinAndLeftInfo
{
    public class Config
    {
        [Description("enable plugin")]
        public bool IsEnabled { get; set; } = true;
        [Description("player left info")]
        public bool PlayerLeftInfo { get; set; } = true;
        [Description("player joined info")]
        public bool PlayerJoinedInfo { get; set; } = true;
    }
}
