using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class SetPlayerSquadSelectionResponse : IMessage<SetPlayerSquadSelectionResponse>, IMessage, IEquatable<SetPlayerSquadSelectionResponse>, IDeepCloneable<SetPlayerSquadSelectionResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<SetPlayerSquadSelectionResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A360", Offset="0x109A360")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD10BC", Offset="0x1BD10BC", VA="0x1BD10BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A350", Offset="0x109A350")]
		public static MessageParser<SetPlayerSquadSelectionResponse> Parser
		{
			[Address(RVA="0x1BD1054", Offset="0x1BD1054", VA="0x1BD1054")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A370", Offset="0x109A370")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD11AC", Offset="0x1BD11AC", VA="0x1BD11AC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BD14C0", Offset="0x1BD14C0", VA="0x1BD14C0")]
		static SetPlayerSquadSelectionResponse()
		{
		}

		[Address(RVA="0x1BD1208", Offset="0x1BD1208", VA="0x1BD1208")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10841CC", Offset="0x10841CC")]
		public SetPlayerSquadSelectionResponse()
		{
		}

		[Address(RVA="0x1BD1210", Offset="0x1BD1210", VA="0x1BD1210")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10841DC", Offset="0x10841DC")]
		public SetPlayerSquadSelectionResponse(SetPlayerSquadSelectionResponse other)
		{
		}

		[Address(RVA="0x1BD1424", Offset="0x1BD1424", VA="0x1BD1424", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108424C", Offset="0x108424C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD1254", Offset="0x1BD1254", VA="0x1BD1254", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10841EC", Offset="0x10841EC")]
		public SetPlayerSquadSelectionResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD12B4", Offset="0x1BD12B4", VA="0x1BD12B4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10841FC", Offset="0x10841FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD134C", Offset="0x1BD134C", VA="0x1BD134C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108420C", Offset="0x108420C")]
		public bool Equals(SetPlayerSquadSelectionResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD1378", Offset="0x1BD1378", VA="0x1BD1378", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108421C", Offset="0x108421C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD1438", Offset="0x1BD1438", VA="0x1BD1438", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108425C", Offset="0x108425C")]
		public void MergeFrom(SetPlayerSquadSelectionResponse other)
		{
		}

		[Address(RVA="0x1BD146C", Offset="0x1BD146C", VA="0x1BD146C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108426C", Offset="0x108426C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD13A8", Offset="0x1BD13A8", VA="0x1BD13A8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108422C", Offset="0x108422C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD1410", Offset="0x1BD1410", VA="0x1BD1410", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108423C", Offset="0x108423C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050488", Offset="0x1050488")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static SetPlayerSquadSelectionResponse.<>c <>9;

			[Address(RVA="0x1BD1598", Offset="0x1BD1598", VA="0x1BD1598")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD15FC", Offset="0x1BD15FC", VA="0x1BD15FC")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD1604", Offset="0x1BD1604", VA="0x1BD1604")]
			internal SetPlayerSquadSelectionResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}