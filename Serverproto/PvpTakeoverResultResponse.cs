using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PvpTakeoverResultResponse : IMessage<PvpTakeoverResultResponse>, IMessage, IEquatable<PvpTakeoverResultResponse>, IDeepCloneable<PvpTakeoverResultResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PvpTakeoverResultResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PvpPackAssetFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string pvpPackAsset_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092B10", Offset="0x1092B10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x201CC10", Offset="0x201CC10", VA="0x201CC10")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092B00", Offset="0x1092B00")]
		public static MessageParser<PvpTakeoverResultResponse> Parser
		{
			[Address(RVA="0x201CBA8", Offset="0x201CBA8", VA="0x201CBA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092B20", Offset="0x1092B20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x201CD00", Offset="0x201CD00", VA="0x201CD00", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092B30", Offset="0x1092B30")]
		public string PvpPackAsset
		{
			[Address(RVA="0x201CE74", Offset="0x201CE74", VA="0x201CE74")]
			get
			{
				return null;
			}
			[Address(RVA="0x201CE7C", Offset="0x201CE7C", VA="0x201CE7C")]
			set
			{
			}
		}

		[Address(RVA="0x201D30C", Offset="0x201D30C", VA="0x201D30C")]
		static PvpTakeoverResultResponse()
		{
		}

		[Address(RVA="0x201CD5C", Offset="0x201CD5C", VA="0x201CD5C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10774FC", Offset="0x10774FC")]
		public PvpTakeoverResultResponse()
		{
		}

		[Address(RVA="0x201CDB4", Offset="0x201CDB4", VA="0x201CDB4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107750C", Offset="0x107750C")]
		public PvpTakeoverResultResponse(PvpTakeoverResultResponse other)
		{
		}

		[Address(RVA="0x201D168", Offset="0x201D168", VA="0x201D168", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107757C", Offset="0x107757C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x201CE14", Offset="0x201CE14", VA="0x201CE14", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107751C", Offset="0x107751C")]
		public PvpTakeoverResultResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x201CEEC", Offset="0x201CEEC", VA="0x201CEEC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107752C", Offset="0x107752C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x201CF60", Offset="0x201CF60", VA="0x201CF60", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107753C", Offset="0x107753C")]
		public bool Equals(PvpTakeoverResultResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x201CFC4", Offset="0x201CFC4", VA="0x201CFC4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107754C", Offset="0x107754C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x201D21C", Offset="0x201D21C", VA="0x201D21C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107758C", Offset="0x107758C")]
		public void MergeFrom(PvpTakeoverResultResponse other)
		{
		}

		[Address(RVA="0x201D288", Offset="0x201D288", VA="0x201D288", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107759C", Offset="0x107759C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201D048", Offset="0x201D048", VA="0x201D048", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107755C", Offset="0x107755C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201D0B0", Offset="0x201D0B0", VA="0x201D0B0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107756C", Offset="0x107756C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F1A8", Offset="0x104F1A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PvpTakeoverResultResponse.<>c <>9;

			[Address(RVA="0x201D3E4", Offset="0x201D3E4", VA="0x201D3E4")]
			static <>c()
			{
			}

			[Address(RVA="0x201D448", Offset="0x201D448", VA="0x201D448")]
			public <>c()
			{
			}

			[Address(RVA="0x201D450", Offset="0x201D450", VA="0x201D450")]
			internal PvpTakeoverResultResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}