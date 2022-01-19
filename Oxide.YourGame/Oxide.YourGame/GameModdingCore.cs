using Oxide.Core;
using Oxide.Core.Plugins;

namespace Oxide.YourGame {
    public class GameModdingCore : CSPlugin {
        public GameModdingCore() {
            Title = "FusionModding";
            Author = "";
            Version = new VersionNumber(0, 0, 1);
            
            RemoteLogger.SetTag("game", "Game Name");
            RemoteLogger.SetTag("game version", Version.ToString());
        }

        [HookMethod("OnPlayerJoined")]
        private void OnPlayerJoined() {
            RemoteLogger.Info("Player has joined!");
        }
    }
}