namespace Game
{
	/// <summary>
	/// Update loop for some time-based thing.
	/// </summary>
	public interface ITimer
	{
		float ElapsedTime { get; }
		float RemainingTime { get; }
		
		bool Terminated { get; }
		void Update();
		void Terminate();
	}
}