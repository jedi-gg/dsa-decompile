using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class Event : IMessage<Event>, IMessage, IEquatable<Event>, IDeepCloneable<Event>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<Event> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ContentIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong contentId_;

		[FieldOffset(Offset="0x0")]
		public const int NameFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string name_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string description_;

		[FieldOffset(Offset="0x0")]
		public const int ImageFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string image_;

		[FieldOffset(Offset="0x0")]
		public const int SortOrderFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private long sortOrder_;

		[FieldOffset(Offset="0x0")]
		public const int BattleLimitFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong battleLimit_;

		[FieldOffset(Offset="0x0")]
		public const int BattleLimitRefreshCostFieldNumber = 7;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ItemCount> _repeated_battleLimitRefreshCost_codec;

		[FieldOffset(Offset="0x48")]
		private readonly RepeatedField<ItemCount> battleLimitRefreshCost_;

		[FieldOffset(Offset="0x0")]
		public const int TiersFieldNumber = 8;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<EventTier> _repeated_tiers_codec;

		[FieldOffset(Offset="0x50")]
		private readonly RepeatedField<EventTier> tiers_;

		[FieldOffset(Offset="0x0")]
		public const int BeginTimestampFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private ulong beginTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int EndTimestampFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private ulong endTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int MarqueeImageFieldNumber = 11;

		[FieldOffset(Offset="0x68")]
		private string marqueeImage_;

		[FieldOffset(Offset="0x0")]
		public const int LifetimeProgressEventFieldNumber = 12;

		[FieldOffset(Offset="0x70")]
		private bool lifetimeProgressEvent_;

		[FieldOffset(Offset="0x0")]
		public const int PreviewTextFieldNumber = 13;

		[FieldOffset(Offset="0x78")]
		private string previewText_;

		[FieldOffset(Offset="0x0")]
		public const int RequirePreviousTierCompletionFieldNumber = 14;

		[FieldOffset(Offset="0x80")]
		private bool requirePreviousTierCompletion_;

		[FieldOffset(Offset="0x0")]
		public const int ShipmentLocationFieldNumber = 15;

		[FieldOffset(Offset="0x88")]
		private ulong shipmentLocation_;

		[FieldOffset(Offset="0x0")]
		public const int LockedColorFieldNumber = 16;

		[FieldOffset(Offset="0x90")]
		private Color lockedColor_;

		[FieldOffset(Offset="0x0")]
		public const int UnlockedColorFieldNumber = 17;

		[FieldOffset(Offset="0x98")]
		private Color unlockedColor_;

		[FieldOffset(Offset="0x0")]
		public const int AllowInstantBattleFieldNumber = 18;

		[FieldOffset(Offset="0xA0")]
		private bool allowInstantBattle_;

		[FieldOffset(Offset="0x0")]
		public const int HudCurrencyFieldNumber = 19;

		[FieldOffset(Offset="0xA8")]
		private ulong hudCurrency_;

		[FieldOffset(Offset="0x0")]
		public const int ShipmentDefIdFieldNumber = 20;

		[FieldOffset(Offset="0xB0")]
		private ulong shipmentDefId_;

		[FieldOffset(Offset="0x0")]
		public const int BannerImageFieldNumber = 21;

		[FieldOffset(Offset="0xB8")]
		private string bannerImage_;

		[FieldOffset(Offset="0x0")]
		public const int BannerTextFieldNumber = 22;

		[FieldOffset(Offset="0xC0")]
		private string bannerText_;

		[FieldOffset(Offset="0x0")]
		public const int ShowcaseItemsFieldNumber = 23;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<ulong> _repeated_showcaseItems_codec;

		[FieldOffset(Offset="0xC8")]
		private readonly RepeatedField<ulong> showcaseItems_;

		[FieldOffset(Offset="0x0")]
		public const int RecommendedDescriptionFieldNumber = 24;

		[FieldOffset(Offset="0xD0")]
		private string recommendedDescription_;

		[FieldOffset(Offset="0x0")]
		public const int EventGroupIdFieldNumber = 25;

		[FieldOffset(Offset="0xD8")]
		private ulong eventGroupId_;

		[FieldOffset(Offset="0x0")]
		public const int IsPermanentFieldNumber = 26;

		[FieldOffset(Offset="0xE0")]
		private bool isPermanent_;

		[FieldOffset(Offset="0x0")]
		public const int BattleCooldownSecondsFieldNumber = 27;

		[FieldOffset(Offset="0xE8")]
		private ulong battleCooldownSeconds_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096FF0", Offset="0x1096FF0")]
		public bool AllowInstantBattle
		{
			[Address(RVA="0x1FC7A38", Offset="0x1FC7A38", VA="0x1FC7A38")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FC7A40", Offset="0x1FC7A40", VA="0x1FC7A40")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097020", Offset="0x1097020")]
		public string BannerImage
		{
			[Address(RVA="0x1FC7A6C", Offset="0x1FC7A6C", VA="0x1FC7A6C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC7A74", Offset="0x1FC7A74", VA="0x1FC7A74")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097030", Offset="0x1097030")]
		public string BannerText
		{
			[Address(RVA="0x1FC7AE4", Offset="0x1FC7AE4", VA="0x1FC7AE4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC7AEC", Offset="0x1FC7AEC", VA="0x1FC7AEC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10970A8", Offset="0x10970A8")]
		public ulong BattleCooldownSeconds
		{
			[Address(RVA="0x1FC7C00", Offset="0x1FC7C00", VA="0x1FC7C00")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC7C08", Offset="0x1FC7C08", VA="0x1FC7C08")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096EE0", Offset="0x1096EE0")]
		public ulong BattleLimit
		{
			[Address(RVA="0x1FC78D0", Offset="0x1FC78D0", VA="0x1FC78D0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC78D8", Offset="0x1FC78D8", VA="0x1FC78D8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096EF0", Offset="0x1096EF0")]
		public RepeatedField<ItemCount> BattleLimitRefreshCost
		{
			[Address(RVA="0x1FC78E0", Offset="0x1FC78E0", VA="0x1FC78E0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096F10", Offset="0x1096F10")]
		public ulong BeginTimestamp
		{
			[Address(RVA="0x1FC78F0", Offset="0x1FC78F0", VA="0x1FC78F0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC78F8", Offset="0x1FC78F8", VA="0x1FC78F8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096E90", Offset="0x1096E90")]
		public ulong ContentId
		{
			[Address(RVA="0x1FC7748", Offset="0x1FC7748", VA="0x1FC7748")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC7750", Offset="0x1FC7750", VA="0x1FC7750")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096EB0", Offset="0x1096EB0")]
		public string Description
		{
			[Address(RVA="0x1FC77D0", Offset="0x1FC77D0", VA="0x1FC77D0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC77D8", Offset="0x1FC77D8", VA="0x1FC77D8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096E70", Offset="0x1096E70")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FC71EC", Offset="0x1FC71EC", VA="0x1FC71EC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096F20", Offset="0x1096F20")]
		public ulong EndTimestamp
		{
			[Address(RVA="0x1FC7900", Offset="0x1FC7900", VA="0x1FC7900")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC7908", Offset="0x1FC7908", VA="0x1FC7908")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097088", Offset="0x1097088")]
		public ulong EventGroupId
		{
			[Address(RVA="0x1FC7BDC", Offset="0x1FC7BDC", VA="0x1FC7BDC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC7BE4", Offset="0x1FC7BE4", VA="0x1FC7BE4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097000", Offset="0x1097000")]
		public ulong HudCurrency
		{
			[Address(RVA="0x1FC7A4C", Offset="0x1FC7A4C", VA="0x1FC7A4C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC7A54", Offset="0x1FC7A54", VA="0x1FC7A54")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096EC0", Offset="0x1096EC0")]
		public string Image
		{
			[Address(RVA="0x1FC7848", Offset="0x1FC7848", VA="0x1FC7848")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC7850", Offset="0x1FC7850", VA="0x1FC7850")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097098", Offset="0x1097098")]
		public bool IsPermanent
		{
			[Address(RVA="0x1FC7BEC", Offset="0x1FC7BEC", VA="0x1FC7BEC")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FC7BF4", Offset="0x1FC7BF4", VA="0x1FC7BF4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096F68", Offset="0x1096F68")]
		public bool LifetimeProgressEvent
		{
			[Address(RVA="0x1FC7988", Offset="0x1FC7988", VA="0x1FC7988")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FC7990", Offset="0x1FC7990", VA="0x1FC7990")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096FD0", Offset="0x1096FD0")]
		public Color LockedColor
		{
			[Address(RVA="0x1FC76C8", Offset="0x1FC76C8", VA="0x1FC76C8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC76D0", Offset="0x1FC76D0", VA="0x1FC76D0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096F30", Offset="0x1096F30")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1096F30", Offset="0x1096F30")]
		public string MarqueeImage
		{
			[Address(RVA="0x1FC7910", Offset="0x1FC7910", VA="0x1FC7910")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC7918", Offset="0x1FC7918", VA="0x1FC7918")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096EA0", Offset="0x1096EA0")]
		public string Name
		{
			[Address(RVA="0x1FC7758", Offset="0x1FC7758", VA="0x1FC7758")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC7760", Offset="0x1FC7760", VA="0x1FC7760")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096E60", Offset="0x1096E60")]
		public static MessageParser<Event> Parser
		{
			[Address(RVA="0x1FC7184", Offset="0x1FC7184", VA="0x1FC7184")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096E80", Offset="0x1096E80")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC7340", Offset="0x1FC7340", VA="0x1FC7340", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096F78", Offset="0x1096F78")]
		public string PreviewText
		{
			[Address(RVA="0x1FC799C", Offset="0x1FC799C", VA="0x1FC799C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC79A4", Offset="0x1FC79A4", VA="0x1FC79A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097050", Offset="0x1097050")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1097050", Offset="0x1097050")]
		public string RecommendedDescription
		{
			[Address(RVA="0x1FC7B64", Offset="0x1FC7B64", VA="0x1FC7B64")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC7B6C", Offset="0x1FC7B6C", VA="0x1FC7B6C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096F88", Offset="0x1096F88")]
		public bool RequirePreviousTierCompletion
		{
			[Address(RVA="0x1FC7A14", Offset="0x1FC7A14", VA="0x1FC7A14")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FC7A1C", Offset="0x1FC7A1C", VA="0x1FC7A1C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097010", Offset="0x1097010")]
		public ulong ShipmentDefId
		{
			[Address(RVA="0x1FC7A5C", Offset="0x1FC7A5C", VA="0x1FC7A5C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC7A64", Offset="0x1FC7A64", VA="0x1FC7A64")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096F98", Offset="0x1096F98")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1096F98", Offset="0x1096F98")]
		public ulong ShipmentLocation
		{
			[Address(RVA="0x1FC7A28", Offset="0x1FC7A28", VA="0x1FC7A28")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC7A30", Offset="0x1FC7A30", VA="0x1FC7A30")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097040", Offset="0x1097040")]
		public RepeatedField<ulong> ShowcaseItems
		{
			[Address(RVA="0x1FC7B5C", Offset="0x1FC7B5C", VA="0x1FC7B5C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096ED0", Offset="0x1096ED0")]
		public long SortOrder
		{
			[Address(RVA="0x1FC78C0", Offset="0x1FC78C0", VA="0x1FC78C0")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1FC78C8", Offset="0x1FC78C8", VA="0x1FC78C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096F00", Offset="0x1096F00")]
		public RepeatedField<EventTier> Tiers
		{
			[Address(RVA="0x1FC78E8", Offset="0x1FC78E8", VA="0x1FC78E8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096FE0", Offset="0x1096FE0")]
		public Color UnlockedColor
		{
			[Address(RVA="0x1FC76D8", Offset="0x1FC76D8", VA="0x1FC76D8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC76E0", Offset="0x1FC76E0", VA="0x1FC76E0")]
			set
			{
			}
		}

		[Address(RVA="0x1FCA050", Offset="0x1FCA050", VA="0x1FCA050")]
		static Event()
		{
		}

		[Address(RVA="0x1FC739C", Offset="0x1FC739C", VA="0x1FC739C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F5EC", Offset="0x107F5EC")]
		public Event()
		{
		}

		[Address(RVA="0x1FC748C", Offset="0x1FC748C", VA="0x1FC748C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F5FC", Offset="0x107F5FC")]
		public Event(Event other)
		{
		}

		[Address(RVA="0x1FC8F54", Offset="0x1FC8F54", VA="0x1FC8F54", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F66C", Offset="0x107F66C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC76E8", Offset="0x1FC76E8", VA="0x1FC76E8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F60C", Offset="0x107F60C")]
		public Event Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC7C10", Offset="0x1FC7C10", VA="0x1FC7C10", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F61C", Offset="0x107F61C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC7C84", Offset="0x1FC7C84", VA="0x1FC7C84", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F62C", Offset="0x107F62C")]
		public bool Equals(Event other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC7F7C", Offset="0x1FC7F7C", VA="0x1FC7F7C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F63C", Offset="0x107F63C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC9674", Offset="0x1FC9674", VA="0x1FC9674", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F67C", Offset="0x107F67C")]
		public void MergeFrom(Event other)
		{
		}

		[Address(RVA="0x1FC9A04", Offset="0x1FC9A04", VA="0x1FC9A04", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F68C", Offset="0x107F68C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC842C", Offset="0x1FC842C", VA="0x1FC842C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F64C", Offset="0x107F64C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC8494", Offset="0x1FC8494", VA="0x1FC8494", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F65C", Offset="0x107F65C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FDA8", Offset="0x104FDA8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static Event.<>c <>9;

			[Address(RVA="0x1FCA1D8", Offset="0x1FCA1D8", VA="0x1FCA1D8")]
			static <>c()
			{
			}

			[Address(RVA="0x1FCA23C", Offset="0x1FCA23C", VA="0x1FCA23C")]
			public <>c()
			{
			}

			[Address(RVA="0x1FCA244", Offset="0x1FCA244", VA="0x1FCA244")]
			internal Event <.cctor>b__155_0()
			{
				return null;
			}
		}
	}
}