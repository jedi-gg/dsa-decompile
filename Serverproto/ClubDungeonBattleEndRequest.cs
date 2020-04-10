using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonBattleEndRequest : IMessage<ClubDungeonBattleEndRequest>, IMessage, IEquatable<ClubDungeonBattleEndRequest>, IDeepCloneable<ClubDungeonBattleEndRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonBattleEndRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int WinFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private bool win_;

		[FieldOffset(Offset="0x0")]
		public const int ActivityResultsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<BattleActivityResult> _repeated_activityResults_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<BattleActivityResult> activityResults_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10931E0", Offset="0x10931E0")]
		public RepeatedField<BattleActivityResult> ActivityResults
		{
			[Address(RVA="0x1A4D014", Offset="0x1A4D014", VA="0x1A4D014")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10931B0", Offset="0x10931B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A4CD2C", Offset="0x1A4CD2C", VA="0x1A4CD2C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10931A0", Offset="0x10931A0")]
		public static MessageParser<ClubDungeonBattleEndRequest> Parser
		{
			[Address(RVA="0x1A4CCC4", Offset="0x1A4CCC4", VA="0x1A4CCC4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10931C0", Offset="0x10931C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A4CE1C", Offset="0x1A4CE1C", VA="0x1A4CE1C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10931D0", Offset="0x10931D0")]
		public bool Win
		{
			[Address(RVA="0x1A4D000", Offset="0x1A4D000", VA="0x1A4D000")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A4D008", Offset="0x1A4D008", VA="0x1A4D008")]
			set
			{
			}
		}

		[Address(RVA="0x1A4D5E4", Offset="0x1A4D5E4", VA="0x1A4D5E4")]
		static ClubDungeonBattleEndRequest()
		{
		}

		[Address(RVA="0x1A4CE78", Offset="0x1A4CE78", VA="0x1A4CE78")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10782BC", Offset="0x10782BC")]
		public ClubDungeonBattleEndRequest()
		{
		}

		[Address(RVA="0x1A4CEE8", Offset="0x1A4CEE8", VA="0x1A4CEE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10782CC", Offset="0x10782CC")]
		public ClubDungeonBattleEndRequest(ClubDungeonBattleEndRequest other)
		{
		}

		[Address(RVA="0x1A4D374", Offset="0x1A4D374", VA="0x1A4D374", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107833C", Offset="0x107833C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A4CFA0", Offset="0x1A4CFA0", VA="0x1A4CFA0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10782DC", Offset="0x10782DC")]
		public ClubDungeonBattleEndRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A4D01C", Offset="0x1A4D01C", VA="0x1A4D01C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10782EC", Offset="0x10782EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4D090", Offset="0x1A4D090", VA="0x1A4D090", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10782FC", Offset="0x10782FC")]
		public bool Equals(ClubDungeonBattleEndRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A4D160", Offset="0x1A4D160", VA="0x1A4D160", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107830C", Offset="0x107830C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A4D438", Offset="0x1A4D438", VA="0x1A4D438", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107834C", Offset="0x107834C")]
		public void MergeFrom(ClubDungeonBattleEndRequest other)
		{
		}

		[Address(RVA="0x1A4D4D4", Offset="0x1A4D4D4", VA="0x1A4D4D4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107835C", Offset="0x107835C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A4D1EC", Offset="0x1A4D1EC", VA="0x1A4D1EC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107831C", Offset="0x107831C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A4D254", Offset="0x1A4D254", VA="0x1A4D254", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107832C", Offset="0x107832C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F2E8", Offset="0x104F2E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonBattleEndRequest.<>c <>9;

			[Address(RVA="0x1A4D708", Offset="0x1A4D708", VA="0x1A4D708")]
			static <>c()
			{
			}

			[Address(RVA="0x1A4D76C", Offset="0x1A4D76C", VA="0x1A4D76C")]
			public <>c()
			{
			}

			[Address(RVA="0x1A4D774", Offset="0x1A4D774", VA="0x1A4D774")]
			internal ClubDungeonBattleEndRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}