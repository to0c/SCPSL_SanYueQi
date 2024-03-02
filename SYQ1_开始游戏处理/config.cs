using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYQ1
{
    public sealed class config : IConfig
    {
        [Description("是否开启插件")]
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }

}
}