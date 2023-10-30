namespace Game
{
	public class MovementChangeEffect : IEffect
	{
		public record Args(float Duration)
		{
			public float Duration { get; } = Duration;
		}
		
		private readonly ICharacter _character;
		private readonly MovementModeChangeJobs _jobs;
		private readonly IMovementMode _movementMode;
		private readonly float _duration;
		
		public MovementChangeEffect(ICharacter character, MovementModeChangeJobs jobs, IMovementMode movementMode, Args args)
		{
			_character = character;
			_jobs = jobs;
			_movementMode = movementMode;
			_duration = args.Duration;
		}

		public void Apply()
		{
			// This will terminate any (if exists) movement mode change timers.
			// Termination will guaranteed to return movement mode to its original state.
			_jobs.TerminateAll();

			// Now save original movement mode state.
			var originalMovementMove = _character.MovementMode;

			// Change character movement mode to a new one.
			_character.MovementMode = _movementMode;
			
			// And finally create a timer, that will return character movement mode to its original state.
			_jobs.Run(new MovementChangeTimer(_character, originalMovementMove, _duration));
		}
	}
}