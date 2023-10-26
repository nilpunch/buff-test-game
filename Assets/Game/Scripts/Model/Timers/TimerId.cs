using System;
using UnityEditor;

namespace Game
{
	public readonly struct TimerId : IEquatable<TimerId>
	{
		public TimerId(int value)
		{
			Value = value;
		}

		public int Value { get; }

		public static TimerId Unique()
		{
			return new TimerId(GUID.Generate().GetHashCode());
		}

		public bool Equals(TimerId other)
		{
			return Value == other.Value;
		}

		public override bool Equals(object obj)
		{
			return obj is TimerId other && Equals(other);
		}

		public override int GetHashCode()
		{
			return Value;
		}
	}
}