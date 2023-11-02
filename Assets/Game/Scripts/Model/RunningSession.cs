using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game
{
	/// <summary>
	/// This class is a core update loop for the runner gameplay.<br/>
	/// Also, it provides easy access to some objects for the factories.
	/// </summary>
	public class RunningSession
	{
		private readonly ICharacter _character;
		private readonly IEnumerable<IJobRunner> _jobRunners;

		public RunningSession(ICharacter character, IEnumerable<IJobRunner> jobRunners)
		{
			_character = character;
			_jobRunners = jobRunners.ToArray();
		}
		
		public void Update()
		{
			_character.Update();
			foreach (var jobRunner in _jobRunners)
				jobRunner.Update();
		}
	}
}