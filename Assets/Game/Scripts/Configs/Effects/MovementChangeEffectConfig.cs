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
			descriptor.AddSingletonExtend(nameof(MovementChangeEffectConfig), scopeDescriptor =>
			{
				_movementModeConfig.BindSettings(scopeDescriptor);
				scopeDescriptor.AddInstance(new MovementChangeEffect.Args(_duration));
			}, typeof(MovementChangeEffect), typeof(IEffect));
		}
	}
}