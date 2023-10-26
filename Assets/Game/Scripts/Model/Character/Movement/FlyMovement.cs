using UnityEngine;

namespace Game
{
	public class FlyMovement : IMovementMode
	{
		private readonly CharacterController _characterController;

		public FlyMovement(CharacterController characterController)
		{
			_characterController = characterController;
		}
		
		public void ProcessMovement()
		{
		}
	}
}