using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace GodMod.Items
{
	public class Tremmor : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Tremmor"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Used By The GOD Logan Who Has Moved To Another Realm");
		}

		public override void SetDefaults() 
		{
			item.damage = 280;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

			item.shoot = 9;
			item.shootSpeed = 25.25f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.MonkStaffT3, 10);
			recipe.AddIngredient(ItemID.Meowmere, 2);
			recipe.AddIngredient(ItemID.LastPrism, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}