using UnityEngine;

namespace Game
{
	public class PickUpFactory
	{
		private readonly GameObject _pickUpPrefab;
		private readonly IEffect _effect;

		public PickUpFactory(GameObject pickUpPrefab, IEffect effect)
		{
			_pickUpPrefab = pickUpPrefab;
			_effect = effect;
		}
		
		public PickUp Create()
		{
			var pickUpObject = Object.Instantiate(_pickUpPrefab);

			var pickUp = pickUpObject.GetComponentInChildren<PickUp>();
			pickUp.Construct(_effect);
			
			return pickUp;
		}
	}
}