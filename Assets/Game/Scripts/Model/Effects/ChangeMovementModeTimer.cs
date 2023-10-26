namespace Game
{
	public class ChangeMovementModeTimer : TimerBase
	{
		private readonly ICharacter _character;
		private readonly IMovementMode _movementMode;
		
		public ChangeMovementModeTimer(ICharacter character, IMovementMode movementMode, float duration) : base(duration)
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