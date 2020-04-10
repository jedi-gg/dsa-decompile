using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Polybrush
{
	public struct z_RndVec3 : IEquatable<z_RndVec3>
	{
		[FieldOffset(Offset="0x0")]
		public float x;

		[FieldOffset(Offset="0x4")]
		public float y;

		[FieldOffset(Offset="0x8")]
		public float z;

		[FieldOffset(Offset="0x0")]
		private const float resolution = 0.0001f;

		[Address(RVA="0xEFD22C", Offset="0xEFD22C", VA="0xEFD22C")]
		public z_RndVec3(Vector3 vector)
		{
		}

		[Address(RVA="0xEFD238", Offset="0xEFD238", VA="0xEFD238", Slot="4")]
		public bool Equals(z_RndVec3 p)
		{
			return new bool();
		}

		[Address(RVA="0xEFD240", Offset="0xEFD240", VA="0xEFD240")]
		public bool Equals(Vector3 p)
		{
			return new bool();
		}

		[Address(RVA="0xEFD248", Offset="0xEFD248", VA="0xEFD248", Slot="0")]
		public override bool Equals(object b)
		{
			return new bool();
		}

		[Address(RVA="0xEFD250", Offset="0xEFD250", VA="0xEFD250", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1277630", Offset="0x1277630", VA="0x1277630")]
		public static implicit operator Vector3(z_RndVec3 p)
		{
			return new Vector3();
		}

		[Address(RVA="0x12771DC", Offset="0x12771DC", VA="0x12771DC")]
		public static implicit operator z_RndVec3(Vector3 p)
		{
			return new z_RndVec3();
		}

		[Address(RVA="0xEFD29C", Offset="0xEFD29C", VA="0xEFD29C")]
		private int round(float v)
		{
			return new int();
		}

		[Address(RVA="0xEFD294", Offset="0xEFD294", VA="0xEFD294", Slot="3")]
		public override string ToString()
		{
			return null;
		}
	}
}