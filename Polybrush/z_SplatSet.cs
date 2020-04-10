using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Polybrush
{
	public class z_SplatSet
	{
		[FieldOffset(Offset="0x0")]
		private const float WEIGHT_EPSILON = 0.0001f;

		[FieldOffset(Offset="0x10")]
		private int weightCount;

		[FieldOffset(Offset="0x18")]
		private Dictionary<z_MeshChannel, int> channelMap;

		[FieldOffset(Offset="0x20")]
		private Vector4[][] weights;

		[FieldOffset(Offset="0x28")]
		public z_AttributeLayout[] attributeLayout;

		public int attributeCount
		{
			[Address(RVA="0x1277664", Offset="0x1277664", VA="0x1277664")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x1277690", Offset="0x1277690", VA="0x1277690")]
		public z_SplatSet(int vertexCount, z_AttributeLayout[] attributes, bool preAlloc = true)
		{
		}

		[Address(RVA="0x1277B94", Offset="0x1277B94", VA="0x1277B94")]
		public z_SplatSet(z_SplatSet other)
		{
		}

		[Address(RVA="0x1277FEC", Offset="0x1277FEC", VA="0x1277FEC")]
		public z_SplatSet(z_Mesh mesh, z_AttributeLayout[] attributes)
		{
		}

		[Address(RVA="0x12799F8", Offset="0x12799F8", VA="0x12799F8")]
		public void Apply(z_Mesh mesh)
		{
		}

		[Address(RVA="0x1277F30", Offset="0x1277F30", VA="0x1277F30")]
		private static Vector4 Color32ToVec4(Color32 color)
		{
			return new Vector4();
		}

		[Address(RVA="0x1279884", Offset="0x1279884", VA="0x1279884")]
		public void CopyTo(z_SplatSet other)
		{
		}

		[Address(RVA="0x1278A84", Offset="0x1278A84", VA="0x1278A84")]
		public z_SplatWeight GetMaxWeights()
		{
			return null;
		}

		[Address(RVA="0x12785F8", Offset="0x12785F8", VA="0x12785F8")]
		public z_SplatWeight GetMinWeights()
		{
			return null;
		}

		[Address(RVA="0x1278BE4", Offset="0x1278BE4", VA="0x1278BE4")]
		public void LerpWeights(z_SplatSet lhs, z_SplatSet rhs, int mask, float[] alpha)
		{
		}

		[Address(RVA="0x1279500", Offset="0x1279500", VA="0x1279500")]
		public void LerpWeights(z_SplatSet lhs, z_SplatWeight rhs, float alpha)
		{
		}

		[Address(RVA="0x1279DEC", Offset="0x1279DEC", VA="0x1279DEC", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1277F98", Offset="0x1277F98", VA="0x1277F98")]
		private static Color32 Vec4ToColor32(Vector4 vec)
		{
			return new Color32();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E598", Offset="0x104E598")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static z_SplatSet.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Converter<Color32, Vector4> <>9__11_0;

			[FieldOffset(Offset="0x10")]
			public static Converter<Vector4, Color32> <>9__17_0;

			[Address(RVA="0x1279FB0", Offset="0x1279FB0", VA="0x1279FB0")]
			static <>c()
			{
			}

			[Address(RVA="0x127A014", Offset="0x127A014", VA="0x127A014")]
			public <>c()
			{
			}

			[Address(RVA="0x127A01C", Offset="0x127A01C", VA="0x127A01C")]
			internal Vector4 <.ctor>b__11_0(Color32 x)
			{
				return new Vector4();
			}

			[Address(RVA="0x127A024", Offset="0x127A024", VA="0x127A024")]
			internal Color32 <Apply>b__17_0(Vector4 x)
			{
				return new Color32();
			}
		}
	}
}