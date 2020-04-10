using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubDungeonRequest : IMessage<ClubDungeonRequest>, IMessage, IEquatable<ClubDungeonRequest>, IDeepCloneable<ClubDungeonRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubDungeonRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DungeonIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string dungeonId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095730", Offset="0x1095730")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FF2BC0", Offset="0x1FF2BC0", VA="0x1FF2BC0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095750", Offset="0x1095750")]
		public string DungeonId
		{
			[Address(RVA="0x1FF2E20", Offset="0x1FF2E20", VA="0x1FF2E20")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF2E28", Offset="0x1FF2E28", VA="0x1FF2E28")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095720", Offset="0x1095720")]
		public static MessageParser<ClubDungeonRequest> Parser
		{
			[Address(RVA="0x1FF2B58", Offset="0x1FF2B58", VA="0x1FF2B58")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095740", Offset="0x1095740")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FF2CAC", Offset="0x1FF2CAC", VA="0x1FF2CAC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FF32B8", Offset="0x1FF32B8", VA="0x1FF32B8")]
		static ClubDungeonRequest()
		{
		}

		[Address(RVA="0x1FF2D08", Offset="0x1FF2D08", VA="0x1FF2D08")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C88C", Offset="0x107C88C")]
		public ClubDungeonRequest()
		{
		}

		[Address(RVA="0x1FF2D60", Offset="0x1FF2D60", VA="0x1FF2D60")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C89C", Offset="0x107C89C")]
		public ClubDungeonRequest(ClubDungeonRequest other)
		{
		}

		[Address(RVA="0x1FF3114", Offset="0x1FF3114", VA="0x1FF3114", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C90C", Offset="0x107C90C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FF2DC0", Offset="0x1FF2DC0", VA="0x1FF2DC0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C8AC", Offset="0x107C8AC")]
		public ClubDungeonRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FF2E98", Offset="0x1FF2E98", VA="0x1FF2E98", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C8BC", Offset="0x107C8BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF2F0C", Offset="0x1FF2F0C", VA="0x1FF2F0C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C8CC", Offset="0x107C8CC")]
		public bool Equals(ClubDungeonRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF2F70", Offset="0x1FF2F70", VA="0x1FF2F70", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C8DC", Offset="0x107C8DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FF31C8", Offset="0x1FF31C8", VA="0x1FF31C8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C91C", Offset="0x107C91C")]
		public void MergeFrom(ClubDungeonRequest other)
		{
		}

		[Address(RVA="0x1FF3234", Offset="0x1FF3234", VA="0x1FF3234", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C92C", Offset="0x107C92C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FF2FF4", Offset="0x1FF2FF4", VA="0x1FF2FF4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C8EC", Offset="0x107C8EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FF305C", Offset="0x1FF305C", VA="0x1FF305C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C8FC", Offset="0x107C8FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F978", Offset="0x104F978")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubDungeonRequest.<>c <>9;

			[Address(RVA="0x1FF3390", Offset="0x1FF3390", VA="0x1FF3390")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF33F4", Offset="0x1FF33F4", VA="0x1FF33F4")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF33FC", Offset="0x1FF33FC", VA="0x1FF33FC")]
			internal ClubDungeonRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}