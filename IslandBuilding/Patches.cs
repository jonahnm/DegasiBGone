using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using BepInEx.Logging;
using UnityEngine;
using UWE;
using System.Runtime.InteropServices;

namespace IslandBuilding
{
    internal class Patches
    {
        [HarmonyPatch(typeof(ProtobufSerializer))]
        public static class ProtobufSerializer_Patch
        {
            [HarmonyPatch(nameof(ProtobufSerializer.InstantiatePrefabAsync))]
            [HarmonyPrefix]
            public static bool InstanatiatePrefabAsync_Prefix(ProtobufSerializer.GameObjectData gameObjectData) {
                var classId = gameObjectData.ClassId;
                if (classId == "569f22e0-274d-49b0-ae5e-21ef0ce907ca" || classId == "0e394d55-da8c-4b3e-b038-979477ce77c1" || classId == "99b164ac-dfb4-4a14-b305-8666fa227717") return false;
                return true;
            }

        }
    }
}
