using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game
{
	public class Application : MonoBehaviour
	{
		[SerializeField] private PickUpConfig[] _pickUpConfigs;
		
		[Header("Character Settings")]
		[SerializeField] private CharacterController _characterPrefab;
		[SerializeField] private MovementModeConfig _characterInitialMovementConfig;
		[SerializeField] private float _characterInitialSpeed;
		
		private Run _run;

		private void Awake()
		{
			CharacterController characterController = Instantiate(_characterPrefab);

			var initialMovement = _characterInitialMovementConfig.CreateMovementMode(characterController);

			_run = new Run(
				new Character(_characterInitialSpeed, initialMovement),
				new Timers(),
				characterController);

			List<PickUpFactory> pickupFactories = _pickUpConfigs
				.Select(pickUpConfig => pickUpConfig.CreatePickUpFactory(_run))
				.ToList();

			// Need to put this in some level generator
			foreach (var pickUpFactory in pickupFactories)
			{
				pickUpFactory.Create();
			}
		}

		private void Update()
		{
			_run.Update();
		}
	}
}