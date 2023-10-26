namespace Game
{
	public class SpeedChangeEffect : IEffect
	{
		private readonly ICharacter _character;
		private readonly Timers _timers;
		private readonly float _speedChange;
		private readonly float _duration;

		public SpeedChangeEffect(ICharacter character, Timers timers, float speedChange, float duration)
		{
			_character = character;
			_timers = timers;
			_speedChange = speedChange;
			_duration = duration;
		}

		public void Apply()
		{
			// Apply speed change
			_character.Speed.Value += _speedChange;
			
			// Add the timer to apply opposite (negative) speed change
			_timers.Add(new ChangeSpeedTimer(_character, -_speedChange, _duration));
		}
	}
}