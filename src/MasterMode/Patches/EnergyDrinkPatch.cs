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

        private static bool boostLocked = false;

        [HarmonyPatch(nameof(Affliction_FasterBoi.UpdateEffect))]
        [HarmonyPrefix]
        private static void EnergydrinkPatch(Affliction_FasterBoi __instance)
        {


            var character = __instance.character;


            if (character == null)
                return;

            if (!character.IsLocal)
                return;


            if (Input.GetKeyDown(KeyCode.U))
            {
                boostLocked = !boostLocked;
            }


            if (boostLocked)
            {
                __instance.totalTime = float.MaxValue;
            }
            else
            {
                __instance.totalTime = 0f;

            }


        }
    }
}


