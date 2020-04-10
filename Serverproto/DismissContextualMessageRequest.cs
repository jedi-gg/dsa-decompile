using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DismissContextualMessageRequest : IMessage<DismissContextualMessageRequest>, IMessage, IEquatable<DismissContextualMessageRequest>, IDeepCloneable<DismissContextualMessageRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DismissContextualMessageRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MessageGroupIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong messageGroupId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B050", Offset="0x109B050")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FBBB70", Offset="0x1FBBB70", VA="0x1FBBB70")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B070", Offset="0x109B070")]
		public ulong MessageGroupId
		{
			[Address(RVA="0x1FBBD88", Offset="0x1FBBD88", VA="0x1FBBD88")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FBBD90", Offset="0x1FBBD90", VA="0x1FBBD90")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B040", Offset="0x109B040")]
		public static MessageParser<DismissContextualMessageRequest> Parser
		{
			[Address(RVA="0x1FBBB08", Offset="0x1FBBB08", VA="0x1FBBB08")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B060", Offset="0x109B060")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FBBC60", Offset="0x1FBBC60", VA="0x1FBBC60", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FBC104", Offset="0x1FBC104", VA="0x1FBC104")]
		static DismissContextualMessageRequest()
		{
		}

		[Address(RVA="0x1FBBCBC", Offset="0x1FBBCBC", VA="0x1FBBCBC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10862CC", Offset="0x10862CC")]
		public DismissContextualMessageRequest()
		{
		}

		[Address(RVA="0x1FBBCC4", Offset="0x1FBBCC4", VA="0x1FBBCC4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10862DC", Offset="0x10862DC")]
		public DismissContextualMessageRequest(DismissContextualMessageRequest other)
		{
		}

		[Address(RVA="0x1FBBFB8", Offset="0x1FBBFB8", VA="0x1FBBFB8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108634C", Offset="0x108634C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FBBD28", Offset="0x1FBBD28", VA="0x1FBBD28", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10862EC", Offset="0x10862EC")]
		public DismissContextualMessageRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FBBD98", Offset="0x1FBBD98", VA="0x1FBBD98", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10862FC", Offset="0x10862FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBBE0C", Offset="0x1FBBE0C", VA="0x1FBBE0C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108630C", Offset="0x108630C")]
		public bool Equals(DismissContextualMessageRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBBE48", Offset="0x1FBBE48", VA="0x1FBBE48", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108631C", Offset="0x108631C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FBC048", Offset="0x1FBC048", VA="0x1FBC048", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108635C", Offset="0x108635C")]
		public void MergeFrom(DismissContextualMessageRequest other)
		{
		}

		[Address(RVA="0x1FBC088", Offset="0x1FBC088", VA="0x1FBC088", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108636C", Offset="0x108636C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FBBEB0", Offset="0x1FBBEB0", VA="0x1FBBEB0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108632C", Offset="0x108632C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FBBF18", Offset="0x1FBBF18", VA="0x1FBBF18", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108633C", Offset="0x108633C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050788", Offset="0x1050788")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DismissContextualMessageRequest.<>c <>9;

			[Address(RVA="0x1FBC1DC", Offset="0x1FBC1DC", VA="0x1FBC1DC")]
			static <>c()
			{
			}

			[Address(RVA="0x1FBC240", Offset="0x1FBC240", VA="0x1FBC240")]
			public <>c()
			{
			}

			[Address(RVA="0x1FBC248", Offset="0x1FBC248", VA="0x1FBC248")]
			internal DismissContextualMessageRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}