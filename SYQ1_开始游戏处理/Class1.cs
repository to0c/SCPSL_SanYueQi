using Exiled.API.Features;
using Exiled.CreditTags;
using PluginAPI.Roles;
using System;
using System.Timers;

namespace SYQ1
{
    // 继承配置文件
    public class Plugin : Plugin<Config>
    {
        private EventHandlers handler;
        private Timer timer;

        public override void OnEnabled()
        {
            base.OnEnabled();

            handler = new EventHandlers();
            Exiled.Events.Handlers.Server.RoundStarted += handler.OnRoundStarted;
            Log.Info("插件启动成功");

            // 初始化计时器
            timer = new Timer();
            timer.Interval = 5 * 60 * 1000; // 5分钟，单位毫秒
            timer.Elapsed += handler.OnTimerElapsed;
            timer.Start();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Exiled.Events.Handlers.Server.RoundStarted -= handler.OnRoundStarted;
            handler = null;

            // 停止和释放计时器
            timer.Stop();
            timer.Elapsed -= handler.OnTimerElapsed;
            timer.Dispose();
            timer = null;

            // Log.Info("插件启动失败");
        }
    }

    public class EventHandlers
    {
        public void OnRoundStarted()
        {
            // 给所有玩家添加一个 COIN
            foreach (Player player in Player.List)
            {
                player.AddItem(ItemType.Coin);
                player.AddAhp(50);
            }

            // 发送广播消息
            Map.Broadcast(5, "<COLOR=RED><SIZE=35>[三月七]</SIZE></COLOR><SIZE=30>QQ:589666207 欢迎加入，游戏已开始</SIZE>");
        }

        public void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // 在计时器触发时给玩家添加2个coin
            foreach (Player player in Player.List)
            {
                player.AddItem(ItemType.Coin, 2);
            }
            Map.Broadcast(5, "<COLOR=GREEN><SIZE=40>[三月七]</size></COLOR>服主送你们了2个大钢镚");
        }
    }
}