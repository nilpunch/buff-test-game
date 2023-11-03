using Reflex.Core;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class DefaultMovementModeConfig : MovementModeConfig
	{
		public override void InstallBindings(ContainerDescriptor descriptor)
		{
			descriptor.AddSingleton(typeof(DefaultMovement), typeof(IMovementMode));
		}
	}
}