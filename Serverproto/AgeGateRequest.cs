using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class AgeGateRequest : IMessage<AgeGateRequest>, IMessage, IEquatable<AgeGateRequest>, IDeepCloneable<AgeGateRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<AgeGateRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int AgeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong age_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AFC0", Offset="0x109AFC0")]
		public ulong Age
		{
			[Address(RVA="0x16070EC", Offset="0x16070EC", VA="0x16070EC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x16070F4", Offset="0x16070F4", VA="0x16070F4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AFA0", Offset="0x109AFA0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1606ED4", Offset="0x1606ED4", VA="0x1606ED4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AF90", Offset="0x109AF90")]
		public static MessageParser<AgeGateRequest> Parser
		{
			[Address(RVA="0x1606E6C", Offset="0x1606E6C", VA="0x1606E6C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AFB0", Offset="0x109AFB0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1606FC4", Offset="0x1606FC4", VA="0x1606FC4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1607468", Offset="0x1607468", VA="0x1607468")]
		static AgeGateRequest()
		{
		}

		[Address(RVA="0x1607020", Offset="0x1607020", VA="0x1607020")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10860BC", Offset="0x10860BC")]
		public AgeGateRequest()
		{
		}

		[Address(RVA="0x1607028", Offset="0x1607028", VA="0x1607028")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10860CC", Offset="0x10860CC")]
		public AgeGateRequest(AgeGateRequest other)
		{
		}

		[Address(RVA="0x160731C", Offset="0x160731C", VA="0x160731C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108613C", Offset="0x108613C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x160708C", Offset="0x160708C", VA="0x160708C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10860DC", Offset="0x10860DC")]
		public AgeGateRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x16070FC", Offset="0x16070FC", VA="0x16070FC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10860EC", Offset="0x10860EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1607170", Offset="0x1607170", VA="0x1607170", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10860FC", Offset="0x10860FC")]
		public bool Equals(AgeGateRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x16071AC", Offset="0x16071AC", VA="0x16071AC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108610C", Offset="0x108610C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x16073AC", Offset="0x16073AC", VA="0x16073AC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108614C", Offset="0x108614C")]
		public void MergeFrom(AgeGateRequest other)
		{
		}

		[Address(RVA="0x16073EC", Offset="0x16073EC", VA="0x16073EC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108615C", Offset="0x108615C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1607214", Offset="0x1607214", VA="0x1607214", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108611C", Offset="0x108611C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x160727C", Offset="0x160727C", VA="0x160727C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108612C", Offset="0x108612C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050758", Offset="0x1050758")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static AgeGateRequest.<>c <>9;

			[Address(RVA="0x1607540", Offset="0x1607540", VA="0x1607540")]
			static <>c()
			{
			}

			[Address(RVA="0x16075A4", Offset="0x16075A4", VA="0x16075A4")]
			public <>c()
			{
			}

			[Address(RVA="0x16075AC", Offset="0x16075AC", VA="0x16075AC")]
			internal AgeGateRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}