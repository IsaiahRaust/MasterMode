using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using static UnityEngine.Analytics.IAnalytic;

namespace MasterMode.Patches
{

    [HarmonyPatch(typeof(StaminaBar))]

    internal class StaminaPatch
    {
        [HarmonyPatch(nameof(StaminaBar.Update))]
        [HarmonyPrefix]
        private static void InfiniteStamina()
        {
            if (Character.observedCharacter == null)
            
                return;

            var data = Character.observedCharacter.data;


            data.currentStamina = 1f;

            data.extraStamina = 0f;

            data.sinceUseStamina = 0f;

        }

    }
}


