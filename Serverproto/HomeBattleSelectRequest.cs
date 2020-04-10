using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeBattleSelectRequest : IMessage<HomeBattleSelectRequest>, IMessage, IEquatable<HomeBattleSelectRequest>, IDeepCloneable<HomeBattleSelectRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeBattleSelectRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098250", Offset="0x1098250")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BAE15C", Offset="0x1BAE15C", VA="0x1BAE15C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098240", Offset="0x1098240")]
		public static MessageParser<HomeBattleSelectRequest> Parser
		{
			[Address(RVA="0x1BAE0F4", Offset="0x1BAE0F4", VA="0x1BAE0F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098260", Offset="0x1098260")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BAE24C", Offset="0x1BAE24C", VA="0x1BAE24C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BAE560", Offset="0x1BAE560", VA="0x1BAE560")]
		static HomeBattleSelectRequest()
		{
		}

		[Address(RVA="0x1BAE2A8", Offset="0x1BAE2A8", VA="0x1BAE2A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10814DC", Offset="0x10814DC")]
		public HomeBattleSelectRequest()
		{
		}

		[Address(RVA="0x1BAE2B0", Offset="0x1BAE2B0", VA="0x1BAE2B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10814EC", Offset="0x10814EC")]
		public HomeBattleSelectRequest(HomeBattleSelectRequest other)
		{
		}

		[Address(RVA="0x1BAE4C4", Offset="0x1BAE4C4", VA="0x1BAE4C4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108155C", Offset="0x108155C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BAE2F4", Offset="0x1BAE2F4", VA="0x1BAE2F4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10814FC", Offset="0x10814FC")]
		public HomeBattleSelectRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BAE354", Offset="0x1BAE354", VA="0x1BAE354", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108150C", Offset="0x108150C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BAE3EC", Offset="0x1BAE3EC", VA="0x1BAE3EC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108151C", Offset="0x108151C")]
		public bool Equals(HomeBattleSelectRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BAE418", Offset="0x1BAE418", VA="0x1BAE418", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108152C", Offset="0x108152C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BAE4D8", Offset="0x1BAE4D8", VA="0x1BAE4D8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108156C", Offset="0x108156C")]
		public void MergeFrom(HomeBattleSelectRequest other)
		{
		}

		[Address(RVA="0x1BAE50C", Offset="0x1BAE50C", VA="0x1BAE50C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108157C", Offset="0x108157C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BAE448", Offset="0x1BAE448", VA="0x1BAE448", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108153C", Offset="0x108153C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BAE4B0", Offset="0x1BAE4B0", VA="0x1BAE4B0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108154C", Offset="0x108154C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050078", Offset="0x1050078")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeBattleSelectRequest.<>c <>9;

			[Address(RVA="0x1BAE638", Offset="0x1BAE638", VA="0x1BAE638")]
			static <>c()
			{
			}

			[Address(RVA="0x1BAE69C", Offset="0x1BAE69C", VA="0x1BAE69C")]
			public <>c()
			{
			}

			[Address(RVA="0x1BAE6A4", Offset="0x1BAE6A4", VA="0x1BAE6A4")]
			internal HomeBattleSelectRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}