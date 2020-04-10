using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CreateClubResponse : IMessage<CreateClubResponse>, IMessage, IEquatable<CreateClubResponse>, IDeepCloneable<CreateClubResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CreateClubResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Club club_;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094C80", Offset="0x1094C80")]
		public Serverproto.Club Club
		{
			[Address(RVA="0x1EF4D4C", Offset="0x1EF4D4C", VA="0x1EF4D4C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF4D54", Offset="0x1EF4D54", VA="0x1EF4D54")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094C60", Offset="0x1094C60")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF4B68", Offset="0x1EF4B68", VA="0x1EF4B68")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094C90", Offset="0x1094C90")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1EF4D5C", Offset="0x1EF4D5C", VA="0x1EF4D5C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF4D64", Offset="0x1EF4D64", VA="0x1EF4D64")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094C50", Offset="0x1094C50")]
		public static MessageParser<CreateClubResponse> Parser
		{
			[Address(RVA="0x1EF4B00", Offset="0x1EF4B00", VA="0x1EF4B00")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094C70", Offset="0x1094C70")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF4C58", Offset="0x1EF4C58", VA="0x1EF4C58", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EF5374", Offset="0x1EF5374", VA="0x1EF5374")]
		static CreateClubResponse()
		{
		}

		[Address(RVA="0x1EF4CB4", Offset="0x1EF4CB4", VA="0x1EF4CB4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ADBC", Offset="0x107ADBC")]
		public CreateClubResponse()
		{
		}

		[Address(RVA="0x1EF4CBC", Offset="0x1EF4CBC", VA="0x1EF4CBC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ADCC", Offset="0x107ADCC")]
		public CreateClubResponse(CreateClubResponse other)
		{
		}

		[Address(RVA="0x1EF5088", Offset="0x1EF5088", VA="0x1EF5088", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AE3C", Offset="0x107AE3C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF4D6C", Offset="0x1EF4D6C", VA="0x1EF4D6C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ADDC", Offset="0x107ADDC")]
		public CreateClubResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF4DCC", Offset="0x1EF4DCC", VA="0x1EF4DCC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ADEC", Offset="0x107ADEC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF4E40", Offset="0x1EF4E40", VA="0x1EF4E40", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ADFC", Offset="0x107ADFC")]
		public bool Equals(CreateClubResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF4EB8", Offset="0x1EF4EB8", VA="0x1EF4EB8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AE0C", Offset="0x107AE0C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF515C", Offset="0x1EF515C", VA="0x1EF515C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AE4C", Offset="0x107AE4C")]
		public void MergeFrom(CreateClubResponse other)
		{
		}

		[Address(RVA="0x1EF5260", Offset="0x1EF5260", VA="0x1EF5260", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AE5C", Offset="0x107AE5C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF4F28", Offset="0x1EF4F28", VA="0x1EF4F28", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AE1C", Offset="0x107AE1C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF4F90", Offset="0x1EF4F90", VA="0x1EF4F90", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AE2C", Offset="0x107AE2C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F708", Offset="0x104F708")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CreateClubResponse.<>c <>9;

			[Address(RVA="0x1EF544C", Offset="0x1EF544C", VA="0x1EF544C")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF54B0", Offset="0x1EF54B0", VA="0x1EF54B0")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF54B8", Offset="0x1EF54B8", VA="0x1EF54B8")]
			internal CreateClubResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}