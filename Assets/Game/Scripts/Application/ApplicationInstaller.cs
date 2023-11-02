using Reflex.Core;
using UnityEngine;

namespace Game
{
	public class ApplicationInstaller : MonoBehaviour, IInstaller
	{
		[SerializeField] private CharacterController _characterController;
		[SerializeField] private LevelConfig _levelConfig;
		[SerializeField] private CharacterConfig _characterConfig;
		
		public void InstallBindings(ContainerDescriptor descriptor)
		{
			descriptor.AddInstance(_characterController);
			descriptor.AddInstance(_levelConfig);

			_characterConfig.BindSettings(descriptor);

			descriptor.AddSingleton(typeof(CommonJobs), typeof(CommonJobs), typeof(IJobRunner));
			descriptor.AddSingleton(typeof(MovementModeChangeJobs), typeof(MovementModeChangeJobs), typeof(IJobRunner));

			descriptor.AddSingleton(typeof(Generator));
			descriptor.AddSingleton(typeof(RunningSession));
			
			descriptor.AddSingleton(typeof(PrefabFactory<PickUp>));
		}
	}
}