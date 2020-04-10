using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EquipSorcererStoneResponse : IMessage<EquipSorcererStoneResponse>, IMessage, IEquatable<EquipSorcererStoneResponse>, IDeepCloneable<EquipSorcererStoneResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EquipSorcererStoneResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10991F0", Offset="0x10991F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FC5A7C", Offset="0x1FC5A7C", VA="0x1FC5A7C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099210", Offset="0x1099210")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1FC5C4C", Offset="0x1FC5C4C", VA="0x1FC5C4C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC5C54", Offset="0x1FC5C54", VA="0x1FC5C54")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10991E0", Offset="0x10991E0")]
		public static MessageParser<EquipSorcererStoneResponse> Parser
		{
			[Address(RVA="0x1FC5A14", Offset="0x1FC5A14", VA="0x1FC5A14")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099200", Offset="0x1099200")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC5B6C", Offset="0x1FC5B6C", VA="0x1FC5B6C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FC6114", Offset="0x1FC6114", VA="0x1FC6114")]
		static EquipSorcererStoneResponse()
		{
		}

		[Address(RVA="0x1FC5BC8", Offset="0x1FC5BC8", VA="0x1FC5BC8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082B8C", Offset="0x1082B8C")]
		public EquipSorcererStoneResponse()
		{
		}

		[Address(RVA="0x1FC5BD0", Offset="0x1FC5BD0", VA="0x1FC5BD0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082B9C", Offset="0x1082B9C")]
		public EquipSorcererStoneResponse(EquipSorcererStoneResponse other)
		{
		}

		[Address(RVA="0x1FC5EF4", Offset="0x1FC5EF4", VA="0x1FC5EF4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082C0C", Offset="0x1082C0C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC5C5C", Offset="0x1FC5C5C", VA="0x1FC5C5C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082BAC", Offset="0x1082BAC")]
		public EquipSorcererStoneResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC5CBC", Offset="0x1FC5CBC", VA="0x1FC5CBC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082BBC", Offset="0x1082BBC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC5D30", Offset="0x1FC5D30", VA="0x1FC5D30", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082BCC", Offset="0x1082BCC")]
		public bool Equals(EquipSorcererStoneResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC5D94", Offset="0x1FC5D94", VA="0x1FC5D94", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082BDC", Offset="0x1082BDC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC5F84", Offset="0x1FC5F84", VA="0x1FC5F84", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082C1C", Offset="0x1082C1C")]
		public void MergeFrom(EquipSorcererStoneResponse other)
		{
		}

		[Address(RVA="0x1FC6038", Offset="0x1FC6038", VA="0x1FC6038", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082C2C", Offset="0x1082C2C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC5DEC", Offset="0x1FC5DEC", VA="0x1FC5DEC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082BEC", Offset="0x1082BEC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC5E54", Offset="0x1FC5E54", VA="0x1FC5E54", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1082BFC", Offset="0x1082BFC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050288", Offset="0x1050288")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EquipSorcererStoneResponse.<>c <>9;

			[Address(RVA="0x1FC61EC", Offset="0x1FC61EC", VA="0x1FC61EC")]
			static <>c()
			{
			}

			[Address(RVA="0x1FC6250", Offset="0x1FC6250", VA="0x1FC6250")]
			public <>c()
			{
			}

			[Address(RVA="0x1FC6258", Offset="0x1FC6258", VA="0x1FC6258")]
			internal EquipSorcererStoneResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}