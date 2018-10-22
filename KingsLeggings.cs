using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TestMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class KingsLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kingsmould Leggings");
			Tooltip.SetDefault("leg.");
		}
		public override void SetDefaults()
		{
			
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 7;
			item.defense = 18;
		
		}
		
			public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.12f;
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
