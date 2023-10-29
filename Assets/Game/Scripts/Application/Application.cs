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
		
		private RunningSession _runningSession;

		private void Awake()
		{
			var characterController = Instantiate(_characterPrefab);

			var initialMovement = _characterInitialMovementConfig.CreateMovementMode(characterController);

			_runningSession = new RunningSession(new Character(_characterInitialSpeed, initialMovement), characterController);

			var pickupFactories = _pickUpConfigs
				.Select(pickUpConfig => pickUpConfig.CreatePickUpFactory(_runningSession))
				.ToList();

			// Need to put this in some level generator
			foreach (var pickUpFactory in pickupFactories)
			{
				pickUpFactory.Create();
			}
		}

		private void Update()
		{
			_runningSession.Update();
		}
	}
}