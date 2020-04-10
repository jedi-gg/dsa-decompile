using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CheatRequest : IMessage<CheatRequest>, IMessage, IEquatable<CheatRequest>, IDeepCloneable<CheatRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CheatRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CommandFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string command_;

		[FieldOffset(Offset="0x0")]
		public const int ArgumentsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<string> _repeated_arguments_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<string> arguments_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091AE0", Offset="0x1091AE0")]
		public RepeatedField<string> Arguments
		{
			[Address(RVA="0x1A3E190", Offset="0x1A3E190", VA="0x1A3E190")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091AD0", Offset="0x1091AD0")]
		public string Command
		{
			[Address(RVA="0x1A3E118", Offset="0x1A3E118", VA="0x1A3E118")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A3E120", Offset="0x1A3E120", VA="0x1A3E120")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091AB0", Offset="0x1091AB0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A3DE34", Offset="0x1A3DE34", VA="0x1A3DE34")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091AA0", Offset="0x1091AA0")]
		public static MessageParser<CheatRequest> Parser
		{
			[Address(RVA="0x1A3DDCC", Offset="0x1A3DDCC", VA="0x1A3DDCC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091AC0", Offset="0x1091AC0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A3DF24", Offset="0x1A3DF24", VA="0x1A3DF24", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A3E808", Offset="0x1A3E808", VA="0x1A3E808")]
		static CheatRequest()
		{
		}

		[Address(RVA="0x1A3DF80", Offset="0x1A3DF80", VA="0x1A3DF80")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10758CC", Offset="0x10758CC")]
		public CheatRequest()
		{
		}

		[Address(RVA="0x1A3E000", Offset="0x1A3E000", VA="0x1A3E000")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10758DC", Offset="0x10758DC")]
		public CheatRequest(CheatRequest other)
		{
		}

		[Address(RVA="0x1A3E520", Offset="0x1A3E520", VA="0x1A3E520", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107594C", Offset="0x107594C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A3E0B8", Offset="0x1A3E0B8", VA="0x1A3E0B8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10758EC", Offset="0x10758EC")]
		public CheatRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A3E198", Offset="0x1A3E198", VA="0x1A3E198", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10758FC", Offset="0x10758FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3E20C", Offset="0x1A3E20C", VA="0x1A3E20C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107590C", Offset="0x107590C")]
		public bool Equals(CheatRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3E2D0", Offset="0x1A3E2D0", VA="0x1A3E2D0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107591C", Offset="0x107591C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A3E638", Offset="0x1A3E638", VA="0x1A3E638", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107595C", Offset="0x107595C")]
		public void MergeFrom(CheatRequest other)
		{
		}

		[Address(RVA="0x1A3E6F4", Offset="0x1A3E6F4", VA="0x1A3E6F4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107596C", Offset="0x107596C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A3E384", Offset="0x1A3E384", VA="0x1A3E384", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107592C", Offset="0x107592C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A3E3EC", Offset="0x1A3E3EC", VA="0x1A3E3EC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107593C", Offset="0x107593C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EF18", Offset="0x104EF18")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CheatRequest.<>c <>9;

			[Address(RVA="0x1A3E8F8", Offset="0x1A3E8F8", VA="0x1A3E8F8")]
			static <>c()
			{
			}

			[Address(RVA="0x1A3E95C", Offset="0x1A3E95C", VA="0x1A3E95C")]
			public <>c()
			{
			}

			[Address(RVA="0x1A3E964", Offset="0x1A3E964", VA="0x1A3E964")]
			internal CheatRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}