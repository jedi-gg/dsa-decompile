using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Polybrush
{
	public static class z_Util
	{
		[Address(RVA="0x127D484", Offset="0x127D484", VA="0x127D484")]
		public static AnimationCurve ClampAnimationKeys(AnimationCurve curve, float firstKeyTime, float firstKeyValue, float secondKeyTime, float secondKeyValue)
		{
			return null;
		}

		[Address(RVA="0x157AAB8", Offset="0x157AAB8", VA="0x157AAB8")]
		public static T[] Duplicate<T>(T[] array)
		{
			return null;
		}

		[Address(RVA="0x157ACE0", Offset="0x157ACE0", VA="0x157ACE0")]
		public static T[] Fill<T>(T value, int count)
		{
			return null;
		}

		[Address(RVA="0x157AB28", Offset="0x157AB28", VA="0x157AB28")]
		public static T[] Fill<T>(Func<int, T> constructor, int count)
		{
			return null;
		}

		[Address(RVA="0x1353014", Offset="0x1353014", VA="0x1353014")]
		public static Dictionary<T, int> GetCommonLookup<T>(List<List<T>> lists)
		{
			return null;
		}

		[Address(RVA="0x127D9A4", Offset="0x127D9A4", VA="0x127D9A4")]
		public static List<Material> GetMaterials(GameObject gameObject)
		{
			return null;
		}

		[Address(RVA="0x127D7C8", Offset="0x127D7C8", VA="0x127D7C8")]
		public static Mesh GetMesh(GameObject gameObject)
		{
			return null;
		}

		[Address(RVA="0x1271D60", Offset="0x1271D60", VA="0x1271D60")]
		internal static string IncrementPrefix(string prefix, string name)
		{
			return null;
		}

		[Address(RVA="0x1352B64", Offset="0x1352B64", VA="0x1352B64")]
		public static Dictionary<K, V> InitDictionary<K, V>(Func<int, K> keyFunc, Func<int, V> valueFunc, int count)
		{
			return null;
		}

		[Address(RVA="0x1F657B0", Offset="0x1F657B0", VA="0x1F657B0")]
		public static bool IsValid<T>(T target)
		where T : z_IValid
		{
			return new bool();
		}

		[Address(RVA="0x127D2C4", Offset="0x127D2C4", VA="0x127D2C4")]
		public static Color32 Lerp(Color32 lhs, Color32 rhs, z_ColorMask mask, float alpha)
		{
			return new Color32();
		}

		[Address(RVA="0x127D3D0", Offset="0x127D3D0", VA="0x127D3D0")]
		public static Color32 Lerp(Color32 lhs, Color32 rhs, float alpha)
		{
			return new Color32();
		}

		[Address(RVA="0x127D640", Offset="0x127D640", VA="0x127D640")]
		public static Enum Next(Enum value)
		{
			return null;
		}

		[Address(RVA="0x138E850", Offset="0x138E850", VA="0x138E850")]
		public static void Resize<T>(ref T[] array, int newSize)
		{
		}

		[Address(RVA="0x135264C", Offset="0x135264C", VA="0x135264C")]
		public static Dictionary<K, T> SetValuesAsKey<K, T>(Dictionary<T, IEnumerable<K>> dic)
		{
			return null;
		}

		[Address(RVA="0x1352C70", Offset="0x1352C70", VA="0x1352C70")]
		public static Dictionary<T, List<K>> ToDictionary<T, K>(IEnumerable<IGrouping<T, K>> groups)
		{
			return null;
		}

		[Address(RVA="0x199A62C", Offset="0x199A62C", VA="0x199A62C")]
		public static string ToString<T>(IEnumerable<T> enumerable, string delim)
		{
			return null;
		}

		[Address(RVA="0x199A378", Offset="0x199A378", VA="0x199A378")]
		public static string ToString<K, V>(Dictionary<K, V> dictionary, string delim)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E5E8", Offset="0x104E5E8")]
		[Serializable]
		private sealed class <>c__4<T>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static z_Util.<>c__4<T> <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<T, string> <>9__4_0;

			[Address(RVA="0x2193C6C", Offset="0x2193C6C", VA="0x2193C6C")]
			static <>c__4()
			{
			}

			[Address(RVA="0x2193D44", Offset="0x2193D44", VA="0x2193D44")]
			public <>c__4()
			{
			}

			[Address(RVA="0x2193D70", Offset="0x2193D70", VA="0x2193D70")]
			internal string <ToString>b__4_0(T x)
			{
				return null;
			}
		}
	}
}