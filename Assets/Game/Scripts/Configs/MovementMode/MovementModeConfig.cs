using Reflex.Core;
using UnityEngine;

namespace Game
{
	public abstract class MovementModeConfig : ScriptableObject, IInstaller
	{
		public abstract void InstallBindings(ContainerDescriptor descriptor);
	}
}