using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Serverproto
{
	public sealed class ClubWarNodeDetailResponse : IMessage<ClubWarNodeDetailResponse>, IMessage, IEquatable<ClubWarNodeDetailResponse>, IDeepCloneable<ClubWarNodeDetailResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarNodeDetailResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int OwnerTeamIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong ownerTeamId_;

		[FieldOffset(Offset="0x0")]
		public const int DefensesFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubWarDefense> _repeated_defenses_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ClubWarDefense> defenses_;

		[FieldOffset(Offset="0x0")]
		public const int RebuildFinishTimeFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong rebuildFinishTime_;

		[FieldOffset(Offset="0x30")]
		private Dictionary<ulong, ulong> _numDefeatedPerTeam;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095FF0", Offset="0x1095FF0")]
		public RepeatedField<ClubWarDefense> Defenses
		{
			[Address(RVA="0x1B25184", Offset="0x1B25184", VA="0x1B25184")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095FC0", Offset="0x1095FC0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B24F68", Offset="0x1B24F68", VA="0x1B24F68")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095FE0", Offset="0x1095FE0")]
		public ulong OwnerTeamId
		{
			[Address(RVA="0x1B25174", Offset="0x1B25174", VA="0x1B25174")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B2517C", Offset="0x1B2517C", VA="0x1B2517C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095FB0", Offset="0x1095FB0")]
		public static MessageParser<ClubWarNodeDetailResponse> Parser
		{
			[Address(RVA="0x1B24F00", Offset="0x1B24F00", VA="0x1B24F00")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095FD0", Offset="0x1095FD0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B25058", Offset="0x1B25058", VA="0x1B25058", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096000", Offset="0x1096000")]
		public ulong RebuildFinishTime
		{
			[Address(RVA="0x1B2518C", Offset="0x1B2518C", VA="0x1B2518C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B25194", Offset="0x1B25194", VA="0x1B25194")]
			set
			{
			}
		}

		[Address(RVA="0x1B25F24", Offset="0x1B25F24", VA="0x1B25F24")]
		static ClubWarNodeDetailResponse()
		{
		}

		[Address(RVA="0x1B1EC78", Offset="0x1B1EC78", VA="0x1B1EC78")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DBCC", Offset="0x107DBCC")]
		public ClubWarNodeDetailResponse()
		{
		}

		[Address(RVA="0x1B250B4", Offset="0x1B250B4", VA="0x1B250B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DBDC", Offset="0x107DBDC")]
		public ClubWarNodeDetailResponse(ClubWarNodeDetailResponse other)
		{
		}

		[Address(RVA="0x1B25564", Offset="0x1B25564", VA="0x1B25564", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DC4C", Offset="0x107DC4C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B1E83C", Offset="0x1B1E83C", VA="0x1B1E83C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DBEC", Offset="0x107DBEC")]
		public ClubWarNodeDetailResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B2519C", Offset="0x1B2519C", VA="0x1B2519C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DBFC", Offset="0x107DBFC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B25210", Offset="0x1B25210", VA="0x1B25210", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DC0C", Offset="0x107DC0C")]
		public bool Equals(ClubWarNodeDetailResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B252E0", Offset="0x1B252E0", VA="0x1B252E0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DC1C", Offset="0x107DC1C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B25860", Offset="0x1B25860", VA="0x1B25860")]
		public Dictionary<ulong, ulong> GetNumDefeatedPerTeam()
		{
			return null;
		}

		[Address(RVA="0x1B257D4", Offset="0x1B257D4", VA="0x1B257D4")]
		public ulong GetNumDefeatedSquadsForTeam(ulong teamId)
		{
			return new ulong();
		}

		[Address(RVA="0x1B25DB8", Offset="0x1B25DB8", VA="0x1B25DB8")]
		public ulong GetNumDefeatedSquadsMax()
		{
			return new ulong();
		}

		[Address(RVA="0x1B1ECE8", Offset="0x1B1ECE8", VA="0x1B1ECE8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DC5C", Offset="0x107DC5C")]
		public void MergeFrom(ClubWarNodeDetailResponse other)
		{
		}

		[Address(RVA="0x1B25698", Offset="0x1B25698", VA="0x1B25698", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DC6C", Offset="0x107DC6C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B25388", Offset="0x1B25388", VA="0x1B25388", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DC2C", Offset="0x107DC2C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B253F0", Offset="0x1B253F0", VA="0x1B253F0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DC3C", Offset="0x107DC3C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FB48", Offset="0x104FB48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarNodeDetailResponse.<>c <>9;

			[Address(RVA="0x1B26044", Offset="0x1B26044", VA="0x1B26044")]
			static <>c()
			{
			}

			[Address(RVA="0x1B260A8", Offset="0x1B260A8", VA="0x1B260A8")]
			public <>c()
			{
			}

			[Address(RVA="0x1B260B0", Offset="0x1B260B0", VA="0x1B260B0")]
			internal ClubWarNodeDetailResponse <.cctor>b__39_0()
			{
				return null;
			}
		}
	}
}