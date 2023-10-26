using UnityEngine;

namespace Game
{
	public abstract class EffectConfig : ScriptableObject
	{
		public abstract IEffect CreateEffect(Run run);
	}
}