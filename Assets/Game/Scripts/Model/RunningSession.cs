using UnityEngine;

namespace Game
{
	/// <summary>
	/// This class is a core update loop for the runner gameplay.<br/>
	/// Also, it provides easy access to some objects for the factories.
	/// </summary>
	public class RunningSession
	{
		public RunningSession(ICharacter character, CharacterController characterController)
		{
			CommonJobRunner = new JobRunner();
			MovementModeJobRunner = new JobRunner();
			Character = character;
			CharacterController = characterController;
		}

		public ICharacter Character { get; }
		
		public IJobRunner MovementModeJobRunner { get; }
		
		public IJobRunner CommonJobRunner { get; }
		
		public CharacterController CharacterController { get; }

		public void Update()
		{
			Character.Update();
			CommonJobRunner.Update();
			MovementModeJobRunner.Update();
		}
	}
}