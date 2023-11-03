using Reflex.Core;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class MultiEffectConfig : EffectConfig
	{
		[SerializeField] private EffectConfig[] _effectConfigs;
		
		public override void InstallBindings(ContainerDescriptor descriptor)
		{
			descriptor.AddSingletonExtend(nameof(MultiEffectConfig), scopeDescriptor =>
			{
				scopeDescriptor.IgnoreParentBind(typeof(MultiEffect), typeof(IEffect));
				
				foreach (var effectConfig in _effectConfigs)
					effectConfig.InstallBindings(scopeDescriptor);
			}, typeof(MultiEffect), typeof(IEffect));
		}
	}
}