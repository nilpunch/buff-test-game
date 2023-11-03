using Reflex.Core;
using UnityEngine;

namespace Game
{
	public class ApplicationInstaller : MonoBehaviour, IInstaller
	{
		[SerializeField] private CharacterController _characterController;
		[SerializeField] private CharacterConfig _characterConfig;
		
		public void InstallBindings(ContainerDescriptor descriptor)
		{
			descriptor.AddInstance(_characterController);

			_characterConfig.InstallBindings(descriptor);

			descriptor.AddSingleton(typeof(CommonJobs), typeof(CommonJobs), typeof(IJobRunner));
			descriptor.AddSingleton(typeof(MovementModeChangeJobs), typeof(MovementModeChangeJobs), typeof(IJobRunner));
			descriptor.AddSingleton(typeof(RunningSession));
		}
	}
}