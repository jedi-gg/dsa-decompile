using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PvpRankRewardPreviewRequest : IMessage<PvpRankRewardPreviewRequest>, IMessage, IEquatable<PvpRankRewardPreviewRequest>, IDeepCloneable<PvpRankRewardPreviewRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PvpRankRewardPreviewRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AEC0", Offset="0x109AEC0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x201AB70", Offset="0x201AB70", VA="0x201AB70")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AEB0", Offset="0x109AEB0")]
		public static MessageParser<PvpRankRewardPreviewRequest> Parser
		{
			[Address(RVA="0x201AB08", Offset="0x201AB08", VA="0x201AB08")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AED0", Offset="0x109AED0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x201AC60", Offset="0x201AC60", VA="0x201AC60", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x201AF74", Offset="0x201AF74", VA="0x201AF74")]
		static PvpRankRewardPreviewRequest()
		{
		}

		[Address(RVA="0x201ACBC", Offset="0x201ACBC", VA="0x201ACBC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085EAC", Offset="0x1085EAC")]
		public PvpRankRewardPreviewRequest()
		{
		}

		[Address(RVA="0x201ACC4", Offset="0x201ACC4", VA="0x201ACC4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085EBC", Offset="0x1085EBC")]
		public PvpRankRewardPreviewRequest(PvpRankRewardPreviewRequest other)
		{
		}

		[Address(RVA="0x201AED8", Offset="0x201AED8", VA="0x201AED8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085F2C", Offset="0x1085F2C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x201AD08", Offset="0x201AD08", VA="0x201AD08", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085ECC", Offset="0x1085ECC")]
		public PvpRankRewardPreviewRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x201AD68", Offset="0x201AD68", VA="0x201AD68", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085EDC", Offset="0x1085EDC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x201AE00", Offset="0x201AE00", VA="0x201AE00", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085EEC", Offset="0x1085EEC")]
		public bool Equals(PvpRankRewardPreviewRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x201AE2C", Offset="0x201AE2C", VA="0x201AE2C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085EFC", Offset="0x1085EFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x201AEEC", Offset="0x201AEEC", VA="0x201AEEC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085F3C", Offset="0x1085F3C")]
		public void MergeFrom(PvpRankRewardPreviewRequest other)
		{
		}

		[Address(RVA="0x201AF20", Offset="0x201AF20", VA="0x201AF20", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085F4C", Offset="0x1085F4C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201AE5C", Offset="0x201AE5C", VA="0x201AE5C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085F0C", Offset="0x1085F0C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201AEC4", Offset="0x201AEC4", VA="0x201AEC4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085F1C", Offset="0x1085F1C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050728", Offset="0x1050728")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PvpRankRewardPreviewRequest.<>c <>9;

			[Address(RVA="0x201B04C", Offset="0x201B04C", VA="0x201B04C")]
			static <>c()
			{
			}

			[Address(RVA="0x201B0B0", Offset="0x201B0B0", VA="0x201B0B0")]
			public <>c()
			{
			}

			[Address(RVA="0x201B0B8", Offset="0x201B0B8", VA="0x201B0B8")]
			internal PvpRankRewardPreviewRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}