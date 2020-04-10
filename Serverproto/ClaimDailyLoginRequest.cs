using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimDailyLoginRequest : IMessage<ClaimDailyLoginRequest>, IMessage, IEquatable<ClaimDailyLoginRequest>, IDeepCloneable<ClaimDailyLoginRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimDailyLoginRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ACD0", Offset="0x109ACD0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A43990", Offset="0x1A43990", VA="0x1A43990")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ACC0", Offset="0x109ACC0")]
		public static MessageParser<ClaimDailyLoginRequest> Parser
		{
			[Address(RVA="0x1A43928", Offset="0x1A43928", VA="0x1A43928")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ACE0", Offset="0x109ACE0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A43A80", Offset="0x1A43A80", VA="0x1A43A80", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A43D94", Offset="0x1A43D94", VA="0x1A43D94")]
		static ClaimDailyLoginRequest()
		{
		}

		[Address(RVA="0x1A43ADC", Offset="0x1A43ADC", VA="0x1A43ADC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108592C", Offset="0x108592C")]
		public ClaimDailyLoginRequest()
		{
		}

		[Address(RVA="0x1A43AE4", Offset="0x1A43AE4", VA="0x1A43AE4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108593C", Offset="0x108593C")]
		public ClaimDailyLoginRequest(ClaimDailyLoginRequest other)
		{
		}

		[Address(RVA="0x1A43CF8", Offset="0x1A43CF8", VA="0x1A43CF8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10859AC", Offset="0x10859AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A43B28", Offset="0x1A43B28", VA="0x1A43B28", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108594C", Offset="0x108594C")]
		public ClaimDailyLoginRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A43B88", Offset="0x1A43B88", VA="0x1A43B88", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108595C", Offset="0x108595C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A43C20", Offset="0x1A43C20", VA="0x1A43C20", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108596C", Offset="0x108596C")]
		public bool Equals(ClaimDailyLoginRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A43C4C", Offset="0x1A43C4C", VA="0x1A43C4C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108597C", Offset="0x108597C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A43D0C", Offset="0x1A43D0C", VA="0x1A43D0C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10859BC", Offset="0x10859BC")]
		public void MergeFrom(ClaimDailyLoginRequest other)
		{
		}

		[Address(RVA="0x1A43D40", Offset="0x1A43D40", VA="0x1A43D40", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10859CC", Offset="0x10859CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A43C7C", Offset="0x1A43C7C", VA="0x1A43C7C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108598C", Offset="0x108598C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A43CE4", Offset="0x1A43CE4", VA="0x1A43CE4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108599C", Offset="0x108599C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10506A8", Offset="0x10506A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimDailyLoginRequest.<>c <>9;

			[Address(RVA="0x1A43E6C", Offset="0x1A43E6C", VA="0x1A43E6C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A43ED0", Offset="0x1A43ED0", VA="0x1A43ED0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A43ED8", Offset="0x1A43ED8", VA="0x1A43ED8")]
			internal ClaimDailyLoginRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}