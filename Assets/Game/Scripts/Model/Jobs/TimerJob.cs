using UnityEngine;

namespace Game
{
	/// <summary>
	/// Code reuse for time-based jobs.
	/// </summary>
	public abstract class TimerJob : IJob
	{
		private readonly float _startTime;
		
		protected TimerJob(float duration)
		{
			Duration = duration;
			_startTime = Time.time;
		}

		public float Duration { get; }
		
		public float ElapsedTime => Time.time - _startTime;

		public float RemainingTime => Duration - ElapsedTime;

		public bool Terminated { get; private set; }
		
		public void Update()
		{
			if (Terminated)
				return;

			OnTick();
			
			if (RemainingTime <= 0f)
				Terminate();
		}

		public void Terminate()
		{
			if (Terminated)
				return;
			
			Terminated = true;
			OnTerminated();
		}

		protected virtual void OnTick() {}

		/// <summary>
		/// Will be executed only once.
		/// </summary>
		protected virtual void OnTerminated() {}
	}
}