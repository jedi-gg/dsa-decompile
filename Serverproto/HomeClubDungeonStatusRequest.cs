using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeClubDungeonStatusRequest : IMessage<HomeClubDungeonStatusRequest>, IMessage, IEquatable<HomeClubDungeonStatusRequest>, IDeepCloneable<HomeClubDungeonStatusRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeClubDungeonStatusRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097B00", Offset="0x1097B00")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1CFF4A4", Offset="0x1CFF4A4", VA="0x1CFF4A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097AF0", Offset="0x1097AF0")]
		public static MessageParser<HomeClubDungeonStatusRequest> Parser
		{
			[Address(RVA="0x1CFF43C", Offset="0x1CFF43C", VA="0x1CFF43C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097B10", Offset="0x1097B10")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1CFF590", Offset="0x1CFF590", VA="0x1CFF590", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1CFF8A4", Offset="0x1CFF8A4", VA="0x1CFF8A4")]
		static HomeClubDungeonStatusRequest()
		{
		}

		[Address(RVA="0x1CFF5EC", Offset="0x1CFF5EC", VA="0x1CFF5EC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108050C", Offset="0x108050C")]
		public HomeClubDungeonStatusRequest()
		{
		}

		[Address(RVA="0x1CFF5F4", Offset="0x1CFF5F4", VA="0x1CFF5F4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108051C", Offset="0x108051C")]
		public HomeClubDungeonStatusRequest(HomeClubDungeonStatusRequest other)
		{
		}

		[Address(RVA="0x1CFF808", Offset="0x1CFF808", VA="0x1CFF808", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108058C", Offset="0x108058C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1CFF638", Offset="0x1CFF638", VA="0x1CFF638", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108052C", Offset="0x108052C")]
		public HomeClubDungeonStatusRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1CFF698", Offset="0x1CFF698", VA="0x1CFF698", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108053C", Offset="0x108053C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1CFF730", Offset="0x1CFF730", VA="0x1CFF730", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108054C", Offset="0x108054C")]
		public bool Equals(HomeClubDungeonStatusRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1CFF75C", Offset="0x1CFF75C", VA="0x1CFF75C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108055C", Offset="0x108055C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1CFF81C", Offset="0x1CFF81C", VA="0x1CFF81C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108059C", Offset="0x108059C")]
		public void MergeFrom(HomeClubDungeonStatusRequest other)
		{
		}

		[Address(RVA="0x1CFF850", Offset="0x1CFF850", VA="0x1CFF850", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10805AC", Offset="0x10805AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1CFF78C", Offset="0x1CFF78C", VA="0x1CFF78C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108056C", Offset="0x108056C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1CFF7F4", Offset="0x1CFF7F4", VA="0x1CFF7F4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108057C", Offset="0x108057C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FF08", Offset="0x104FF08")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeClubDungeonStatusRequest.<>c <>9;

			[Address(RVA="0x1CFF97C", Offset="0x1CFF97C", VA="0x1CFF97C")]
			static <>c()
			{
			}

			[Address(RVA="0x1CFF9E0", Offset="0x1CFF9E0", VA="0x1CFF9E0")]
			public <>c()
			{
			}

			[Address(RVA="0x1CFF9E8", Offset="0x1CFF9E8", VA="0x1CFF9E8")]
			internal HomeClubDungeonStatusRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}