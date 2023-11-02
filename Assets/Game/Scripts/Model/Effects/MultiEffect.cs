using System.Collections.Generic;
using System.Linq;

namespace Game
{
	public class MultiEffect : IEffect
	{
		private readonly IEnumerable<IEffect> _effects;

		public MultiEffect(IEnumerable<IEffect> effects)
		{
			_effects = effects.ToArray();
		}
		
		public void Apply()
		{
			foreach (var effect in _effects)
				effect.Apply();
		}
	}
}