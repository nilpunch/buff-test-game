using Reflex.Core;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class FlyMovementModeConfig : MovementModeConfig
	{
		public override void InstallBindings(ContainerDescriptor descriptor)
		{
			descriptor.AddSingleton(typeof(FlyMovement), typeof(IMovementMode));
		}
	}
}