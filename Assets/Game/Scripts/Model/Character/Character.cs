namespace Game
{
    public class Character : ICharacter
    {
        public record Args(float Speed)
        {
            public float Speed { get; } = Speed;
        }

        public Character(IMovementMode movementMode, Args args)
        {
            MovementMode = movementMode;
            Speed = new Stat(args.Speed);
        }

        public Stat Speed { get; }

        public IMovementMode MovementMode { get; set; }

        public void Update()
        {
            MovementMode.ProcessMovement();
        }
    }
}
