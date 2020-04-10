using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EquipUnitSkinResponse : IMessage<EquipUnitSkinResponse>, IMessage, IEquatable<EquipUnitSkinResponse>, IDeepCloneable<EquipUnitSkinResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EquipUnitSkinResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10990F0", Offset="0x10990F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FC6BE0", Offset="0x1FC6BE0", VA="0x1FC6BE0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10990E0", Offset="0x10990E0")]
		public static MessageParser<EquipUnitSkinResponse> Parser
		{
			[Address(RVA="0x1FC6B78", Offset="0x1FC6B78", VA="0x1FC6B78")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099100", Offset="0x1099100")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FC6CD0", Offset="0x1FC6CD0", VA="0x1FC6CD0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FC6FE4", Offset="0x1FC6FE4", VA="0x1FC6FE4")]
		static EquipUnitSkinResponse()
		{
		}

		[Address(RVA="0x1FC6D2C", Offset="0x1FC6D2C", VA="0x1FC6D2C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10828CC", Offset="0x10828CC")]
		public EquipUnitSkinResponse()
		{
		}

		[Address(RVA="0x1FC6D34", Offset="0x1FC6D34", VA="0x1FC6D34")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10828DC", Offset="0x10828DC")]
		public EquipUnitSkinResponse(EquipUnitSkinResponse other)
		{
		}

		[Address(RVA="0x1FC6F48", Offset="0x1FC6F48", VA="0x1FC6F48", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108294C", Offset="0x108294C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FC6D78", Offset="0x1FC6D78", VA="0x1FC6D78", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10828EC", Offset="0x10828EC")]
		public EquipUnitSkinResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FC6DD8", Offset="0x1FC6DD8", VA="0x1FC6DD8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10828FC", Offset="0x10828FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC6E70", Offset="0x1FC6E70", VA="0x1FC6E70", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108290C", Offset="0x108290C")]
		public bool Equals(EquipUnitSkinResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FC6E9C", Offset="0x1FC6E9C", VA="0x1FC6E9C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108291C", Offset="0x108291C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FC6F5C", Offset="0x1FC6F5C", VA="0x1FC6F5C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108295C", Offset="0x108295C")]
		public void MergeFrom(EquipUnitSkinResponse other)
		{
		}

		[Address(RVA="0x1FC6F90", Offset="0x1FC6F90", VA="0x1FC6F90", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108296C", Offset="0x108296C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FC6ECC", Offset="0x1FC6ECC", VA="0x1FC6ECC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108292C", Offset="0x108292C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FC6F34", Offset="0x1FC6F34", VA="0x1FC6F34", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108293C", Offset="0x108293C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050248", Offset="0x1050248")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EquipUnitSkinResponse.<>c <>9;

			[Address(RVA="0x1FC70BC", Offset="0x1FC70BC", VA="0x1FC70BC")]
			static <>c()
			{
			}

			[Address(RVA="0x1FC7120", Offset="0x1FC7120", VA="0x1FC7120")]
			public <>c()
			{
			}

			[Address(RVA="0x1FC7128", Offset="0x1FC7128", VA="0x1FC7128")]
			internal EquipUnitSkinResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}