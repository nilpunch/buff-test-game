namespace Game
{
	public class MovementChangeAfterDuration : TimerJob
	{
		private readonly ICharacter _character;
		private readonly IMovementMode _movementMode;
		
		public MovementChangeAfterDuration(ICharacter character, IMovementMode movementMode, float duration) : base(duration)
		{
			_character = character;
			_movementMode = movementMode;
		}

		protected override void OnTerminated()
		{
			_character.MovementMode = _movementMode;
		}
	}
}