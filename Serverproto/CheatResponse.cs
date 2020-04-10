using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CheatResponse : IMessage<CheatResponse>, IMessage, IEquatable<CheatResponse>, IDeepCloneable<CheatResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CheatResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ResultFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string result_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091B00", Offset="0x1091B00")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A3EA24", Offset="0x1A3EA24", VA="0x1A3EA24")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091AF0", Offset="0x1091AF0")]
		public static MessageParser<CheatResponse> Parser
		{
			[Address(RVA="0x1A3E9BC", Offset="0x1A3E9BC", VA="0x1A3E9BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091B10", Offset="0x1091B10")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A3EB14", Offset="0x1A3EB14", VA="0x1A3EB14", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091B20", Offset="0x1091B20")]
		public string Result
		{
			[Address(RVA="0x1A3EC88", Offset="0x1A3EC88", VA="0x1A3EC88")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A3EC90", Offset="0x1A3EC90", VA="0x1A3EC90")]
			set
			{
			}
		}

		[Address(RVA="0x1A3F120", Offset="0x1A3F120", VA="0x1A3F120")]
		static CheatResponse()
		{
		}

		[Address(RVA="0x1A3EB70", Offset="0x1A3EB70", VA="0x1A3EB70")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107597C", Offset="0x107597C")]
		public CheatResponse()
		{
		}

		[Address(RVA="0x1A3EBC8", Offset="0x1A3EBC8", VA="0x1A3EBC8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107598C", Offset="0x107598C")]
		public CheatResponse(CheatResponse other)
		{
		}

		[Address(RVA="0x1A3EF7C", Offset="0x1A3EF7C", VA="0x1A3EF7C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10759FC", Offset="0x10759FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A3EC28", Offset="0x1A3EC28", VA="0x1A3EC28", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107599C", Offset="0x107599C")]
		public CheatResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A3ED00", Offset="0x1A3ED00", VA="0x1A3ED00", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10759AC", Offset="0x10759AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3ED74", Offset="0x1A3ED74", VA="0x1A3ED74", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10759BC", Offset="0x10759BC")]
		public bool Equals(CheatResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3EDD8", Offset="0x1A3EDD8", VA="0x1A3EDD8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10759CC", Offset="0x10759CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A3F030", Offset="0x1A3F030", VA="0x1A3F030", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075A0C", Offset="0x1075A0C")]
		public void MergeFrom(CheatResponse other)
		{
		}

		[Address(RVA="0x1A3F09C", Offset="0x1A3F09C", VA="0x1A3F09C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075A1C", Offset="0x1075A1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A3EE5C", Offset="0x1A3EE5C", VA="0x1A3EE5C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10759DC", Offset="0x10759DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A3EEC4", Offset="0x1A3EEC4", VA="0x1A3EEC4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10759EC", Offset="0x10759EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EF28", Offset="0x104EF28")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CheatResponse.<>c <>9;

			[Address(RVA="0x1A3F1F8", Offset="0x1A3F1F8", VA="0x1A3F1F8")]
			static <>c()
			{
			}

			[Address(RVA="0x1A3F25C", Offset="0x1A3F25C", VA="0x1A3F25C")]
			public <>c()
			{
			}

			[Address(RVA="0x1A3F264", Offset="0x1A3F264", VA="0x1A3F264")]
			internal CheatResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}