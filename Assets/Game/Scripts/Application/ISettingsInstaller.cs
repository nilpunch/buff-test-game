using Reflex.Core;

namespace Game
{
	public interface ISettingsInstaller
	{
		void BindSettings(ContainerDescriptor descriptor);
	}
}