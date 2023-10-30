using Reflex.Core;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class MovementChangeEffectConfig : EffectConfig
	{
		[SerializeField] private MovementModeConfig _movementModeConfig;
		[SerializeField] private float _duration;
		
		public override void BindSettings(ContainerDescriptor descriptor)
		{
			_movementModeConfig.BindSettings(descriptor);
			descriptor.AddInstance(new MovementChangeEffect.Args(_duration));
			descriptor.AddSingleton(typeof(MovementChangeEffect), typeof(IEffect));
		}
	}
}