using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InstantBattleResponse : IMessage<InstantBattleResponse>, IMessage, IEquatable<InstantBattleResponse>, IDeepCloneable<InstantBattleResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InstantBattleResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int UpdatedProgressFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private CampaignProgress updatedProgress_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092BA0", Offset="0x1092BA0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E6C7C", Offset="0x18E6C7C", VA="0x18E6C7C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092BC0", Offset="0x1092BC0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x18E6E5C", Offset="0x18E6E5C", VA="0x18E6E5C")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E6E64", Offset="0x18E6E64", VA="0x18E6E64")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092B90", Offset="0x1092B90")]
		public static MessageParser<InstantBattleResponse> Parser
		{
			[Address(RVA="0x18E6C14", Offset="0x18E6C14", VA="0x18E6C14")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092BB0", Offset="0x1092BB0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E6D6C", Offset="0x18E6D6C", VA="0x18E6D6C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092BD0", Offset="0x1092BD0")]
		public CampaignProgress UpdatedProgress
		{
			[Address(RVA="0x18E6E6C", Offset="0x18E6E6C", VA="0x18E6E6C")]
			get
			{
				return null;
			}
			[Address(RVA="0x18E6E74", Offset="0x18E6E74", VA="0x18E6E74")]
			set
			{
			}
		}

		[Address(RVA="0x18E7478", Offset="0x18E7478", VA="0x18E7478")]
		static InstantBattleResponse()
		{
		}

		[Address(RVA="0x18E6DC8", Offset="0x18E6DC8", VA="0x18E6DC8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107765C", Offset="0x107765C")]
		public InstantBattleResponse()
		{
		}

		[Address(RVA="0x18E6DD0", Offset="0x18E6DD0", VA="0x18E6DD0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107766C", Offset="0x107766C")]
		public InstantBattleResponse(InstantBattleResponse other)
		{
		}

		[Address(RVA="0x18E7198", Offset="0x18E7198", VA="0x18E7198", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10776DC", Offset="0x10776DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18E6E7C", Offset="0x18E6E7C", VA="0x18E6E7C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107767C", Offset="0x107767C")]
		public InstantBattleResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18E6EDC", Offset="0x18E6EDC", VA="0x18E6EDC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107768C", Offset="0x107768C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E6F50", Offset="0x18E6F50", VA="0x18E6F50", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107769C", Offset="0x107769C")]
		public bool Equals(InstantBattleResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18E6FC8", Offset="0x18E6FC8", VA="0x18E6FC8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10776AC", Offset="0x10776AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18E726C", Offset="0x18E726C", VA="0x18E726C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10776EC", Offset="0x10776EC")]
		public void MergeFrom(InstantBattleResponse other)
		{
		}

		[Address(RVA="0x18E7368", Offset="0x18E7368", VA="0x18E7368", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10776FC", Offset="0x10776FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E7038", Offset="0x18E7038", VA="0x18E7038", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10776BC", Offset="0x10776BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E70A0", Offset="0x18E70A0", VA="0x18E70A0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10776CC", Offset="0x10776CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F1C8", Offset="0x104F1C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InstantBattleResponse.<>c <>9;

			[Address(RVA="0x18E7550", Offset="0x18E7550", VA="0x18E7550")]
			static <>c()
			{
			}

			[Address(RVA="0x18E75B4", Offset="0x18E75B4", VA="0x18E75B4")]
			public <>c()
			{
			}

			[Address(RVA="0x18E75BC", Offset="0x18E75BC", VA="0x18E75BC")]
			internal InstantBattleResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}