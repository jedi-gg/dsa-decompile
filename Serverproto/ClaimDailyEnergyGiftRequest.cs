using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimDailyEnergyGiftRequest : IMessage<ClaimDailyEnergyGiftRequest>, IMessage, IEquatable<ClaimDailyEnergyGiftRequest>, IDeepCloneable<ClaimDailyEnergyGiftRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimDailyEnergyGiftRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EnergyItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong energyItemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A4E0", Offset="0x109A4E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A41578", Offset="0x1A41578", VA="0x1A41578")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A500", Offset="0x109A500")]
		public ulong EnergyItemId
		{
			[Address(RVA="0x1A41790", Offset="0x1A41790", VA="0x1A41790")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A41798", Offset="0x1A41798", VA="0x1A41798")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A4D0", Offset="0x109A4D0")]
		public static MessageParser<ClaimDailyEnergyGiftRequest> Parser
		{
			[Address(RVA="0x1A41510", Offset="0x1A41510", VA="0x1A41510")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A4F0", Offset="0x109A4F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A41668", Offset="0x1A41668", VA="0x1A41668", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A41B0C", Offset="0x1A41B0C", VA="0x1A41B0C")]
		static ClaimDailyEnergyGiftRequest()
		{
		}

		[Address(RVA="0x1A416C4", Offset="0x1A416C4", VA="0x1A416C4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108453C", Offset="0x108453C")]
		public ClaimDailyEnergyGiftRequest()
		{
		}

		[Address(RVA="0x1A416CC", Offset="0x1A416CC", VA="0x1A416CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108454C", Offset="0x108454C")]
		public ClaimDailyEnergyGiftRequest(ClaimDailyEnergyGiftRequest other)
		{
		}

		[Address(RVA="0x1A419C0", Offset="0x1A419C0", VA="0x1A419C0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10845BC", Offset="0x10845BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A41730", Offset="0x1A41730", VA="0x1A41730", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108455C", Offset="0x108455C")]
		public ClaimDailyEnergyGiftRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A417A0", Offset="0x1A417A0", VA="0x1A417A0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108456C", Offset="0x108456C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A41814", Offset="0x1A41814", VA="0x1A41814", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108457C", Offset="0x108457C")]
		public bool Equals(ClaimDailyEnergyGiftRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A41850", Offset="0x1A41850", VA="0x1A41850", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108458C", Offset="0x108458C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A41A50", Offset="0x1A41A50", VA="0x1A41A50", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10845CC", Offset="0x10845CC")]
		public void MergeFrom(ClaimDailyEnergyGiftRequest other)
		{
		}

		[Address(RVA="0x1A41A90", Offset="0x1A41A90", VA="0x1A41A90", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10845DC", Offset="0x10845DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A418B8", Offset="0x1A418B8", VA="0x1A418B8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108459C", Offset="0x108459C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A41920", Offset="0x1A41920", VA="0x1A41920", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10845AC", Offset="0x10845AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10504D8", Offset="0x10504D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimDailyEnergyGiftRequest.<>c <>9;

			[Address(RVA="0x1A41BE4", Offset="0x1A41BE4", VA="0x1A41BE4")]
			static <>c()
			{
			}

			[Address(RVA="0x1A41C48", Offset="0x1A41C48", VA="0x1A41C48")]
			public <>c()
			{
			}

			[Address(RVA="0x1A41C50", Offset="0x1A41C50", VA="0x1A41C50")]
			internal ClaimDailyEnergyGiftRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}