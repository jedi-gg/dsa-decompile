using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonStatus : IMessage<ClubDungeonStatus>, IMessage, IEquatable<ClubDungeonStatus>, IDeepCloneable<ClubDungeonStatus>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonStatus> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DungeonIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string dungeonId_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentMapFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong currentMap_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentNodeFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong currentNode_;

		[FieldOffset(Offset="0x0")]
		public const int LimitedAttemptResetTimeFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong limitedAttemptResetTime_;

		[FieldOffset(Offset="0x0")]
		public const int LimitedAttemptsRemainingFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong limitedAttemptsRemaining_;

		[FieldOffset(Offset="0x0")]
		public const int CanParticipateFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private bool canParticipate_;

		[FieldOffset(Offset="0x0")]
		public const int OtherPlayersFieldNumber = 7;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubDungeonPlayer> _repeated_otherPlayers_codec;

		[FieldOffset(Offset="0x48")]
		private readonly RepeatedField<ClubDungeonPlayer> otherPlayers_;

		[FieldOffset(Offset="0x0")]
		public const int ClaimedBonusAttemptFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private bool claimedBonusAttempt_;

		[FieldOffset(Offset="0x0")]
		public const int IsDungeonActiveFieldNumber = 9;

		[FieldOffset(Offset="0x51")]
		private bool isDungeonActive_;

		[FieldOffset(Offset="0x0")]
		public const int HasPendingDoorSelectionFieldNumber = 10;

		[FieldOffset(Offset="0x52")]
		private bool hasPendingDoorSelection_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095820", Offset="0x1095820")]
		public bool CanParticipate
		{
			[Address(RVA="0x1FF4FD8", Offset="0x1FF4FD8", VA="0x1FF4FD8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FF4FE0", Offset="0x1FF4FE0", VA="0x1FF4FE0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095840", Offset="0x1095840")]
		public bool ClaimedBonusAttempt
		{
			[Address(RVA="0x1FF4FF4", Offset="0x1FF4FF4", VA="0x1FF4FF4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FF4FFC", Offset="0x1FF4FFC", VA="0x1FF4FFC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10957E0", Offset="0x10957E0")]
		public ulong CurrentMap
		{
			[Address(RVA="0x1FF4F98", Offset="0x1FF4F98", VA="0x1FF4F98")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF4FA0", Offset="0x1FF4FA0", VA="0x1FF4FA0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10957F0", Offset="0x10957F0")]
		public ulong CurrentNode
		{
			[Address(RVA="0x1FF4FA8", Offset="0x1FF4FA8", VA="0x1FF4FA8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF4FB0", Offset="0x1FF4FB0", VA="0x1FF4FB0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10957B0", Offset="0x10957B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FF4B9C", Offset="0x1FF4B9C", VA="0x1FF4B9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10957D0", Offset="0x10957D0")]
		public string DungeonId
		{
			[Address(RVA="0x1FF4F20", Offset="0x1FF4F20", VA="0x1FF4F20")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF4F28", Offset="0x1FF4F28", VA="0x1FF4F28")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095860", Offset="0x1095860")]
		public bool HasPendingDoorSelection
		{
			[Address(RVA="0x1FF501C", Offset="0x1FF501C", VA="0x1FF501C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FF5024", Offset="0x1FF5024", VA="0x1FF5024")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095850", Offset="0x1095850")]
		public bool IsDungeonActive
		{
			[Address(RVA="0x1FF5008", Offset="0x1FF5008", VA="0x1FF5008")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1FF5010", Offset="0x1FF5010", VA="0x1FF5010")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095800", Offset="0x1095800")]
		public ulong LimitedAttemptResetTime
		{
			[Address(RVA="0x1FF4FB8", Offset="0x1FF4FB8", VA="0x1FF4FB8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF4FC0", Offset="0x1FF4FC0", VA="0x1FF4FC0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095810", Offset="0x1095810")]
		public ulong LimitedAttemptsRemaining
		{
			[Address(RVA="0x1FF4FC8", Offset="0x1FF4FC8", VA="0x1FF4FC8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FF4FD0", Offset="0x1FF4FD0", VA="0x1FF4FD0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095830", Offset="0x1095830")]
		public RepeatedField<ClubDungeonPlayer> OtherPlayers
		{
			[Address(RVA="0x1FF4FEC", Offset="0x1FF4FEC", VA="0x1FF4FEC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10957A0", Offset="0x10957A0")]
		public static MessageParser<ClubDungeonStatus> Parser
		{
			[Address(RVA="0x1FF4B34", Offset="0x1FF4B34", VA="0x1FF4B34")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10957C0", Offset="0x10957C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FF4C88", Offset="0x1FF4C88", VA="0x1FF4C88", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FF5E24", Offset="0x1FF5E24", VA="0x1FF5E24")]
		static ClubDungeonStatus()
		{
		}

		[Address(RVA="0x1FF4CE4", Offset="0x1FF4CE4", VA="0x1FF4CE4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C9EC", Offset="0x107C9EC")]
		public ClubDungeonStatus()
		{
		}

		[Address(RVA="0x1FF4D64", Offset="0x1FF4D64", VA="0x1FF4D64")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C9FC", Offset="0x107C9FC")]
		public ClubDungeonStatus(ClubDungeonStatus other)
		{
		}

		[Address(RVA="0x1FF5840", Offset="0x1FF5840", VA="0x1FF5840", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CA6C", Offset="0x107CA6C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FF4EC0", Offset="0x1FF4EC0", VA="0x1FF4EC0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CA0C", Offset="0x107CA0C")]
		public ClubDungeonStatus Clone()
		{
			return null;
		}

		[Address(RVA="0x1FF5030", Offset="0x1FF5030", VA="0x1FF5030", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CA1C", Offset="0x107CA1C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF50A4", Offset="0x1FF50A4", VA="0x1FF50A4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CA2C", Offset="0x107CA2C")]
		public bool Equals(ClubDungeonStatus other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF5228", Offset="0x1FF5228", VA="0x1FF5228", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CA3C", Offset="0x107CA3C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FF5A8C", Offset="0x1FF5A8C", VA="0x1FF5A8C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CA7C", Offset="0x107CA7C")]
		public void MergeFrom(ClubDungeonStatus other)
		{
		}

		[Address(RVA="0x1FF5BA8", Offset="0x1FF5BA8", VA="0x1FF5BA8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CA8C", Offset="0x107CA8C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FF53D4", Offset="0x1FF53D4", VA="0x1FF53D4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CA4C", Offset="0x107CA4C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FF543C", Offset="0x1FF543C", VA="0x1FF543C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CA5C", Offset="0x107CA5C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F998", Offset="0x104F998")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonStatus.<>c <>9;

			[Address(RVA="0x1FF5F44", Offset="0x1FF5F44", VA="0x1FF5F44")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF5FA8", Offset="0x1FF5FA8", VA="0x1FF5FA8")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF5FB0", Offset="0x1FF5FB0", VA="0x1FF5FB0")]
			internal ClubDungeonStatus <.cctor>b__70_0()
			{
				return null;
			}
		}
	}
}