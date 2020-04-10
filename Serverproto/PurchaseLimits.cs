using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PurchaseLimits : IMessage<PurchaseLimits>, IMessage, IEquatable<PurchaseLimits>, IDeepCloneable<PurchaseLimits>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PurchaseLimits> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int LimitElapsedTimestampFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong limitElapsedTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int PurchaseDataFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<PurchaseLimit> _repeated_purchaseData_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<PurchaseLimit> purchaseData_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C3A8", Offset="0x109C3A8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x20123C0", Offset="0x20123C0", VA="0x20123C0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C3C8", Offset="0x109C3C8")]
		public ulong LimitElapsedTimestamp
		{
			[Address(RVA="0x2012694", Offset="0x2012694", VA="0x2012694")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201269C", Offset="0x201269C", VA="0x201269C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C398", Offset="0x109C398")]
		public static MessageParser<PurchaseLimits> Parser
		{
			[Address(RVA="0x2012358", Offset="0x2012358", VA="0x2012358")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C3B8", Offset="0x109C3B8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x20124B0", Offset="0x20124B0", VA="0x20124B0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C3D8", Offset="0x109C3D8")]
		public RepeatedField<PurchaseLimit> PurchaseData
		{
			[Address(RVA="0x20126A4", Offset="0x20126A4", VA="0x20126A4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2012C98", Offset="0x2012C98", VA="0x2012C98")]
		static PurchaseLimits()
		{
		}

		[Address(RVA="0x201250C", Offset="0x201250C", VA="0x201250C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108826C", Offset="0x108826C")]
		public PurchaseLimits()
		{
		}

		[Address(RVA="0x201257C", Offset="0x201257C", VA="0x201257C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108827C", Offset="0x108827C")]
		public PurchaseLimits(PurchaseLimits other)
		{
		}

		[Address(RVA="0x20129F4", Offset="0x20129F4", VA="0x20129F4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10882EC", Offset="0x10882EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2012634", Offset="0x2012634", VA="0x2012634", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108828C", Offset="0x108828C")]
		public PurchaseLimits Clone()
		{
			return null;
		}

		[Address(RVA="0x20126AC", Offset="0x20126AC", VA="0x20126AC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108829C", Offset="0x108829C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2012720", Offset="0x2012720", VA="0x2012720", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10882AC", Offset="0x10882AC")]
		public bool Equals(PurchaseLimits other)
		{
			return new bool();
		}

		[Address(RVA="0x20127E0", Offset="0x20127E0", VA="0x20127E0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10882BC", Offset="0x10882BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2012AF0", Offset="0x2012AF0", VA="0x2012AF0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10882FC", Offset="0x10882FC")]
		public void MergeFrom(PurchaseLimits other)
		{
		}

		[Address(RVA="0x2012B8C", Offset="0x2012B8C", VA="0x2012B8C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108830C", Offset="0x108830C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2012870", Offset="0x2012870", VA="0x2012870", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10882CC", Offset="0x10882CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x20128D8", Offset="0x20128D8", VA="0x20128D8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10882DC", Offset="0x10882DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050A78", Offset="0x1050A78")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PurchaseLimits.<>c <>9;

			[Address(RVA="0x2012DB8", Offset="0x2012DB8", VA="0x2012DB8")]
			static <>c()
			{
			}

			[Address(RVA="0x2012E1C", Offset="0x2012E1C", VA="0x2012E1C")]
			public <>c()
			{
			}

			[Address(RVA="0x2012E24", Offset="0x2012E24", VA="0x2012E24")]
			internal PurchaseLimits <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}