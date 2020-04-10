using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class UpdatePlayerProfileResponse : IMessage<UpdatePlayerProfileResponse>, IMessage, IEquatable<UpdatePlayerProfileResponse>, IDeepCloneable<UpdatePlayerProfileResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<UpdatePlayerProfileResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A5E0", Offset="0x109A5E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x14B8890", Offset="0x14B8890", VA="0x14B8890")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A5D0", Offset="0x109A5D0")]
		public static MessageParser<UpdatePlayerProfileResponse> Parser
		{
			[Address(RVA="0x14B8828", Offset="0x14B8828", VA="0x14B8828")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A5F0", Offset="0x109A5F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x14B8980", Offset="0x14B8980", VA="0x14B8980", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14B8C94", Offset="0x14B8C94", VA="0x14B8C94")]
		static UpdatePlayerProfileResponse()
		{
		}

		[Address(RVA="0x14B89DC", Offset="0x14B89DC", VA="0x14B89DC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108474C", Offset="0x108474C")]
		public UpdatePlayerProfileResponse()
		{
		}

		[Address(RVA="0x14B89E4", Offset="0x14B89E4", VA="0x14B89E4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108475C", Offset="0x108475C")]
		public UpdatePlayerProfileResponse(UpdatePlayerProfileResponse other)
		{
		}

		[Address(RVA="0x14B8BF8", Offset="0x14B8BF8", VA="0x14B8BF8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10847CC", Offset="0x10847CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x14B8A28", Offset="0x14B8A28", VA="0x14B8A28", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108476C", Offset="0x108476C")]
		public UpdatePlayerProfileResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x14B8A88", Offset="0x14B8A88", VA="0x14B8A88", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108477C", Offset="0x108477C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x14B8B20", Offset="0x14B8B20", VA="0x14B8B20", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108478C", Offset="0x108478C")]
		public bool Equals(UpdatePlayerProfileResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x14B8B4C", Offset="0x14B8B4C", VA="0x14B8B4C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108479C", Offset="0x108479C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x14B8C0C", Offset="0x14B8C0C", VA="0x14B8C0C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10847DC", Offset="0x10847DC")]
		public void MergeFrom(UpdatePlayerProfileResponse other)
		{
		}

		[Address(RVA="0x14B8C40", Offset="0x14B8C40", VA="0x14B8C40", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10847EC", Offset="0x10847EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x14B8B7C", Offset="0x14B8B7C", VA="0x14B8B7C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10847AC", Offset="0x10847AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14B8BE4", Offset="0x14B8BE4", VA="0x14B8BE4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10847BC", Offset="0x10847BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050508", Offset="0x1050508")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UpdatePlayerProfileResponse.<>c <>9;

			[Address(RVA="0x14B8D6C", Offset="0x14B8D6C", VA="0x14B8D6C")]
			static <>c()
			{
			}

			[Address(RVA="0x14B8DD0", Offset="0x14B8DD0", VA="0x14B8DD0")]
			public <>c()
			{
			}

			[Address(RVA="0x14B8DD8", Offset="0x14B8DD8", VA="0x14B8DD8")]
			internal UpdatePlayerProfileResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}