using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothClearCooldownResponse : IMessage<KothClearCooldownResponse>, IMessage, IEquatable<KothClearCooldownResponse>, IDeepCloneable<KothClearCooldownResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothClearCooldownResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int CooldownEndTimeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong cooldownEndTime_;

		[FieldOffset(Offset="0x0")]
		public const int CooldownLapsedFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private bool cooldownLapsed_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B470", Offset="0x109B470")]
		public ulong CooldownEndTime
		{
			[Address(RVA="0x1A9E694", Offset="0x1A9E694", VA="0x1A9E694")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A9E69C", Offset="0x1A9E69C", VA="0x1A9E69C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B480", Offset="0x109B480")]
		public bool CooldownLapsed
		{
			[Address(RVA="0x1A9E6A4", Offset="0x1A9E6A4", VA="0x1A9E6A4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A9E6AC", Offset="0x1A9E6AC", VA="0x1A9E6AC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B440", Offset="0x109B440")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A9E444", Offset="0x1A9E444", VA="0x1A9E444")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B460", Offset="0x109B460")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1A9E624", Offset="0x1A9E624", VA="0x1A9E624")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9E62C", Offset="0x1A9E62C", VA="0x1A9E62C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B430", Offset="0x109B430")]
		public static MessageParser<KothClearCooldownResponse> Parser
		{
			[Address(RVA="0x1A9E3DC", Offset="0x1A9E3DC", VA="0x1A9E3DC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B450", Offset="0x109B450")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A9E534", Offset="0x1A9E534", VA="0x1A9E534", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A9ED10", Offset="0x1A9ED10", VA="0x1A9ED10")]
		static KothClearCooldownResponse()
		{
		}

		[Address(RVA="0x1A9E590", Offset="0x1A9E590", VA="0x1A9E590")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086BBC", Offset="0x1086BBC")]
		public KothClearCooldownResponse()
		{
		}

		[Address(RVA="0x1A9E598", Offset="0x1A9E598", VA="0x1A9E598")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086BCC", Offset="0x1086BCC")]
		public KothClearCooldownResponse(KothClearCooldownResponse other)
		{
		}

		[Address(RVA="0x1A9EA20", Offset="0x1A9EA20", VA="0x1A9EA20", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086C3C", Offset="0x1086C3C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A9E634", Offset="0x1A9E634", VA="0x1A9E634", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086BDC", Offset="0x1086BDC")]
		public KothClearCooldownResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A9E6B8", Offset="0x1A9E6B8", VA="0x1A9E6B8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086BEC", Offset="0x1086BEC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9E72C", Offset="0x1A9E72C", VA="0x1A9E72C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086BFC", Offset="0x1086BFC")]
		public bool Equals(KothClearCooldownResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9E7C0", Offset="0x1A9E7C0", VA="0x1A9E7C0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086C0C", Offset="0x1086C0C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A9EB0C", Offset="0x1A9EB0C", VA="0x1A9EB0C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086C4C", Offset="0x1086C4C")]
		public void MergeFrom(KothClearCooldownResponse other)
		{
		}

		[Address(RVA="0x1A9EBD8", Offset="0x1A9EBD8", VA="0x1A9EBD8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086C5C", Offset="0x1086C5C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A9E864", Offset="0x1A9E864", VA="0x1A9E864", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086C1C", Offset="0x1086C1C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A9E8CC", Offset="0x1A9E8CC", VA="0x1A9E8CC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086C2C", Offset="0x1086C2C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050858", Offset="0x1050858")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothClearCooldownResponse.<>c <>9;

			[Address(RVA="0x1A9EDE8", Offset="0x1A9EDE8", VA="0x1A9EDE8")]
			static <>c()
			{
			}

			[Address(RVA="0x1A9EE4C", Offset="0x1A9EE4C", VA="0x1A9EE4C")]
			public <>c()
			{
			}

			[Address(RVA="0x1A9EE54", Offset="0x1A9EE54", VA="0x1A9EE54")]
			internal KothClearCooldownResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}