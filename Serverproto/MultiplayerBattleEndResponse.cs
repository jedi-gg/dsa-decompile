using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MultiplayerBattleEndResponse : IMessage<MultiplayerBattleEndResponse>, IMessage, IEquatable<MultiplayerBattleEndResponse>, IDeepCloneable<MultiplayerBattleEndResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MultiplayerBattleEndResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092A40", Offset="0x1092A40")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A23810", Offset="0x1A23810", VA="0x1A23810")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092A30", Offset="0x1092A30")]
		public static MessageParser<MultiplayerBattleEndResponse> Parser
		{
			[Address(RVA="0x1A237A8", Offset="0x1A237A8", VA="0x1A237A8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092A50", Offset="0x1092A50")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A23900", Offset="0x1A23900", VA="0x1A23900", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A23C14", Offset="0x1A23C14", VA="0x1A23C14")]
		static MultiplayerBattleEndResponse()
		{
		}

		[Address(RVA="0x1A2395C", Offset="0x1A2395C", VA="0x1A2395C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10772EC", Offset="0x10772EC")]
		public MultiplayerBattleEndResponse()
		{
		}

		[Address(RVA="0x1A23964", Offset="0x1A23964", VA="0x1A23964")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10772FC", Offset="0x10772FC")]
		public MultiplayerBattleEndResponse(MultiplayerBattleEndResponse other)
		{
		}

		[Address(RVA="0x1A23B78", Offset="0x1A23B78", VA="0x1A23B78", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107736C", Offset="0x107736C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A239A8", Offset="0x1A239A8", VA="0x1A239A8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107730C", Offset="0x107730C")]
		public MultiplayerBattleEndResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A23A08", Offset="0x1A23A08", VA="0x1A23A08", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107731C", Offset="0x107731C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A23AA0", Offset="0x1A23AA0", VA="0x1A23AA0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107732C", Offset="0x107732C")]
		public bool Equals(MultiplayerBattleEndResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A23ACC", Offset="0x1A23ACC", VA="0x1A23ACC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107733C", Offset="0x107733C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A23B8C", Offset="0x1A23B8C", VA="0x1A23B8C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107737C", Offset="0x107737C")]
		public void MergeFrom(MultiplayerBattleEndResponse other)
		{
		}

		[Address(RVA="0x1A23BC0", Offset="0x1A23BC0", VA="0x1A23BC0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107738C", Offset="0x107738C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A23AFC", Offset="0x1A23AFC", VA="0x1A23AFC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107734C", Offset="0x107734C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A23B64", Offset="0x1A23B64", VA="0x1A23B64", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107735C", Offset="0x107735C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F178", Offset="0x104F178")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MultiplayerBattleEndResponse.<>c <>9;

			[Address(RVA="0x1A23CEC", Offset="0x1A23CEC", VA="0x1A23CEC")]
			static <>c()
			{
			}

			[Address(RVA="0x1A23D50", Offset="0x1A23D50", VA="0x1A23D50")]
			public <>c()
			{
			}

			[Address(RVA="0x1A23D58", Offset="0x1A23D58", VA="0x1A23D58")]
			internal MultiplayerBattleEndResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}