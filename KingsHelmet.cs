using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class KingsHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kingsmould Helmet");
			Tooltip.SetDefault("hat.");
		}
		public override void SetDefaults()
		{
			
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 7;
			item.defense = 20;
			
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
