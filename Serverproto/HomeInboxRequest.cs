using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeInboxRequest : IMessage<HomeInboxRequest>, IMessage, IEquatable<HomeInboxRequest>, IDeepCloneable<HomeInboxRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeInboxRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097DE0", Offset="0x1097DE0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D04DBC", Offset="0x1D04DBC", VA="0x1D04DBC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097DD0", Offset="0x1097DD0")]
		public static MessageParser<HomeInboxRequest> Parser
		{
			[Address(RVA="0x1D04D54", Offset="0x1D04D54", VA="0x1D04D54")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097DF0", Offset="0x1097DF0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D04EA8", Offset="0x1D04EA8", VA="0x1D04EA8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D051BC", Offset="0x1D051BC", VA="0x1D051BC")]
		static HomeInboxRequest()
		{
		}

		[Address(RVA="0x1D04F04", Offset="0x1D04F04", VA="0x1D04F04")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080A8C", Offset="0x1080A8C")]
		public HomeInboxRequest()
		{
		}

		[Address(RVA="0x1D04F0C", Offset="0x1D04F0C", VA="0x1D04F0C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080A9C", Offset="0x1080A9C")]
		public HomeInboxRequest(HomeInboxRequest other)
		{
		}

		[Address(RVA="0x1D05120", Offset="0x1D05120", VA="0x1D05120", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080B0C", Offset="0x1080B0C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D04F50", Offset="0x1D04F50", VA="0x1D04F50", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080AAC", Offset="0x1080AAC")]
		public HomeInboxRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1D04FB0", Offset="0x1D04FB0", VA="0x1D04FB0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080ABC", Offset="0x1080ABC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D05048", Offset="0x1D05048", VA="0x1D05048", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080ACC", Offset="0x1080ACC")]
		public bool Equals(HomeInboxRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1D05074", Offset="0x1D05074", VA="0x1D05074", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080ADC", Offset="0x1080ADC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D05134", Offset="0x1D05134", VA="0x1D05134", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080B1C", Offset="0x1080B1C")]
		public void MergeFrom(HomeInboxRequest other)
		{
		}

		[Address(RVA="0x1D05168", Offset="0x1D05168", VA="0x1D05168", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080B2C", Offset="0x1080B2C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D050A4", Offset="0x1D050A4", VA="0x1D050A4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080AEC", Offset="0x1080AEC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D0510C", Offset="0x1D0510C", VA="0x1D0510C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080AFC", Offset="0x1080AFC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FF88", Offset="0x104FF88")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeInboxRequest.<>c <>9;

			[Address(RVA="0x1D05294", Offset="0x1D05294", VA="0x1D05294")]
			static <>c()
			{
			}

			[Address(RVA="0x1D052F8", Offset="0x1D052F8", VA="0x1D052F8")]
			public <>c()
			{
			}

			[Address(RVA="0x1D05300", Offset="0x1D05300", VA="0x1D05300")]
			internal HomeInboxRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}