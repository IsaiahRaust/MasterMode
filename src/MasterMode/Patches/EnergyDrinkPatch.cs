using HarmonyLib;
using Peak.Afflictions;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.TextCore.Text;
using static Zorro.ControllerSupport.Rumble.RumbleClip;

namespace MasterMode.Patches
{
    [HarmonyPatch(typeof(Affliction_FasterBoi))]
    internal class EnergyDrinkPatch
    {

        [HarmonyPatch(nameof(Affliction_FasterBoi.UpdateEffect))]
        [HarmonyPrefix]
        private static void EnergydrinkPatch(Affliction_FasterBoi __instance)
        {



        }
    }
}


