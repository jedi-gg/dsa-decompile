using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Polybrush
{
	[Serializable]
	public class z_AttributeLayoutContainer : ScriptableObject, IEquatable<z_AttributeLayoutContainer>
	{
		[FieldOffset(Offset="0x18")]
		public Shader shader;

		[FieldOffset(Offset="0x20")]
		public z_AttributeLayout[] attributes;

		[Address(RVA="0x1347034", Offset="0x1347034", VA="0x1347034")]
		public z_AttributeLayoutContainer()
		{
		}

		[Address(RVA="0x1346E30", Offset="0x1346E30", VA="0x1346E30")]
		public static z_AttributeLayoutContainer Create(Shader shader, z_AttributeLayout[] attributes)
		{
			return null;
		}

		[Address(RVA="0x1346EB8", Offset="0x1346EB8", VA="0x1346EB8", Slot="4")]
		public bool Equals(z_AttributeLayoutContainer other)
		{
			return new bool();
		}
	}
}