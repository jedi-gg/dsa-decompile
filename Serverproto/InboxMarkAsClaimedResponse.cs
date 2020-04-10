using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxMarkAsClaimedResponse : IMessage<InboxMarkAsClaimedResponse>, IMessage, IEquatable<InboxMarkAsClaimedResponse>, IDeepCloneable<InboxMarkAsClaimedResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxMarkAsClaimedResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AB10", Offset="0x109AB10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18DBAD8", Offset="0x18DBAD8", VA="0x18DBAD8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AB30", Offset="0x109AB30")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x18DBCA4", Offset="0x18DBCA4", VA="0x18DBCA4")]
			get
			{
				return null;
			}
			[Address(RVA="0x18DBD0C", Offset="0x18DBD0C", VA="0x18DBD0C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AB00", Offset="0x109AB00")]
		public static MessageParser<InboxMarkAsClaimedResponse> Parser
		{
			[Address(RVA="0x18DBA70", Offset="0x18DBA70", VA="0x18DBA70")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AB20", Offset="0x109AB20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18DBBC8", Offset="0x18DBBC8", VA="0x18DBBC8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18DC45C", Offset="0x18DC45C", VA="0x18DC45C")]
		static InboxMarkAsClaimedResponse()
		{
		}

		[Address(RVA="0x18DBC24", Offset="0x18DBC24", VA="0x18DBC24")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10853AC", Offset="0x10853AC")]
		public InboxMarkAsClaimedResponse()
		{
		}

		[Address(RVA="0x18DBC2C", Offset="0x18DBC2C", VA="0x18DBC2C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10853BC", Offset="0x10853BC")]
		public InboxMarkAsClaimedResponse(InboxMarkAsClaimedResponse other)
		{
		}

		[Address(RVA="0x18DBFAC", Offset="0x18DBFAC", VA="0x18DBFAC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108542C", Offset="0x108542C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18DBD14", Offset="0x18DBD14", VA="0x18DBD14", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10853CC", Offset="0x10853CC")]
		public InboxMarkAsClaimedResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18DBD74", Offset="0x18DBD74", VA="0x18DBD74", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10853DC", Offset="0x10853DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18DBDE8", Offset="0x18DBDE8", VA="0x18DBDE8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10853EC", Offset="0x10853EC")]
		public bool Equals(InboxMarkAsClaimedResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18DBE4C", Offset="0x18DBE4C", VA="0x18DBE4C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10853FC", Offset="0x10853FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18DC03C", Offset="0x18DC03C", VA="0x18DC03C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108543C", Offset="0x108543C")]
		public void MergeFrom(InboxMarkAsClaimedResponse other)
		{
		}

		[Address(RVA="0x18DC384", Offset="0x18DC384", VA="0x18DC384", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108544C", Offset="0x108544C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18DBEA4", Offset="0x18DBEA4", VA="0x18DBEA4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108540C", Offset="0x108540C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18DBF0C", Offset="0x18DBF0C", VA="0x18DBF0C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108541C", Offset="0x108541C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050628", Offset="0x1050628")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxMarkAsClaimedResponse.<>c <>9;

			[Address(RVA="0x18DC534", Offset="0x18DC534", VA="0x18DC534")]
			static <>c()
			{
			}

			[Address(RVA="0x18DC598", Offset="0x18DC598", VA="0x18DC598")]
			public <>c()
			{
			}

			[Address(RVA="0x18DC5A0", Offset="0x18DC5A0", VA="0x18DC5A0")]
			internal InboxMarkAsClaimedResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}