namespace Game
{
	public class MovementChangeEffect : IEffect
	{
		private readonly ICharacter _character;
		private readonly Timers _timers;
		private readonly IMovementMode _flyMovement;
		private readonly float _duration;
		
		// We need to sign all movement change timers with the same TimerId,
		// so they will not conflict with each other.
		private static readonly TimerId s_movementModeTimerId = TimerId.Unique();

		public MovementChangeEffect(ICharacter character, Timers timers, IMovementMode flyMovement, float duration)
		{
			_character = character;
			_timers = timers;
			_flyMovement = flyMovement;
			_duration = duration;
		}

		public void Apply()
		{
			// This will terminate movement mode timer (if exist), and return movement mode to original state.
			_timers.Terminate(s_movementModeTimerId);

			// Now we create a new timer to return movement mode to original state, after the effect duration.
			_timers.AddUnique(s_movementModeTimerId,
				new ChangeMovementModeTimer(_character, _character.MovementMode, _duration));

			// And we change movement mode.
			// We can also do this before adding a new timer, there is no magic and nothing will break,
			// but remember to save the last MovementMode state in temporary variable for the timer.
			_character.MovementMode = _flyMovement;
		}
	}
}