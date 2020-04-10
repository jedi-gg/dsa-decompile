using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class SelectClubDungeonDoorResponse : IMessage<SelectClubDungeonDoorResponse>, IMessage, IEquatable<SelectClubDungeonDoorResponse>, IDeepCloneable<SelectClubDungeonDoorResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<SelectClubDungeonDoorResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CorrectDoorFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private bool correctDoor_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095A90", Offset="0x1095A90")]
		public bool CorrectDoor
		{
			[Address(RVA="0x1BCF504", Offset="0x1BCF504", VA="0x1BCF504")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BCF50C", Offset="0x1BCF50C", VA="0x1BCF50C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095A70", Offset="0x1095A70")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BCF2EC", Offset="0x1BCF2EC", VA="0x1BCF2EC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095A60", Offset="0x1095A60")]
		public static MessageParser<SelectClubDungeonDoorResponse> Parser
		{
			[Address(RVA="0x1BCF284", Offset="0x1BCF284", VA="0x1BCF284")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095A80", Offset="0x1095A80")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BCF3DC", Offset="0x1BCF3DC", VA="0x1BCF3DC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BCF840", Offset="0x1BCF840", VA="0x1BCF840")]
		static SelectClubDungeonDoorResponse()
		{
		}

		[Address(RVA="0x1BCF438", Offset="0x1BCF438", VA="0x1BCF438")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D01C", Offset="0x107D01C")]
		public SelectClubDungeonDoorResponse()
		{
		}

		[Address(RVA="0x1BCF440", Offset="0x1BCF440", VA="0x1BCF440")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D02C", Offset="0x107D02C")]
		public SelectClubDungeonDoorResponse(SelectClubDungeonDoorResponse other)
		{
		}

		[Address(RVA="0x1BCF748", Offset="0x1BCF748", VA="0x1BCF748", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D09C", Offset="0x107D09C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BCF4A4", Offset="0x1BCF4A4", VA="0x1BCF4A4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D03C", Offset="0x107D03C")]
		public SelectClubDungeonDoorResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BCF518", Offset="0x1BCF518", VA="0x1BCF518", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D04C", Offset="0x107D04C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BCF58C", Offset="0x1BCF58C", VA="0x1BCF58C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D05C", Offset="0x107D05C")]
		public bool Equals(SelectClubDungeonDoorResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BCF5D8", Offset="0x1BCF5D8", VA="0x1BCF5D8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D06C", Offset="0x107D06C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BCF780", Offset="0x1BCF780", VA="0x1BCF780", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D0AC", Offset="0x107D0AC")]
		public void MergeFrom(SelectClubDungeonDoorResponse other)
		{
		}

		[Address(RVA="0x1BCF7C0", Offset="0x1BCF7C0", VA="0x1BCF7C0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D0BC", Offset="0x107D0BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BCF63C", Offset="0x1BCF63C", VA="0x1BCF63C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D07C", Offset="0x107D07C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BCF6A4", Offset="0x1BCF6A4", VA="0x1BCF6A4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D08C", Offset="0x107D08C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FA28", Offset="0x104FA28")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static SelectClubDungeonDoorResponse.<>c <>9;

			[Address(RVA="0x1BCF918", Offset="0x1BCF918", VA="0x1BCF918")]
			static <>c()
			{
			}

			[Address(RVA="0x1BCF97C", Offset="0x1BCF97C", VA="0x1BCF97C")]
			public <>c()
			{
			}

			[Address(RVA="0x1BCF984", Offset="0x1BCF984", VA="0x1BCF984")]
			internal SelectClubDungeonDoorResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}