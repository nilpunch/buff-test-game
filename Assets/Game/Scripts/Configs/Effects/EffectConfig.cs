using Reflex.Core;
using UnityEngine;

namespace Game
{
	public abstract class EffectConfig : ScriptableObject, ISettingsInstaller
	{
		public abstract void BindSettings(ContainerDescriptor descriptor);
	}
}