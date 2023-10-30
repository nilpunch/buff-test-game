using System;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class LevelConfig : ScriptableObject
	{
		[Serializable]
		public struct LevelPickUp
		{
			public PickUpConfig PickUpConfig;
			public float SpawnWeight;
		}
		
		[field: SerializeField] public LevelPickUp[] PickUps { get; private set; }
	}

	public class LevelGenerator
	{
		public LevelGenerator()
		{
			
		}
	}
}