namespace Game
{
	/// <summary>
	/// Update loops for some time-based things.
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