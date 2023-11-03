using Reflex.Core;
using Reflex.Extensions;
using UnityEngine;

namespace Game
{
	public class ConfiguredPrefabFactory<TCreation> : IFactory<TCreation> where TCreation : Component
	{
		private readonly TCreation _prefab;
		private readonly Container _container;
		
		public ConfiguredPrefabFactory(Container container, TCreation prefab, IInstaller config)
		{
			_prefab = prefab;
			_container = container.Scope(GetType().Name, config.InstallBindings);
		}

		public TCreation Create()
		{
			return _container.Instantiate(_prefab);
		}
	}
}