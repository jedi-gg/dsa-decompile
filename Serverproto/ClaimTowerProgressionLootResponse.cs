using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimTowerProgressionLootResponse : IMessage<ClaimTowerProgressionLootResponse>, IMessage, IEquatable<ClaimTowerProgressionLootResponse>, IDeepCloneable<ClaimTowerProgressionLootResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimTowerProgressionLootResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D028", Offset="0x109D028")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A451FC", Offset="0x1A451FC", VA="0x1A451FC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D048", Offset="0x109D048")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1A453CC", Offset="0x1A453CC", VA="0x1A453CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A453D4", Offset="0x1A453D4", VA="0x1A453D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D018", Offset="0x109D018")]
		public static MessageParser<ClaimTowerProgressionLootResponse> Parser
		{
			[Address(RVA="0x1A45194", Offset="0x1A45194", VA="0x1A45194")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D038", Offset="0x109D038")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A452EC", Offset="0x1A452EC", VA="0x1A452EC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A45894", Offset="0x1A45894", VA="0x1A45894")]
		static ClaimTowerProgressionLootResponse()
		{
		}

		[Address(RVA="0x1A45348", Offset="0x1A45348", VA="0x1A45348")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089BDC", Offset="0x1089BDC")]
		public ClaimTowerProgressionLootResponse()
		{
		}

		[Address(RVA="0x1A45350", Offset="0x1A45350", VA="0x1A45350")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089BEC", Offset="0x1089BEC")]
		public ClaimTowerProgressionLootResponse(ClaimTowerProgressionLootResponse other)
		{
		}

		[Address(RVA="0x1A45674", Offset="0x1A45674", VA="0x1A45674", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089C5C", Offset="0x1089C5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A453DC", Offset="0x1A453DC", VA="0x1A453DC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089BFC", Offset="0x1089BFC")]
		public ClaimTowerProgressionLootResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A4543C", Offset="0x1A4543C", VA="0x1A4543C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089C0C", Offset="0x1089C0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A454B0", Offset="0x1A454B0", VA="0x1A454B0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089C1C", Offset="0x1089C1C")]
		public bool Equals(ClaimTowerProgressionLootResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A45514", Offset="0x1A45514", VA="0x1A45514", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089C2C", Offset="0x1089C2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A45704", Offset="0x1A45704", VA="0x1A45704", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089C6C", Offset="0x1089C6C")]
		public void MergeFrom(ClaimTowerProgressionLootResponse other)
		{
		}

		[Address(RVA="0x1A457B8", Offset="0x1A457B8", VA="0x1A457B8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089C7C", Offset="0x1089C7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A4556C", Offset="0x1A4556C", VA="0x1A4556C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089C3C", Offset="0x1089C3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A455D4", Offset="0x1A455D4", VA="0x1A455D4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1089C4C", Offset="0x1089C4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050CC8", Offset="0x1050CC8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimTowerProgressionLootResponse.<>c <>9;

			[Address(RVA="0x1A4596C", Offset="0x1A4596C", VA="0x1A4596C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A459D0", Offset="0x1A459D0", VA="0x1A459D0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A459D8", Offset="0x1A459D8", VA="0x1A459D8")]
			internal ClaimTowerProgressionLootResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}