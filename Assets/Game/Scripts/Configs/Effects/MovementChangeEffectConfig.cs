using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class MovementChangeEffectConfig : EffectConfig
	{
		[SerializeField] private MovementModeConfig _movementModeConfig;
		[SerializeField] private float _duration;
		
		public override IEffect CreateEffect(RunningSession runningSession)
		{
			return new MovementChangeEffect(runningSession.Character, runningSession.MovementModeChangeJobs,
				_movementModeConfig.CreateMovementMode(runningSession.CharacterController), _duration);
		}
	}
}