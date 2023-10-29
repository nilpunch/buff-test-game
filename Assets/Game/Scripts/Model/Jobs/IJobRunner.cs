namespace Game
{
	/// <summary>
	/// Update loop for many jobs.
	/// </summary>
	public interface IJobRunner
	{
		void Run(IJob job);
		void Update();
		void TerminateAll();
	}
}