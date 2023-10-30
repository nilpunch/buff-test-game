using Reflex.Core;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class CharacterConfig : ScriptableObject, ISettingsInstaller
	{
		[SerializeField] private MovementModeConfig _initialMovementConfig;
		[SerializeField] private float _initialSpeed;
		
		public void BindSettings(ContainerDescriptor descriptor)
		{
			_initialMovementConfig.BindSettings(descriptor);
			descriptor.AddInstance(new Character.Args(_initialSpeed));
			descriptor.AddSingleton(typeof(Character), typeof(ICharacter));
		}
	}
}