using Reflex.Core;

namespace Game
{
	public class Factory<TCreation>
	{
		private readonly Container _container;
		
		public Factory(Container container)
		{
			_container = container;
		}

		public TCreation Create(ISettingsInstaller settingsInstaller)
		{
			using var scope = _container.Scope(typeof(Factory<TCreation>).Name, settingsInstaller.BindSettings);
			return scope.Construct<TCreation>();
		}
	}
}