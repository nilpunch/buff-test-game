using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class MovementChangeEffectConfig : EffectConfig
	{
		[SerializeField] private MovementModeConfig _movementModeConfig;
		[SerializeField] private float _duration;
		
		public override IEffect CreateEffect(Run run)
		{
			return new MovementChangeEffect(run.Character, run.Timers, _movementModeConfig.CreateMovementMode(run.CharacterController), _duration);
		}
	}
}