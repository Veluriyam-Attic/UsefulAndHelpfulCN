using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using TigerForceLocalizationLib;
using TigerForceLocalizationLib.Filters;

namespace UsefulAndHelpfulCN
{
    public class HelpfulNPCs : ModSystem
    {
        public override void PostSetupContent()
        {
            if (ModLoader.HasMod("HelpfulNPCs"))
            {
                TigerForceLocalizationHelper.LocalizeAll("UsefulAnHelpfCN", "HelpfulNPCs", true, filters: new()
                {
                    MethodFilter = MethodFilter.CommonMethodFilter,
                    CursorFilter = ILCursorFilter.CommonCursorFilter,
                });
            }
        }
    }

    public class UsefulNPCs : ModSystem
    {
        public override void PostSetupContent()
        {
            if (ModLoader.HasMod("UsefulNPCs"))
            {
                TigerForceLocalizationHelper.LocalizeAll("UsefulAnHelpfCN", "UsefulNPCs", true, filters: new()
                {
                    MethodFilter = MethodFilter.CommonMethodFilter,
                    CursorFilter = ILCursorFilter.CommonCursorFilter,
                });
            }
        }
    }
}
