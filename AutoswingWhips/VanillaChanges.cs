using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AutoswingWhips
{
    public class AutoswingWhips : Mod
    {
        public class VanillaItemChanges : GlobalItem
        {
            public override void SetDefaults(Item item)
            {
                if (item.type == ItemID.BlandWhip || item.type == ItemID.SwordWhip || item.type == ItemID.ScytheWhip || item.type == ItemID.CoolWhip || item.type == ItemID.FireWhip || item.type == ItemID.ThornWhip || item.type == ItemID.RainbowWhip || item.type == ItemID.BoneWhip) // List of weapons to alter
                {
                    item.autoReuse = true; // Makes listed weapons autoswing
                }
            }
        }
    }
}