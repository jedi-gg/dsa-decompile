using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MultiplayerBattleActivity : IMessage<MultiplayerBattleActivity>, IMessage, IEquatable<MultiplayerBattleActivity>, IDeepCloneable<MultiplayerBattleActivity>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MultiplayerBattleActivity> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerAccountIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerAccountId_;

		[FieldOffset(Offset="0x0")]
		public const int ActivityDefIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong activityDefId_;

		[FieldOffset(Offset="0x0")]
		public const int TrackerIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong trackerId_;

		[FieldOffset(Offset="0x0")]
		public const int ActivityValueFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong activityValue_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092438", Offset="0x1092438")]
		public ulong ActivityDefId
		{
			[Address(RVA="0x1A21D08", Offset="0x1A21D08", VA="0x1A21D08")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A21D10", Offset="0x1A21D10", VA="0x1A21D10")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092458", Offset="0x1092458")]
		public ulong ActivityValue
		{
			[Address(RVA="0x1A21D28", Offset="0x1A21D28", VA="0x1A21D28")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A21D30", Offset="0x1A21D30", VA="0x1A21D30")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092408", Offset="0x1092408")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A219D8", Offset="0x1A219D8", VA="0x1A219D8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10923F8", Offset="0x10923F8")]
		public static MessageParser<MultiplayerBattleActivity> Parser
		{
			[Address(RVA="0x1A1D224", Offset="0x1A1D224", VA="0x1A1D224")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092418", Offset="0x1092418")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A21AC8", Offset="0x1A21AC8", VA="0x1A21AC8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092428", Offset="0x1092428")]
		public string PlayerAccountId
		{
			[Address(RVA="0x1A21C90", Offset="0x1A21C90", VA="0x1A21C90")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A21C98", Offset="0x1A21C98", VA="0x1A21C98")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092448", Offset="0x1092448")]
		public ulong TrackerId
		{
			[Address(RVA="0x1A21D18", Offset="0x1A21D18", VA="0x1A21D18")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A21D20", Offset="0x1A21D20", VA="0x1A21D20")]
			set
			{
			}
		}

		[Address(RVA="0x1A22450", Offset="0x1A22450", VA="0x1A22450")]
		static MultiplayerBattleActivity()
		{
		}

		[Address(RVA="0x1A21B24", Offset="0x1A21B24", VA="0x1A21B24")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107689C", Offset="0x107689C")]
		public MultiplayerBattleActivity()
		{
		}

		[Address(RVA="0x1A21B7C", Offset="0x1A21B7C", VA="0x1A21B7C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10768AC", Offset="0x10768AC")]
		public MultiplayerBattleActivity(MultiplayerBattleActivity other)
		{
		}

		[Address(RVA="0x1A2214C", Offset="0x1A2214C", VA="0x1A2214C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107691C", Offset="0x107691C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A21C30", Offset="0x1A21C30", VA="0x1A21C30", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10768BC", Offset="0x10768BC")]
		public MultiplayerBattleActivity Clone()
		{
			return null;
		}

		[Address(RVA="0x1A21D38", Offset="0x1A21D38", VA="0x1A21D38", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10768CC", Offset="0x10768CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A21DAC", Offset="0x1A21DAC", VA="0x1A21DAC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10768DC", Offset="0x10768DC")]
		public bool Equals(MultiplayerBattleActivity other)
		{
			return new bool();
		}

		[Address(RVA="0x1A21E40", Offset="0x1A21E40", VA="0x1A21E40", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10768EC", Offset="0x10768EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A222BC", Offset="0x1A222BC", VA="0x1A222BC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107692C", Offset="0x107692C")]
		public void MergeFrom(MultiplayerBattleActivity other)
		{
		}

		[Address(RVA="0x1A2234C", Offset="0x1A2234C", VA="0x1A2234C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107693C", Offset="0x107693C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A21F24", Offset="0x1A21F24", VA="0x1A21F24", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10768FC", Offset="0x10768FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A21F8C", Offset="0x1A21F8C", VA="0x1A21F8C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107690C", Offset="0x107690C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F088", Offset="0x104F088")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MultiplayerBattleActivity.<>c <>9;

			[Address(RVA="0x1A22528", Offset="0x1A22528", VA="0x1A22528")]
			static <>c()
			{
			}

			[Address(RVA="0x1A2258C", Offset="0x1A2258C", VA="0x1A2258C")]
			public <>c()
			{
			}

			[Address(RVA="0x1A22594", Offset="0x1A22594", VA="0x1A22594")]
			internal MultiplayerBattleActivity <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}