using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PurchaseLimit : IMessage<PurchaseLimit>, IMessage, IEquatable<PurchaseLimit>, IDeepCloneable<PurchaseLimit>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PurchaseLimit> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int GranularityFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private PurchaseLimitGranularity granularity_;

		[FieldOffset(Offset="0x0")]
		public const int CountFieldNumber = 2;

		[FieldOffset(Offset="0x1C")]
		private int count_;

		[FieldOffset(Offset="0x0")]
		public const int RemainingPurchasesFieldNumber = 3;

		[FieldOffset(Offset="0x20")]
		private int remainingPurchases_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C428", Offset="0x109C428")]
		public int Count
		{
			[Address(RVA="0x2011C30", Offset="0x2011C30", VA="0x2011C30")]
			get
			{
				return new int();
			}
			[Address(RVA="0x2011C38", Offset="0x2011C38", VA="0x2011C38")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C3F8", Offset="0x109C3F8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x20119D0", Offset="0x20119D0", VA="0x20119D0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C418", Offset="0x109C418")]
		public PurchaseLimitGranularity Granularity
		{
			[Address(RVA="0x2011C20", Offset="0x2011C20", VA="0x2011C20")]
			get
			{
				return new PurchaseLimitGranularity();
			}
			[Address(RVA="0x2011C28", Offset="0x2011C28", VA="0x2011C28")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C3E8", Offset="0x109C3E8")]
		public static MessageParser<PurchaseLimit> Parser
		{
			[Address(RVA="0x2011968", Offset="0x2011968", VA="0x2011968")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C408", Offset="0x109C408")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2011AC0", Offset="0x2011AC0", VA="0x2011AC0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C438", Offset="0x109C438")]
		public int RemainingPurchases
		{
			[Address(RVA="0x2011C40", Offset="0x2011C40", VA="0x2011C40")]
			get
			{
				return new int();
			}
			[Address(RVA="0x2011C48", Offset="0x2011C48", VA="0x2011C48")]
			set
			{
			}
		}

		[Address(RVA="0x20121B8", Offset="0x20121B8", VA="0x20121B8")]
		static PurchaseLimit()
		{
		}

		[Address(RVA="0x2011B1C", Offset="0x2011B1C", VA="0x2011B1C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108831C", Offset="0x108831C")]
		public PurchaseLimit()
		{
		}

		[Address(RVA="0x2011B24", Offset="0x2011B24", VA="0x2011B24")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108832C", Offset="0x108832C")]
		public PurchaseLimit(PurchaseLimit other)
		{
		}

		[Address(RVA="0x2011F78", Offset="0x2011F78", VA="0x2011F78", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108839C", Offset="0x108839C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2011BC0", Offset="0x2011BC0", VA="0x2011BC0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108833C", Offset="0x108833C")]
		public PurchaseLimit Clone()
		{
			return null;
		}

		[Address(RVA="0x2011C50", Offset="0x2011C50", VA="0x2011C50", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108834C", Offset="0x108834C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2011CC4", Offset="0x2011CC4", VA="0x2011CC4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108835C", Offset="0x108835C")]
		public bool Equals(PurchaseLimit other)
		{
			return new bool();
		}

		[Address(RVA="0x2011D20", Offset="0x2011D20", VA="0x2011D20", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108836C", Offset="0x108836C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2012088", Offset="0x2012088", VA="0x2012088", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10883AC", Offset="0x10883AC")]
		public void MergeFrom(PurchaseLimit other)
		{
		}

		[Address(RVA="0x20120E0", Offset="0x20120E0", VA="0x20120E0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10883BC", Offset="0x10883BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2011DC0", Offset="0x2011DC0", VA="0x2011DC0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108837C", Offset="0x108837C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2011E28", Offset="0x2011E28", VA="0x2011E28", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108838C", Offset="0x108838C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050A88", Offset="0x1050A88")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PurchaseLimit.<>c <>9;

			[Address(RVA="0x2012290", Offset="0x2012290", VA="0x2012290")]
			static <>c()
			{
			}

			[Address(RVA="0x20122F4", Offset="0x20122F4", VA="0x20122F4")]
			public <>c()
			{
			}

			[Address(RVA="0x20122FC", Offset="0x20122FC", VA="0x20122FC")]
			internal PurchaseLimit <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}