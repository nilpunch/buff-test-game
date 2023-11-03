using Reflex.Core;
using UnityEngine;

namespace Game
{
	public abstract class EffectConfig : ScriptableObject, IInstaller
	{
		public abstract void InstallBindings(ContainerDescriptor descriptor);
	}
}