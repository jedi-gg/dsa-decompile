using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubSettings : IMessage<ClubSettings>, IMessage, IEquatable<ClubSettings>, IDeepCloneable<ClubSettings>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubSettings> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int AvatarIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong avatarId_;

		[FieldOffset(Offset="0x0")]
		public const int DescriptionFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string description_;

		[FieldOffset(Offset="0x0")]
		public const int LevelRequirementFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong levelRequirement_;

		[FieldOffset(Offset="0x0")]
		public const int InvitePolicyFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ClubInvitePolicy invitePolicy_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10948D0", Offset="0x10948D0")]
		public ulong AvatarId
		{
			[Address(RVA="0x1B15FAC", Offset="0x1B15FAC", VA="0x1B15FAC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B15FB4", Offset="0x1B15FB4", VA="0x1B15FB4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10948E0", Offset="0x10948E0")]
		public string Description
		{
			[Address(RVA="0x1B15FBC", Offset="0x1B15FBC", VA="0x1B15FBC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B15FC4", Offset="0x1B15FC4", VA="0x1B15FC4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10948B0", Offset="0x10948B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B15CF4", Offset="0x1B15CF4", VA="0x1B15CF4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094900", Offset="0x1094900")]
		public ClubInvitePolicy InvitePolicy
		{
			[Address(RVA="0x1B16044", Offset="0x1B16044", VA="0x1B16044")]
			get
			{
				return new ClubInvitePolicy();
			}
			[Address(RVA="0x1B1604C", Offset="0x1B1604C", VA="0x1B1604C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10948F0", Offset="0x10948F0")]
		public ulong LevelRequirement
		{
			[Address(RVA="0x1B16034", Offset="0x1B16034", VA="0x1B16034")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B1603C", Offset="0x1B1603C", VA="0x1B1603C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10948A0", Offset="0x10948A0")]
		public static MessageParser<ClubSettings> Parser
		{
			[Address(RVA="0x1B15C8C", Offset="0x1B15C8C", VA="0x1B15C8C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10948C0", Offset="0x10948C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B15DE4", Offset="0x1B15DE4", VA="0x1B15DE4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B1676C", Offset="0x1B1676C", VA="0x1B1676C")]
		static ClubSettings()
		{
		}

		[Address(RVA="0x1B15E40", Offset="0x1B15E40", VA="0x1B15E40")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A83C", Offset="0x107A83C")]
		public ClubSettings()
		{
		}

		[Address(RVA="0x1B15E98", Offset="0x1B15E98", VA="0x1B15E98")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A84C", Offset="0x107A84C")]
		public ClubSettings(ClubSettings other)
		{
		}

		[Address(RVA="0x1B16470", Offset="0x1B16470", VA="0x1B16470", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A8BC", Offset="0x107A8BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B15F4C", Offset="0x1B15F4C", VA="0x1B15F4C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A85C", Offset="0x107A85C")]
		public ClubSettings Clone()
		{
			return null;
		}

		[Address(RVA="0x1B16054", Offset="0x1B16054", VA="0x1B16054", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A86C", Offset="0x107A86C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B160C8", Offset="0x1B160C8", VA="0x1B160C8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A87C", Offset="0x107A87C")]
		public bool Equals(ClubSettings other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1615C", Offset="0x1B1615C", VA="0x1B1615C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A88C", Offset="0x107A88C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B165D8", Offset="0x1B165D8", VA="0x1B165D8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A8CC", Offset="0x107A8CC")]
		public void MergeFrom(ClubSettings other)
		{
		}

		[Address(RVA="0x1B16668", Offset="0x1B16668", VA="0x1B16668", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A8DC", Offset="0x107A8DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B16248", Offset="0x1B16248", VA="0x1B16248", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A89C", Offset="0x107A89C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B162B0", Offset="0x1B162B0", VA="0x1B162B0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A8AC", Offset="0x107A8AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F688", Offset="0x104F688")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubSettings.<>c <>9;

			[Address(RVA="0x1B16844", Offset="0x1B16844", VA="0x1B16844")]
			static <>c()
			{
			}

			[Address(RVA="0x1B168A8", Offset="0x1B168A8", VA="0x1B168A8")]
			public <>c()
			{
			}

			[Address(RVA="0x1B168B0", Offset="0x1B168B0", VA="0x1B168B0")]
			internal ClubSettings <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}