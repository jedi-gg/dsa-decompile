using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeShowcaseRequest : IMessage<HomeShowcaseRequest>, IMessage, IEquatable<HomeShowcaseRequest>, IDeepCloneable<HomeShowcaseRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeShowcaseRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097EE0", Offset="0x1097EE0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D5798", Offset="0x18D5798", VA="0x18D5798")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097ED0", Offset="0x1097ED0")]
		public static MessageParser<HomeShowcaseRequest> Parser
		{
			[Address(RVA="0x18D5730", Offset="0x18D5730", VA="0x18D5730")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097EF0", Offset="0x1097EF0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D5888", Offset="0x18D5888", VA="0x18D5888", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18D5B9C", Offset="0x18D5B9C", VA="0x18D5B9C")]
		static HomeShowcaseRequest()
		{
		}

		[Address(RVA="0x18D58E4", Offset="0x18D58E4", VA="0x18D58E4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080D4C", Offset="0x1080D4C")]
		public HomeShowcaseRequest()
		{
		}

		[Address(RVA="0x18D58EC", Offset="0x18D58EC", VA="0x18D58EC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080D5C", Offset="0x1080D5C")]
		public HomeShowcaseRequest(HomeShowcaseRequest other)
		{
		}

		[Address(RVA="0x18D5B00", Offset="0x18D5B00", VA="0x18D5B00", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080DCC", Offset="0x1080DCC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D5930", Offset="0x18D5930", VA="0x18D5930", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080D6C", Offset="0x1080D6C")]
		public HomeShowcaseRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18D5990", Offset="0x18D5990", VA="0x18D5990", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080D7C", Offset="0x1080D7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D5A28", Offset="0x18D5A28", VA="0x18D5A28", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080D8C", Offset="0x1080D8C")]
		public bool Equals(HomeShowcaseRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18D5A54", Offset="0x18D5A54", VA="0x18D5A54", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080D9C", Offset="0x1080D9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18D5B14", Offset="0x18D5B14", VA="0x18D5B14", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080DDC", Offset="0x1080DDC")]
		public void MergeFrom(HomeShowcaseRequest other)
		{
		}

		[Address(RVA="0x18D5B48", Offset="0x18D5B48", VA="0x18D5B48", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080DEC", Offset="0x1080DEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18D5A84", Offset="0x18D5A84", VA="0x18D5A84", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080DAC", Offset="0x1080DAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18D5AEC", Offset="0x18D5AEC", VA="0x18D5AEC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080DBC", Offset="0x1080DBC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FFC8", Offset="0x104FFC8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeShowcaseRequest.<>c <>9;

			[Address(RVA="0x18D5C74", Offset="0x18D5C74", VA="0x18D5C74")]
			static <>c()
			{
			}

			[Address(RVA="0x18D5CD8", Offset="0x18D5CD8", VA="0x18D5CD8")]
			public <>c()
			{
			}

			[Address(RVA="0x18D5CE0", Offset="0x18D5CE0", VA="0x18D5CE0")]
			internal HomeShowcaseRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}