namespace Game
{
	/// <summary>
	/// Custom update loop.
	/// </summary>
	public interface IJob
	{
		bool Terminated { get; }
		void Update();
		void Terminate();
	}
}