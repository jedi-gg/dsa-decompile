using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class SelectClubDungeonDoorRequest : IMessage<SelectClubDungeonDoorRequest>, IMessage, IEquatable<SelectClubDungeonDoorRequest>, IDeepCloneable<SelectClubDungeonDoorRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<SelectClubDungeonDoorRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SelectedDoorFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong selectedDoor_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095A30", Offset="0x1095A30")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BCEB50", Offset="0x1BCEB50", VA="0x1BCEB50")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095A20", Offset="0x1095A20")]
		public static MessageParser<SelectClubDungeonDoorRequest> Parser
		{
			[Address(RVA="0x1BCEAE8", Offset="0x1BCEAE8", VA="0x1BCEAE8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095A40", Offset="0x1095A40")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BCEC40", Offset="0x1BCEC40", VA="0x1BCEC40", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095A50", Offset="0x1095A50")]
		public ulong SelectedDoor
		{
			[Address(RVA="0x1BCED68", Offset="0x1BCED68", VA="0x1BCED68")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BCED70", Offset="0x1BCED70", VA="0x1BCED70")]
			set
			{
			}
		}

		[Address(RVA="0x1BCF0E4", Offset="0x1BCF0E4", VA="0x1BCF0E4")]
		static SelectClubDungeonDoorRequest()
		{
		}

		[Address(RVA="0x1BCEC9C", Offset="0x1BCEC9C", VA="0x1BCEC9C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CF6C", Offset="0x107CF6C")]
		public SelectClubDungeonDoorRequest()
		{
		}

		[Address(RVA="0x1BCECA4", Offset="0x1BCECA4", VA="0x1BCECA4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CF7C", Offset="0x107CF7C")]
		public SelectClubDungeonDoorRequest(SelectClubDungeonDoorRequest other)
		{
		}

		[Address(RVA="0x1BCEF98", Offset="0x1BCEF98", VA="0x1BCEF98", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CFEC", Offset="0x107CFEC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BCED08", Offset="0x1BCED08", VA="0x1BCED08", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CF8C", Offset="0x107CF8C")]
		public SelectClubDungeonDoorRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BCED78", Offset="0x1BCED78", VA="0x1BCED78", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CF9C", Offset="0x107CF9C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BCEDEC", Offset="0x1BCEDEC", VA="0x1BCEDEC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CFAC", Offset="0x107CFAC")]
		public bool Equals(SelectClubDungeonDoorRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BCEE28", Offset="0x1BCEE28", VA="0x1BCEE28", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CFBC", Offset="0x107CFBC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BCF028", Offset="0x1BCF028", VA="0x1BCF028", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CFFC", Offset="0x107CFFC")]
		public void MergeFrom(SelectClubDungeonDoorRequest other)
		{
		}

		[Address(RVA="0x1BCF068", Offset="0x1BCF068", VA="0x1BCF068", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D00C", Offset="0x107D00C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BCEE90", Offset="0x1BCEE90", VA="0x1BCEE90", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CFCC", Offset="0x107CFCC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BCEEF8", Offset="0x1BCEEF8", VA="0x1BCEEF8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107CFDC", Offset="0x107CFDC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FA18", Offset="0x104FA18")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static SelectClubDungeonDoorRequest.<>c <>9;

			[Address(RVA="0x1BCF1BC", Offset="0x1BCF1BC", VA="0x1BCF1BC")]
			static <>c()
			{
			}

			[Address(RVA="0x1BCF220", Offset="0x1BCF220", VA="0x1BCF220")]
			public <>c()
			{
			}

			[Address(RVA="0x1BCF228", Offset="0x1BCF228", VA="0x1BCF228")]
			internal SelectClubDungeonDoorRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}