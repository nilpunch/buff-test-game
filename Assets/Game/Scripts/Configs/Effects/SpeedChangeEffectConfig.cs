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
			var argsScope = new ContainerDescriptor(nameof(SpeedChangeEffect.Args));
			
			descriptor.AddSingletonExtend(nameof(SpeedChangeEffectConfig), scopeDescriptor =>
			{
				scopeDescriptor.AddInstance(new SpeedChangeEffect.Args(_speedDelta, _duration));
			}, typeof(SpeedChangeEffect), typeof(IEffect));
		}
	}
}