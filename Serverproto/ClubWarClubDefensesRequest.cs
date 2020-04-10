using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarClubDefensesRequest : IMessage<ClubWarClubDefensesRequest>, IMessage, IEquatable<ClubWarClubDefensesRequest>, IDeepCloneable<ClubWarClubDefensesRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarClubDefensesRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096250", Offset="0x1096250")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B1FADC", Offset="0x1B1FADC", VA="0x1B1FADC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096240", Offset="0x1096240")]
		public static MessageParser<ClubWarClubDefensesRequest> Parser
		{
			[Address(RVA="0x1B1FA74", Offset="0x1B1FA74", VA="0x1B1FA74")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096260", Offset="0x1096260")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B1FBCC", Offset="0x1B1FBCC", VA="0x1B1FBCC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B1FEE0", Offset="0x1B1FEE0", VA="0x1B1FEE0")]
		static ClubWarClubDefensesRequest()
		{
		}

		[Address(RVA="0x1B1FC28", Offset="0x1B1FC28", VA="0x1B1FC28")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E1FC", Offset="0x107E1FC")]
		public ClubWarClubDefensesRequest()
		{
		}

		[Address(RVA="0x1B1FC30", Offset="0x1B1FC30", VA="0x1B1FC30")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E20C", Offset="0x107E20C")]
		public ClubWarClubDefensesRequest(ClubWarClubDefensesRequest other)
		{
		}

		[Address(RVA="0x1B1FE44", Offset="0x1B1FE44", VA="0x1B1FE44", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E27C", Offset="0x107E27C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B1FC74", Offset="0x1B1FC74", VA="0x1B1FC74", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E21C", Offset="0x107E21C")]
		public ClubWarClubDefensesRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B1FCD4", Offset="0x1B1FCD4", VA="0x1B1FCD4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E22C", Offset="0x107E22C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1FD6C", Offset="0x1B1FD6C", VA="0x1B1FD6C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E23C", Offset="0x107E23C")]
		public bool Equals(ClubWarClubDefensesRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1FD98", Offset="0x1B1FD98", VA="0x1B1FD98", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E24C", Offset="0x107E24C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B1FE58", Offset="0x1B1FE58", VA="0x1B1FE58", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E28C", Offset="0x107E28C")]
		public void MergeFrom(ClubWarClubDefensesRequest other)
		{
		}

		[Address(RVA="0x1B1FE8C", Offset="0x1B1FE8C", VA="0x1B1FE8C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E29C", Offset="0x107E29C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B1FDC8", Offset="0x1B1FDC8", VA="0x1B1FDC8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E25C", Offset="0x107E25C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B1FE30", Offset="0x1B1FE30", VA="0x1B1FE30", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E26C", Offset="0x107E26C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FBD8", Offset="0x104FBD8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarClubDefensesRequest.<>c <>9;

			[Address(RVA="0x1B1FFB8", Offset="0x1B1FFB8", VA="0x1B1FFB8")]
			static <>c()
			{
			}

			[Address(RVA="0x1B2001C", Offset="0x1B2001C", VA="0x1B2001C")]
			public <>c()
			{
			}

			[Address(RVA="0x1B20024", Offset="0x1B20024", VA="0x1B20024")]
			internal ClubWarClubDefensesRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}