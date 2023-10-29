using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class SpeedChangeEffectConfig : EffectConfig
	{
		[SerializeField] private float _speedDelta = 5f;
		[SerializeField] private float _duration = 5f;
		
		public override IEffect CreateEffect(RunningSession runningSession)
		{
			return new SpeedChangeEffect(runningSession.Character, runningSession.CommonJobRunner, _speedDelta, _duration);
		}
	}
}