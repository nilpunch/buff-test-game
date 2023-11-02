using System;
using System.Threading.Tasks;
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

			Fuck();
			
			async void Fuck()
			{
				await Task.Delay(1000);
				generator.Generate();
			}
		}

		private void Update()
		{
			_runningSession.Update();
		}
	}
}