using Reflex.Core;
using UnityEngine;

namespace Game
{
	public class GeneratorInstaller : MonoBehaviour, IInstaller
	{
		[SerializeField] private LevelConfig _levelConfig;
		
		public void InstallBindings(ContainerDescriptor descriptor)
		{
			descriptor.AddSingletonExtend("GeneratorScope", generatorScope =>
			{
				foreach (var levelConfigPickUp in _levelConfig.PickUps)
				{
					generatorScope.AddSingletonExtend("LevelElementScope", elementScope =>
					{
						elementScope.AddInstance(levelConfigPickUp.PickUpConfig, typeof(IInstaller));
						elementScope.AddInstance(levelConfigPickUp.SpawnWeight);
						elementScope.AddInstance(levelConfigPickUp.PickUpConfig.Prefab);
						elementScope.AddSingleton(typeof(ConfiguredPrefabFactory<PickUp>), typeof(IFactory<PickUp>));
					}, typeof(Generator.Element));
				}
			}, typeof(Generator));
		}
	}
}