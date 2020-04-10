using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerJoinClubLock : IMessage<PlayerJoinClubLock>, IMessage, IEquatable<PlayerJoinClubLock>, IDeepCloneable<PlayerJoinClubLock>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerJoinClubLock> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int LeftClubTimestampFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong leftClubTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int JoinClubLockLevelFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong joinClubLockLevel_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096D50", Offset="0x1096D50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AF91AC", Offset="0x1AF91AC", VA="0x1AF91AC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096D80", Offset="0x1096D80")]
		public ulong JoinClubLockLevel
		{
			[Address(RVA="0x1AF93F0", Offset="0x1AF93F0", VA="0x1AF93F0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF93F8", Offset="0x1AF93F8", VA="0x1AF93F8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096D70", Offset="0x1096D70")]
		public ulong LeftClubTimestamp
		{
			[Address(RVA="0x1AF93E0", Offset="0x1AF93E0", VA="0x1AF93E0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF93E8", Offset="0x1AF93E8", VA="0x1AF93E8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096D40", Offset="0x1096D40")]
		public static MessageParser<PlayerJoinClubLock> Parser
		{
			[Address(RVA="0x1AF9144", Offset="0x1AF9144", VA="0x1AF9144")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096D60", Offset="0x1096D60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AF929C", Offset="0x1AF929C", VA="0x1AF929C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1AF9868", Offset="0x1AF9868", VA="0x1AF9868")]
		static PlayerJoinClubLock()
		{
		}

		[Address(RVA="0x1AF92F8", Offset="0x1AF92F8", VA="0x1AF92F8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F3DC", Offset="0x107F3DC")]
		public PlayerJoinClubLock()
		{
		}

		[Address(RVA="0x1AF9300", Offset="0x1AF9300", VA="0x1AF9300")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F3EC", Offset="0x107F3EC")]
		public PlayerJoinClubLock(PlayerJoinClubLock other)
		{
		}

		[Address(RVA="0x1AF96A4", Offset="0x1AF96A4", VA="0x1AF96A4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F45C", Offset="0x107F45C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AF9380", Offset="0x1AF9380", VA="0x1AF9380", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F3FC", Offset="0x107F3FC")]
		public PlayerJoinClubLock Clone()
		{
			return null;
		}

		[Address(RVA="0x1AF9400", Offset="0x1AF9400", VA="0x1AF9400", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F40C", Offset="0x107F40C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF9474", Offset="0x1AF9474", VA="0x1AF9474", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F41C", Offset="0x107F41C")]
		public bool Equals(PlayerJoinClubLock other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF94C0", Offset="0x1AF94C0", VA="0x1AF94C0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F42C", Offset="0x107F42C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AF9778", Offset="0x1AF9778", VA="0x1AF9778", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F46C", Offset="0x107F46C")]
		public void MergeFrom(PlayerJoinClubLock other)
		{
		}

		[Address(RVA="0x1AF97C4", Offset="0x1AF97C4", VA="0x1AF97C4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F47C", Offset="0x107F47C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AF9544", Offset="0x1AF9544", VA="0x1AF9544", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F43C", Offset="0x107F43C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AF95AC", Offset="0x1AF95AC", VA="0x1AF95AC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F44C", Offset="0x107F44C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FD78", Offset="0x104FD78")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerJoinClubLock.<>c <>9;

			[Address(RVA="0x1AF9940", Offset="0x1AF9940", VA="0x1AF9940")]
			static <>c()
			{
			}

			[Address(RVA="0x1AF99A4", Offset="0x1AF99A4", VA="0x1AF99A4")]
			public <>c()
			{
			}

			[Address(RVA="0x1AF99AC", Offset="0x1AF99AC", VA="0x1AF99AC")]
			internal PlayerJoinClubLock <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}