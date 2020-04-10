using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EquipGearResponse : IMessage<EquipGearResponse>, IMessage, IEquatable<EquipGearResponse>, IDeepCloneable<EquipGearResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EquipGearResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098B50", Offset="0x1098B50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FC4918", Offset="0x1FC4918", VA="0x1FC4918")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098B70", Offset="0x1098B70")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1FC4AE8", Offset="0x1FC4AE8", VA="0x1FC4AE8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FC4AF0", Offset="0x1FC4AF0", VA="0x1FC4AF0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098B40", Offset="0x1098B40")]
		public static MessageParser<EquipGearResponse> Parser
		{
			[Address(RVA="0x1FC48B0", Offset="0x1FC48B0", VA="0x1FC48B0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098B60", Offset="0x1098B60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC4A08", Offset="0x1FC4A08", VA="0x1FC4A08", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FC4FB0", Offset="0x1FC4FB0", VA="0x1FC4FB0")]
		static EquipGearResponse()
		{
		}

		[Address(RVA="0x1FC4A64", Offset="0x1FC4A64", VA="0x1FC4A64")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081F2C", Offset="0x1081F2C")]
		public EquipGearResponse()
		{
		}

		[Address(RVA="0x1FC4A6C", Offset="0x1FC4A6C", VA="0x1FC4A6C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081F3C", Offset="0x1081F3C")]
		public EquipGearResponse(EquipGearResponse other)
		{
		}

		[Address(RVA="0x1FC4D90", Offset="0x1FC4D90", VA="0x1FC4D90", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081FAC", Offset="0x1081FAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC4AF8", Offset="0x1FC4AF8", VA="0x1FC4AF8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081F4C", Offset="0x1081F4C")]
		public EquipGearResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC4B58", Offset="0x1FC4B58", VA="0x1FC4B58", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081F5C", Offset="0x1081F5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC4BCC", Offset="0x1FC4BCC", VA="0x1FC4BCC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081F6C", Offset="0x1081F6C")]
		public bool Equals(EquipGearResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC4C30", Offset="0x1FC4C30", VA="0x1FC4C30", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081F7C", Offset="0x1081F7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC4E20", Offset="0x1FC4E20", VA="0x1FC4E20", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081FBC", Offset="0x1081FBC")]
		public void MergeFrom(EquipGearResponse other)
		{
		}

		[Address(RVA="0x1FC4ED4", Offset="0x1FC4ED4", VA="0x1FC4ED4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081FCC", Offset="0x1081FCC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC4C88", Offset="0x1FC4C88", VA="0x1FC4C88", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081F8C", Offset="0x1081F8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC4CF0", Offset="0x1FC4CF0", VA="0x1FC4CF0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081F9C", Offset="0x1081F9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050168", Offset="0x1050168")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EquipGearResponse.<>c <>9;

			[Address(RVA="0x1FC5088", Offset="0x1FC5088", VA="0x1FC5088")]
			static <>c()
			{
			}

			[Address(RVA="0x1FC50EC", Offset="0x1FC50EC", VA="0x1FC50EC")]
			public <>c()
			{
			}

			[Address(RVA="0x1FC50F4", Offset="0x1FC50F4", VA="0x1FC50F4")]
			internal EquipGearResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}