using System;
using System.Collections.Generic;

namespace Game
{
	/// <summary>
	/// Update loop for all timers.
	/// </summary>
	public class Timers
	{
		private readonly List<ITimer> _timers = new List<ITimer>();
		private readonly Dictionary<TimerId, ITimer> _signedTimers = new Dictionary<TimerId, ITimer>();

		private readonly List<TimerId> _bufferForRemoves = new List<TimerId>();

		public void Add(ITimer timer)
		{
			_timers.Add(timer);
		}

		public void AddUnique(TimerId timerId, ITimer timer)
		{
			_signedTimers.Add(timerId, timer);
		}

		public void Terminate(TimerId timerId)
		{
			if (_signedTimers.TryGetValue(timerId, out var oldTimer))
			{
				oldTimer.Terminate();
				_signedTimers.Remove(timerId);
			}
		}

		public bool Exists(TimerId timerId)
		{
			return _signedTimers.ContainsKey(timerId);
		}
		
		public ITimer Find(TimerId timerId)
		{
			return _signedTimers[timerId];
		}

		public void Update()
		{
			// Update and clean simple timers
			foreach (var timer in _timers)
			{
				timer.Update();
			}
			_timers.RemoveAll(timer => timer.Terminated);

			// Update and clean unique timers
			foreach (var (timerId, timer) in _signedTimers)
			{
				timer.Update();
				if (timer.Terminated)
				{
					_bufferForRemoves.Add(timerId);
				}
			}
			foreach (var timerId in _bufferForRemoves)
			{
				_signedTimers.Remove(timerId);
			}
			_bufferForRemoves.Clear();
		}
	}
}