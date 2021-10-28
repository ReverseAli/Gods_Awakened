using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace GodMod.Items
{
	public class Sizzler : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Tremmor"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Used By The GOD Logan Who Has Moved Forwards In His Quest");
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(12, 28);
			

			item.damage = 195;
			item.ranged = true;
			item.useTime = 1;
			item.useAnimation = 5;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 6;
			item.crit = 55;
			item.value = 10001;
			item.rare = 4;
			item.UseSound = SoundID.Item10;
			item.autoReuse = true;
			item.noMelee = true;

			item.shoot = 14;
			item.shootSpeed = 25.25f;
			item.useAmmo = 97;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.Meowmere, 2);
			recipe.AddIngredient(ItemID.LastPrism, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}