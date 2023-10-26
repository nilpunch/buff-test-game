using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class FlyMovementModeConfig : MovementModeConfig
	{
		public override IMovementMode CreateMovementMode(CharacterController characterController)
		{
			return new FlyMovement(characterController);
		}
	}
}