namespace Game
{
	public class MovementChangeEffect : IEffect
	{
		private readonly ICharacter _character;
		private readonly IJobRunner _jobRunner;
		private readonly IMovementMode _flyMovement;
		private readonly float _duration;
		
		public MovementChangeEffect(ICharacter character, IJobRunner jobRunner, IMovementMode flyMovement, float duration)
		{
			_character = character;
			_jobRunner = jobRunner;
			_flyMovement = flyMovement;
			_duration = duration;
		}

		public void Apply()
		{
			// This will terminate movement mode timer (if exist), and return movement mode to original state.
			_jobRunner.TerminateAll();

			// Now we create a new timer to return movement mode to original state, after the effect duration.
			_jobRunner.Run(new MovementChangeAfterDuration(_character, _character.MovementMode, _duration));

			// And we change movement mode.
			// We can also do this before adding a new timer, there is no magic and nothing will break,
			// but remember to save the last MovementMode state in temporary variable for the timer.
			_character.MovementMode = _flyMovement;
		}
	}
}