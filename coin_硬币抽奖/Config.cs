// -----------------------------------------------------------------------
// <copyright file="config.cs" company="SanYueQi">.
// SCPSL插件 © 2024/2/20 下许可 CC BY-SA 4.0
// </copyright>
// -----------------------------------------------------------------------
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin1
{
    public class Config : IConfig
    {
        [Description("是否开启COIN抽奖插件")]
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }
    }
}
