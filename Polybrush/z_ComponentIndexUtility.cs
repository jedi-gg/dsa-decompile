using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Polybrush
{
	public static class z_ComponentIndexUtility
	{
		[FieldOffset(Offset="0x0")]
		public readonly static GUIContent[] ComponentIndexPopupDescriptions;

		[FieldOffset(Offset="0x8")]
		public readonly static int[] ComponentIndexPopupValues;

		[Address(RVA="0x1347B30", Offset="0x1347B30", VA="0x1347B30")]
		static z_ComponentIndexUtility()
		{
		}

		[Address(RVA="0x1345EE0", Offset="0x1345EE0", VA="0x1345EE0")]
		public static string GetString(z_ComponentIndex component, z_ComponentIndexType type = 0)
		{
			return null;
		}

		[Address(RVA="0x1347A68", Offset="0x1347A68", VA="0x1347A68")]
		public static float GetValueAtIndex(Vector3 value, z_ComponentIndex index)
		{
			return new float();
		}

		[Address(RVA="0x1347A94", Offset="0x1347A94", VA="0x1347A94")]
		public static float GetValueAtIndex(Vector4 value, z_ComponentIndex index)
		{
			return new float();
		}

		[Address(RVA="0x1347AD4", Offset="0x1347AD4", VA="0x1347AD4")]
		public static float GetValueAtIndex(Color value, z_ComponentIndex index)
		{
			return new float();
		}

		[Address(RVA="0x1347B14", Offset="0x1347B14", VA="0x1347B14")]
		public static uint ToFlag(z_ComponentIndex e)
		{
			return new uint();
		}
	}
}