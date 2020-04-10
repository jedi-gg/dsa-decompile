using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EventProgress : IMessage<EventProgress>, IMessage, IEquatable<EventProgress>, IDeepCloneable<EventProgress>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EventProgress> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private EventIdentifier id_;

		[FieldOffset(Offset="0x0")]
		public const int StarCountFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong starCount_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097238", Offset="0x1097238")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FCF3CC", Offset="0x1FCF3CC", VA="0x1FCF3CC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097258", Offset="0x1097258")]
		public EventIdentifier Id
		{
			[Address(RVA="0x1FCF59C", Offset="0x1FCF59C", VA="0x1FCF59C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FCF5A4", Offset="0x1FCF5A4", VA="0x1FCF5A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097228", Offset="0x1097228")]
		public static MessageParser<EventProgress> Parser
		{
			[Address(RVA="0x1FCF364", Offset="0x1FCF364", VA="0x1FCF364")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097248", Offset="0x1097248")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FCF4B8", Offset="0x1FCF4B8", VA="0x1FCF4B8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097268", Offset="0x1097268")]
		public ulong StarCount
		{
			[Address(RVA="0x1FCF60C", Offset="0x1FCF60C", VA="0x1FCF60C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FCF614", Offset="0x1FCF614", VA="0x1FCF614")]
			set
			{
			}
		}

		[Address(RVA="0x1FCFB78", Offset="0x1FCFB78", VA="0x1FCFB78")]
		static EventProgress()
		{
		}

		[Address(RVA="0x1FCF514", Offset="0x1FCF514", VA="0x1FCF514")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F7FC", Offset="0x107F7FC")]
		public EventProgress()
		{
		}

		[Address(RVA="0x1FCF51C", Offset="0x1FCF51C", VA="0x1FCF51C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F80C", Offset="0x107F80C")]
		public EventProgress(EventProgress other)
		{
		}

		[Address(RVA="0x1FCF8E4", Offset="0x1FCF8E4", VA="0x1FCF8E4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F87C", Offset="0x107F87C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FCF5AC", Offset="0x1FCF5AC", VA="0x1FCF5AC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F81C", Offset="0x107F81C")]
		public EventProgress Clone()
		{
			return null;
		}

		[Address(RVA="0x1FCF61C", Offset="0x1FCF61C", VA="0x1FCF61C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F82C", Offset="0x107F82C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCF690", Offset="0x1FCF690", VA="0x1FCF690", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F83C", Offset="0x107F83C")]
		public bool Equals(EventProgress other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCF704", Offset="0x1FCF704", VA="0x1FCF704", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F84C", Offset="0x107F84C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FCF9B8", Offset="0x1FCF9B8", VA="0x1FCF9B8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F88C", Offset="0x107F88C")]
		public void MergeFrom(EventProgress other)
		{
		}

		[Address(RVA="0x1FCFA74", Offset="0x1FCFA74", VA="0x1FCFA74", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F89C", Offset="0x107F89C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FCF784", Offset="0x1FCF784", VA="0x1FCF784", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F85C", Offset="0x107F85C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FCF7EC", Offset="0x1FCF7EC", VA="0x1FCF7EC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F86C", Offset="0x107F86C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FDD8", Offset="0x104FDD8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EventProgress.<>c <>9;

			[Address(RVA="0x1FCFC50", Offset="0x1FCFC50", VA="0x1FCFC50")]
			static <>c()
			{
			}

			[Address(RVA="0x1FCFCB4", Offset="0x1FCFCB4", VA="0x1FCFCB4")]
			public <>c()
			{
			}

			[Address(RVA="0x1FCFCBC", Offset="0x1FCFCBC", VA="0x1FCFCBC")]
			internal EventProgress <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}