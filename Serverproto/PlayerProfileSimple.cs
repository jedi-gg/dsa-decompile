using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerProfileSimple : IMessage<PlayerProfileSimple>, IMessage, IEquatable<PlayerProfileSimple>, IDeepCloneable<PlayerProfileSimple>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerProfileSimple> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int UsernameFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string username_;

		[FieldOffset(Offset="0x0")]
		public const int LevelFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong level_;

		[FieldOffset(Offset="0x0")]
		public const int AvatarIdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong avatarId_;

		[FieldOffset(Offset="0x0")]
		public const int ClubIdFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string clubId_;

		[FieldOffset(Offset="0x0")]
		public const int ClubNameFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string clubName_;

		[FieldOffset(Offset="0x0")]
		public const int ClubAvatarIdFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong clubAvatarId_;

		[FieldOffset(Offset="0x0")]
		public const int ClubRoleFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private Serverproto.ClubRole clubRole_;

		[FieldOffset(Offset="0x0")]
		public const int ShowVipProfileBgFieldNumber = 9;

		[FieldOffset(Offset="0x54")]
		private bool showVipProfileBg_;

		[FieldOffset(Offset="0x0")]
		public const int CollectionPowerFieldNumber = 10;

		[FieldOffset(Offset="0x58")]
		private ulong collectionPower_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10965C0", Offset="0x10965C0")]
		public ulong AvatarId
		{
			[Address(RVA="0x1AFDD70", Offset="0x1AFDD70", VA="0x1AFDD70")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AFDD78", Offset="0x1AFDD78", VA="0x1AFDD78")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10965F0", Offset="0x10965F0")]
		public ulong ClubAvatarId
		{
			[Address(RVA="0x1AFDE70", Offset="0x1AFDE70", VA="0x1AFDE70")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AFDE78", Offset="0x1AFDE78", VA="0x1AFDE78")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10965D0", Offset="0x10965D0")]
		public string ClubId
		{
			[Address(RVA="0x1AFDD80", Offset="0x1AFDD80", VA="0x1AFDD80")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AFDD88", Offset="0x1AFDD88", VA="0x1AFDD88")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10965E0", Offset="0x10965E0")]
		public string ClubName
		{
			[Address(RVA="0x1AFDDF8", Offset="0x1AFDDF8", VA="0x1AFDDF8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AFDE00", Offset="0x1AFDE00", VA="0x1AFDE00")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096600", Offset="0x1096600")]
		public Serverproto.ClubRole ClubRole
		{
			[Address(RVA="0x1AFDE80", Offset="0x1AFDE80", VA="0x1AFDE80")]
			get
			{
				return new Serverproto.ClubRole();
			}
			[Address(RVA="0x1AFDE88", Offset="0x1AFDE88", VA="0x1AFDE88")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096620", Offset="0x1096620")]
		public ulong CollectionPower
		{
			[Address(RVA="0x1AFDEA4", Offset="0x1AFDEA4", VA="0x1AFDEA4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AFDEAC", Offset="0x1AFDEAC", VA="0x1AFDEAC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096570", Offset="0x1096570")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AFD9C8", Offset="0x1AFD9C8", VA="0x1AFD9C8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096590", Offset="0x1096590")]
		public string Id
		{
			[Address(RVA="0x1AFDC70", Offset="0x1AFDC70", VA="0x1AFDC70")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AFDC78", Offset="0x1AFDC78", VA="0x1AFDC78")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10965B0", Offset="0x10965B0")]
		public ulong Level
		{
			[Address(RVA="0x1AFDD60", Offset="0x1AFDD60", VA="0x1AFDD60")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AFDD68", Offset="0x1AFDD68", VA="0x1AFDD68")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096560", Offset="0x1096560")]
		public static MessageParser<PlayerProfileSimple> Parser
		{
			[Address(RVA="0x1AFD960", Offset="0x1AFD960", VA="0x1AFD960")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096580", Offset="0x1096580")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AFDAB8", Offset="0x1AFDAB8", VA="0x1AFDAB8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096610", Offset="0x1096610")]
		public bool ShowVipProfileBg
		{
			[Address(RVA="0x1AFDE90", Offset="0x1AFDE90", VA="0x1AFDE90")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1AFDE98", Offset="0x1AFDE98", VA="0x1AFDE98")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10965A0", Offset="0x10965A0")]
		public string Username
		{
			[Address(RVA="0x1AFDCE8", Offset="0x1AFDCE8", VA="0x1AFDCE8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AFDCF0", Offset="0x1AFDCF0", VA="0x1AFDCF0")]
			set
			{
			}
		}

		[Address(RVA="0x1AFEBF0", Offset="0x1AFEBF0", VA="0x1AFEBF0")]
		static PlayerProfileSimple()
		{
		}

		[Address(RVA="0x1AFA260", Offset="0x1AFA260", VA="0x1AFA260")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E98C", Offset="0x107E98C")]
		public PlayerProfileSimple()
		{
		}

		[Address(RVA="0x1AFDB14", Offset="0x1AFDB14", VA="0x1AFDB14")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E99C", Offset="0x107E99C")]
		public PlayerProfileSimple(PlayerProfileSimple other)
		{
		}

		[Address(RVA="0x1AFE6D0", Offset="0x1AFE6D0", VA="0x1AFE6D0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EA0C", Offset="0x107EA0C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AF9C54", Offset="0x1AF9C54", VA="0x1AF9C54", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E9AC", Offset="0x107E9AC")]
		public PlayerProfileSimple Clone()
		{
			return null;
		}

		[Address(RVA="0x1AFDEB4", Offset="0x1AFDEB4", VA="0x1AFDEB4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E9BC", Offset="0x107E9BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFDF28", Offset="0x1AFDF28", VA="0x1AFDF28", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E9CC", Offset="0x107E9CC")]
		public bool Equals(PlayerProfileSimple other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFE038", Offset="0x1AFE038", VA="0x1AFE038", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E9DC", Offset="0x107E9DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AFA2BC", Offset="0x1AFA2BC", VA="0x1AFA2BC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EA1C", Offset="0x107EA1C")]
		public void MergeFrom(PlayerProfileSimple other)
		{
		}

		[Address(RVA="0x1AFE9D0", Offset="0x1AFE9D0", VA="0x1AFE9D0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EA2C", Offset="0x107EA2C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AFE24C", Offset="0x1AFE24C", VA="0x1AFE24C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E9EC", Offset="0x107E9EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AFE2B4", Offset="0x1AFE2B4", VA="0x1AFE2B4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107E9FC", Offset="0x107E9FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FC88", Offset="0x104FC88")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerProfileSimple.<>c <>9;

			[Address(RVA="0x1AFECC8", Offset="0x1AFECC8", VA="0x1AFECC8")]
			static <>c()
			{
			}

			[Address(RVA="0x1AFED2C", Offset="0x1AFED2C", VA="0x1AFED2C")]
			public <>c()
			{
			}

			[Address(RVA="0x1AFED34", Offset="0x1AFED34", VA="0x1AFED34")]
			internal PlayerProfileSimple <.cctor>b__70_0()
			{
				return null;
			}
		}
	}
}