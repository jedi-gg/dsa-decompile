using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimDailyLoginBonusResponse : IMessage<ClaimDailyLoginBonusResponse>, IMessage, IEquatable<ClaimDailyLoginBonusResponse>, IDeepCloneable<ClaimDailyLoginBonusResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimDailyLoginBonusResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int ValidatedFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool validated_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ADF0", Offset="0x109ADF0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A42FDC", Offset="0x1A42FDC", VA="0x1A42FDC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AE10", Offset="0x109AE10")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1A431B4", Offset="0x1A431B4", VA="0x1A431B4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A431BC", Offset="0x1A431BC", VA="0x1A431BC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ADE0", Offset="0x109ADE0")]
		public static MessageParser<ClaimDailyLoginBonusResponse> Parser
		{
			[Address(RVA="0x1A42F74", Offset="0x1A42F74", VA="0x1A42F74")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AE00", Offset="0x109AE00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A430CC", Offset="0x1A430CC", VA="0x1A430CC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AE20", Offset="0x109AE20")]
		public bool Validated
		{
			[Address(RVA="0x1A43224", Offset="0x1A43224", VA="0x1A43224")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A4322C", Offset="0x1A4322C", VA="0x1A4322C")]
			set
			{
			}
		}

		[Address(RVA="0x1A43788", Offset="0x1A43788", VA="0x1A43788")]
		static ClaimDailyLoginBonusResponse()
		{
		}

		[Address(RVA="0x1A43128", Offset="0x1A43128", VA="0x1A43128")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085C9C", Offset="0x1085C9C")]
		public ClaimDailyLoginBonusResponse()
		{
		}

		[Address(RVA="0x1A43130", Offset="0x1A43130", VA="0x1A43130")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085CAC", Offset="0x1085CAC")]
		public ClaimDailyLoginBonusResponse(ClaimDailyLoginBonusResponse other)
		{
		}

		[Address(RVA="0x1A43518", Offset="0x1A43518", VA="0x1A43518", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085D1C", Offset="0x1085D1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A431C4", Offset="0x1A431C4", VA="0x1A431C4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085CBC", Offset="0x1085CBC")]
		public ClaimDailyLoginBonusResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A43238", Offset="0x1A43238", VA="0x1A43238", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085CCC", Offset="0x1085CCC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A432AC", Offset="0x1A432AC", VA="0x1A432AC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085CDC", Offset="0x1085CDC")]
		public bool Equals(ClaimDailyLoginBonusResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A43330", Offset="0x1A43330", VA="0x1A43330", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085CEC", Offset="0x1085CEC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A435C0", Offset="0x1A435C0", VA="0x1A435C0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085D2C", Offset="0x1085D2C")]
		public void MergeFrom(ClaimDailyLoginBonusResponse other)
		{
		}

		[Address(RVA="0x1A43680", Offset="0x1A43680", VA="0x1A43680", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085D3C", Offset="0x1085D3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A433B4", Offset="0x1A433B4", VA="0x1A433B4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085CFC", Offset="0x1085CFC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A4341C", Offset="0x1A4341C", VA="0x1A4341C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085D0C", Offset="0x1085D0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10506F8", Offset="0x10506F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimDailyLoginBonusResponse.<>c <>9;

			[Address(RVA="0x1A43860", Offset="0x1A43860", VA="0x1A43860")]
			static <>c()
			{
			}

			[Address(RVA="0x1A438C4", Offset="0x1A438C4", VA="0x1A438C4")]
			public <>c()
			{
			}

			[Address(RVA="0x1A438CC", Offset="0x1A438CC", VA="0x1A438CC")]
			internal ClaimDailyLoginBonusResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}