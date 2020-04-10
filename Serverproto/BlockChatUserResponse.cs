using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BlockChatUserResponse : IMessage<BlockChatUserResponse>, IMessage, IEquatable<BlockChatUserResponse>, IDeepCloneable<BlockChatUserResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BlockChatUserResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094760", Offset="0x1094760")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD9404", Offset="0x1DD9404", VA="0x1DD9404")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094750", Offset="0x1094750")]
		public static MessageParser<BlockChatUserResponse> Parser
		{
			[Address(RVA="0x1DD939C", Offset="0x1DD939C", VA="0x1DD939C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094770", Offset="0x1094770")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD94F4", Offset="0x1DD94F4", VA="0x1DD94F4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1DD9808", Offset="0x1DD9808", VA="0x1DD9808")]
		static BlockChatUserResponse()
		{
		}

		[Address(RVA="0x1DD9550", Offset="0x1DD9550", VA="0x1DD9550")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A41C", Offset="0x107A41C")]
		public BlockChatUserResponse()
		{
		}

		[Address(RVA="0x1DD9558", Offset="0x1DD9558", VA="0x1DD9558")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A42C", Offset="0x107A42C")]
		public BlockChatUserResponse(BlockChatUserResponse other)
		{
		}

		[Address(RVA="0x1DD976C", Offset="0x1DD976C", VA="0x1DD976C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A49C", Offset="0x107A49C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD959C", Offset="0x1DD959C", VA="0x1DD959C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A43C", Offset="0x107A43C")]
		public BlockChatUserResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD95FC", Offset="0x1DD95FC", VA="0x1DD95FC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A44C", Offset="0x107A44C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD9694", Offset="0x1DD9694", VA="0x1DD9694", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A45C", Offset="0x107A45C")]
		public bool Equals(BlockChatUserResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD96C0", Offset="0x1DD96C0", VA="0x1DD96C0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A46C", Offset="0x107A46C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD9780", Offset="0x1DD9780", VA="0x1DD9780", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A4AC", Offset="0x107A4AC")]
		public void MergeFrom(BlockChatUserResponse other)
		{
		}

		[Address(RVA="0x1DD97B4", Offset="0x1DD97B4", VA="0x1DD97B4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A4BC", Offset="0x107A4BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD96F0", Offset="0x1DD96F0", VA="0x1DD96F0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A47C", Offset="0x107A47C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD9758", Offset="0x1DD9758", VA="0x1DD9758", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A48C", Offset="0x107A48C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F628", Offset="0x104F628")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BlockChatUserResponse.<>c <>9;

			[Address(RVA="0x1DD98E0", Offset="0x1DD98E0", VA="0x1DD98E0")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD9944", Offset="0x1DD9944", VA="0x1DD9944")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD994C", Offset="0x1DD994C", VA="0x1DD994C")]
			internal BlockChatUserResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}