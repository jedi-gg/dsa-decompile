using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EnergyRefreshResponse : IMessage<EnergyRefreshResponse>, IMessage, IEquatable<EnergyRefreshResponse>, IDeepCloneable<EnergyRefreshResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EnergyRefreshResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int DailyPurchasesFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong dailyPurchases_;

		[FieldOffset(Offset="0x0")]
		public const int EnergyItemIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong energyItemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A4B0", Offset="0x109A4B0")]
		public ulong DailyPurchases
		{
			[Address(RVA="0x1FC0220", Offset="0x1FC0220", VA="0x1FC0220")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC0228", Offset="0x1FC0228", VA="0x1FC0228")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A480", Offset="0x109A480")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FBFFD0", Offset="0x1FBFFD0", VA="0x1FBFFD0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A4C0", Offset="0x109A4C0")]
		public ulong EnergyItemId
		{
			[Address(RVA="0x1FC0230", Offset="0x1FC0230", VA="0x1FC0230")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC0238", Offset="0x1FC0238", VA="0x1FC0238")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A4A0", Offset="0x109A4A0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1FC01B0", Offset="0x1FC01B0", VA="0x1FC01B0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC01B8", Offset="0x1FC01B8", VA="0x1FC01B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A470", Offset="0x109A470")]
		public static MessageParser<EnergyRefreshResponse> Parser
		{
			[Address(RVA="0x1FBFF68", Offset="0x1FBFF68", VA="0x1FBFF68")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A490", Offset="0x109A490")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC00C0", Offset="0x1FC00C0", VA="0x1FC00C0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FC089C", Offset="0x1FC089C", VA="0x1FC089C")]
		static EnergyRefreshResponse()
		{
		}

		[Address(RVA="0x1FC011C", Offset="0x1FC011C", VA="0x1FC011C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108448C", Offset="0x108448C")]
		public EnergyRefreshResponse()
		{
		}

		[Address(RVA="0x1FC0124", Offset="0x1FC0124", VA="0x1FC0124")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108449C", Offset="0x108449C")]
		public EnergyRefreshResponse(EnergyRefreshResponse other)
		{
		}

		[Address(RVA="0x1FC058C", Offset="0x1FC058C", VA="0x1FC058C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108450C", Offset="0x108450C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC01C0", Offset="0x1FC01C0", VA="0x1FC01C0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10844AC", Offset="0x10844AC")]
		public EnergyRefreshResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC0240", Offset="0x1FC0240", VA="0x1FC0240", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10844BC", Offset="0x10844BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC02B4", Offset="0x1FC02B4", VA="0x1FC02B4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10844CC", Offset="0x10844CC")]
		public bool Equals(EnergyRefreshResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC0338", Offset="0x1FC0338", VA="0x1FC0338", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10844DC", Offset="0x10844DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC069C", Offset="0x1FC069C", VA="0x1FC069C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108451C", Offset="0x108451C")]
		public void MergeFrom(EnergyRefreshResponse other)
		{
		}

		[Address(RVA="0x1FC0768", Offset="0x1FC0768", VA="0x1FC0768", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108452C", Offset="0x108452C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC03D4", Offset="0x1FC03D4", VA="0x1FC03D4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10844EC", Offset="0x10844EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC043C", Offset="0x1FC043C", VA="0x1FC043C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10844FC", Offset="0x10844FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10504C8", Offset="0x10504C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EnergyRefreshResponse.<>c <>9;

			[Address(RVA="0x1FC0974", Offset="0x1FC0974", VA="0x1FC0974")]
			static <>c()
			{
			}

			[Address(RVA="0x1FC09D8", Offset="0x1FC09D8", VA="0x1FC09D8")]
			public <>c()
			{
			}

			[Address(RVA="0x1FC09E0", Offset="0x1FC09E0", VA="0x1FC09E0")]
			internal EnergyRefreshResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}