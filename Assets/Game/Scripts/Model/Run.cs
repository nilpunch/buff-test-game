using UnityEngine;

namespace Game
{
	public class Run
	{
		public Run(ICharacter character, Timers timers, CharacterController characterController)
		{
			Character = character;
			Timers = timers;
			CharacterController = characterController;
		}

		public ICharacter Character { get; }
		
		public Timers Timers { get; }
		
		public CharacterController CharacterController { get; }

		public void Update()
		{
			Character.MovementMode.ProcessMovement();
			Timers.Tick();
		}
	}
}