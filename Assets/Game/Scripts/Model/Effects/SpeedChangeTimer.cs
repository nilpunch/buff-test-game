namespace Game
{
	public class ChangeSpeedTimer : TimerBase
	{
		private readonly ICharacter _character;
		private readonly float _deltaSpeed;

		public ChangeSpeedTimer(ICharacter character, float deltaSpeed, float duration) : base(duration)
		{
			_character = character;
			_deltaSpeed = deltaSpeed;
		}

		protected override void OnTerminated()
		{
			_character.Speed.Value += _deltaSpeed;
		}
	}
}