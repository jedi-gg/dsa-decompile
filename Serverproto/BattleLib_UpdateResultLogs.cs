using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleLib_UpdateResultLogs : IMessage<BattleLib_UpdateResultLogs>, IMessage, IEquatable<BattleLib_UpdateResultLogs>, IDeepCloneable<BattleLib_UpdateResultLogs>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleLib_UpdateResultLogs> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DebugLogsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<string> _repeated_debugLogs_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<string> debugLogs_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10939D0", Offset="0x10939D0")]
		public RepeatedField<string> DebugLogs
		{
			[Address(RVA="0x203C468", Offset="0x203C468", VA="0x203C468")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10939B0", Offset="0x10939B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x203C1B4", Offset="0x203C1B4", VA="0x203C1B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10939A0", Offset="0x10939A0")]
		public static MessageParser<BattleLib_UpdateResultLogs> Parser
		{
			[Address(RVA="0x203C14C", Offset="0x203C14C", VA="0x203C14C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10939C0", Offset="0x10939C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x203C2A4", Offset="0x203C2A4", VA="0x203C2A4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x203C950", Offset="0x203C950", VA="0x203C950")]
		static BattleLib_UpdateResultLogs()
		{
		}

		[Address(RVA="0x203C300", Offset="0x203C300", VA="0x203C300")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078C5C", Offset="0x1078C5C")]
		public BattleLib_UpdateResultLogs()
		{
		}

		[Address(RVA="0x203C370", Offset="0x203C370", VA="0x203C370")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078C6C", Offset="0x1078C6C")]
		public BattleLib_UpdateResultLogs(BattleLib_UpdateResultLogs other)
		{
		}

		[Address(RVA="0x203C720", Offset="0x203C720", VA="0x203C720", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078CDC", Offset="0x1078CDC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x203C408", Offset="0x203C408", VA="0x203C408", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078C7C", Offset="0x1078C7C")]
		public BattleLib_UpdateResultLogs Clone()
		{
			return null;
		}

		[Address(RVA="0x203C470", Offset="0x203C470", VA="0x203C470", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078C8C", Offset="0x1078C8C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x203C4E4", Offset="0x203C4E4", VA="0x203C4E4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078C9C", Offset="0x1078C9C")]
		public bool Equals(BattleLib_UpdateResultLogs other)
		{
			return new bool();
		}

		[Address(RVA="0x203C594", Offset="0x203C594", VA="0x203C594", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078CAC", Offset="0x1078CAC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x203C7DC", Offset="0x203C7DC", VA="0x203C7DC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078CEC", Offset="0x1078CEC")]
		public void MergeFrom(BattleLib_UpdateResultLogs other)
		{
		}

		[Address(RVA="0x203C86C", Offset="0x203C86C", VA="0x203C86C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078CFC", Offset="0x1078CFC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x203C5F4", Offset="0x203C5F4", VA="0x203C5F4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078CBC", Offset="0x1078CBC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x203C65C", Offset="0x203C65C", VA="0x203C65C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078CCC", Offset="0x1078CCC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F3D8", Offset="0x104F3D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleLib_UpdateResultLogs.<>c <>9;

			[Address(RVA="0x203CA40", Offset="0x203CA40", VA="0x203CA40")]
			static <>c()
			{
			}

			[Address(RVA="0x203CAA4", Offset="0x203CAA4", VA="0x203CAA4")]
			public <>c()
			{
			}

			[Address(RVA="0x203CAAC", Offset="0x203CAAC", VA="0x203CAAC")]
			internal BattleLib_UpdateResultLogs <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}