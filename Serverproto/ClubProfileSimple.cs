using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubProfileSimple : IMessage<ClubProfileSimple>, IMessage, IEquatable<ClubProfileSimple>, IDeepCloneable<ClubProfileSimple>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubProfileSimple> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int NameFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string name_;

		[FieldOffset(Offset="0x0")]
		public const int AvatarIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong avatarId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096680", Offset="0x1096680")]
		public ulong AvatarId
		{
			[Address(RVA="0x1FFF7D4", Offset="0x1FFF7D4", VA="0x1FFF7D4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FFF7DC", Offset="0x1FFF7DC", VA="0x1FFF7DC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096640", Offset="0x1096640")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FFF448", Offset="0x1FFF448", VA="0x1FFF448")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096660", Offset="0x1096660")]
		public string Id
		{
			[Address(RVA="0x1FFF6E4", Offset="0x1FFF6E4", VA="0x1FFF6E4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FFF6EC", Offset="0x1FFF6EC", VA="0x1FFF6EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096670", Offset="0x1096670")]
		public string Name
		{
			[Address(RVA="0x1FFF75C", Offset="0x1FFF75C", VA="0x1FFF75C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FFF764", Offset="0x1FFF764", VA="0x1FFF764")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096630", Offset="0x1096630")]
		public static MessageParser<ClubProfileSimple> Parser
		{
			[Address(RVA="0x1FFF3E0", Offset="0x1FFF3E0", VA="0x1FFF3E0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096650", Offset="0x1096650")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FFF538", Offset="0x1FFF538", VA="0x1FFF538", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FFFE90", Offset="0x1FFFE90", VA="0x1FFFE90")]
		static ClubProfileSimple()
		{
		}

		[Address(RVA="0x1FFF594", Offset="0x1FFF594", VA="0x1FFF594")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EA3C", Offset="0x107EA3C")]
		public ClubProfileSimple()
		{
		}

		[Address(RVA="0x1FFF5EC", Offset="0x1FFF5EC", VA="0x1FFF5EC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EA4C", Offset="0x107EA4C")]
		public ClubProfileSimple(ClubProfileSimple other)
		{
		}

		[Address(RVA="0x1FFFBB8", Offset="0x1FFFBB8", VA="0x1FFFBB8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EABC", Offset="0x107EABC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FFF684", Offset="0x1FFF684", VA="0x1FFF684", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EA5C", Offset="0x107EA5C")]
		public ClubProfileSimple Clone()
		{
			return null;
		}

		[Address(RVA="0x1FFF7E4", Offset="0x1FFF7E4", VA="0x1FFF7E4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EA6C", Offset="0x107EA6C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFF858", Offset="0x1FFF858", VA="0x1FFF858", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EA7C", Offset="0x107EA7C")]
		public bool Equals(ClubProfileSimple other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFF8E0", Offset="0x1FFF8E0", VA="0x1FFF8E0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EA8C", Offset="0x107EA8C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FFFD08", Offset="0x1FFFD08", VA="0x1FFFD08", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EACC", Offset="0x107EACC")]
		public void MergeFrom(ClubProfileSimple other)
		{
		}

		[Address(RVA="0x1FFFDAC", Offset="0x1FFFDAC", VA="0x1FFFDAC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EADC", Offset="0x107EADC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FFF9D0", Offset="0x1FFF9D0", VA="0x1FFF9D0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EA9C", Offset="0x107EA9C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FFFA38", Offset="0x1FFFA38", VA="0x1FFFA38", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EAAC", Offset="0x107EAAC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FC98", Offset="0x104FC98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubProfileSimple.<>c <>9;

			[Address(RVA="0x1FFFF68", Offset="0x1FFFF68", VA="0x1FFFF68")]
			static <>c()
			{
			}

			[Address(RVA="0x1FFFFCC", Offset="0x1FFFFCC", VA="0x1FFFFCC")]
			public <>c()
			{
			}

			[Address(RVA="0x1FFFFD4", Offset="0x1FFFFD4", VA="0x1FFFFD4")]
			internal ClubProfileSimple <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}