using Terraria.ModLoader;
using TigerForceLocalizationLib;

namespace UsefulAndHelpfulCN
{
    public class UsefulAndHelpfulCN : Mod
    {
        public override void PostSetupContent()
        {
            if (ModLoader.HasMod("UsefulNPCs"))
            {
                TigerForceLocalizationHelper.LocalizeAll(nameof(UsefulAndHelpfulCN), "UsefulNPCs");
            }
            // if (ModLoader.HasMod("HelpfulNPCs"))
            // {
            //     TigerForceLocalizationHelper.LocalizeAll(nameof(UsefulAndHelpfulCN), "HelpfulNPCs");
            // }
        }
    }
}
