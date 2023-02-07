using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using HarmonyLib.Tools;

namespace IslandBuilding
{
    [BepInPlugin(myGUID,myName,myV)]
    public class Class1 : BaseUnityPlugin
    {
        private const string myGUID = "MJredd.efi.DegasiBGone";
        private const string myName = "DegasiBGone";
        private const string myV = "1.0.0";
        private static readonly Harmony harmony = new Harmony(myGUID);
        public static ManualLogSource logger;
        private void Awake()
        {
            harmony.PatchAll();
            Logger.LogInfo("The Degasi on the floating island have been eradicated!");
            logger = Logger;
        }
    }
}
