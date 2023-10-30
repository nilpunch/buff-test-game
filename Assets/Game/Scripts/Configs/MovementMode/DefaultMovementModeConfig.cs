using Reflex.Core;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class DefaultMovementModeConfig : MovementModeConfig
	{
		public override void BindSettings(ContainerDescriptor descriptor)
		{
			descriptor.AddSingleton(typeof(DefaultMovement), typeof(IMovementMode));
		}
	}
}