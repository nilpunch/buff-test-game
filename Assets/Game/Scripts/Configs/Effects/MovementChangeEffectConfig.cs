using Reflex.Core;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class MovementChangeEffectConfig : EffectConfig
	{
		[SerializeField] private MovementModeConfig _movementModeConfig;
		[SerializeField] private float _duration;
		
		public override void InstallBindings(ContainerDescriptor descriptor)
		{
			descriptor.AddSingletonExtend(nameof(MovementChangeEffectConfig), scopeDescriptor =>
			{
				_movementModeConfig.InstallBindings(scopeDescriptor);
				scopeDescriptor.AddInstance(new MovementChangeEffect.Args(_duration));
			}, typeof(MovementChangeEffect), typeof(IEffect));
		}
	}
}