using UnityEngine;

namespace Game
{
	public abstract class TimerBase : ITimer
	{
		private readonly float _startTime;
		private readonly float _duration;
		
		protected TimerBase(float duration)
		{
			_duration = duration;
			_startTime = Time.time;
		}

		public float ElapsedTime => Time.time - _startTime;
		
		public float RemainingTime => _startTime + _duration - Time.time;
		
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

		protected virtual void OnTerminated() {}
	}
}