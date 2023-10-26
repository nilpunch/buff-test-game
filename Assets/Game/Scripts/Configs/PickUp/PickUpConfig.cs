using UnityEngine;

namespace Game
{
	[CreateAssetMenu]
	public class PickUpConfig : ScriptableObject
	{
		[SerializeField] private PickUp _prefab;
		[SerializeField] private EffectConfig _effect;

		[field: SerializeField] public float GenerationWeight { get; private set; } = 1f;

		public PickUpFactory CreatePickUpFactory(Run run)
		{
			return new PickUpFactory(_prefab, _effect.CreateEffect(run));
		}
	}
}