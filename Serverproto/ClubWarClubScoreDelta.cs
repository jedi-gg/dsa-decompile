using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarClubScoreDelta : IMessage<ClubWarClubScoreDelta>, IMessage, IEquatable<ClubWarClubScoreDelta>, IDeepCloneable<ClubWarClubScoreDelta>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarClubScoreDelta> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubProfileSimple club_;

		[FieldOffset(Offset="0x0")]
		public const int GdTeamIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong gdTeamId_;

		[FieldOffset(Offset="0x0")]
		public const int OldScoreFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong oldScore_;

		[FieldOffset(Offset="0x0")]
		public const int NewScoreFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong newScore_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093640", Offset="0x1093640")]
		public ClubProfileSimple Club
		{
			[Address(RVA="0x1B20C54", Offset="0x1B20C54", VA="0x1B20C54")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B20C5C", Offset="0x1B20C5C", VA="0x1B20C5C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093620", Offset="0x1093620")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B20A6C", Offset="0x1B20A6C", VA="0x1B20A6C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093650", Offset="0x1093650")]
		public ulong GdTeamId
		{
			[Address(RVA="0x1B20CC4", Offset="0x1B20CC4", VA="0x1B20CC4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B20CCC", Offset="0x1B20CCC", VA="0x1B20CCC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093670", Offset="0x1093670")]
		public ulong NewScore
		{
			[Address(RVA="0x1B20CE4", Offset="0x1B20CE4", VA="0x1B20CE4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B20CEC", Offset="0x1B20CEC", VA="0x1B20CEC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093660", Offset="0x1093660")]
		public ulong OldScore
		{
			[Address(RVA="0x1B20CD4", Offset="0x1B20CD4", VA="0x1B20CD4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B20CDC", Offset="0x1B20CDC", VA="0x1B20CDC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093610", Offset="0x1093610")]
		public static MessageParser<ClubWarClubScoreDelta> Parser
		{
			[Address(RVA="0x1B1B53C", Offset="0x1B1B53C", VA="0x1B1B53C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093630", Offset="0x1093630")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B20B5C", Offset="0x1B20B5C", VA="0x1B20B5C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B21444", Offset="0x1B21444", VA="0x1B21444")]
		static ClubWarClubScoreDelta()
		{
		}

		[Address(RVA="0x1B20BB8", Offset="0x1B20BB8", VA="0x1B20BB8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107899C", Offset="0x107899C")]
		public ClubWarClubScoreDelta()
		{
		}

		[Address(RVA="0x1B20BC0", Offset="0x1B20BC0", VA="0x1B20BC0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10789AC", Offset="0x10789AC")]
		public ClubWarClubScoreDelta(ClubWarClubScoreDelta other)
		{
		}

		[Address(RVA="0x1B210C4", Offset="0x1B210C4", VA="0x1B210C4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078A1C", Offset="0x1078A1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B20C64", Offset="0x1B20C64", VA="0x1B20C64", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10789BC", Offset="0x10789BC")]
		public ClubWarClubScoreDelta Clone()
		{
			return null;
		}

		[Address(RVA="0x1B20CF4", Offset="0x1B20CF4", VA="0x1B20CF4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10789CC", Offset="0x10789CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B20D68", Offset="0x1B20D68", VA="0x1B20D68", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10789DC", Offset="0x10789DC")]
		public bool Equals(ClubWarClubScoreDelta other)
		{
			return new bool();
		}

		[Address(RVA="0x1B20DFC", Offset="0x1B20DFC", VA="0x1B20DFC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10789EC", Offset="0x10789EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B21210", Offset="0x1B21210", VA="0x1B21210", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078A2C", Offset="0x1078A2C")]
		public void MergeFrom(ClubWarClubScoreDelta other)
		{
		}

		[Address(RVA="0x1B212E8", Offset="0x1B212E8", VA="0x1B212E8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078A3C", Offset="0x1078A3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B20EB4", Offset="0x1B20EB4", VA="0x1B20EB4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10789FC", Offset="0x10789FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B20F1C", Offset="0x1B20F1C", VA="0x1B20F1C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078A0C", Offset="0x1078A0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F388", Offset="0x104F388")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarClubScoreDelta.<>c <>9;

			[Address(RVA="0x1B2151C", Offset="0x1B2151C", VA="0x1B2151C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B21580", Offset="0x1B21580", VA="0x1B21580")]
			public <>c()
			{
			}

			[Address(RVA="0x1B21588", Offset="0x1B21588", VA="0x1B21588")]
			internal ClubWarClubScoreDelta <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}