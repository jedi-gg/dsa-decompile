using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DonateClubItemResponse : IMessage<DonateClubItemResponse>, IMessage, IEquatable<DonateClubItemResponse>, IDeepCloneable<DonateClubItemResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DonateClubItemResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095300", Offset="0x1095300")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FBD28C", Offset="0x1FBD28C", VA="0x1FBD28C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095320", Offset="0x1095320")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1FBD45C", Offset="0x1FBD45C", VA="0x1FBD45C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FBD464", Offset="0x1FBD464", VA="0x1FBD464")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10952F0", Offset="0x10952F0")]
		public static MessageParser<DonateClubItemResponse> Parser
		{
			[Address(RVA="0x1FBD224", Offset="0x1FBD224", VA="0x1FBD224")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095310", Offset="0x1095310")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FBD37C", Offset="0x1FBD37C", VA="0x1FBD37C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FBD924", Offset="0x1FBD924", VA="0x1FBD924")]
		static DonateClubItemResponse()
		{
		}

		[Address(RVA="0x1FBD3D8", Offset="0x1FBD3D8", VA="0x1FBD3D8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BE3C", Offset="0x107BE3C")]
		public DonateClubItemResponse()
		{
		}

		[Address(RVA="0x1FBD3E0", Offset="0x1FBD3E0", VA="0x1FBD3E0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BE4C", Offset="0x107BE4C")]
		public DonateClubItemResponse(DonateClubItemResponse other)
		{
		}

		[Address(RVA="0x1FBD704", Offset="0x1FBD704", VA="0x1FBD704", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BEBC", Offset="0x107BEBC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FBD46C", Offset="0x1FBD46C", VA="0x1FBD46C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BE5C", Offset="0x107BE5C")]
		public DonateClubItemResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FBD4CC", Offset="0x1FBD4CC", VA="0x1FBD4CC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BE6C", Offset="0x107BE6C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBD540", Offset="0x1FBD540", VA="0x1FBD540", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BE7C", Offset="0x107BE7C")]
		public bool Equals(DonateClubItemResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBD5A4", Offset="0x1FBD5A4", VA="0x1FBD5A4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BE8C", Offset="0x107BE8C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FBD794", Offset="0x1FBD794", VA="0x1FBD794", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BECC", Offset="0x107BECC")]
		public void MergeFrom(DonateClubItemResponse other)
		{
		}

		[Address(RVA="0x1FBD848", Offset="0x1FBD848", VA="0x1FBD848", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BEDC", Offset="0x107BEDC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FBD5FC", Offset="0x1FBD5FC", VA="0x1FBD5FC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BE9C", Offset="0x107BE9C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FBD664", Offset="0x1FBD664", VA="0x1FBD664", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BEAC", Offset="0x107BEAC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F888", Offset="0x104F888")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DonateClubItemResponse.<>c <>9;

			[Address(RVA="0x1FBD9FC", Offset="0x1FBD9FC", VA="0x1FBD9FC")]
			static <>c()
			{
			}

			[Address(RVA="0x1FBDA60", Offset="0x1FBDA60", VA="0x1FBDA60")]
			public <>c()
			{
			}

			[Address(RVA="0x1FBDA68", Offset="0x1FBDA68", VA="0x1FBDA68")]
			internal DonateClubItemResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}