using UnityEngine;

namespace Game
{
	public class PickUpFactory
	{
		private readonly PickUp _pickUpPrefab;
		private readonly IEffect _effect;

		public PickUpFactory(PickUp pickUpPrefab, IEffect effect)
		{
			_pickUpPrefab = pickUpPrefab;
			_effect = effect;
		}
		
		public PickUp Create()
		{
			var pickUp = Object.Instantiate(_pickUpPrefab);
			pickUp.Construct(_effect);
			return pickUp;
		}
	}
}