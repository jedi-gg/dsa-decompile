using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubItemRequest : IMessage<ClubItemRequest>, IMessage, IEquatable<ClubItemRequest>, IDeepCloneable<ClubItemRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubItemRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ByteString id_;

		[FieldOffset(Offset="0x0")]
		public const int ItemIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong itemId_;

		[FieldOffset(Offset="0x0")]
		public const int DonationCountFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong donationCount_;

		[FieldOffset(Offset="0x0")]
		public const int DonationCapacityFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong donationCapacity_;

		[FieldOffset(Offset="0x0")]
		public const int OwnerFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private PlayerProfileSimple owner_;

		[FieldOffset(Offset="0x0")]
		public const int CreatedFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong created_;

		[FieldOffset(Offset="0x0")]
		public const int ExpiryFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong expiry_;

		[FieldOffset(Offset="0x0")]
		public const int TelemetryRefIdFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private long telemetryRefId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096A10", Offset="0x1096A10")]
		public ulong Created
		{
			[Address(RVA="0x1FFA474", Offset="0x1FFA474", VA="0x1FFA474")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FFA47C", Offset="0x1FFA47C", VA="0x1FFA47C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10969A0", Offset="0x10969A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FFA0BC", Offset="0x1FFA0BC", VA="0x1FFA0BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10969F0", Offset="0x10969F0")]
		public ulong DonationCapacity
		{
			[Address(RVA="0x1FFA464", Offset="0x1FFA464", VA="0x1FFA464")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FFA46C", Offset="0x1FFA46C", VA="0x1FFA46C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10969E0", Offset="0x10969E0")]
		public ulong DonationCount
		{
			[Address(RVA="0x1FFA454", Offset="0x1FFA454", VA="0x1FFA454")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FFA45C", Offset="0x1FFA45C", VA="0x1FFA45C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096A20", Offset="0x1096A20")]
		public ulong Expiry
		{
			[Address(RVA="0x1FFA484", Offset="0x1FFA484", VA="0x1FFA484")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FFA48C", Offset="0x1FFA48C", VA="0x1FFA48C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10969C0", Offset="0x10969C0")]
		public ByteString Id
		{
			[Address(RVA="0x1FFA3CC", Offset="0x1FFA3CC", VA="0x1FFA3CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FFA3D4", Offset="0x1FFA3D4", VA="0x1FFA3D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10969D0", Offset="0x10969D0")]
		public ulong ItemId
		{
			[Address(RVA="0x1FFA444", Offset="0x1FFA444", VA="0x1FFA444")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FFA44C", Offset="0x1FFA44C", VA="0x1FFA44C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096A00", Offset="0x1096A00")]
		public PlayerProfileSimple Owner
		{
			[Address(RVA="0x1FFA35C", Offset="0x1FFA35C", VA="0x1FFA35C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FFA364", Offset="0x1FFA364", VA="0x1FFA364")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096990", Offset="0x1096990")]
		public static MessageParser<ClubItemRequest> Parser
		{
			[Address(RVA="0x1FFA054", Offset="0x1FFA054", VA="0x1FFA054")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10969B0", Offset="0x10969B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FFA1AC", Offset="0x1FFA1AC", VA="0x1FFA1AC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096A30", Offset="0x1096A30")]
		public long TelemetryRefId
		{
			[Address(RVA="0x1FFA494", Offset="0x1FFA494", VA="0x1FFA494")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1FFA49C", Offset="0x1FFA49C", VA="0x1FFA49C")]
			set
			{
			}
		}

		[Address(RVA="0x1FFB0BC", Offset="0x1FFB0BC", VA="0x1FFB0BC")]
		static ClubItemRequest()
		{
		}

		[Address(RVA="0x1FFA208", Offset="0x1FFA208", VA="0x1FFA208")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EE5C", Offset="0x107EE5C")]
		public ClubItemRequest()
		{
		}

		[Address(RVA="0x1FFA27C", Offset="0x1FFA27C", VA="0x1FFA27C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EE6C", Offset="0x107EE6C")]
		public ClubItemRequest(ClubItemRequest other)
		{
		}

		[Address(RVA="0x1FFAB20", Offset="0x1FFAB20", VA="0x1FFAB20", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EEDC", Offset="0x107EEDC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FFA36C", Offset="0x1FFA36C", VA="0x1FFA36C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EE7C", Offset="0x107EE7C")]
		public ClubItemRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FFA4A4", Offset="0x1FFA4A4", VA="0x1FFA4A4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EE8C", Offset="0x107EE8C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFA518", Offset="0x1FFA518", VA="0x1FFA518", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EE9C", Offset="0x107EE9C")]
		public bool Equals(ClubItemRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFA648", Offset="0x1FFA648", VA="0x1FFA648", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EEAC", Offset="0x107EEAC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FFAD80", Offset="0x1FFAD80", VA="0x1FFAD80", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EEEC", Offset="0x107EEEC")]
		public void MergeFrom(ClubItemRequest other)
		{
		}

		[Address(RVA="0x1FFAEA8", Offset="0x1FFAEA8", VA="0x1FFAEA8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EEFC", Offset="0x107EEFC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FFA798", Offset="0x1FFA798", VA="0x1FFA798", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EEBC", Offset="0x107EEBC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FFA800", Offset="0x1FFA800", VA="0x1FFA800", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EECC", Offset="0x107EECC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FCF8", Offset="0x104FCF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubItemRequest.<>c <>9;

			[Address(RVA="0x1FFB194", Offset="0x1FFB194", VA="0x1FFB194")]
			static <>c()
			{
			}

			[Address(RVA="0x1FFB1F8", Offset="0x1FFB1F8", VA="0x1FFB1F8")]
			public <>c()
			{
			}

			[Address(RVA="0x1FFB200", Offset="0x1FFB200", VA="0x1FFB200")]
			internal ClubItemRequest <.cctor>b__60_0()
			{
				return null;
			}
		}
	}
}