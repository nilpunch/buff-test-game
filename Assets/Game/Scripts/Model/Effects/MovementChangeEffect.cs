namespace Game
{
	public class MovementChangeEffect : IEffect
	{
		private readonly ICharacter _character;
		private readonly IJobRunner _jobRunner;
		private readonly IMovementMode _movementMode;
		private readonly float _duration;
		
		public MovementChangeEffect(ICharacter character, IJobRunner jobRunner, IMovementMode movementMode, float duration)
		{
			_character = character;
			_jobRunner = jobRunner;
			_movementMode = movementMode;
			_duration = duration;
		}

		public void Apply()
		{
			// This will terminate any (if exists) movement mode change timers.
			// Termination will guaranteed to return movement mode to its original state.
			_jobRunner.TerminateAll();

			// Now save original movement mode state.
			var originalMovementMove = _character.MovementMode;

			// Change character movement mode to a new one.
			_character.MovementMode = _movementMode;
			
			// And finally create a timer, that will return character movement mode to its original state.
			_jobRunner.Run(new MovementChangeTimer(_character, originalMovementMove, _duration));
		}
	}
}