namespace Game
{
	/// <summary>
	/// Highest point of interaction with effect system.
	/// </summary>
	public interface IEffect
	{
		/// <summary>
		/// Apply any effect. Effect can be applied many times.
		/// </summary>
		void Apply();
	}
}