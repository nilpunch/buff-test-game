using System;
using Reflex.Core;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class CharacterConfig : ScriptableObject, IInstaller
	{
		[SerializeField] private MovementModeConfig _initialMovementConfig;
		[SerializeField] private float _initialSpeed;

		public void InstallBindings(ContainerDescriptor descriptor)
		{
			descriptor.AddSingletonExtend(nameof(CharacterConfig), scopeDescriptor =>
			{
				_initialMovementConfig.InstallBindings(scopeDescriptor);
				scopeDescriptor.AddInstance(new Character.Args(_initialSpeed));
			}, typeof(Character), typeof(ICharacter));
		}
	}
}