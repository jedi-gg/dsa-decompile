using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerActivityRewardChoice : IMessage<PlayerActivityRewardChoice>, IMessage, IEquatable<PlayerActivityRewardChoice>, IDeepCloneable<PlayerActivityRewardChoice>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerActivityRewardChoice> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RewardsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<InventoryItem> _repeated_rewards_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<InventoryItem> rewards_;

		[FieldOffset(Offset="0x0")]
		public const int PreviewAssetFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string previewAsset_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099F00", Offset="0x1099F00")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AF64D8", Offset="0x1AF64D8", VA="0x1AF64D8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099EF0", Offset="0x1099EF0")]
		public static MessageParser<PlayerActivityRewardChoice> Parser
		{
			[Address(RVA="0x1AF63AC", Offset="0x1AF63AC", VA="0x1AF63AC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099F10", Offset="0x1099F10")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AF65C4", Offset="0x1AF65C4", VA="0x1AF65C4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099F30", Offset="0x1099F30")]
		public string PreviewAsset
		{
			[Address(RVA="0x1AF67A8", Offset="0x1AF67A8", VA="0x1AF67A8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AF67B0", Offset="0x1AF67B0", VA="0x1AF67B0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099F20", Offset="0x1099F20")]
		public RepeatedField<InventoryItem> Rewards
		{
			[Address(RVA="0x1AF67A0", Offset="0x1AF67A0", VA="0x1AF67A0")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1AF6E80", Offset="0x1AF6E80", VA="0x1AF6E80")]
		static PlayerActivityRewardChoice()
		{
		}

		[Address(RVA="0x1AF6620", Offset="0x1AF6620", VA="0x1AF6620")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083AEC", Offset="0x1083AEC")]
		public PlayerActivityRewardChoice()
		{
		}

		[Address(RVA="0x1AF66A0", Offset="0x1AF66A0", VA="0x1AF66A0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083AFC", Offset="0x1083AFC")]
		public PlayerActivityRewardChoice(PlayerActivityRewardChoice other)
		{
		}

		[Address(RVA="0x1AF6BA0", Offset="0x1AF6BA0", VA="0x1AF6BA0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083B6C", Offset="0x1083B6C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AF6740", Offset="0x1AF6740", VA="0x1AF6740", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083B0C", Offset="0x1083B0C")]
		public PlayerActivityRewardChoice Clone()
		{
			return null;
		}

		[Address(RVA="0x1AF6820", Offset="0x1AF6820", VA="0x1AF6820", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083B1C", Offset="0x1083B1C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF6894", Offset="0x1AF6894", VA="0x1AF6894", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083B2C", Offset="0x1083B2C")]
		public bool Equals(PlayerActivityRewardChoice other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF6958", Offset="0x1AF6958", VA="0x1AF6958", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083B3C", Offset="0x1083B3C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AF6CB0", Offset="0x1AF6CB0", VA="0x1AF6CB0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083B7C", Offset="0x1083B7C")]
		public void MergeFrom(PlayerActivityRewardChoice other)
		{
		}

		[Address(RVA="0x1AF6D6C", Offset="0x1AF6D6C", VA="0x1AF6D6C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083B8C", Offset="0x1083B8C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AF6A04", Offset="0x1AF6A04", VA="0x1AF6A04", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083B4C", Offset="0x1083B4C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AF6A6C", Offset="0x1AF6A6C", VA="0x1AF6A6C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083B5C", Offset="0x1083B5C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10503E8", Offset="0x10503E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerActivityRewardChoice.<>c <>9;

			[Address(RVA="0x1AF6FA4", Offset="0x1AF6FA4", VA="0x1AF6FA4")]
			static <>c()
			{
			}

			[Address(RVA="0x1AF7008", Offset="0x1AF7008", VA="0x1AF7008")]
			public <>c()
			{
			}

			[Address(RVA="0x1AF7010", Offset="0x1AF7010", VA="0x1AF7010")]
			internal PlayerActivityRewardChoice <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}