using UnityEngine;

namespace Game
{
	/// <summary>
	/// This class is a core update loop for the running session.<br/>
	/// Also, it provides easy access to some objects for the factories.
	/// </summary>
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
			Character.Update();
			Timers.Update();
		}
	}
}