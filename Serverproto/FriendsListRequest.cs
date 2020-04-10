using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FriendsListRequest : IMessage<FriendsListRequest>, IMessage, IEquatable<FriendsListRequest>, IDeepCloneable<FriendsListRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FriendsListRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A710", Offset="0x109A710")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA0E8C", Offset="0x1BA0E8C", VA="0x1BA0E8C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A700", Offset="0x109A700")]
		public static MessageParser<FriendsListRequest> Parser
		{
			[Address(RVA="0x1BA0E24", Offset="0x1BA0E24", VA="0x1BA0E24")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A720", Offset="0x109A720")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA0F7C", Offset="0x1BA0F7C", VA="0x1BA0F7C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA1290", Offset="0x1BA1290", VA="0x1BA1290")]
		static FriendsListRequest()
		{
		}

		[Address(RVA="0x1BA0FD8", Offset="0x1BA0FD8", VA="0x1BA0FD8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084A0C", Offset="0x1084A0C")]
		public FriendsListRequest()
		{
		}

		[Address(RVA="0x1BA0FE0", Offset="0x1BA0FE0", VA="0x1BA0FE0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084A1C", Offset="0x1084A1C")]
		public FriendsListRequest(FriendsListRequest other)
		{
		}

		[Address(RVA="0x1BA11F4", Offset="0x1BA11F4", VA="0x1BA11F4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084A8C", Offset="0x1084A8C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA1024", Offset="0x1BA1024", VA="0x1BA1024", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084A2C", Offset="0x1084A2C")]
		public FriendsListRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA1084", Offset="0x1BA1084", VA="0x1BA1084", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084A3C", Offset="0x1084A3C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA111C", Offset="0x1BA111C", VA="0x1BA111C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084A4C", Offset="0x1084A4C")]
		public bool Equals(FriendsListRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA1148", Offset="0x1BA1148", VA="0x1BA1148", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084A5C", Offset="0x1084A5C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA1208", Offset="0x1BA1208", VA="0x1BA1208", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084A9C", Offset="0x1084A9C")]
		public void MergeFrom(FriendsListRequest other)
		{
		}

		[Address(RVA="0x1BA123C", Offset="0x1BA123C", VA="0x1BA123C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084AAC", Offset="0x1084AAC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA1178", Offset="0x1BA1178", VA="0x1BA1178", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084A6C", Offset="0x1084A6C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA11E0", Offset="0x1BA11E0", VA="0x1BA11E0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084A7C", Offset="0x1084A7C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050548", Offset="0x1050548")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FriendsListRequest.<>c <>9;

			[Address(RVA="0x1BA1368", Offset="0x1BA1368", VA="0x1BA1368")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA13CC", Offset="0x1BA13CC", VA="0x1BA13CC")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA13D4", Offset="0x1BA13D4", VA="0x1BA13D4")]
			internal FriendsListRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}