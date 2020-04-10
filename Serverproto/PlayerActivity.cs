using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerActivity : IMessage<PlayerActivity>, IMessage, IEquatable<PlayerActivity>, IDeepCloneable<PlayerActivity>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerActivity> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefinitionIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong definitionId_;

		[FieldOffset(Offset="0x0")]
		public const int NameFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string name_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string description_;

		[FieldOffset(Offset="0x0")]
		public const int TypeFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private PlayerActivityType type_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentValueFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong currentValue_;

		[FieldOffset(Offset="0x0")]
		public const int RequiredValueFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong requiredValue_;

		[FieldOffset(Offset="0x0")]
		public const int SortOrderFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong sortOrder_;

		[FieldOffset(Offset="0x0")]
		public const int RewardsFieldNumber = 8;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<InventoryItem> _repeated_rewards_codec;

		[FieldOffset(Offset="0x50")]
		private readonly RepeatedField<InventoryItem> rewards_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkLocationFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private ulong deepLinkLocation_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkSublocationFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private string deepLinkSublocation_;

		[FieldOffset(Offset="0x0")]
		public const int TelemetryRefIdFieldNumber = 11;

		[FieldOffset(Offset="0x68")]
		private long telemetryRefId_;

		[FieldOffset(Offset="0x0")]
		public const int RewardChoicesFieldNumber = 12;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<PlayerActivityRewardChoice> _repeated_rewardChoices_codec;

		[FieldOffset(Offset="0x70")]
		private readonly RepeatedField<PlayerActivityRewardChoice> rewardChoices_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099FB0", Offset="0x1099FB0")]
		public ulong CurrentValue
		{
			[Address(RVA="0x1AF4FA8", Offset="0x1AF4FA8", VA="0x1AF4FA8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF4FB0", Offset="0x1AF4FB0", VA="0x1AF4FB0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099FF0", Offset="0x1099FF0")]
		public ulong DeepLinkLocation
		{
			[Address(RVA="0x1AF4FE0", Offset="0x1AF4FE0", VA="0x1AF4FE0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF4FE8", Offset="0x1AF4FE8", VA="0x1AF4FE8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A000", Offset="0x109A000")]
		public string DeepLinkSublocation
		{
			[Address(RVA="0x1AF4FF0", Offset="0x1AF4FF0", VA="0x1AF4FF0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AF4FF8", Offset="0x1AF4FF8", VA="0x1AF4FF8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099F70", Offset="0x1099F70")]
		public ulong DefinitionId
		{
			[Address(RVA="0x1AF4E98", Offset="0x1AF4E98", VA="0x1AF4E98")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF4EA0", Offset="0x1AF4EA0", VA="0x1AF4EA0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099F90", Offset="0x1099F90")]
		public string Description
		{
			[Address(RVA="0x1AF4F20", Offset="0x1AF4F20", VA="0x1AF4F20")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AF4F28", Offset="0x1AF4F28", VA="0x1AF4F28")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099F50", Offset="0x1099F50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AF4A30", Offset="0x1AF4A30", VA="0x1AF4A30")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099F80", Offset="0x1099F80")]
		public string Name
		{
			[Address(RVA="0x1AF4EA8", Offset="0x1AF4EA8", VA="0x1AF4EA8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AF4EB0", Offset="0x1AF4EB0", VA="0x1AF4EB0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099F40", Offset="0x1099F40")]
		public static MessageParser<PlayerActivity> Parser
		{
			[Address(RVA="0x1AF49C8", Offset="0x1AF49C8", VA="0x1AF49C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099F60", Offset="0x1099F60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AF4B84", Offset="0x1AF4B84", VA="0x1AF4B84", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099FC0", Offset="0x1099FC0")]
		public ulong RequiredValue
		{
			[Address(RVA="0x1AF4FB8", Offset="0x1AF4FB8", VA="0x1AF4FB8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF4FC0", Offset="0x1AF4FC0", VA="0x1AF4FC0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A020", Offset="0x109A020")]
		public RepeatedField<PlayerActivityRewardChoice> RewardChoices
		{
			[Address(RVA="0x1AF5078", Offset="0x1AF5078", VA="0x1AF5078")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099FE0", Offset="0x1099FE0")]
		public RepeatedField<InventoryItem> Rewards
		{
			[Address(RVA="0x1AF4FD8", Offset="0x1AF4FD8", VA="0x1AF4FD8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099FD0", Offset="0x1099FD0")]
		public ulong SortOrder
		{
			[Address(RVA="0x1AF4FC8", Offset="0x1AF4FC8", VA="0x1AF4FC8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF4FD0", Offset="0x1AF4FD0", VA="0x1AF4FD0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A010", Offset="0x109A010")]
		public long TelemetryRefId
		{
			[Address(RVA="0x1AF5068", Offset="0x1AF5068", VA="0x1AF5068")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1AF5070", Offset="0x1AF5070", VA="0x1AF5070")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099FA0", Offset="0x1099FA0")]
		public PlayerActivityType Type
		{
			[Address(RVA="0x1AF4F98", Offset="0x1AF4F98", VA="0x1AF4F98")]
			get
			{
				return new PlayerActivityType();
			}
			[Address(RVA="0x1AF4FA0", Offset="0x1AF4FA0", VA="0x1AF4FA0")]
			set
			{
			}
		}

		[Address(RVA="0x1AF6240", Offset="0x1AF6240", VA="0x1AF6240")]
		static PlayerActivity()
		{
		}

		[Address(RVA="0x1AF4BE0", Offset="0x1AF4BE0", VA="0x1AF4BE0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083B9C", Offset="0x1083B9C")]
		public PlayerActivity()
		{
		}

		[Address(RVA="0x1AF4C98", Offset="0x1AF4C98", VA="0x1AF4C98")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083BAC", Offset="0x1083BAC")]
		public PlayerActivity(PlayerActivity other)
		{
		}

		[Address(RVA="0x1AF59F4", Offset="0x1AF59F4", VA="0x1AF59F4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083C1C", Offset="0x1083C1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AF4E38", Offset="0x1AF4E38", VA="0x1AF4E38", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083BBC", Offset="0x1083BBC")]
		public PlayerActivity Clone()
		{
			return null;
		}

		[Address(RVA="0x1AF5080", Offset="0x1AF5080", VA="0x1AF5080", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083BCC", Offset="0x1083BCC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF50F4", Offset="0x1AF50F4", VA="0x1AF50F4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083BDC", Offset="0x1083BDC")]
		public bool Equals(PlayerActivity other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF5280", Offset="0x1AF5280", VA="0x1AF5280", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083BEC", Offset="0x1083BEC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AF5DB8", Offset="0x1AF5DB8", VA="0x1AF5DB8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083C2C", Offset="0x1083C2C")]
		public void MergeFrom(PlayerActivity other)
		{
		}

		[Address(RVA="0x1AF5F4C", Offset="0x1AF5F4C", VA="0x1AF5F4C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083C3C", Offset="0x1083C3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AF54B4", Offset="0x1AF54B4", VA="0x1AF54B4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083BFC", Offset="0x1083BFC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AF551C", Offset="0x1AF551C", VA="0x1AF551C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083C0C", Offset="0x1083C0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10503F8", Offset="0x10503F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerActivity.<>c <>9;

			[Address(RVA="0x1AF6414", Offset="0x1AF6414", VA="0x1AF6414")]
			static <>c()
			{
			}

			[Address(RVA="0x1AF6478", Offset="0x1AF6478", VA="0x1AF6478")]
			public <>c()
			{
			}

			[Address(RVA="0x1AF6480", Offset="0x1AF6480", VA="0x1AF6480")]
			internal PlayerActivity <.cctor>b__80_0()
			{
				return null;
			}
		}
	}
}