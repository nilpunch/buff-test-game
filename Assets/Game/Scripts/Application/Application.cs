using System;
using Reflex.Attributes;
using UnityEngine;

namespace Game
{
	public class Application : MonoBehaviour
	{
		private RunningSession _runningSession;

		[Inject]
		public void Inject(Generator generator, RunningSession runningSession)
		{
			_runningSession = runningSession;
			generator.Generate();
		}

		private void Update()
		{
			_runningSession.Update();
		}
	}
}