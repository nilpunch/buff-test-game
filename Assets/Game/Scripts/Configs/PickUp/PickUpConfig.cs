using Reflex.Core;
using Reflex.Extensions;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class PickUpConfig : ScriptableObject, IInstaller
	{
		[field: SerializeField] public PickUp Prefab { get; private set; }
		
		[SerializeField] private EffectConfig _effect;

		public void InstallBindings(ContainerDescriptor descriptor)
		{
			_effect.InstallBindings(descriptor);
		}
	}
}