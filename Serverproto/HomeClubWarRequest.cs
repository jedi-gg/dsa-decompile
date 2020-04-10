using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeClubWarRequest : IMessage<HomeClubWarRequest>, IMessage, IEquatable<HomeClubWarRequest>, IDeepCloneable<HomeClubWarRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeClubWarRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10980A0", Offset="0x10980A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D01A58", Offset="0x1D01A58", VA="0x1D01A58")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098090", Offset="0x1098090")]
		public static MessageParser<HomeClubWarRequest> Parser
		{
			[Address(RVA="0x1D019F0", Offset="0x1D019F0", VA="0x1D019F0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10980B0", Offset="0x10980B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D01B44", Offset="0x1D01B44", VA="0x1D01B44", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D01E58", Offset="0x1D01E58", VA="0x1D01E58")]
		static HomeClubWarRequest()
		{
		}

		[Address(RVA="0x1D01BA0", Offset="0x1D01BA0", VA="0x1D01BA0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10810BC", Offset="0x10810BC")]
		public HomeClubWarRequest()
		{
		}

		[Address(RVA="0x1D01BA8", Offset="0x1D01BA8", VA="0x1D01BA8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10810CC", Offset="0x10810CC")]
		public HomeClubWarRequest(HomeClubWarRequest other)
		{
		}

		[Address(RVA="0x1D01DBC", Offset="0x1D01DBC", VA="0x1D01DBC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108113C", Offset="0x108113C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D01BEC", Offset="0x1D01BEC", VA="0x1D01BEC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10810DC", Offset="0x10810DC")]
		public HomeClubWarRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1D01C4C", Offset="0x1D01C4C", VA="0x1D01C4C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10810EC", Offset="0x10810EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D01CE4", Offset="0x1D01CE4", VA="0x1D01CE4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10810FC", Offset="0x10810FC")]
		public bool Equals(HomeClubWarRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1D01D10", Offset="0x1D01D10", VA="0x1D01D10", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108110C", Offset="0x108110C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D01DD0", Offset="0x1D01DD0", VA="0x1D01DD0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108114C", Offset="0x108114C")]
		public void MergeFrom(HomeClubWarRequest other)
		{
		}

		[Address(RVA="0x1D01E04", Offset="0x1D01E04", VA="0x1D01E04", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108115C", Offset="0x108115C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D01D40", Offset="0x1D01D40", VA="0x1D01D40", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108111C", Offset="0x108111C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D01DA8", Offset="0x1D01DA8", VA="0x1D01DA8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108112C", Offset="0x108112C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050018", Offset="0x1050018")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeClubWarRequest.<>c <>9;

			[Address(RVA="0x1D01F30", Offset="0x1D01F30", VA="0x1D01F30")]
			static <>c()
			{
			}

			[Address(RVA="0x1D01F94", Offset="0x1D01F94", VA="0x1D01F94")]
			public <>c()
			{
			}

			[Address(RVA="0x1D01F9C", Offset="0x1D01F9C", VA="0x1D01F9C")]
			internal HomeClubWarRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}