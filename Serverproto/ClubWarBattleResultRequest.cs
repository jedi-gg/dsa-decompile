using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarBattleResultRequest : IMessage<ClubWarBattleResultRequest>, IMessage, IEquatable<ClubWarBattleResultRequest>, IDeepCloneable<ClubWarBattleResultRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarBattleResultRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BattleIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string battleId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093590", Offset="0x1093590")]
		public string BattleId
		{
			[Address(RVA="0x1B1A20C", Offset="0x1B1A20C", VA="0x1B1A20C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1A214", Offset="0x1B1A214", VA="0x1B1A214")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093570", Offset="0x1093570")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B19FA8", Offset="0x1B19FA8", VA="0x1B19FA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093560", Offset="0x1093560")]
		public static MessageParser<ClubWarBattleResultRequest> Parser
		{
			[Address(RVA="0x1B19F40", Offset="0x1B19F40", VA="0x1B19F40")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093580", Offset="0x1093580")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B1A098", Offset="0x1B1A098", VA="0x1B1A098", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B1A6A4", Offset="0x1B1A6A4", VA="0x1B1A6A4")]
		static ClubWarBattleResultRequest()
		{
		}

		[Address(RVA="0x1B1A0F4", Offset="0x1B1A0F4", VA="0x1B1A0F4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107883C", Offset="0x107883C")]
		public ClubWarBattleResultRequest()
		{
		}

		[Address(RVA="0x1B1A14C", Offset="0x1B1A14C", VA="0x1B1A14C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107884C", Offset="0x107884C")]
		public ClubWarBattleResultRequest(ClubWarBattleResultRequest other)
		{
		}

		[Address(RVA="0x1B1A500", Offset="0x1B1A500", VA="0x1B1A500", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10788BC", Offset="0x10788BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B1A1AC", Offset="0x1B1A1AC", VA="0x1B1A1AC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107885C", Offset="0x107885C")]
		public ClubWarBattleResultRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B1A284", Offset="0x1B1A284", VA="0x1B1A284", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107886C", Offset="0x107886C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1A2F8", Offset="0x1B1A2F8", VA="0x1B1A2F8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107887C", Offset="0x107887C")]
		public bool Equals(ClubWarBattleResultRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1A35C", Offset="0x1B1A35C", VA="0x1B1A35C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107888C", Offset="0x107888C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B1A5B4", Offset="0x1B1A5B4", VA="0x1B1A5B4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10788CC", Offset="0x10788CC")]
		public void MergeFrom(ClubWarBattleResultRequest other)
		{
		}

		[Address(RVA="0x1B1A620", Offset="0x1B1A620", VA="0x1B1A620", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10788DC", Offset="0x10788DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B1A3E0", Offset="0x1B1A3E0", VA="0x1B1A3E0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107889C", Offset="0x107889C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B1A448", Offset="0x1B1A448", VA="0x1B1A448", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10788AC", Offset="0x10788AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F368", Offset="0x104F368")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarBattleResultRequest.<>c <>9;

			[Address(RVA="0x1B1A77C", Offset="0x1B1A77C", VA="0x1B1A77C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B1A7E0", Offset="0x1B1A7E0", VA="0x1B1A7E0")]
			public <>c()
			{
			}

			[Address(RVA="0x1B1A7E8", Offset="0x1B1A7E8", VA="0x1B1A7E8")]
			internal ClubWarBattleResultRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}