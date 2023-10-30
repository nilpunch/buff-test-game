namespace Game
{
	public class SpeedChangeEffect : IEffect
	{
		public record Args(float SpeedChange, float Duration)
		{
			public float SpeedChange { get; } = SpeedChange;
			public float Duration { get; } = Duration;
		}
		
		private readonly ICharacter _character;
		private readonly CommonJobs _jobs;
		private readonly float _speedChange;
		private readonly float _duration;

		public SpeedChangeEffect(ICharacter character, CommonJobs jobs, Args args)
		{
			_character = character;
			_jobs = jobs;
			_speedChange = args.SpeedChange;
			_duration = args.Duration;
		}

		public void Apply()
		{
			// Apply speed change to character speed.
			_character.Speed.Value += _speedChange;
			
			// Create a timer, that will apply opposite (negative) speed change.
			_jobs.Run(new SpeedChangeTimer(_character, -_speedChange, _duration));
		}
	}
}