using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RefreshEventBattleLimitResponse : IMessage<RefreshEventBattleLimitResponse>, IMessage, IEquatable<RefreshEventBattleLimitResponse>, IDeepCloneable<RefreshEventBattleLimitResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RefreshEventBattleLimitResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int StatusFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private EventStatus status_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097588", Offset="0x1097588")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x201E9E4", Offset="0x201E9E4", VA="0x201E9E4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10975A8", Offset="0x10975A8")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x201EBC8", Offset="0x201EBC8", VA="0x201EBC8")]
			get
			{
				return null;
			}
			[Address(RVA="0x201EBD0", Offset="0x201EBD0", VA="0x201EBD0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097578", Offset="0x1097578")]
		public static MessageParser<RefreshEventBattleLimitResponse> Parser
		{
			[Address(RVA="0x201E97C", Offset="0x201E97C", VA="0x201E97C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097598", Offset="0x1097598")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x201EAD4", Offset="0x201EAD4", VA="0x201EAD4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10975B8", Offset="0x10975B8")]
		public EventStatus Status
		{
			[Address(RVA="0x201EBD8", Offset="0x201EBD8", VA="0x201EBD8")]
			get
			{
				return null;
			}
			[Address(RVA="0x201EBE0", Offset="0x201EBE0", VA="0x201EBE0")]
			set
			{
			}
		}

		[Address(RVA="0x201F1F0", Offset="0x201F1F0", VA="0x201F1F0")]
		static RefreshEventBattleLimitResponse()
		{
		}

		[Address(RVA="0x201EB30", Offset="0x201EB30", VA="0x201EB30")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FE2C", Offset="0x107FE2C")]
		public RefreshEventBattleLimitResponse()
		{
		}

		[Address(RVA="0x201EB38", Offset="0x201EB38", VA="0x201EB38")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FE3C", Offset="0x107FE3C")]
		public RefreshEventBattleLimitResponse(RefreshEventBattleLimitResponse other)
		{
		}

		[Address(RVA="0x201EF04", Offset="0x201EF04", VA="0x201EF04", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FEAC", Offset="0x107FEAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x201EBE8", Offset="0x201EBE8", VA="0x201EBE8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FE4C", Offset="0x107FE4C")]
		public RefreshEventBattleLimitResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x201EC48", Offset="0x201EC48", VA="0x201EC48", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FE5C", Offset="0x107FE5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x201ECBC", Offset="0x201ECBC", VA="0x201ECBC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FE6C", Offset="0x107FE6C")]
		public bool Equals(RefreshEventBattleLimitResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x201ED34", Offset="0x201ED34", VA="0x201ED34", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FE7C", Offset="0x107FE7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x201EFD8", Offset="0x201EFD8", VA="0x201EFD8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FEBC", Offset="0x107FEBC")]
		public void MergeFrom(RefreshEventBattleLimitResponse other)
		{
		}

		[Address(RVA="0x201F0DC", Offset="0x201F0DC", VA="0x201F0DC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FECC", Offset="0x107FECC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x201EDA4", Offset="0x201EDA4", VA="0x201EDA4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FE8C", Offset="0x107FE8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x201EE0C", Offset="0x201EE0C", VA="0x201EE0C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FE9C", Offset="0x107FE9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FE68", Offset="0x104FE68")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RefreshEventBattleLimitResponse.<>c <>9;

			[Address(RVA="0x201F2C8", Offset="0x201F2C8", VA="0x201F2C8")]
			static <>c()
			{
			}

			[Address(RVA="0x201F32C", Offset="0x201F32C", VA="0x201F32C")]
			public <>c()
			{
			}

			[Address(RVA="0x201F334", Offset="0x201F334", VA="0x201F334")]
			internal RefreshEventBattleLimitResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}