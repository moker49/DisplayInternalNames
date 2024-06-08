using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Xna.Framework;
using Terraria.Graphics;

public class ItemCodeTooltipGlobalItem : GlobalItem
{
    private static Color cyan = new(100, 200, 230);

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        // Get the full item type name, which includes the namespace and class name
        string itemTypeName = item.ModItem != null ? item.ModItem.GetType().FullName : "Terraria.ItemID." + item.type;

        // Create a new tooltip line
        TooltipLine line = new(Mod, "ItemCode", itemTypeName);

        // Make the line cyan
        line.OverrideColor = cyan;

        // Add the tooltip line to the tooltips list
        tooltips.Add(line);
    }
}
