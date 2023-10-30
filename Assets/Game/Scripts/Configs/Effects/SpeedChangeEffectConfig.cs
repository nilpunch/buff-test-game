using Reflex.Core;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class SpeedChangeEffectConfig : EffectConfig
	{
		[SerializeField] private float _speedDelta = 5f;
		[SerializeField] private float _duration = 5f;

		public override void BindSettings(ContainerDescriptor descriptor)
		{
			descriptor.AddInstance(new SpeedChangeEffect.Args(_speedDelta, _duration));
			descriptor.AddSingleton(typeof(SpeedChangeEffect), typeof(IEffect));
		}
	}
}