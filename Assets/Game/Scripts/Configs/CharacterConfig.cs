using System;
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
			descriptor.AddSingletonExtend(nameof(CharacterConfig), scopeDescriptor =>
			{
				_initialMovementConfig.BindSettings(scopeDescriptor);
				scopeDescriptor.AddInstance(new Character.Args(_initialSpeed));
			}, typeof(Character), typeof(ICharacter));
		}
	}
}