using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace GodMod.Items
{
	public class TriPlant : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pot O' Fungi"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Uhm x100");
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(40, 40);
			item.width = 100;
			item.height = 100;


			item.damage = 83;
			item.ranged = true;
			item.useTime = 13;
			item.useAnimation = 5;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 6;
			item.crit = 14;
			item.value = 10003;
			item.rare = 4;
			item.UseSound = SoundID.Item10;
			item.autoReuse = true;
			item.noMelee = true;

			item.shoot = 131;
			item.shootSpeed = 90.25f;
		}



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GlowingMushroom, 30);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 6);
			recipe.AddIngredient(ItemID.ClayPot, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}