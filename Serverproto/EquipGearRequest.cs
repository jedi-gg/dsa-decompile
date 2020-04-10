using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EquipGearRequest : IMessage<EquipGearRequest>, IMessage, IEquatable<EquipGearRequest>, IDeepCloneable<EquipGearRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EquipGearRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[FieldOffset(Offset="0x0")]
		public const int SlotFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong slot_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098B00", Offset="0x1098B00")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FC4054", Offset="0x1FC4054", VA="0x1FC4054")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098AF0", Offset="0x1098AF0")]
		public static MessageParser<EquipGearRequest> Parser
		{
			[Address(RVA="0x1FC3FEC", Offset="0x1FC3FEC", VA="0x1FC3FEC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098B10", Offset="0x1098B10")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC4144", Offset="0x1FC4144", VA="0x1FC4144", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098B30", Offset="0x1098B30")]
		public ulong Slot
		{
			[Address(RVA="0x1FC4298", Offset="0x1FC4298", VA="0x1FC4298")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC42A0", Offset="0x1FC42A0", VA="0x1FC42A0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098B20", Offset="0x1098B20")]
		public ulong UnitId
		{
			[Address(RVA="0x1FC4288", Offset="0x1FC4288", VA="0x1FC4288")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC4290", Offset="0x1FC4290", VA="0x1FC4290")]
			set
			{
			}
		}

		[Address(RVA="0x1FC4710", Offset="0x1FC4710", VA="0x1FC4710")]
		static EquipGearRequest()
		{
		}

		[Address(RVA="0x1FC41A0", Offset="0x1FC41A0", VA="0x1FC41A0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081E7C", Offset="0x1081E7C")]
		public EquipGearRequest()
		{
		}

		[Address(RVA="0x1FC41A8", Offset="0x1FC41A8", VA="0x1FC41A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081E8C", Offset="0x1081E8C")]
		public EquipGearRequest(EquipGearRequest other)
		{
		}

		[Address(RVA="0x1FC454C", Offset="0x1FC454C", VA="0x1FC454C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081EFC", Offset="0x1081EFC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC4228", Offset="0x1FC4228", VA="0x1FC4228", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081E9C", Offset="0x1081E9C")]
		public EquipGearRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC42A8", Offset="0x1FC42A8", VA="0x1FC42A8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081EAC", Offset="0x1081EAC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC431C", Offset="0x1FC431C", VA="0x1FC431C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081EBC", Offset="0x1081EBC")]
		public bool Equals(EquipGearRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC4368", Offset="0x1FC4368", VA="0x1FC4368", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081ECC", Offset="0x1081ECC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC4620", Offset="0x1FC4620", VA="0x1FC4620", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081F0C", Offset="0x1081F0C")]
		public void MergeFrom(EquipGearRequest other)
		{
		}

		[Address(RVA="0x1FC466C", Offset="0x1FC466C", VA="0x1FC466C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081F1C", Offset="0x1081F1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC43EC", Offset="0x1FC43EC", VA="0x1FC43EC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081EDC", Offset="0x1081EDC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC4454", Offset="0x1FC4454", VA="0x1FC4454", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081EEC", Offset="0x1081EEC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050158", Offset="0x1050158")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EquipGearRequest.<>c <>9;

			[Address(RVA="0x1FC47E8", Offset="0x1FC47E8", VA="0x1FC47E8")]
			static <>c()
			{
			}

			[Address(RVA="0x1FC484C", Offset="0x1FC484C", VA="0x1FC484C")]
			public <>c()
			{
			}

			[Address(RVA="0x1FC4854", Offset="0x1FC4854", VA="0x1FC4854")]
			internal EquipGearRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}