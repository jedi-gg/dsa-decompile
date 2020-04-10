using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerCollectionPowerUpdated : IMessage<PlayerCollectionPowerUpdated>, IMessage, IEquatable<PlayerCollectionPowerUpdated>, IDeepCloneable<PlayerCollectionPowerUpdated>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerCollectionPowerUpdated> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CollectionPowerFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong collectionPower_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AE60", Offset="0x109AE60")]
		public ulong CollectionPower
		{
			[Address(RVA="0x1AF72E4", Offset="0x1AF72E4", VA="0x1AF72E4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF72EC", Offset="0x1AF72EC", VA="0x1AF72EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AE40", Offset="0x109AE40")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AF70D0", Offset="0x1AF70D0", VA="0x1AF70D0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AE30", Offset="0x109AE30")]
		public static MessageParser<PlayerCollectionPowerUpdated> Parser
		{
			[Address(RVA="0x1AF7068", Offset="0x1AF7068", VA="0x1AF7068")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AE50", Offset="0x109AE50")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AF71BC", Offset="0x1AF71BC", VA="0x1AF71BC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1AF7660", Offset="0x1AF7660", VA="0x1AF7660")]
		static PlayerCollectionPowerUpdated()
		{
		}

		[Address(RVA="0x1AF7218", Offset="0x1AF7218", VA="0x1AF7218")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085D4C", Offset="0x1085D4C")]
		public PlayerCollectionPowerUpdated()
		{
		}

		[Address(RVA="0x1AF7220", Offset="0x1AF7220", VA="0x1AF7220")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085D5C", Offset="0x1085D5C")]
		public PlayerCollectionPowerUpdated(PlayerCollectionPowerUpdated other)
		{
		}

		[Address(RVA="0x1AF7514", Offset="0x1AF7514", VA="0x1AF7514", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085DCC", Offset="0x1085DCC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AF7284", Offset="0x1AF7284", VA="0x1AF7284", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085D6C", Offset="0x1085D6C")]
		public PlayerCollectionPowerUpdated Clone()
		{
			return null;
		}

		[Address(RVA="0x1AF72F4", Offset="0x1AF72F4", VA="0x1AF72F4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085D7C", Offset="0x1085D7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF7368", Offset="0x1AF7368", VA="0x1AF7368", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085D8C", Offset="0x1085D8C")]
		public bool Equals(PlayerCollectionPowerUpdated other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF73A4", Offset="0x1AF73A4", VA="0x1AF73A4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085D9C", Offset="0x1085D9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AF75A4", Offset="0x1AF75A4", VA="0x1AF75A4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085DDC", Offset="0x1085DDC")]
		public void MergeFrom(PlayerCollectionPowerUpdated other)
		{
		}

		[Address(RVA="0x1AF75E4", Offset="0x1AF75E4", VA="0x1AF75E4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085DEC", Offset="0x1085DEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AF740C", Offset="0x1AF740C", VA="0x1AF740C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085DAC", Offset="0x1085DAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AF7474", Offset="0x1AF7474", VA="0x1AF7474", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085DBC", Offset="0x1085DBC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050708", Offset="0x1050708")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerCollectionPowerUpdated.<>c <>9;

			[Address(RVA="0x1AF7738", Offset="0x1AF7738", VA="0x1AF7738")]
			static <>c()
			{
			}

			[Address(RVA="0x1AF779C", Offset="0x1AF779C", VA="0x1AF779C")]
			public <>c()
			{
			}

			[Address(RVA="0x1AF77A4", Offset="0x1AF77A4", VA="0x1AF77A4")]
			internal PlayerCollectionPowerUpdated <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}