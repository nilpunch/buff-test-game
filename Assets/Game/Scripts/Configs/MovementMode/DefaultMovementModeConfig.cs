using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class DefaultMovementModeConfig : MovementModeConfig
	{
		public override IMovementMode CreateMovementMode(CharacterController characterController)
		{
			return new DefaultMovement(characterController);
		}
	}
}