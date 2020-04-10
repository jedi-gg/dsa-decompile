using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreRequest : IMessage<StoreRequest>, IMessage, IEquatable<StoreRequest>, IDeepCloneable<StoreRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C4B8", Offset="0x109C4B8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B678D4", Offset="0x1B678D4", VA="0x1B678D4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C4A8", Offset="0x109C4A8")]
		public static MessageParser<StoreRequest> Parser
		{
			[Address(RVA="0x1B67804", Offset="0x1B67804", VA="0x1B67804")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C4C8", Offset="0x109C4C8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B679C0", Offset="0x1B679C0", VA="0x1B679C0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B67CD4", Offset="0x1B67CD4", VA="0x1B67CD4")]
		static StoreRequest()
		{
		}

		[Address(RVA="0x1B67A1C", Offset="0x1B67A1C", VA="0x1B67A1C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108847C", Offset="0x108847C")]
		public StoreRequest()
		{
		}

		[Address(RVA="0x1B67A24", Offset="0x1B67A24", VA="0x1B67A24")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108848C", Offset="0x108848C")]
		public StoreRequest(StoreRequest other)
		{
		}

		[Address(RVA="0x1B67C38", Offset="0x1B67C38", VA="0x1B67C38", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10884FC", Offset="0x10884FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B67A68", Offset="0x1B67A68", VA="0x1B67A68", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108849C", Offset="0x108849C")]
		public StoreRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B67AC8", Offset="0x1B67AC8", VA="0x1B67AC8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10884AC", Offset="0x10884AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B67B60", Offset="0x1B67B60", VA="0x1B67B60", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10884BC", Offset="0x10884BC")]
		public bool Equals(StoreRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B67B8C", Offset="0x1B67B8C", VA="0x1B67B8C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10884CC", Offset="0x10884CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B67C4C", Offset="0x1B67C4C", VA="0x1B67C4C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108850C", Offset="0x108850C")]
		public void MergeFrom(StoreRequest other)
		{
		}

		[Address(RVA="0x1B67C80", Offset="0x1B67C80", VA="0x1B67C80", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108851C", Offset="0x108851C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B67BBC", Offset="0x1B67BBC", VA="0x1B67BBC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10884DC", Offset="0x10884DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B67C24", Offset="0x1B67C24", VA="0x1B67C24", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10884EC", Offset="0x10884EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050AA8", Offset="0x1050AA8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreRequest.<>c <>9;

			[Address(RVA="0x1B67DAC", Offset="0x1B67DAC", VA="0x1B67DAC")]
			static <>c()
			{
			}

			[Address(RVA="0x1B67E10", Offset="0x1B67E10", VA="0x1B67E10")]
			public <>c()
			{
			}

			[Address(RVA="0x1B67E18", Offset="0x1B67E18", VA="0x1B67E18")]
			internal StoreRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}