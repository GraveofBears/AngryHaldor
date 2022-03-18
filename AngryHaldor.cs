using BepInEx;
using ItemManager;
using UnityEngine;
using CreatureManager;
using ServerSync;
using HarmonyLib;


namespace AngryHaldor
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	public class AngryHaldor : BaseUnityPlugin
	{
		private const string ModName = "AngryHaldor";
		private const string ModVersion = "0.0.1";
		private const string ModGUID = "org.bepinex.plugins.angryhaldor";

		public void Awake()

		{				

			Creature AngryHaldor = new("angryhaldor", "AngryHaldor")            //add creature
			{
				Biome = Heightmap.Biome.BlackForest,
				CanSpawn = true,
				CanBeTamed = false,
				FoodItems = "Coins",
				SpawnChance = 15,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 300,
				RequiredWeather = Weather.ClearSkies,
				SpecificSpawnTime = SpawnTime.Night,
				Maximum = 1
			};
			AngryHaldor.Drops["Amber"].Amount = new Range(1, 2);
			AngryHaldor.Drops["Amber"].DropChance = 100f;
			AngryHaldor.Drops["Ruby"].Amount = new Range(1, 2);
			AngryHaldor.Drops["Ruby"].DropChance = 10f;
			AngryHaldor.Drops["Coins"].Amount = new Range(10, 20);
			AngryHaldor.Drops["Coins"].DropChance = 100f;


		}
	}		
	
}