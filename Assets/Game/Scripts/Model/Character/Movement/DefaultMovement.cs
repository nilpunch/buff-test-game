using UnityEngine;

namespace Game
{
	public class DefaultMovement : IMovementMode
	{
		private readonly CharacterController _characterController;

		public DefaultMovement(CharacterController characterController)
		{
			_characterController = characterController;
		}
		
		public void ProcessMovement()
		{
		}
	}
}