using UnityEngine;

namespace Game
{
	public abstract class MovementModeConfig : ScriptableObject
	{
		public abstract IMovementMode CreateMovementMode(CharacterController characterController);
	}
}