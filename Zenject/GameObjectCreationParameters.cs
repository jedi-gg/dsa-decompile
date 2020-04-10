using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class GameObjectCreationParameters
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060078", Offset="0x1060078")]
		[FieldOffset(Offset="0x10")]
		private string <Name>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060088", Offset="0x1060088")]
		[FieldOffset(Offset="0x18")]
		private string <GroupName>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060098", Offset="0x1060098")]
		[FieldOffset(Offset="0x20")]
		private Transform <ParentTransform>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10600A8", Offset="0x10600A8")]
		[FieldOffset(Offset="0x28")]
		private Func<InjectContext, Transform> <ParentTransformGetter>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10600B8", Offset="0x10600B8")]
		[FieldOffset(Offset="0x30")]
		private Vector3? <Position>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10600C8", Offset="0x10600C8")]
		[FieldOffset(Offset="0x40")]
		private Quaternion? <Rotation>k__BackingField;

		[FieldOffset(Offset="0x0")]
		public readonly static GameObjectCreationParameters Default;

		public string GroupName
		{
			[Address(RVA="0x1837700", Offset="0x1837700", VA="0x1837700")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072514", Offset="0x1072514")]
			get
			{
				return null;
			}
			[Address(RVA="0x1837708", Offset="0x1837708", VA="0x1837708")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072524", Offset="0x1072524")]
			set
			{
			}
		}

		public string Name
		{
			[Address(RVA="0x18376F0", Offset="0x18376F0", VA="0x18376F0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10724F4", Offset="0x10724F4")]
			get
			{
				return null;
			}
			[Address(RVA="0x18376F8", Offset="0x18376F8", VA="0x18376F8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072504", Offset="0x1072504")]
			set
			{
			}
		}

		public Transform ParentTransform
		{
			[Address(RVA="0x1837710", Offset="0x1837710", VA="0x1837710")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072534", Offset="0x1072534")]
			get
			{
				return null;
			}
			[Address(RVA="0x1837718", Offset="0x1837718", VA="0x1837718")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072544", Offset="0x1072544")]
			set
			{
			}
		}

		public Func<InjectContext, Transform> ParentTransformGetter
		{
			[Address(RVA="0x1837720", Offset="0x1837720", VA="0x1837720")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072554", Offset="0x1072554")]
			get
			{
				return null;
			}
			[Address(RVA="0x1837728", Offset="0x1837728", VA="0x1837728")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072564", Offset="0x1072564")]
			set
			{
			}
		}

		public Vector3? Position
		{
			[Address(RVA="0x1837730", Offset="0x1837730", VA="0x1837730")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072574", Offset="0x1072574")]
			get
			{
				return null;
			}
			[Address(RVA="0x183773C", Offset="0x183773C", VA="0x183773C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072584", Offset="0x1072584")]
			set
			{
			}
		}

		public Quaternion? Rotation
		{
			[Address(RVA="0x1837744", Offset="0x1837744", VA="0x1837744")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072594", Offset="0x1072594")]
			get
			{
				return null;
			}
			[Address(RVA="0x1837758", Offset="0x1837758", VA="0x1837758")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10725A4", Offset="0x10725A4")]
			set
			{
			}
		}

		[Address(RVA="0x1837BD8", Offset="0x1837BD8", VA="0x1837BD8")]
		static GameObjectCreationParameters()
		{
		}

		[Address(RVA="0x1834B48", Offset="0x1834B48", VA="0x1834B48")]
		public GameObjectCreationParameters()
		{
		}

		[Address(RVA="0x183798C", Offset="0x183798C", VA="0x183798C", Slot="0")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1837B28", Offset="0x1837B28", VA="0x1837B28")]
		public bool Equals(GameObjectCreationParameters that)
		{
			return new bool();
		}

		[Address(RVA="0x183776C", Offset="0x183776C", VA="0x183776C", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1837AB4", Offset="0x1837AB4", VA="0x1837AB4")]
		public static bool operator ==(GameObjectCreationParameters left, GameObjectCreationParameters right)
		{
			return new bool();
		}

		[Address(RVA="0x1837B9C", Offset="0x1837B9C", VA="0x1837B9C")]
		public static bool operator !=(GameObjectCreationParameters left, GameObjectCreationParameters right)
		{
			return new bool();
		}
	}
}