// -----------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="SanYueQi">.
// SCPSL插件 © 2024/2/20 下许可 CC BY-SA 4.0
// </copyright>
// -----------------------------------------------------------------------
using Exiled.API.Enums;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.CreditTags;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;
using PluginAPI.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Permissions.Features;
using PlayerStatsSystem;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;

namespace coin1
{
    public class Plugin : Plugin<Config>
    {
        private EventHandlers handler;

        public override void OnEnabled()
        {
            base.OnEnabled();
            handler = new EventHandlers();
            Exiled.Events.Handlers.Player.DroppingItem += handler.DropItem;
            Log.Info("插件启动成功");
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
            Exiled.Events.Handlers.Player.DroppingItem -= handler.DropItem;
            handler = null;
            //Log.Info("插件启动失败");
        }
    }
    public class EventHandlers
    {
        public void DropItem(DroppingItemEventArgs ev)
        {
            if (ev.Player != null)
            {
                if (ev.Item.Type == ItemType.Coin)
                {
                    int a = UnityEngine.Random.Range(1, 130);
                    if (a <= 2)
                    {
                        ev.Player.AddItem(ItemType.MicroHID);
                        ev.Player.ShowHint("你获得了MicroHID");
                        ev.Item.Destroy();
                    }
                    if (a > 2 && a <= 3)
                    {
                        ev.Player.AddItem(ItemType.SCP207);
                        ev.Player.ShowHint("你获得了SCP207");
                        ev.Item.Destroy();
                    }
                    if (a > 4 && a <= 5)
                    {
                        ev.Player.AddItem(ItemType.Jailbird);
                        ev.Player.ShowHint("你获得了囚鸟");
                        ev.Item.Destroy();
                    }
                    if (a > 6 && a <= 8)
                    {
                        ev.Player.AddItem(ItemType.KeycardO5);
                        ev.Player.ShowHint("你获得了黑卡");
                        ev.Item.Destroy();
                    }
                    if (a > 9 && a <= 11)
                    {
                        ev.Player.AddItem(ItemType.GunLogicer);
                        ev.Player.ShowHint("你获得了机枪");
                        ev.Item.Destroy();
                    }
                    if (a > 12 && a <= 13)
                    {
                        ev.Player.AddItem(ItemType.GunCom45);
                        ev.Player.ShowHint("你获得了COM45");
                        ev.Item.Destroy();
                    }
                    if (a > 14 && a <= 16)
                    {
                        ev.Player.AddItem(ItemType.ParticleDisruptor);
                        ev.Player.ShowHint("你获得了粒子分解者");
                        ev.Item.Destroy();
                    }
                    if (a > 17 && a <= 18)
                    {
                        ev.Player.AddItem(ItemType.KeycardFacilityManager);
                        ev.Player.ShowHint("你获得了设施主管卡");
                        ev.Item.Destroy();
                    }
                    if (a > 19 && a <= 23)
                    {
                        ev.Player.AddItem(ItemType.GunA7);
                        ev.Player.ShowHint("你获得了A7步枪");
                        ev.Item.Destroy();
                    }
                    if (a > 24 && a <= 26)
                    {
                        ev.Player.AddItem(ItemType.SCP018);
                        ev.Player.ShowHint("你获得了SCP018");
                        ev.Item.Destroy();
                    }
                    if (a > 27 && a <= 53)
                    {
                        ev.Player.AddItem(ItemType.SCP500);
                        ev.Player.ShowHint("你获得了SCP500");
                        ev.Item.Destroy();
                    }
                    if (a > 54 && a <= 56)
                    {
                        ev.Player.AddItem(ItemType.SCP1853);
                        ev.Player.ShowHint("你获得了SCP1853");
                        ev.Item.Destroy();
                    }
                    if (a > 57 && a <= 58)
                    {
                        ev.Player.AddItem(ItemType.AntiSCP207);
                        ev.Player.ShowHint("你获得了AntiSCP207");
                        ev.Item.Destroy();
                    }
                    if (a > 59 && a <= 70)
                    {
                        ev.Player.AddItem(ItemType.Flashlight);
                        ev.Player.ShowHint("你获得了手电筒");
                        ev.Item.Destroy();
                    }
                    if (a > 71 && a <= 80)
                    {
                        ev.Player.AddAhp(50);
                        ev.Player.ShowHint("你得到了50AHP");
                        ev.Item.Destroy();
                    }
                    if (a > 81 && a <= 90)
                    {
                        ev.Player.Teleport(DoorType.EscapeSecondary);
                        ev.Player.ShowHint("免费送你到逃生点");
                        ev.Item.Destroy();
                    }
                    if (a > 91 && a <= 100)
                    {
                        ev.Player.Kill(Exiled.API.Enums.DamageType.Tesla);
                        ev.Player.ShowHint("你获得了<COLOR=RED>杨永信治网瘾套餐</COLOR>");
                        ev.Item.Destroy();
                    }
                    if (a > 101 && a <= 111)
                    {
                        ev.Player.AddItem(ItemType.Medkit);
                        ev.Player.ShowHint("你获得了药包"); }
                    if (a > 112 && a <= 130)
                        {
                          
                            if (ev.Player.MaxHealth >= 125)
                            {
                                ev.Player.ShowHint("你不能重复获得血量上限,重新抽取吧牢底");
                                ev.Player.AddItem(ItemType.Coin);
                                
                            }
                            else if (100 <= ev.Player.MaxHealth)
                            {
                                ev.Player.ShowHint("你获得了50AHP和增加25HP血量上限");
                                ev.Player.AddAhp(50);
                                ev.Player.Health += 25;
                                ev.Player.MaxHealth += 25;
                                ev.Item.Destroy();
                            }
                            
                        }
                        
                    }
                }
            }
        }
    }




