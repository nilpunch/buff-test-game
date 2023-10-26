namespace Game
{
	public interface ICharacter
	{
        Stat Speed { get; }

        IMovementMode MovementMode { get; set; }

        void Update();
	}
}