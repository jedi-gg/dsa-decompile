using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerStatusResponse : IMessage<TowerStatusResponse>, IMessage, IEquatable<TowerStatusResponse>, IDeepCloneable<TowerStatusResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerStatusResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StatusFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private TowerStatus status_;

		[FieldOffset(Offset="0x0")]
		public const int StatusesFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<TowerStatus> _repeated_statuses_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<TowerStatus> statuses_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CF28", Offset="0x109CF28")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B789BC", Offset="0x1B789BC", VA="0x1B789BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CF18", Offset="0x109CF18")]
		public static MessageParser<TowerStatusResponse> Parser
		{
			[Address(RVA="0x1B762B4", Offset="0x1B762B4", VA="0x1B762B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CF38", Offset="0x109CF38")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B78AA8", Offset="0x1B78AA8", VA="0x1B78AA8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CF48", Offset="0x109CF48")]
		public TowerStatus Status
		{
			[Address(RVA="0x1B78C38", Offset="0x1B78C38", VA="0x1B78C38")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B78C40", Offset="0x1B78C40", VA="0x1B78C40")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CF58", Offset="0x109CF58")]
		public RepeatedField<TowerStatus> Statuses
		{
			[Address(RVA="0x1B78CA8", Offset="0x1B78CA8", VA="0x1B78CA8")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B79304", Offset="0x1B79304", VA="0x1B79304")]
		static TowerStatusResponse()
		{
		}

		[Address(RVA="0x1B78B04", Offset="0x1B78B04", VA="0x1B78B04")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108991C", Offset="0x108991C")]
		public TowerStatusResponse()
		{
		}

		[Address(RVA="0x1B78B74", Offset="0x1B78B74", VA="0x1B78B74")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108992C", Offset="0x108992C")]
		public TowerStatusResponse(TowerStatusResponse other)
		{
		}

		[Address(RVA="0x1B78FF4", Offset="0x1B78FF4", VA="0x1B78FF4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108999C", Offset="0x108999C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B78C48", Offset="0x1B78C48", VA="0x1B78C48", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108993C", Offset="0x108993C")]
		public TowerStatusResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B78CB0", Offset="0x1B78CB0", VA="0x1B78CB0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108994C", Offset="0x108994C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B78D24", Offset="0x1B78D24", VA="0x1B78D24", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108995C", Offset="0x108995C")]
		public bool Equals(TowerStatusResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B78DE8", Offset="0x1B78DE8", VA="0x1B78DE8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108996C", Offset="0x108996C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B790F0", Offset="0x1B790F0", VA="0x1B790F0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10899AC", Offset="0x10899AC")]
		public void MergeFrom(TowerStatusResponse other)
		{
		}

		[Address(RVA="0x1B791C8", Offset="0x1B791C8", VA="0x1B791C8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10899BC", Offset="0x10899BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B78E70", Offset="0x1B78E70", VA="0x1B78E70", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108997C", Offset="0x108997C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B78ED8", Offset="0x1B78ED8", VA="0x1B78ED8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108998C", Offset="0x108998C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050C88", Offset="0x1050C88")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerStatusResponse.<>c <>9;

			[Address(RVA="0x1B79424", Offset="0x1B79424", VA="0x1B79424")]
			static <>c()
			{
			}

			[Address(RVA="0x1B79488", Offset="0x1B79488", VA="0x1B79488")]
			public <>c()
			{
			}

			[Address(RVA="0x1B79490", Offset="0x1B79490", VA="0x1B79490")]
			internal TowerStatusResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}