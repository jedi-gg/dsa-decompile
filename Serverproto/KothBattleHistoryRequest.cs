using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothBattleHistoryRequest : IMessage<KothBattleHistoryRequest>, IMessage, IEquatable<KothBattleHistoryRequest>, IDeepCloneable<KothBattleHistoryRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothBattleHistoryRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B6C0", Offset="0x109B6C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A98EA8", Offset="0x1A98EA8", VA="0x1A98EA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B6B0", Offset="0x109B6B0")]
		public static MessageParser<KothBattleHistoryRequest> Parser
		{
			[Address(RVA="0x1A98E40", Offset="0x1A98E40", VA="0x1A98E40")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B6D0", Offset="0x109B6D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A98F98", Offset="0x1A98F98", VA="0x1A98F98", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A992AC", Offset="0x1A992AC", VA="0x1A992AC")]
		static KothBattleHistoryRequest()
		{
		}

		[Address(RVA="0x1A98FF4", Offset="0x1A98FF4", VA="0x1A98FF4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108713C", Offset="0x108713C")]
		public KothBattleHistoryRequest()
		{
		}

		[Address(RVA="0x1A98FFC", Offset="0x1A98FFC", VA="0x1A98FFC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108714C", Offset="0x108714C")]
		public KothBattleHistoryRequest(KothBattleHistoryRequest other)
		{
		}

		[Address(RVA="0x1A99210", Offset="0x1A99210", VA="0x1A99210", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10871BC", Offset="0x10871BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A99040", Offset="0x1A99040", VA="0x1A99040", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108715C", Offset="0x108715C")]
		public KothBattleHistoryRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A990A0", Offset="0x1A990A0", VA="0x1A990A0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108716C", Offset="0x108716C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A99138", Offset="0x1A99138", VA="0x1A99138", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108717C", Offset="0x108717C")]
		public bool Equals(KothBattleHistoryRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A99164", Offset="0x1A99164", VA="0x1A99164", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108718C", Offset="0x108718C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A99224", Offset="0x1A99224", VA="0x1A99224", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10871CC", Offset="0x10871CC")]
		public void MergeFrom(KothBattleHistoryRequest other)
		{
		}

		[Address(RVA="0x1A99258", Offset="0x1A99258", VA="0x1A99258", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10871DC", Offset="0x10871DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A99194", Offset="0x1A99194", VA="0x1A99194", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108719C", Offset="0x108719C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A991FC", Offset="0x1A991FC", VA="0x1A991FC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10871AC", Offset="0x10871AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10508D8", Offset="0x10508D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothBattleHistoryRequest.<>c <>9;

			[Address(RVA="0x1A99384", Offset="0x1A99384", VA="0x1A99384")]
			static <>c()
			{
			}

			[Address(RVA="0x1A993E8", Offset="0x1A993E8", VA="0x1A993E8")]
			public <>c()
			{
			}

			[Address(RVA="0x1A993F0", Offset="0x1A993F0", VA="0x1A993F0")]
			internal KothBattleHistoryRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}