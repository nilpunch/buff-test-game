using Reflex.Core;
using UnityEngine;

namespace Game
{
	public class Generator
	{
		private readonly PrefabFactory<PickUp> _pickUpFactory;
		private readonly LevelConfig _levelConfig;

		public Generator(PrefabFactory<PickUp> pickUpFactory, LevelConfig levelConfig)
		{
			_pickUpFactory = pickUpFactory;
			_levelConfig = levelConfig;
		}

		public void Generate()
		{
			for (int i = 0; i < 3; i++)
			{
				foreach (var levelPickUp in _levelConfig.PickUps)
				{
					var element = _pickUpFactory.Create(levelPickUp.PickUpConfig.Prefab, levelPickUp.PickUpConfig);
					Vector2 randomPosition = Random.insideUnitCircle.normalized;
					element.transform.position = new Vector3(randomPosition.x, 0f, randomPosition.y) * 5f;
				}
			}
		}
	}
}