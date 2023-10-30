namespace Game
{
	/// <summary>
	/// Highest point of interaction with effect system.
	/// With this design, one instance of effect can be applied many times.
	/// </summary>
	public interface IEffect
	{
		/// <summary>
		/// Instantly applies some effect.
		/// </summary>
		void Apply();
	}
}