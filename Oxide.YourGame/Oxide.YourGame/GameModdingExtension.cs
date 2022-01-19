using Oxide.Core;
using Oxide.Core.Extensions;
using Oxide.Plugins;

namespace Oxide.YourGame {
    public class GameModdingExtension : Extension {
        
        public GameModdingExtension(ExtensionManager manager) : base(manager) { }

        public override string Name => "Example Game Extension";
        public override string Author => "Creator Name";

        public override VersionNumber Version => new VersionNumber(0, 0, 1);

        public override string[] DefaultReferences => new[] {
            "System.Drawing",
            "UnityEngine.AIModule",
            "UnityEngine.AssetBundleModule",
            "UnityEngine.CoreModule",
            "UnityEngine.GridModule",
            "UnityEngine.ImageConversionModule",
            "UnityEngine.Networking",
            "UnityEngine.PhysicsModule",
            "UnityEngine.TerrainModule",
            "UnityEngine.TerrainPhysicsModule",
            "UnityEngine.UI",
            "UnityEngine.UIModule",
            "UnityEngine.UIElementsModule",
            "UnityEngine.UnityWebRequestAudioModule",
            "UnityEngine.UnityWebRequestModule",
            "UnityEngine.UnityWebRequestTextureModule",
            "UnityEngine.UnityWebRequestWWWModule",
            "UnityEngine.VehiclesModule",
            "UnityEngine.WebModule",
            "netstandard",
            // "Fusion.Common",
            // "Fusion.Runtime",
            // "Fusion.Realtime",
            // "Fusion.Addressables",
            // "Fusion.Sockets",
            "Assembly-CSharp",
            "Assembly-CSharp-firstpass",
        };

        public override string[] WhitelistAssemblies => new[] {
            "Assembly-CSharp",
            "Assembly-CSharp-firstpass",
            "mscorlib",
            "Oxide.Core",
            "Oxide.YourGame",
            "System",
            "System.Core",
            "UnityEngine",
            // "Fusion.Common",
            // "Fusion.Runtime",
            // "Fusion.Realtime",
            // "Fusion.Addressables",
            // "Fusion.Sockets"
        };

        public override string[] WhitelistNamespaces => new[] {
            "Oxide.YourGame",
            "System.Collections",
            "System.Security.Cryptography",
            "System.Text",
            "System.Threading.Monitor",
            "UnityEngine",
            // "Shared",
            // "Server",
            // "Fusion"
        };

        public override void OnModLoad() => CSharpPluginLoader.PluginReferences.UnionWith(DefaultReferences);
    }
}