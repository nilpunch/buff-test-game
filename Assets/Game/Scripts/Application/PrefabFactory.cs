using Reflex.Core;
using Reflex.Extensions;
using UnityEngine;

namespace Game
{
	public class PrefabFactory<TCreation> where TCreation : Component
	{
		private readonly Container _container;
		
		public PrefabFactory(Container container)
		{
			_container = container;
		}

		public TCreation Create(TCreation prefab, ISettingsInstaller settingsInstaller)
		{
			using var scope = _container.Scope(GetType().Name, settingsInstaller.BindSettings);
			
			
			
			return scope.Instantiate(prefab);
		}
	}
}