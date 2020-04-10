using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EventUnlocked : IMessage<EventUnlocked>, IMessage, IEquatable<EventUnlocked>, IDeepCloneable<EventUnlocked>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EventUnlocked> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ProgressFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<EventProgress> _repeated_progress_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<EventProgress> progress_;

		[FieldOffset(Offset="0x0")]
		public const int StatusFieldNumber = 2;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<EventStatus> _repeated_status_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<EventStatus> status_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BCA0", Offset="0x109BCA0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B99EB4", Offset="0x1B99EB4", VA="0x1B99EB4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BC90", Offset="0x109BC90")]
		public static MessageParser<EventUnlocked> Parser
		{
			[Address(RVA="0x1B99E4C", Offset="0x1B99E4C", VA="0x1B99E4C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BCB0", Offset="0x109BCB0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B99FA4", Offset="0x1B99FA4", VA="0x1B99FA4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BCC0", Offset="0x109BCC0")]
		public RepeatedField<EventProgress> Progress
		{
			[Address(RVA="0x1B9A1B8", Offset="0x1B9A1B8", VA="0x1B9A1B8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BCD0", Offset="0x109BCD0")]
		public RepeatedField<EventStatus> Status
		{
			[Address(RVA="0x1B9A1C0", Offset="0x1B9A1C0", VA="0x1B9A1C0")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B9A7FC", Offset="0x1B9A7FC", VA="0x1B9A7FC")]
		static EventUnlocked()
		{
		}

		[Address(RVA="0x1B9A000", Offset="0x1B9A000", VA="0x1B9A000")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087CEC", Offset="0x1087CEC")]
		public EventUnlocked()
		{
		}

		[Address(RVA="0x1B9A098", Offset="0x1B9A098", VA="0x1B9A098")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087CFC", Offset="0x1087CFC")]
		public EventUnlocked(EventUnlocked other)
		{
		}

		[Address(RVA="0x1B9A518", Offset="0x1B9A518", VA="0x1B9A518", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087D6C", Offset="0x1087D6C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B9A158", Offset="0x1B9A158", VA="0x1B9A158", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087D0C", Offset="0x1087D0C")]
		public EventUnlocked Clone()
		{
			return null;
		}

		[Address(RVA="0x1B9A1C8", Offset="0x1B9A1C8", VA="0x1B9A1C8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087D1C", Offset="0x1087D1C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9A23C", Offset="0x1B9A23C", VA="0x1B9A23C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087D2C", Offset="0x1087D2C")]
		public bool Equals(EventUnlocked other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9A31C", Offset="0x1B9A31C", VA="0x1B9A31C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087D3C", Offset="0x1087D3C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B9A60C", Offset="0x1B9A60C", VA="0x1B9A60C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087D7C", Offset="0x1087D7C")]
		public void MergeFrom(EventUnlocked other)
		{
		}

		[Address(RVA="0x1B9A6C8", Offset="0x1B9A6C8", VA="0x1B9A6C8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087D8C", Offset="0x1087D8C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B9A3A8", Offset="0x1B9A3A8", VA="0x1B9A3A8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087D4C", Offset="0x1087D4C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B9A410", Offset="0x1B9A410", VA="0x1B9A410", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087D5C", Offset="0x1087D5C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10509E8", Offset="0x10509E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EventUnlocked.<>c <>9;

			[Address(RVA="0x1B9A968", Offset="0x1B9A968", VA="0x1B9A968")]
			static <>c()
			{
			}

			[Address(RVA="0x1B9A9CC", Offset="0x1B9A9CC", VA="0x1B9A9CC")]
			public <>c()
			{
			}

			[Address(RVA="0x1B9A9D4", Offset="0x1B9A9D4", VA="0x1B9A9D4")]
			internal EventUnlocked <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}