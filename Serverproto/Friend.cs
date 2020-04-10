using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class Friend : IMessage<Friend>, IMessage, IEquatable<Friend>, IDeepCloneable<Friend>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<Friend> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ProfileFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private PlayerProfileSimple profile_;

		[FieldOffset(Offset="0x0")]
		public const int StatusFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private FriendStatus status_;

		[FieldOffset(Offset="0x0")]
		public const int TelemetryRefIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private long telemetryRefId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A6B0", Offset="0x109A6B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B9CAF4", Offset="0x1B9CAF4", VA="0x1B9CAF4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A6A0", Offset="0x109A6A0")]
		public static MessageParser<Friend> Parser
		{
			[Address(RVA="0x1B9CA8C", Offset="0x1B9CA8C", VA="0x1B9CA8C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A6C0", Offset="0x109A6C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B9CBE4", Offset="0x1B9CBE4", VA="0x1B9CBE4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A6D0", Offset="0x109A6D0")]
		public PlayerProfileSimple Profile
		{
			[Address(RVA="0x1B9CCD4", Offset="0x1B9CCD4", VA="0x1B9CCD4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B9CCDC", Offset="0x1B9CCDC", VA="0x1B9CCDC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A6E0", Offset="0x109A6E0")]
		public FriendStatus Status
		{
			[Address(RVA="0x1B9CD44", Offset="0x1B9CD44", VA="0x1B9CD44")]
			get
			{
				return new FriendStatus();
			}
			[Address(RVA="0x1B9CD4C", Offset="0x1B9CD4C", VA="0x1B9CD4C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A6F0", Offset="0x109A6F0")]
		public long TelemetryRefId
		{
			[Address(RVA="0x1B9CD54", Offset="0x1B9CD54", VA="0x1B9CD54")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1B9CD5C", Offset="0x1B9CD5C", VA="0x1B9CD5C")]
			set
			{
			}
		}

		[Address(RVA="0x1B9D3C4", Offset="0x1B9D3C4", VA="0x1B9D3C4")]
		static Friend()
		{
		}

		[Address(RVA="0x1B9CC40", Offset="0x1B9CC40", VA="0x1B9CC40")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108495C", Offset="0x108495C")]
		public Friend()
		{
		}

		[Address(RVA="0x1B9CC48", Offset="0x1B9CC48", VA="0x1B9CC48")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108496C", Offset="0x108496C")]
		public Friend(Friend other)
		{
		}

		[Address(RVA="0x1B9D0B4", Offset="0x1B9D0B4", VA="0x1B9D0B4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10849DC", Offset="0x10849DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B9CCE4", Offset="0x1B9CCE4", VA="0x1B9CCE4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108497C", Offset="0x108497C")]
		public Friend Clone()
		{
			return null;
		}

		[Address(RVA="0x1B9CD64", Offset="0x1B9CD64", VA="0x1B9CD64", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108498C", Offset="0x108498C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9CDD8", Offset="0x1B9CDD8", VA="0x1B9CDD8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108499C", Offset="0x108499C")]
		public bool Equals(Friend other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9CE5C", Offset="0x1B9CE5C", VA="0x1B9CE5C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10849AC", Offset="0x10849AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B9D1C4", Offset="0x1B9D1C4", VA="0x1B9D1C4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10849EC", Offset="0x10849EC")]
		public void MergeFrom(Friend other)
		{
		}

		[Address(RVA="0x1B9D290", Offset="0x1B9D290", VA="0x1B9D290", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10849FC", Offset="0x10849FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B9CEFC", Offset="0x1B9CEFC", VA="0x1B9CEFC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10849BC", Offset="0x10849BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B9CF64", Offset="0x1B9CF64", VA="0x1B9CF64", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10849CC", Offset="0x10849CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050538", Offset="0x1050538")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static Friend.<>c <>9;

			[Address(RVA="0x1B9D49C", Offset="0x1B9D49C", VA="0x1B9D49C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B9D500", Offset="0x1B9D500", VA="0x1B9D500")]
			public <>c()
			{
			}

			[Address(RVA="0x1B9D508", Offset="0x1B9D508", VA="0x1B9D508")]
			internal Friend <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}