using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothRankRewardPreviewRequest : IMessage<KothRankRewardPreviewRequest>, IMessage, IEquatable<KothRankRewardPreviewRequest>, IDeepCloneable<KothRankRewardPreviewRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothRankRewardPreviewRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B4A0", Offset="0x109B4A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A15410", Offset="0x1A15410", VA="0x1A15410")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B490", Offset="0x109B490")]
		public static MessageParser<KothRankRewardPreviewRequest> Parser
		{
			[Address(RVA="0x1A153A8", Offset="0x1A153A8", VA="0x1A153A8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B4B0", Offset="0x109B4B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A15500", Offset="0x1A15500", VA="0x1A15500", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A15814", Offset="0x1A15814", VA="0x1A15814")]
		static KothRankRewardPreviewRequest()
		{
		}

		[Address(RVA="0x1A1555C", Offset="0x1A1555C", VA="0x1A1555C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086C6C", Offset="0x1086C6C")]
		public KothRankRewardPreviewRequest()
		{
		}

		[Address(RVA="0x1A15564", Offset="0x1A15564", VA="0x1A15564")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086C7C", Offset="0x1086C7C")]
		public KothRankRewardPreviewRequest(KothRankRewardPreviewRequest other)
		{
		}

		[Address(RVA="0x1A15778", Offset="0x1A15778", VA="0x1A15778", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086CEC", Offset="0x1086CEC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A155A8", Offset="0x1A155A8", VA="0x1A155A8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086C8C", Offset="0x1086C8C")]
		public KothRankRewardPreviewRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A15608", Offset="0x1A15608", VA="0x1A15608", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086C9C", Offset="0x1086C9C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A156A0", Offset="0x1A156A0", VA="0x1A156A0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086CAC", Offset="0x1086CAC")]
		public bool Equals(KothRankRewardPreviewRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A156CC", Offset="0x1A156CC", VA="0x1A156CC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086CBC", Offset="0x1086CBC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A1578C", Offset="0x1A1578C", VA="0x1A1578C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086CFC", Offset="0x1086CFC")]
		public void MergeFrom(KothRankRewardPreviewRequest other)
		{
		}

		[Address(RVA="0x1A157C0", Offset="0x1A157C0", VA="0x1A157C0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086D0C", Offset="0x1086D0C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A156FC", Offset="0x1A156FC", VA="0x1A156FC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086CCC", Offset="0x1086CCC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A15764", Offset="0x1A15764", VA="0x1A15764", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086CDC", Offset="0x1086CDC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050868", Offset="0x1050868")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothRankRewardPreviewRequest.<>c <>9;

			[Address(RVA="0x1A158EC", Offset="0x1A158EC", VA="0x1A158EC")]
			static <>c()
			{
			}

			[Address(RVA="0x1A15950", Offset="0x1A15950", VA="0x1A15950")]
			public <>c()
			{
			}

			[Address(RVA="0x1A15958", Offset="0x1A15958", VA="0x1A15958")]
			internal KothRankRewardPreviewRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}