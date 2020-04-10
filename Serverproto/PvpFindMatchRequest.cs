using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PvpFindMatchRequest : IMessage<PvpFindMatchRequest>, IMessage, IEquatable<PvpFindMatchRequest>, IDeepCloneable<PvpFindMatchRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PvpFindMatchRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_units_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ulong> units_;

		[FieldOffset(Offset="0x0")]
		public const int SpellsFieldNumber = 2;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_spells_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> spells_;

		[FieldOffset(Offset="0x0")]
		public const int SquadSaveFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private BattleSquadSaveInfo squadSave_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong leaderUnit_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091F88", Offset="0x1091F88")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2016164", Offset="0x2016164", VA="0x2016164")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091FD8", Offset="0x1091FD8")]
		public ulong LeaderUnit
		{
			[Address(RVA="0x2016494", Offset="0x2016494", VA="0x2016494")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x201649C", Offset="0x201649C", VA="0x201649C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091F78", Offset="0x1091F78")]
		public static MessageParser<PvpFindMatchRequest> Parser
		{
			[Address(RVA="0x20160FC", Offset="0x20160FC", VA="0x20160FC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091F98", Offset="0x1091F98")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2016254", Offset="0x2016254", VA="0x2016254", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091FB8", Offset="0x1091FB8")]
		public RepeatedField<ulong> Spells
		{
			[Address(RVA="0x201648C", Offset="0x201648C", VA="0x201648C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091FC8", Offset="0x1091FC8")]
		public BattleSquadSaveInfo SquadSave
		{
			[Address(RVA="0x2016414", Offset="0x2016414", VA="0x2016414")]
			get
			{
				return null;
			}
			[Address(RVA="0x201641C", Offset="0x201641C", VA="0x201641C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091FA8", Offset="0x1091FA8")]
		public RepeatedField<ulong> Units
		{
			[Address(RVA="0x2016484", Offset="0x2016484", VA="0x2016484")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2016D40", Offset="0x2016D40", VA="0x2016D40")]
		static PvpFindMatchRequest()
		{
		}

		[Address(RVA="0x20162B0", Offset="0x20162B0", VA="0x20162B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10761BC", Offset="0x10761BC")]
		public PvpFindMatchRequest()
		{
		}

		[Address(RVA="0x2016340", Offset="0x2016340", VA="0x2016340")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10761CC", Offset="0x10761CC")]
		public PvpFindMatchRequest(PvpFindMatchRequest other)
		{
		}

		[Address(RVA="0x20168FC", Offset="0x20168FC", VA="0x20168FC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107623C", Offset="0x107623C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2016424", Offset="0x2016424", VA="0x2016424", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10761DC", Offset="0x10761DC")]
		public PvpFindMatchRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x20164A4", Offset="0x20164A4", VA="0x20164A4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10761EC", Offset="0x10761EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2016518", Offset="0x2016518", VA="0x2016518", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10761FC", Offset="0x10761FC")]
		public bool Equals(PvpFindMatchRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x2016620", Offset="0x2016620", VA="0x2016620", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107620C", Offset="0x107620C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2016A64", Offset="0x2016A64", VA="0x2016A64", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107624C", Offset="0x107624C")]
		public void MergeFrom(PvpFindMatchRequest other)
		{
		}

		[Address(RVA="0x2016B7C", Offset="0x2016B7C", VA="0x2016B7C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107625C", Offset="0x107625C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x20166E4", Offset="0x20166E4", VA="0x20166E4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107621C", Offset="0x107621C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201674C", Offset="0x201674C", VA="0x201674C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107622C", Offset="0x107622C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EFE8", Offset="0x104EFE8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PvpFindMatchRequest.<>c <>9;

			[Address(RVA="0x2016E48", Offset="0x2016E48", VA="0x2016E48")]
			static <>c()
			{
			}

			[Address(RVA="0x2016EAC", Offset="0x2016EAC", VA="0x2016EAC")]
			public <>c()
			{
			}

			[Address(RVA="0x2016EB4", Offset="0x2016EB4", VA="0x2016EB4")]
			internal PvpFindMatchRequest <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}