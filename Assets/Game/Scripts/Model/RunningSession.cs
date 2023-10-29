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
			CommonJobs = new JobRunner();
			MovementModeChangeJobs = new JobRunner();
			Character = character;
			CharacterController = characterController;
		}

		public ICharacter Character { get; }
		
		public IJobRunner MovementModeChangeJobs { get; }
		
		public IJobRunner CommonJobs { get; }
		
		public CharacterController CharacterController { get; }

		public void Update()
		{
			Character.Update();
			CommonJobs.Update();
			MovementModeChangeJobs.Update();
		}
	}
}