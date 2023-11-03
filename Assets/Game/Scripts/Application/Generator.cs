using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Reflex.Core;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Game
{
	public class Generator
	{
		public class Element
		{
			public Element(IFactory<PickUp> factory, float weight)
			{
				Factory = factory;
				Weight = weight;
			}

			public float Weight { get; }
			public IFactory<PickUp> Factory { get; }
		}

		private readonly IEnumerable<Element> _elements;

		public Generator(IEnumerable<Element> elements)
		{
			_elements = elements.ToArray();
		}

		public void Generate()
		{
			for (int i = 0; i < 20; i++)
			{
				foreach (var generationElement in _elements)
				{
					var element = generationElement.Factory.Create();
					Vector2 randomPosition = Random.insideUnitCircle.normalized;
					element.transform.position = new Vector3(randomPosition.x, 0f, randomPosition.y) * 5f;
				}
			}
		}
	}
}