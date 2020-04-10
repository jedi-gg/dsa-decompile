using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Serverproto
{
	public sealed class Shipment : IMessage<Shipment>, IMessage, IEquatable<Shipment>, IDeepCloneable<Shipment>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<Shipment> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IconAssetFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string iconAsset_;

		[FieldOffset(Offset="0x0")]
		public const int LocationFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong location_;

		[FieldOffset(Offset="0x0")]
		public const int ItemsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ShipmentItem> _repeated_items_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ShipmentItem> items_;

		[FieldOffset(Offset="0x0")]
		public const int RefreshCostFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ItemCount refreshCost_;

		[FieldOffset(Offset="0x0")]
		public const int SortOrderFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private long sortOrder_;

		[FieldOffset(Offset="0x0")]
		public const int IsLockedFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private bool isLocked_;

		[FieldOffset(Offset="0x0")]
		public const int LockedKeyFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private string lockedKey_;

		[FieldOffset(Offset="0x0")]
		public const int DefIdFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private ulong defId_;

		[FieldOffset(Offset="0x0")]
		public const int OccasionExpireTimestampFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private ulong occasionExpireTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int AllowVipBuyAllFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private bool allowVipBuyAll_;

		[FieldOffset(Offset="0x0")]
		public const int VipOnlyFieldNumber = 11;

		[FieldOffset(Offset="0x61")]
		private bool vipOnly_;

		[FieldOffset(Offset="0x0")]
		public const int ResetTimestampFieldNumber = 12;

		[FieldOffset(Offset="0x68")]
		private ulong resetTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int AllowRefreshFieldNumber = 13;

		[FieldOffset(Offset="0x70")]
		private bool allowRefresh_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10997E8", Offset="0x10997E8")]
		public bool AllowRefresh
		{
			[Address(RVA="0x1BD2114", Offset="0x1BD2114", VA="0x1BD2114")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BD211C", Offset="0x1BD211C", VA="0x1BD211C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10997B8", Offset="0x10997B8")]
		public bool AllowVipBuyAll
		{
			[Address(RVA="0x1BD20DC", Offset="0x1BD20DC", VA="0x1BD20DC")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BD20E4", Offset="0x1BD20E4", VA="0x1BD20E4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099798", Offset="0x1099798")]
		public ulong DefId
		{
			[Address(RVA="0x1BD20BC", Offset="0x1BD20BC", VA="0x1BD20BC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BD20C4", Offset="0x1BD20C4", VA="0x1BD20C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10996E0", Offset="0x10996E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD1C1C", Offset="0x1BD1C1C", VA="0x1BD1C1C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099700", Offset="0x1099700")]
		public string IconAsset
		{
			[Address(RVA="0x1BD1F98", Offset="0x1BD1F98", VA="0x1BD1F98")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BD1FA0", Offset="0x1BD1FA0", VA="0x1BD1FA0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099778", Offset="0x1099778")]
		public bool IsLocked
		{
			[Address(RVA="0x1BD2030", Offset="0x1BD2030", VA="0x1BD2030")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BD2038", Offset="0x1BD2038", VA="0x1BD2038")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099748", Offset="0x1099748")]
		public RepeatedField<ShipmentItem> Items
		{
			[Address(RVA="0x1BD1B9C", Offset="0x1BD1B9C", VA="0x1BD1B9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099710", Offset="0x1099710")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1099710", Offset="0x1099710")]
		public ulong Location
		{
			[Address(RVA="0x1BD2010", Offset="0x1BD2010", VA="0x1BD2010")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BD2018", Offset="0x1BD2018", VA="0x1BD2018")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099788", Offset="0x1099788")]
		public string LockedKey
		{
			[Address(RVA="0x1BD2044", Offset="0x1BD2044", VA="0x1BD2044")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BD204C", Offset="0x1BD204C", VA="0x1BD204C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10997A8", Offset="0x10997A8")]
		public ulong OccasionExpireTimestamp
		{
			[Address(RVA="0x1BD20CC", Offset="0x1BD20CC", VA="0x1BD20CC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BD20D4", Offset="0x1BD20D4", VA="0x1BD20D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10996D0", Offset="0x10996D0")]
		public static MessageParser<Shipment> Parser
		{
			[Address(RVA="0x1BD1BB4", Offset="0x1BD1BB4", VA="0x1BD1BB4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10996F0", Offset="0x10996F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD1D0C", Offset="0x1BD1D0C", VA="0x1BD1D0C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099758", Offset="0x1099758")]
		public ItemCount RefreshCost
		{
			[Address(RVA="0x1BD1F28", Offset="0x1BD1F28", VA="0x1BD1F28")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BD1F30", Offset="0x1BD1F30", VA="0x1BD1F30")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10997D8", Offset="0x10997D8")]
		public ulong ResetTimestamp
		{
			[Address(RVA="0x1BD2104", Offset="0x1BD2104", VA="0x1BD2104")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BD210C", Offset="0x1BD210C", VA="0x1BD210C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099768", Offset="0x1099768")]
		public long SortOrder
		{
			[Address(RVA="0x1BD2020", Offset="0x1BD2020", VA="0x1BD2020")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1BD2028", Offset="0x1BD2028", VA="0x1BD2028")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10997C8", Offset="0x10997C8")]
		public bool VipOnly
		{
			[Address(RVA="0x1BD20F0", Offset="0x1BD20F0", VA="0x1BD20F0")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BD20F8", Offset="0x1BD20F8", VA="0x1BD20F8")]
			set
			{
			}
		}

		[Address(RVA="0x1BD3300", Offset="0x1BD3300", VA="0x1BD3300")]
		static Shipment()
		{
		}

		[Address(RVA="0x1BD1D68", Offset="0x1BD1D68", VA="0x1BD1D68")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108373C", Offset="0x108373C")]
		public Shipment()
		{
		}

		[Address(RVA="0x1BD1DF8", Offset="0x1BD1DF8", VA="0x1BD1DF8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108374C", Offset="0x108374C")]
		public Shipment(Shipment other)
		{
		}

		[Address(RVA="0x1BD2B10", Offset="0x1BD2B10", VA="0x1BD2B10", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10837BC", Offset="0x10837BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD1F38", Offset="0x1BD1F38", VA="0x1BD1F38", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108375C", Offset="0x108375C")]
		public Shipment Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD2128", Offset="0x1BD2128", VA="0x1BD2128", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108376C", Offset="0x108376C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD219C", Offset="0x1BD219C", VA="0x1BD219C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108377C", Offset="0x108377C")]
		public bool Equals(Shipment other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD2358", Offset="0x1BD2358", VA="0x1BD2358", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108378C", Offset="0x108378C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD1660", Offset="0x1BD1660", VA="0x1BD1660")]
		public List<ItemCount> GetTotalBuyAllCosts()
		{
			return null;
		}

		[Address(RVA="0x1BD2E24", Offset="0x1BD2E24", VA="0x1BD2E24", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10837CC", Offset="0x10837CC")]
		public void MergeFrom(Shipment other)
		{
		}

		[Address(RVA="0x1BD2FC8", Offset="0x1BD2FC8", VA="0x1BD2FC8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10837DC", Offset="0x10837DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD2584", Offset="0x1BD2584", VA="0x1BD2584", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108379C", Offset="0x108379C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD25EC", Offset="0x1BD25EC", VA="0x1BD25EC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10837AC", Offset="0x10837AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050398", Offset="0x1050398")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static Shipment.<>c <>9;

			[Address(RVA="0x1BD3488", Offset="0x1BD3488", VA="0x1BD3488")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD34EC", Offset="0x1BD34EC", VA="0x1BD34EC")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD34F4", Offset="0x1BD34F4", VA="0x1BD34F4")]
			internal Shipment <.cctor>b__86_0()
			{
				return null;
			}
		}
	}
}