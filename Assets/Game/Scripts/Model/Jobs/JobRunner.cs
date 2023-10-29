using System;
using System.Collections.Generic;

namespace Game
{
	public class JobRunner : IJobRunner
	{
		private readonly List<IJob> _jobs = new List<IJob>();

		public void Run(IJob job)
		{
			_jobs.Add(job);
		}

		public void TerminateAll()
		{
			foreach (var job in _jobs)
				job.Terminate();

			_jobs.Clear();
		}

		public void Update()
		{
			foreach (var job in _jobs)
				job.Update();

			_jobs.RemoveAll(job => job.Terminated);
		}
	}
}