namespace Game
{
	public class SpeedChangeTimer : TimerJob
	{
		private readonly ICharacter _character;
		private readonly float _deltaSpeed;

		public SpeedChangeTimer(ICharacter character, float deltaSpeed, float duration) : base(duration)
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