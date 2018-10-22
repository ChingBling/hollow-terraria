using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items.Weapons
{
	public class KingsSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kingsmould Sword");
			Tooltip.SetDefault("pain");
		}
		public override void SetDefaults()
		{
			
			item.width = 25;
			item.height = 25;
			item.value = 10000;
			item.rare = 7;
			item.damage = 50;
			item.useTime = 13;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; 
			item.crit = 10;
			item.useTurn = true;
			
		}
		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
