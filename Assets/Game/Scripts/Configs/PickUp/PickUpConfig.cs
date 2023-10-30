using Reflex.Core;
using Reflex.Extensions;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class PickUpConfig : ScriptableObject, ISettingsInstaller
	{
		[field: SerializeField] public PickUp Prefab { get; private set; }
		
		[SerializeField] private EffectConfig _effect;

		public void BindSettings(ContainerDescriptor descriptor)
		{
			_effect.BindSettings(descriptor);
		}
	}
}