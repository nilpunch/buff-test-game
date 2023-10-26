using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class SpeedChangeEffectConfig : EffectConfig
	{
		[SerializeField] private float _speedDelta = 5f;
		[SerializeField] private float _duration = 5f;
		
		public override IEffect CreateEffect(Run run)
		{
			return new SpeedChangeEffect(run.Character, run.Timers, _speedDelta, _duration);
		}
	}
}