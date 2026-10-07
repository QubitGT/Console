using BepInEx;

namespace Console
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start() => Console.LoadConsole();
    }
}
