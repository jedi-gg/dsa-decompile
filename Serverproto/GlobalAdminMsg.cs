using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GlobalAdminMsg : IMessage<GlobalAdminMsg>, IMessage, IEquatable<GlobalAdminMsg>, IDeepCloneable<GlobalAdminMsg>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GlobalAdminMsg> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MsgLocKeyFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string msgLocKey_;

		[FieldOffset(Offset="0x0")]
		public const int ParamsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<string> _repeated_params_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<string> params_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10946A0", Offset="0x10946A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BAD56C", Offset="0x1BAD56C", VA="0x1BAD56C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10946C0", Offset="0x10946C0")]
		public string MsgLocKey
		{
			[Address(RVA="0x1BAD850", Offset="0x1BAD850", VA="0x1BAD850")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BAD858", Offset="0x1BAD858", VA="0x1BAD858")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10946D0", Offset="0x10946D0")]
		public RepeatedField<string> Params
		{
			[Address(RVA="0x1BAD8C8", Offset="0x1BAD8C8", VA="0x1BAD8C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094690", Offset="0x1094690")]
		public static MessageParser<GlobalAdminMsg> Parser
		{
			[Address(RVA="0x1BAD504", Offset="0x1BAD504", VA="0x1BAD504")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10946B0", Offset="0x10946B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BAD65C", Offset="0x1BAD65C", VA="0x1BAD65C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BADF40", Offset="0x1BADF40", VA="0x1BADF40")]
		static GlobalAdminMsg()
		{
		}

		[Address(RVA="0x1BAD6B8", Offset="0x1BAD6B8", VA="0x1BAD6B8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A20C", Offset="0x107A20C")]
		public GlobalAdminMsg()
		{
		}

		[Address(RVA="0x1BAD738", Offset="0x1BAD738", VA="0x1BAD738")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A21C", Offset="0x107A21C")]
		public GlobalAdminMsg(GlobalAdminMsg other)
		{
		}

		[Address(RVA="0x1BADC58", Offset="0x1BADC58", VA="0x1BADC58", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A28C", Offset="0x107A28C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BAD7F0", Offset="0x1BAD7F0", VA="0x1BAD7F0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A22C", Offset="0x107A22C")]
		public GlobalAdminMsg Clone()
		{
			return null;
		}

		[Address(RVA="0x1BAD8D0", Offset="0x1BAD8D0", VA="0x1BAD8D0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A23C", Offset="0x107A23C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BAD944", Offset="0x1BAD944", VA="0x1BAD944", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A24C", Offset="0x107A24C")]
		public bool Equals(GlobalAdminMsg other)
		{
			return new bool();
		}

		[Address(RVA="0x1BADA08", Offset="0x1BADA08", VA="0x1BADA08", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A25C", Offset="0x107A25C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BADD70", Offset="0x1BADD70", VA="0x1BADD70", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A29C", Offset="0x107A29C")]
		public void MergeFrom(GlobalAdminMsg other)
		{
		}

		[Address(RVA="0x1BADE2C", Offset="0x1BADE2C", VA="0x1BADE2C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A2AC", Offset="0x107A2AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BADABC", Offset="0x1BADABC", VA="0x1BADABC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A26C", Offset="0x107A26C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BADB24", Offset="0x1BADB24", VA="0x1BADB24", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A27C", Offset="0x107A27C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F5F8", Offset="0x104F5F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GlobalAdminMsg.<>c <>9;

			[Address(RVA="0x1BAE030", Offset="0x1BAE030", VA="0x1BAE030")]
			static <>c()
			{
			}

			[Address(RVA="0x1BAE094", Offset="0x1BAE094", VA="0x1BAE094")]
			public <>c()
			{
			}

			[Address(RVA="0x1BAE09C", Offset="0x1BAE09C", VA="0x1BAE09C")]
			internal GlobalAdminMsg <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}