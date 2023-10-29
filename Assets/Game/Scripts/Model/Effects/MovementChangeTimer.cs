namespace Game
{
	public class MovementChangeTimer : TimerJob
	{
		private readonly ICharacter _character;
		private readonly IMovementMode _movementMode;
		
		public MovementChangeTimer(ICharacter character, IMovementMode movementMode, float duration) : base(duration)
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