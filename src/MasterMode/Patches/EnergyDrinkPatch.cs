using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace MasterMode.Patches
{
    [HarmonyPatch(typeof())]
    internal class EnergyDrinkPatch
    {

        [HarmonyPatch(nameof())]
        [HarmonyPrefix]
        private static void ()
        {

        }

    }

}

