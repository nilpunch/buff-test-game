using UnityEngine;

namespace Game
{
	public class PickUp : MonoBehaviour
	{
		private IEffect _effect;

		public void Construct(IEffect effect)
		{
			_effect = effect;
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other.TryGetComponent<Character>(out _))
			{
				_effect.Apply();
			}
		}
	}
}