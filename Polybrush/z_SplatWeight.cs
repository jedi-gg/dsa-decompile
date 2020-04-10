using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Polybrush
{
	[Attribute(Name="DefaultMemberAttribute", RVA="0x1049790", Offset="0x1049790")]
	public class z_SplatWeight
	{
		[FieldOffset(Offset="0x10")]
		private Dictionary<z_MeshChannel, int> map;

		[FieldOffset(Offset="0x18")]
		private float[] values;

		public Vector4 Item(z_MeshChannel channel)
		{
			[Address(RVA="0x127895C", Offset="0x127895C", VA="0x127895C")]
			get
			{
				return new Vector4();
			}
			[Address(RVA="0x12789D8", Offset="0x12789D8", VA="0x12789D8")]
			set
			{
			}
		}

		public float Item(z_AttributeLayout attribute)
		{
			[Address(RVA="0x127A2C8", Offset="0x127A2C8", VA="0x127A2C8")]
			get
			{
				return new float();
			}
			[Address(RVA="0x127A390", Offset="0x127A390", VA="0x127A390")]
			set
			{
			}
		}

		public float Item(int valueIndex)
		{
			[Address(RVA="0x127A464", Offset="0x127A464", VA="0x127A464")]
			get
			{
				return new float();
			}
			[Address(RVA="0x127A4B8", Offset="0x127A4B8", VA="0x127A4B8")]
			set
			{
			}
		}

		[Address(RVA="0x1278758", Offset="0x1278758", VA="0x1278758")]
		public z_SplatWeight(Dictionary<z_MeshChannel, int> map)
		{
		}

		[Address(RVA="0x127A518", Offset="0x127A518", VA="0x127A518")]
		public z_SplatWeight(z_SplatWeight rhs)
		{
		}

		[Address(RVA="0x127A968", Offset="0x127A968", VA="0x127A968")]
		public void CopyTo(z_SplatWeight other)
		{
		}

		[Address(RVA="0x127A740", Offset="0x127A740", VA="0x127A740")]
		public List<int> GetAffectedIndicesWithMask(z_AttributeLayout[] attributes, int mask)
		{
			return null;
		}

		[Address(RVA="0x127A2CC", Offset="0x127A2CC", VA="0x127A2CC")]
		public float GetAttributeValue(z_AttributeLayout attrib)
		{
			return new float();
		}

		[Address(RVA="0x1277800", Offset="0x1277800", VA="0x1277800")]
		public static Dictionary<z_MeshChannel, int> GetChannelMap(z_AttributeLayout[] attributes)
		{
			return null;
		}

		[Address(RVA="0x127A03C", Offset="0x127A03C", VA="0x127A03C")]
		private Vector4 GetVec4(int index)
		{
			return new Vector4();
		}

		[Address(RVA="0x127AA38", Offset="0x127AA38", VA="0x127AA38")]
		public void Lerp(z_SplatWeight lhs, z_SplatWeight rhs, float alpha)
		{
		}

		[Address(RVA="0x127BE80", Offset="0x127BE80", VA="0x127BE80")]
		public void Lerp(z_SplatWeight lhs, z_SplatWeight rhs, float alpha, List<int> mask)
		{
		}

		[Address(RVA="0x127A888", Offset="0x127A888", VA="0x127A888")]
		public bool MatchesAttributes(z_AttributeLayout[] attributes)
		{
			return new bool();
		}

		[Address(RVA="0x127A394", Offset="0x127A394", VA="0x127A394")]
		public void SetAttributeValue(z_AttributeLayout attrib, float value)
		{
		}

		[Address(RVA="0x127A190", Offset="0x127A190", VA="0x127A190")]
		private void SetVec4(int index, Vector4 value)
		{
		}

		[Address(RVA="0x127CF8C", Offset="0x127CF8C", VA="0x127CF8C", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E5A8", Offset="0x104E5A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static z_SplatWeight.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<z_AttributeLayout, z_MeshChannel> <>9__13_0;

			[Address(RVA="0x127D22C", Offset="0x127D22C", VA="0x127D22C")]
			static <>c()
			{
			}

			[Address(RVA="0x127D290", Offset="0x127D290", VA="0x127D290")]
			public <>c()
			{
			}

			[Address(RVA="0x127D298", Offset="0x127D298", VA="0x127D298")]
			internal z_MeshChannel <GetChannelMap>b__13_0(z_AttributeLayout x)
			{
				return new z_MeshChannel();
			}
		}
	}
}