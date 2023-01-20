using HarmonyLib;
using NeosModLoader;
using FrooxEngine.CommonAvatar;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Linq;
using System.Reflection;

namespace iTrackerFix
{
    public class iTrackerFix : NeosMod
    {
        public override string Name => "iTrackerFix";
        public override string Author => "DoubleStyx";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/DoubleStyx/iTrackerFix";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("net.DoubleStyx.iTrackerFix");
            harmony.PatchAll();
        }

        
        [HarmonyPatch]
        public static class EyeManager_OnCommonUpdate
        {

            [HarmonyPatch(typeof(EyeManager), "OnCommonUpdate")]
            [HarmonyTranspiler]
            public static IEnumerable<CodeInstruction> OnAttach_Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                var codes = instructions.ToList();
                int index = codes.FindLastIndex(x => x.opcode == OpCodes.Call && ((MethodInfo)x.operand).Name == "get_HasValue");

                codes[index+1].opcode = OpCodes.Br;

                codes.Insert(index+1, new CodeInstruction(OpCodes.Pop));
                return codes.AsEnumerable();
            }
        }
    }
}
//         ****     **                          *******                             **                        
//        /**/**   /**                         /**////**                           /**                        
//        /**//**  /**  *****   ******   ******/**   /**   *****   ******  ******  /** **    **  *****  ******
//        /** //** /** **///** **////** **//// /*******   **///** **////  **////** /**/**   /** **///**//**//*
//        /**  //**/**/*******/**   /**//***** /**///**  /*******//***** /**   /** /**//** /** /******* /** / 
//        /**   //****/**//// /**   /** /////**/**  //** /**////  /////**/**   /** /** //****  /**////  /**   
//        /**    //***//******//******  ****** /**   //**//****** ****** //******  ***  //**   //******/***   
//        //      ///  //////  //////  //////  //     //  ////// //////   //////  ///    //     ////// ///    
// Hey guys check out this c00l html 6.7 surround sound website called NEOSResolver ඞ