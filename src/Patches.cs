using Harmony;

namespace SilentAurora
{
    [HarmonyPatch(typeof(AuroraManager), "UpdateAuroraAudio")]
    internal class AuroraManager_UpdateAuroraAudio
    {
        internal static bool Prefix()
        {
            return false;
        }
    }
}