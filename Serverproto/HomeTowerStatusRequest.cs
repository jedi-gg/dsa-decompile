using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeTowerStatusRequest : IMessage<HomeTowerStatusRequest>, IMessage, IEquatable<HomeTowerStatusRequest>, IDeepCloneable<HomeTowerStatusRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeTowerStatusRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097A70", Offset="0x1097A70")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D79E4", Offset="0x18D79E4", VA="0x18D79E4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097A60", Offset="0x1097A60")]
		public static MessageParser<HomeTowerStatusRequest> Parser
		{
			[Address(RVA="0x18D797C", Offset="0x18D797C", VA="0x18D797C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097A80", Offset="0x1097A80")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D7AD4", Offset="0x18D7AD4", VA="0x18D7AD4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18D7DE8", Offset="0x18D7DE8", VA="0x18D7DE8")]
		static HomeTowerStatusRequest()
		{
		}

		[Address(RVA="0x18D7B30", Offset="0x18D7B30", VA="0x18D7B30")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10803AC", Offset="0x10803AC")]
		public HomeTowerStatusRequest()
		{
		}

		[Address(RVA="0x18D7B38", Offset="0x18D7B38", VA="0x18D7B38")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10803BC", Offset="0x10803BC")]
		public HomeTowerStatusRequest(HomeTowerStatusRequest other)
		{
		}

		[Address(RVA="0x18D7D4C", Offset="0x18D7D4C", VA="0x18D7D4C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108042C", Offset="0x108042C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D7B7C", Offset="0x18D7B7C", VA="0x18D7B7C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10803CC", Offset="0x10803CC")]
		public HomeTowerStatusRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18D7BDC", Offset="0x18D7BDC", VA="0x18D7BDC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10803DC", Offset="0x10803DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D7C74", Offset="0x18D7C74", VA="0x18D7C74", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10803EC", Offset="0x10803EC")]
		public bool Equals(HomeTowerStatusRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18D7CA0", Offset="0x18D7CA0", VA="0x18D7CA0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10803FC", Offset="0x10803FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18D7D60", Offset="0x18D7D60", VA="0x18D7D60", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108043C", Offset="0x108043C")]
		public void MergeFrom(HomeTowerStatusRequest other)
		{
		}

		[Address(RVA="0x18D7D94", Offset="0x18D7D94", VA="0x18D7D94", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108044C", Offset="0x108044C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18D7CD0", Offset="0x18D7CD0", VA="0x18D7CD0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108040C", Offset="0x108040C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18D7D38", Offset="0x18D7D38", VA="0x18D7D38", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108041C", Offset="0x108041C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FEE8", Offset="0x104FEE8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeTowerStatusRequest.<>c <>9;

			[Address(RVA="0x18D7EC0", Offset="0x18D7EC0", VA="0x18D7EC0")]
			static <>c()
			{
			}

			[Address(RVA="0x18D7F24", Offset="0x18D7F24", VA="0x18D7F24")]
			public <>c()
			{
			}

			[Address(RVA="0x18D7F2C", Offset="0x18D7F2C", VA="0x18D7F2C")]
			internal HomeTowerStatusRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}