using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinAndLeftInfo
{
    public class MainClass
    {
        [PluginEntryPoint("JoinAndLeftInfo","1.0.0","Show player join and left info in localadmin","XLittleleft")]
        void OnLoad()
        {
            if (!Config.IsEnabled) return;
            EventManager.RegisterEvents(this);
        }

        [PluginEvent(ServerEventType.PlayerJoined)]
        void OnPlayerJoined(Player player)
        {
            if (Config.PlayerJoinedInfo)
            Log.Info($"{player.Nickname} Has Joined Server,Server Player Count: {Server.PlayerCount + 1}");
        }

        [PluginEvent(ServerEventType.PlayerLeft)]
        void OnPlayerLeft(Player player)
        {
            if (Config.PlayerLeftInfo)
            Log.Info($"{player.Nickname} Has Left Server,Server Remaining Player Count: {Server.PlayerCount - 1}");
        }

        [PluginConfig]
        public Config Config;
    }
}
