using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ExpireRpcCacheMessage : IMessage<ExpireRpcCacheMessage>, IMessage, IEquatable<ExpireRpcCacheMessage>, IDeepCloneable<ExpireRpcCacheMessage>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ExpireRpcCacheMessage> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RpcNameFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string rpcName_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BAF0", Offset="0x109BAF0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B9AA94", Offset="0x1B9AA94", VA="0x1B9AA94")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BAE0", Offset="0x109BAE0")]
		public static MessageParser<ExpireRpcCacheMessage> Parser
		{
			[Address(RVA="0x1B9AA2C", Offset="0x1B9AA2C", VA="0x1B9AA2C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BB00", Offset="0x109BB00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B9AB84", Offset="0x1B9AB84", VA="0x1B9AB84", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BB10", Offset="0x109BB10")]
		public string RpcName
		{
			[Address(RVA="0x1B9ACF8", Offset="0x1B9ACF8", VA="0x1B9ACF8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B9AD00", Offset="0x1B9AD00", VA="0x1B9AD00")]
			set
			{
			}
		}

		[Address(RVA="0x1B9B190", Offset="0x1B9B190", VA="0x1B9B190")]
		static ExpireRpcCacheMessage()
		{
		}

		[Address(RVA="0x1B9ABE0", Offset="0x1B9ABE0", VA="0x1B9ABE0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10878CC", Offset="0x10878CC")]
		public ExpireRpcCacheMessage()
		{
		}

		[Address(RVA="0x1B9AC38", Offset="0x1B9AC38", VA="0x1B9AC38")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10878DC", Offset="0x10878DC")]
		public ExpireRpcCacheMessage(ExpireRpcCacheMessage other)
		{
		}

		[Address(RVA="0x1B9AFEC", Offset="0x1B9AFEC", VA="0x1B9AFEC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108794C", Offset="0x108794C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B9AC98", Offset="0x1B9AC98", VA="0x1B9AC98", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10878EC", Offset="0x10878EC")]
		public ExpireRpcCacheMessage Clone()
		{
			return null;
		}

		[Address(RVA="0x1B9AD70", Offset="0x1B9AD70", VA="0x1B9AD70", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10878FC", Offset="0x10878FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9ADE4", Offset="0x1B9ADE4", VA="0x1B9ADE4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108790C", Offset="0x108790C")]
		public bool Equals(ExpireRpcCacheMessage other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9AE48", Offset="0x1B9AE48", VA="0x1B9AE48", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108791C", Offset="0x108791C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B9B0A0", Offset="0x1B9B0A0", VA="0x1B9B0A0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108795C", Offset="0x108795C")]
		public void MergeFrom(ExpireRpcCacheMessage other)
		{
		}

		[Address(RVA="0x1B9B10C", Offset="0x1B9B10C", VA="0x1B9B10C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108796C", Offset="0x108796C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B9AECC", Offset="0x1B9AECC", VA="0x1B9AECC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108792C", Offset="0x108792C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B9AF34", Offset="0x1B9AF34", VA="0x1B9AF34", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108793C", Offset="0x108793C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050988", Offset="0x1050988")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ExpireRpcCacheMessage.<>c <>9;

			[Address(RVA="0x1B9B268", Offset="0x1B9B268", VA="0x1B9B268")]
			static <>c()
			{
			}

			[Address(RVA="0x1B9B2CC", Offset="0x1B9B2CC", VA="0x1B9B2CC")]
			public <>c()
			{
			}

			[Address(RVA="0x1B9B2D4", Offset="0x1B9B2D4", VA="0x1B9B2D4")]
			internal ExpireRpcCacheMessage <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}