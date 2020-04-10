using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EquipUnitSkinRequest : IMessage<EquipUnitSkinRequest>, IMessage, IEquatable<EquipUnitSkinRequest>, IDeepCloneable<EquipUnitSkinRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EquipUnitSkinRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[FieldOffset(Offset="0x0")]
		public const int UnitSkinItemIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong unitSkinItemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10990A0", Offset="0x10990A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FC631C", Offset="0x1FC631C", VA="0x1FC631C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099090", Offset="0x1099090")]
		public static MessageParser<EquipUnitSkinRequest> Parser
		{
			[Address(RVA="0x1FC62B4", Offset="0x1FC62B4", VA="0x1FC62B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10990B0", Offset="0x10990B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC640C", Offset="0x1FC640C", VA="0x1FC640C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10990C0", Offset="0x10990C0")]
		public ulong UnitId
		{
			[Address(RVA="0x1FC6550", Offset="0x1FC6550", VA="0x1FC6550")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC6558", Offset="0x1FC6558", VA="0x1FC6558")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10990D0", Offset="0x10990D0")]
		public ulong UnitSkinItemId
		{
			[Address(RVA="0x1FC6560", Offset="0x1FC6560", VA="0x1FC6560")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC6568", Offset="0x1FC6568", VA="0x1FC6568")]
			set
			{
			}
		}

		[Address(RVA="0x1FC69D8", Offset="0x1FC69D8", VA="0x1FC69D8")]
		static EquipUnitSkinRequest()
		{
		}

		[Address(RVA="0x1FC6468", Offset="0x1FC6468", VA="0x1FC6468")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108281C", Offset="0x108281C")]
		public EquipUnitSkinRequest()
		{
		}

		[Address(RVA="0x1FC6470", Offset="0x1FC6470", VA="0x1FC6470")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108282C", Offset="0x108282C")]
		public EquipUnitSkinRequest(EquipUnitSkinRequest other)
		{
		}

		[Address(RVA="0x1FC6814", Offset="0x1FC6814", VA="0x1FC6814", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108289C", Offset="0x108289C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC64F0", Offset="0x1FC64F0", VA="0x1FC64F0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108283C", Offset="0x108283C")]
		public EquipUnitSkinRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC6570", Offset="0x1FC6570", VA="0x1FC6570", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108284C", Offset="0x108284C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC65E4", Offset="0x1FC65E4", VA="0x1FC65E4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108285C", Offset="0x108285C")]
		public bool Equals(EquipUnitSkinRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC6630", Offset="0x1FC6630", VA="0x1FC6630", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108286C", Offset="0x108286C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC68E8", Offset="0x1FC68E8", VA="0x1FC68E8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10828AC", Offset="0x10828AC")]
		public void MergeFrom(EquipUnitSkinRequest other)
		{
		}

		[Address(RVA="0x1FC6934", Offset="0x1FC6934", VA="0x1FC6934", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10828BC", Offset="0x10828BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC66B4", Offset="0x1FC66B4", VA="0x1FC66B4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108287C", Offset="0x108287C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC671C", Offset="0x1FC671C", VA="0x1FC671C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108288C", Offset="0x108288C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050238", Offset="0x1050238")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EquipUnitSkinRequest.<>c <>9;

			[Address(RVA="0x1FC6AB0", Offset="0x1FC6AB0", VA="0x1FC6AB0")]
			static <>c()
			{
			}

			[Address(RVA="0x1FC6B14", Offset="0x1FC6B14", VA="0x1FC6B14")]
			public <>c()
			{
			}

			[Address(RVA="0x1FC6B1C", Offset="0x1FC6B1C", VA="0x1FC6B1C")]
			internal EquipUnitSkinRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}