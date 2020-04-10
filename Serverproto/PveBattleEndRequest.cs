using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PveBattleEndRequest : IMessage<PveBattleEndRequest>, IMessage, IEquatable<PveBattleEndRequest>, IDeepCloneable<PveBattleEndRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PveBattleEndRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int WinFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private bool win_;

		[FieldOffset(Offset="0x0")]
		public const int StarLevelFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong starLevel_;

		[FieldOffset(Offset="0x0")]
		public const int ActivityResultsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<BattleActivityResult> _repeated_activityResults_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<BattleActivityResult> activityResults_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091F18", Offset="0x1091F18")]
		public RepeatedField<BattleActivityResult> ActivityResults
		{
			[Address(RVA="0x20131F8", Offset="0x20131F8", VA="0x20131F8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091ED8", Offset="0x1091ED8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2012EE4", Offset="0x2012EE4", VA="0x2012EE4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091EC8", Offset="0x1091EC8")]
		public static MessageParser<PveBattleEndRequest> Parser
		{
			[Address(RVA="0x2012E7C", Offset="0x2012E7C", VA="0x2012E7C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091EE8", Offset="0x1091EE8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2012FD4", Offset="0x2012FD4", VA="0x2012FD4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091F08", Offset="0x1091F08")]
		public ulong StarLevel
		{
			[Address(RVA="0x20131E8", Offset="0x20131E8", VA="0x20131E8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x20131F0", Offset="0x20131F0", VA="0x20131F0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091EF8", Offset="0x1091EF8")]
		public bool Win
		{
			[Address(RVA="0x20131D4", Offset="0x20131D4", VA="0x20131D4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x20131DC", Offset="0x20131DC", VA="0x20131DC")]
			set
			{
			}
		}

		[Address(RVA="0x20138CC", Offset="0x20138CC", VA="0x20138CC")]
		static PveBattleEndRequest()
		{
		}

		[Address(RVA="0x2013030", Offset="0x2013030", VA="0x2013030")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107605C", Offset="0x107605C")]
		public PveBattleEndRequest()
		{
		}

		[Address(RVA="0x20130A0", Offset="0x20130A0", VA="0x20130A0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107606C", Offset="0x107606C")]
		public PveBattleEndRequest(PveBattleEndRequest other)
		{
		}

		[Address(RVA="0x20135E4", Offset="0x20135E4", VA="0x20135E4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10760DC", Offset="0x10760DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2013174", Offset="0x2013174", VA="0x2013174", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107607C", Offset="0x107607C")]
		public PveBattleEndRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x2013200", Offset="0x2013200", VA="0x2013200", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107608C", Offset="0x107608C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2013274", Offset="0x2013274", VA="0x2013274", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107609C", Offset="0x107609C")]
		public bool Equals(PveBattleEndRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x2013354", Offset="0x2013354", VA="0x2013354", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10760AC", Offset="0x10760AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x20136E4", Offset="0x20136E4", VA="0x20136E4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10760EC", Offset="0x10760EC")]
		public void MergeFrom(PveBattleEndRequest other)
		{
		}

		[Address(RVA="0x201378C", Offset="0x201378C", VA="0x201378C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10760FC", Offset="0x10760FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2013404", Offset="0x2013404", VA="0x2013404", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10760BC", Offset="0x10760BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201346C", Offset="0x201346C", VA="0x201346C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10760CC", Offset="0x10760CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EFC8", Offset="0x104EFC8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PveBattleEndRequest.<>c <>9;

			[Address(RVA="0x20139F0", Offset="0x20139F0", VA="0x20139F0")]
			static <>c()
			{
			}

			[Address(RVA="0x2013A54", Offset="0x2013A54", VA="0x2013A54")]
			public <>c()
			{
			}

			[Address(RVA="0x2013A5C", Offset="0x2013A5C", VA="0x2013A5C")]
			internal PveBattleEndRequest <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}