using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EquipAllGearRequest : IMessage<EquipAllGearRequest>, IMessage, IEquatable<EquipAllGearRequest>, IDeepCloneable<EquipAllGearRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EquipAllGearRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong unitId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098B90", Offset="0x1098B90")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FC1C98", Offset="0x1FC1C98", VA="0x1FC1C98")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098B80", Offset="0x1098B80")]
		public static MessageParser<EquipAllGearRequest> Parser
		{
			[Address(RVA="0x1FC1C30", Offset="0x1FC1C30", VA="0x1FC1C30")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098BA0", Offset="0x1098BA0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC1D88", Offset="0x1FC1D88", VA="0x1FC1D88", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098BB0", Offset="0x1098BB0")]
		public ulong UnitId
		{
			[Address(RVA="0x1FC1EB0", Offset="0x1FC1EB0", VA="0x1FC1EB0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FC1EB8", Offset="0x1FC1EB8", VA="0x1FC1EB8")]
			set
			{
			}
		}

		[Address(RVA="0x1FC222C", Offset="0x1FC222C", VA="0x1FC222C")]
		static EquipAllGearRequest()
		{
		}

		[Address(RVA="0x1FC1DE4", Offset="0x1FC1DE4", VA="0x1FC1DE4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081FDC", Offset="0x1081FDC")]
		public EquipAllGearRequest()
		{
		}

		[Address(RVA="0x1FC1DEC", Offset="0x1FC1DEC", VA="0x1FC1DEC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081FEC", Offset="0x1081FEC")]
		public EquipAllGearRequest(EquipAllGearRequest other)
		{
		}

		[Address(RVA="0x1FC20E0", Offset="0x1FC20E0", VA="0x1FC20E0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108205C", Offset="0x108205C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC1E50", Offset="0x1FC1E50", VA="0x1FC1E50", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1081FFC", Offset="0x1081FFC")]
		public EquipAllGearRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC1EC0", Offset="0x1FC1EC0", VA="0x1FC1EC0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108200C", Offset="0x108200C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC1F34", Offset="0x1FC1F34", VA="0x1FC1F34", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108201C", Offset="0x108201C")]
		public bool Equals(EquipAllGearRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC1F70", Offset="0x1FC1F70", VA="0x1FC1F70", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108202C", Offset="0x108202C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC2170", Offset="0x1FC2170", VA="0x1FC2170", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108206C", Offset="0x108206C")]
		public void MergeFrom(EquipAllGearRequest other)
		{
		}

		[Address(RVA="0x1FC21B0", Offset="0x1FC21B0", VA="0x1FC21B0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108207C", Offset="0x108207C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC1FD8", Offset="0x1FC1FD8", VA="0x1FC1FD8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108203C", Offset="0x108203C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC2040", Offset="0x1FC2040", VA="0x1FC2040", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108204C", Offset="0x108204C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050178", Offset="0x1050178")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EquipAllGearRequest.<>c <>9;

			[Address(RVA="0x1FC2304", Offset="0x1FC2304", VA="0x1FC2304")]
			static <>c()
			{
			}

			[Address(RVA="0x1FC2368", Offset="0x1FC2368", VA="0x1FC2368")]
			public <>c()
			{
			}

			[Address(RVA="0x1FC2370", Offset="0x1FC2370", VA="0x1FC2370")]
			internal EquipAllGearRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}