namespace Game
{
	public class SpeedChangeEffect : IEffect
	{
		private readonly ICharacter _character;
		private readonly IJobRunner _jobRunner;
		private readonly float _speedChange;
		private readonly float _duration;

		public SpeedChangeEffect(ICharacter character, IJobRunner jobRunner, float speedChange, float duration)
		{
			_character = character;
			_jobRunner = jobRunner;
			_speedChange = speedChange;
			_duration = duration;
		}

		public void Apply()
		{
			// Apply speed change to character speed.
			_character.Speed.Value += _speedChange;
			
			// Create a timer, that will apply opposite (negative) speed change.
			_jobRunner.Run(new SpeedChangeTimer(_character, -_speedChange, _duration));
		}
	}
}