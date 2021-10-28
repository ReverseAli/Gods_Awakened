using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace GodMod.Items
{
	public class Plants : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hanging Plants"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Uhm");
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(12, 28);


			item.damage = 17;
			item.ranged = true;
			item.useTime = 25;
			item.useAnimation = 5;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 6;
			item.crit = 7;
			item.value = 10002;
			item.rare = 4;
			item.UseSound = SoundID.Item10;
			item.autoReuse = true;
			item.noMelee = true;

			item.shoot = 95;
			item.shootSpeed = 15.25f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddIngredient(ItemID.Sunflower, 2);
			recipe.AddIngredient(ItemID.IronBar, 6);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}