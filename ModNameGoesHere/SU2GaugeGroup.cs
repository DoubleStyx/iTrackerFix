using HarmonyLib;
using NeosModLoader;
using FrooxEngine;
using FrooxEngine.CommonAvatar;

namespace SU2GaugeGroup
{
    public class SU2GaugeGroup : NeosMod
    {
        public override string Name => "SU2GaugeGroup";
        public override string Author => "DoubleStyx";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/DoubleStyx/SU2GaugeGroup";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("net.doublestyx.su2gaugegroup");
            harmony.PatchAll();
        }
		
        [HarmonyPatch(typeof(SimpleAvatarProtection), "CanUse")]
        class SimpleAvatarProtection_CanUse_Prefix
        {
            public static bool Prefix(User user)
            {
                return true; //don't run rest of method
            }
        }
    }
}