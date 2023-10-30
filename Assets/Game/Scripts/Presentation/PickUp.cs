using Reflex.Attributes;
using Reflex.Core;
using UnityEngine;

namespace Game
{
	public class PickUp : MonoBehaviour
	{
		[SerializeField] private GameObject _root;
		
		private IEffect _effect;

		[Inject]
		public void Inject(IEffect effect)
		{
			_effect = effect;
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other.TryGetComponent<CharacterController>(out _))
			{
				_effect.Apply();
				Destroy(_root);
			}
		}
	}
}