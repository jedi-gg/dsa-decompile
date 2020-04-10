using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerStat : IMessage<PlayerStat>, IMessage, IEquatable<PlayerStat>, IDeepCloneable<PlayerStat>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerStat> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StatIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong statId_;

		[FieldOffset(Offset="0x0")]
		public const int CountFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong count_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A1E0", Offset="0x109A1E0")]
		public ulong Count
		{
			[Address(RVA="0x1B119C4", Offset="0x1B119C4", VA="0x1B119C4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B119CC", Offset="0x1B119CC", VA="0x1B119CC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A1B0", Offset="0x109A1B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B11784", Offset="0x1B11784", VA="0x1B11784")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A1A0", Offset="0x109A1A0")]
		public static MessageParser<PlayerStat> Parser
		{
			[Address(RVA="0x1AFD834", Offset="0x1AFD834", VA="0x1AFD834")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A1C0", Offset="0x109A1C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B11870", Offset="0x1B11870", VA="0x1B11870", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A1D0", Offset="0x109A1D0")]
		public ulong StatId
		{
			[Address(RVA="0x1B119B4", Offset="0x1B119B4", VA="0x1B119B4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B119BC", Offset="0x1B119BC", VA="0x1B119BC")]
			set
			{
			}
		}

		[Address(RVA="0x1B11E3C", Offset="0x1B11E3C", VA="0x1B11E3C")]
		static PlayerStat()
		{
		}

		[Address(RVA="0x1B118CC", Offset="0x1B118CC", VA="0x1B118CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083E5C", Offset="0x1083E5C")]
		public PlayerStat()
		{
		}

		[Address(RVA="0x1B118D4", Offset="0x1B118D4", VA="0x1B118D4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083E6C", Offset="0x1083E6C")]
		public PlayerStat(PlayerStat other)
		{
		}

		[Address(RVA="0x1B11C78", Offset="0x1B11C78", VA="0x1B11C78", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083EDC", Offset="0x1083EDC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B11954", Offset="0x1B11954", VA="0x1B11954", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083E7C", Offset="0x1083E7C")]
		public PlayerStat Clone()
		{
			return null;
		}

		[Address(RVA="0x1B119D4", Offset="0x1B119D4", VA="0x1B119D4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083E8C", Offset="0x1083E8C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B11A48", Offset="0x1B11A48", VA="0x1B11A48", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083E9C", Offset="0x1083E9C")]
		public bool Equals(PlayerStat other)
		{
			return new bool();
		}

		[Address(RVA="0x1B11A94", Offset="0x1B11A94", VA="0x1B11A94", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083EAC", Offset="0x1083EAC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B11D4C", Offset="0x1B11D4C", VA="0x1B11D4C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083EEC", Offset="0x1083EEC")]
		public void MergeFrom(PlayerStat other)
		{
		}

		[Address(RVA="0x1B11D98", Offset="0x1B11D98", VA="0x1B11D98", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083EFC", Offset="0x1083EFC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B11B18", Offset="0x1B11B18", VA="0x1B11B18", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083EBC", Offset="0x1083EBC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B11B80", Offset="0x1B11B80", VA="0x1B11B80", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083ECC", Offset="0x1083ECC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050438", Offset="0x1050438")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerStat.<>c <>9;

			[Address(RVA="0x1B11F14", Offset="0x1B11F14", VA="0x1B11F14")]
			static <>c()
			{
			}

			[Address(RVA="0x1B11F78", Offset="0x1B11F78", VA="0x1B11F78")]
			public <>c()
			{
			}

			[Address(RVA="0x1B11F80", Offset="0x1B11F80", VA="0x1B11F80")]
			internal PlayerStat <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}