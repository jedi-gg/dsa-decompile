using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimBonusClubDungeonAttemptRequest : IMessage<ClaimBonusClubDungeonAttemptRequest>, IMessage, IEquatable<ClaimBonusClubDungeonAttemptRequest>, IDeepCloneable<ClaimBonusClubDungeonAttemptRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimBonusClubDungeonAttemptRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095B30", Offset="0x1095B30")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A406B0", Offset="0x1A406B0", VA="0x1A406B0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095B20", Offset="0x1095B20")]
		public static MessageParser<ClaimBonusClubDungeonAttemptRequest> Parser
		{
			[Address(RVA="0x1A40648", Offset="0x1A40648", VA="0x1A40648")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095B40", Offset="0x1095B40")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A407A0", Offset="0x1A407A0", VA="0x1A407A0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A40AB4", Offset="0x1A40AB4", VA="0x1A40AB4")]
		static ClaimBonusClubDungeonAttemptRequest()
		{
		}

		[Address(RVA="0x1A407FC", Offset="0x1A407FC", VA="0x1A407FC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D22C", Offset="0x107D22C")]
		public ClaimBonusClubDungeonAttemptRequest()
		{
		}

		[Address(RVA="0x1A40804", Offset="0x1A40804", VA="0x1A40804")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D23C", Offset="0x107D23C")]
		public ClaimBonusClubDungeonAttemptRequest(ClaimBonusClubDungeonAttemptRequest other)
		{
		}

		[Address(RVA="0x1A40A18", Offset="0x1A40A18", VA="0x1A40A18", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D2AC", Offset="0x107D2AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A40848", Offset="0x1A40848", VA="0x1A40848", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D24C", Offset="0x107D24C")]
		public ClaimBonusClubDungeonAttemptRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A408A8", Offset="0x1A408A8", VA="0x1A408A8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D25C", Offset="0x107D25C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A40940", Offset="0x1A40940", VA="0x1A40940", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D26C", Offset="0x107D26C")]
		public bool Equals(ClaimBonusClubDungeonAttemptRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4096C", Offset="0x1A4096C", VA="0x1A4096C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D27C", Offset="0x107D27C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A40A2C", Offset="0x1A40A2C", VA="0x1A40A2C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D2BC", Offset="0x107D2BC")]
		public void MergeFrom(ClaimBonusClubDungeonAttemptRequest other)
		{
		}

		[Address(RVA="0x1A40A60", Offset="0x1A40A60", VA="0x1A40A60", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D2CC", Offset="0x107D2CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A4099C", Offset="0x1A4099C", VA="0x1A4099C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D28C", Offset="0x107D28C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A40A04", Offset="0x1A40A04", VA="0x1A40A04", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D29C", Offset="0x107D29C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FA58", Offset="0x104FA58")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimBonusClubDungeonAttemptRequest.<>c <>9;

			[Address(RVA="0x1A40B8C", Offset="0x1A40B8C", VA="0x1A40B8C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A40BF0", Offset="0x1A40BF0", VA="0x1A40BF0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A40BF8", Offset="0x1A40BF8", VA="0x1A40BF8")]
			internal ClaimBonusClubDungeonAttemptRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}