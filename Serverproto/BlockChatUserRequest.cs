using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BlockChatUserRequest : IMessage<BlockChatUserRequest>, IMessage, IEquatable<BlockChatUserRequest>, IDeepCloneable<BlockChatUserRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BlockChatUserRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094720", Offset="0x1094720")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD8B04", Offset="0x1DD8B04", VA="0x1DD8B04")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094710", Offset="0x1094710")]
		public static MessageParser<BlockChatUserRequest> Parser
		{
			[Address(RVA="0x1DD8A9C", Offset="0x1DD8A9C", VA="0x1DD8A9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094730", Offset="0x1094730")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD8BF4", Offset="0x1DD8BF4", VA="0x1DD8BF4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094740", Offset="0x1094740")]
		public string PlayerId
		{
			[Address(RVA="0x1DD8D68", Offset="0x1DD8D68", VA="0x1DD8D68")]
			get
			{
				return null;
			}
			[Address(RVA="0x1DD8D70", Offset="0x1DD8D70", VA="0x1DD8D70")]
			set
			{
			}
		}

		[Address(RVA="0x1DD9200", Offset="0x1DD9200", VA="0x1DD9200")]
		static BlockChatUserRequest()
		{
		}

		[Address(RVA="0x1DD8C50", Offset="0x1DD8C50", VA="0x1DD8C50")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A36C", Offset="0x107A36C")]
		public BlockChatUserRequest()
		{
		}

		[Address(RVA="0x1DD8CA8", Offset="0x1DD8CA8", VA="0x1DD8CA8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A37C", Offset="0x107A37C")]
		public BlockChatUserRequest(BlockChatUserRequest other)
		{
		}

		[Address(RVA="0x1DD905C", Offset="0x1DD905C", VA="0x1DD905C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A3EC", Offset="0x107A3EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD8D08", Offset="0x1DD8D08", VA="0x1DD8D08", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A38C", Offset="0x107A38C")]
		public BlockChatUserRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD8DE0", Offset="0x1DD8DE0", VA="0x1DD8DE0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A39C", Offset="0x107A39C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD8E54", Offset="0x1DD8E54", VA="0x1DD8E54", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A3AC", Offset="0x107A3AC")]
		public bool Equals(BlockChatUserRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD8EB8", Offset="0x1DD8EB8", VA="0x1DD8EB8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A3BC", Offset="0x107A3BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD9110", Offset="0x1DD9110", VA="0x1DD9110", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A3FC", Offset="0x107A3FC")]
		public void MergeFrom(BlockChatUserRequest other)
		{
		}

		[Address(RVA="0x1DD917C", Offset="0x1DD917C", VA="0x1DD917C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A40C", Offset="0x107A40C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD8F3C", Offset="0x1DD8F3C", VA="0x1DD8F3C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A3CC", Offset="0x107A3CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD8FA4", Offset="0x1DD8FA4", VA="0x1DD8FA4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A3DC", Offset="0x107A3DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F618", Offset="0x104F618")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BlockChatUserRequest.<>c <>9;

			[Address(RVA="0x1DD92D8", Offset="0x1DD92D8", VA="0x1DD92D8")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD933C", Offset="0x1DD933C", VA="0x1DD933C")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD9344", Offset="0x1DD9344", VA="0x1DD9344")]
			internal BlockChatUserRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}