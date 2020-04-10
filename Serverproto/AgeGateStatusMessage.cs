using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AgeGateStatusMessage : IMessage<AgeGateStatusMessage>, IMessage, IEquatable<AgeGateStatusMessage>, IDeepCloneable<AgeGateStatusMessage>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AgeGateStatusMessage> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StatusFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private AgeGateStatus status_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B010", Offset="0x109B010")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1607C7C", Offset="0x1607C7C", VA="0x1607C7C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B000", Offset="0x109B000")]
		public static MessageParser<AgeGateStatusMessage> Parser
		{
			[Address(RVA="0x1607C14", Offset="0x1607C14", VA="0x1607C14")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B020", Offset="0x109B020")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1607D6C", Offset="0x1607D6C", VA="0x1607D6C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B030", Offset="0x109B030")]
		public AgeGateStatus Status
		{
			[Address(RVA="0x1607E94", Offset="0x1607E94", VA="0x1607E94")]
			get
			{
				return new AgeGateStatus();
			}
			[Address(RVA="0x1607E9C", Offset="0x1607E9C", VA="0x1607E9C")]
			set
			{
			}
		}

		[Address(RVA="0x1608210", Offset="0x1608210", VA="0x1608210")]
		static AgeGateStatusMessage()
		{
		}

		[Address(RVA="0x1607DC8", Offset="0x1607DC8", VA="0x1607DC8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108621C", Offset="0x108621C")]
		public AgeGateStatusMessage()
		{
		}

		[Address(RVA="0x1607DD0", Offset="0x1607DD0", VA="0x1607DD0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108622C", Offset="0x108622C")]
		public AgeGateStatusMessage(AgeGateStatusMessage other)
		{
		}

		[Address(RVA="0x16080C4", Offset="0x16080C4", VA="0x16080C4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108629C", Offset="0x108629C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1607E34", Offset="0x1607E34", VA="0x1607E34", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108623C", Offset="0x108623C")]
		public AgeGateStatusMessage Clone()
		{
			return null;
		}

		[Address(RVA="0x1607EA4", Offset="0x1607EA4", VA="0x1607EA4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108624C", Offset="0x108624C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1607F18", Offset="0x1607F18", VA="0x1607F18", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108625C", Offset="0x108625C")]
		public bool Equals(AgeGateStatusMessage other)
		{
			return new bool();
		}

		[Address(RVA="0x1607F54", Offset="0x1607F54", VA="0x1607F54", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108626C", Offset="0x108626C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1608154", Offset="0x1608154", VA="0x1608154", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10862AC", Offset="0x10862AC")]
		public void MergeFrom(AgeGateStatusMessage other)
		{
		}

		[Address(RVA="0x1608194", Offset="0x1608194", VA="0x1608194", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10862BC", Offset="0x10862BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1607FBC", Offset="0x1607FBC", VA="0x1607FBC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108627C", Offset="0x108627C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1608024", Offset="0x1608024", VA="0x1608024", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108628C", Offset="0x108628C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050778", Offset="0x1050778")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AgeGateStatusMessage.<>c <>9;

			[Address(RVA="0x16082E8", Offset="0x16082E8", VA="0x16082E8")]
			static <>c()
			{
			}

			[Address(RVA="0x160834C", Offset="0x160834C", VA="0x160834C")]
			public <>c()
			{
			}

			[Address(RVA="0x1608354", Offset="0x1608354", VA="0x1608354")]
			internal AgeGateStatusMessage <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}