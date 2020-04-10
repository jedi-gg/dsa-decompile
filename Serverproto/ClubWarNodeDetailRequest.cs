using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarNodeDetailRequest : IMessage<ClubWarNodeDetailRequest>, IMessage, IEquatable<ClubWarNodeDetailRequest>, IDeepCloneable<ClubWarNodeDetailRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarNodeDetailRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NodeIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string nodeId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095F80", Offset="0x1095F80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B24668", Offset="0x1B24668", VA="0x1B24668")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095FA0", Offset="0x1095FA0")]
		public string NodeId
		{
			[Address(RVA="0x1B248CC", Offset="0x1B248CC", VA="0x1B248CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B248D4", Offset="0x1B248D4", VA="0x1B248D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095F70", Offset="0x1095F70")]
		public static MessageParser<ClubWarNodeDetailRequest> Parser
		{
			[Address(RVA="0x1B24600", Offset="0x1B24600", VA="0x1B24600")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095F90", Offset="0x1095F90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B24758", Offset="0x1B24758", VA="0x1B24758", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B24D64", Offset="0x1B24D64", VA="0x1B24D64")]
		static ClubWarNodeDetailRequest()
		{
		}

		[Address(RVA="0x1B247B4", Offset="0x1B247B4", VA="0x1B247B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DB1C", Offset="0x107DB1C")]
		public ClubWarNodeDetailRequest()
		{
		}

		[Address(RVA="0x1B2480C", Offset="0x1B2480C", VA="0x1B2480C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DB2C", Offset="0x107DB2C")]
		public ClubWarNodeDetailRequest(ClubWarNodeDetailRequest other)
		{
		}

		[Address(RVA="0x1B24BC0", Offset="0x1B24BC0", VA="0x1B24BC0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DB9C", Offset="0x107DB9C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B2486C", Offset="0x1B2486C", VA="0x1B2486C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DB3C", Offset="0x107DB3C")]
		public ClubWarNodeDetailRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B24944", Offset="0x1B24944", VA="0x1B24944", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DB4C", Offset="0x107DB4C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B249B8", Offset="0x1B249B8", VA="0x1B249B8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DB5C", Offset="0x107DB5C")]
		public bool Equals(ClubWarNodeDetailRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B24A1C", Offset="0x1B24A1C", VA="0x1B24A1C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DB6C", Offset="0x107DB6C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B24C74", Offset="0x1B24C74", VA="0x1B24C74", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DBAC", Offset="0x107DBAC")]
		public void MergeFrom(ClubWarNodeDetailRequest other)
		{
		}

		[Address(RVA="0x1B24CE0", Offset="0x1B24CE0", VA="0x1B24CE0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DBBC", Offset="0x107DBBC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B24AA0", Offset="0x1B24AA0", VA="0x1B24AA0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DB7C", Offset="0x107DB7C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B24B08", Offset="0x1B24B08", VA="0x1B24B08", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DB8C", Offset="0x107DB8C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FB38", Offset="0x104FB38")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarNodeDetailRequest.<>c <>9;

			[Address(RVA="0x1B24E3C", Offset="0x1B24E3C", VA="0x1B24E3C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B24EA0", Offset="0x1B24EA0", VA="0x1B24EA0")]
			public <>c()
			{
			}

			[Address(RVA="0x1B24EA8", Offset="0x1B24EA8", VA="0x1B24EA8")]
			internal ClubWarNodeDetailRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}