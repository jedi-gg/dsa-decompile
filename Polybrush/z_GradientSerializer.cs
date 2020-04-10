using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Polybrush
{
	public static class z_GradientSerializer
	{
		[Address(RVA="0x126E4D0", Offset="0x126E4D0", VA="0x126E4D0")]
		public static bool Deserialize(string str, out Gradient gradient)
		{
			gradient = null;
			return new bool();
		}

		[Address(RVA="0x126E194", Offset="0x126E194", VA="0x126E194")]
		public static string Serialize(Gradient gradient)
		{
			return null;
		}

		[Address(RVA="0x126EA14", Offset="0x126EA14", VA="0x126EA14")]
		private static bool TryParseColor(string str, out Color value)
		{
			value = new Color();
			return new bool();
		}
	}
}