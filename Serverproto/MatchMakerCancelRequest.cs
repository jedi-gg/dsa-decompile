using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MatchMakerCancelRequest : IMessage<MatchMakerCancelRequest>, IMessage, IEquatable<MatchMakerCancelRequest>, IDeepCloneable<MatchMakerCancelRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MatchMakerCancelRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10926D0", Offset="0x10926D0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A1A1F0", Offset="0x1A1A1F0", VA="0x1A1A1F0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10926C0", Offset="0x10926C0")]
		public static MessageParser<MatchMakerCancelRequest> Parser
		{
			[Address(RVA="0x1A1A188", Offset="0x1A1A188", VA="0x1A1A188")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10926E0", Offset="0x10926E0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A1A2E0", Offset="0x1A1A2E0", VA="0x1A1A2E0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10926F0", Offset="0x10926F0")]
		public string PlayerId
		{
			[Address(RVA="0x1A1A454", Offset="0x1A1A454", VA="0x1A1A454")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1A45C", Offset="0x1A1A45C", VA="0x1A1A45C")]
			set
			{
			}
		}

		[Address(RVA="0x1A1A8EC", Offset="0x1A1A8EC", VA="0x1A1A8EC")]
		static MatchMakerCancelRequest()
		{
		}

		[Address(RVA="0x1A1A33C", Offset="0x1A1A33C", VA="0x1A1A33C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076CBC", Offset="0x1076CBC")]
		public MatchMakerCancelRequest()
		{
		}

		[Address(RVA="0x1A1A394", Offset="0x1A1A394", VA="0x1A1A394")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076CCC", Offset="0x1076CCC")]
		public MatchMakerCancelRequest(MatchMakerCancelRequest other)
		{
		}

		[Address(RVA="0x1A1A748", Offset="0x1A1A748", VA="0x1A1A748", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076D3C", Offset="0x1076D3C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A1A3F4", Offset="0x1A1A3F4", VA="0x1A1A3F4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076CDC", Offset="0x1076CDC")]
		public MatchMakerCancelRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A1A4CC", Offset="0x1A1A4CC", VA="0x1A1A4CC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076CEC", Offset="0x1076CEC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1A540", Offset="0x1A1A540", VA="0x1A1A540", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076CFC", Offset="0x1076CFC")]
		public bool Equals(MatchMakerCancelRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1A5A4", Offset="0x1A1A5A4", VA="0x1A1A5A4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076D0C", Offset="0x1076D0C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A1A7FC", Offset="0x1A1A7FC", VA="0x1A1A7FC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076D4C", Offset="0x1076D4C")]
		public void MergeFrom(MatchMakerCancelRequest other)
		{
		}

		[Address(RVA="0x1A1A868", Offset="0x1A1A868", VA="0x1A1A868", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076D5C", Offset="0x1076D5C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A1A628", Offset="0x1A1A628", VA="0x1A1A628", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076D1C", Offset="0x1076D1C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A1A690", Offset="0x1A1A690", VA="0x1A1A690", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076D2C", Offset="0x1076D2C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F0E8", Offset="0x104F0E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MatchMakerCancelRequest.<>c <>9;

			[Address(RVA="0x1A1A9C4", Offset="0x1A1A9C4", VA="0x1A1A9C4")]
			static <>c()
			{
			}

			[Address(RVA="0x1A1AA28", Offset="0x1A1AA28", VA="0x1A1AA28")]
			public <>c()
			{
			}

			[Address(RVA="0x1A1AA30", Offset="0x1A1AA30", VA="0x1A1AA30")]
			internal MatchMakerCancelRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}