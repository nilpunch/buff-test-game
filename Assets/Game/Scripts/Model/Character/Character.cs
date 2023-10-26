using System.Collections;
using System.Collections.Generic;

namespace Game
{
    public class Character : ICharacter
    {
        public Stat Speed { get; }
        
        public IMovementMode MovementMode { get; set; }

        public Character(float speed, IMovementMode movementMode)
        {
            MovementMode = movementMode;
            Speed = new Stat(speed);
        }
    }
}
