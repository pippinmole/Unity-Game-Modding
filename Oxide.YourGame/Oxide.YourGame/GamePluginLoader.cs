using System;
using Oxide.Core.Plugins;

namespace Oxide.YourGame {
    public class GamePluginLoader : PluginLoader {
        public override Type[] CorePlugins => new[] {
            typeof(GameModdingCore)
        };
    }
}