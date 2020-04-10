using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimTowerProgressionLootRequest : IMessage<ClaimTowerProgressionLootRequest>, IMessage, IEquatable<ClaimTowerProgressionLootRequest>, IDeepCloneable<ClaimTowerProgressionLootRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimTowerProgressionLootRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private TowerIdentifier id_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CFE8", Offset="0x109CFE8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A4495C", Offset="0x1A4495C", VA="0x1A4495C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D008", Offset="0x109D008")]
		public TowerIdentifier Id
		{
			[Address(RVA="0x1A44B2C", Offset="0x1A44B2C", VA="0x1A44B2C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A44B34", Offset="0x1A44B34", VA="0x1A44B34")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CFD8", Offset="0x109CFD8")]
		public static MessageParser<ClaimTowerProgressionLootRequest> Parser
		{
			[Address(RVA="0x1A448F4", Offset="0x1A448F4", VA="0x1A448F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CFF8", Offset="0x109CFF8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A44A4C", Offset="0x1A44A4C", VA="0x1A44A4C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A44FF4", Offset="0x1A44FF4", VA="0x1A44FF4")]
		static ClaimTowerProgressionLootRequest()
		{
		}

		[Address(RVA="0x1A44AA8", Offset="0x1A44AA8", VA="0x1A44AA8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089B2C", Offset="0x1089B2C")]
		public ClaimTowerProgressionLootRequest()
		{
		}

		[Address(RVA="0x1A44AB0", Offset="0x1A44AB0", VA="0x1A44AB0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089B3C", Offset="0x1089B3C")]
		public ClaimTowerProgressionLootRequest(ClaimTowerProgressionLootRequest other)
		{
		}

		[Address(RVA="0x1A44DD4", Offset="0x1A44DD4", VA="0x1A44DD4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089BAC", Offset="0x1089BAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A44B3C", Offset="0x1A44B3C", VA="0x1A44B3C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089B4C", Offset="0x1089B4C")]
		public ClaimTowerProgressionLootRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A44B9C", Offset="0x1A44B9C", VA="0x1A44B9C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089B5C", Offset="0x1089B5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A44C10", Offset="0x1A44C10", VA="0x1A44C10", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089B6C", Offset="0x1089B6C")]
		public bool Equals(ClaimTowerProgressionLootRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A44C74", Offset="0x1A44C74", VA="0x1A44C74", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089B7C", Offset="0x1089B7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A44E64", Offset="0x1A44E64", VA="0x1A44E64", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089BBC", Offset="0x1089BBC")]
		public void MergeFrom(ClaimTowerProgressionLootRequest other)
		{
		}

		[Address(RVA="0x1A44F18", Offset="0x1A44F18", VA="0x1A44F18", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089BCC", Offset="0x1089BCC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A44CCC", Offset="0x1A44CCC", VA="0x1A44CCC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089B8C", Offset="0x1089B8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A44D34", Offset="0x1A44D34", VA="0x1A44D34", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089B9C", Offset="0x1089B9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050CB8", Offset="0x1050CB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimTowerProgressionLootRequest.<>c <>9;

			[Address(RVA="0x1A450CC", Offset="0x1A450CC", VA="0x1A450CC")]
			static <>c()
			{
			}

			[Address(RVA="0x1A45130", Offset="0x1A45130", VA="0x1A45130")]
			public <>c()
			{
			}

			[Address(RVA="0x1A45138", Offset="0x1A45138", VA="0x1A45138")]
			internal ClaimTowerProgressionLootRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}