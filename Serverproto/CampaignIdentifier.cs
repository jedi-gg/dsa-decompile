using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CampaignIdentifier : IMessage<CampaignIdentifier>, IMessage, IEquatable<CampaignIdentifier>, IDeepCloneable<CampaignIdentifier>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CampaignIdentifier> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong campaignId_;

		[FieldOffset(Offset="0x0")]
		public const int MapIndexFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong mapIndex_;

		[FieldOffset(Offset="0x0")]
		public const int NodeIndexFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong nodeIndex_;

		[FieldOffset(Offset="0x0")]
		public const int BattleIndexFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong battleIndex_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096BE0", Offset="0x1096BE0")]
		public ulong BattleIndex
		{
			[Address(RVA="0x1F8E9BC", Offset="0x1F8E9BC", VA="0x1F8E9BC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8E9C4", Offset="0x1F8E9C4", VA="0x1F8E9C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096BB0", Offset="0x1096BB0")]
		public ulong CampaignId
		{
			[Address(RVA="0x1F8E98C", Offset="0x1F8E98C", VA="0x1F8E98C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8E994", Offset="0x1F8E994", VA="0x1F8E994")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096B90", Offset="0x1096B90")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F8E788", Offset="0x1F8E788", VA="0x1F8E788")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096BC0", Offset="0x1096BC0")]
		public ulong MapIndex
		{
			[Address(RVA="0x1F8E99C", Offset="0x1F8E99C", VA="0x1F8E99C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8E9A4", Offset="0x1F8E9A4", VA="0x1F8E9A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096BD0", Offset="0x1096BD0")]
		public ulong NodeIndex
		{
			[Address(RVA="0x1F8E9AC", Offset="0x1F8E9AC", VA="0x1F8E9AC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8E9B4", Offset="0x1F8E9B4", VA="0x1F8E9B4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096B80", Offset="0x1096B80")]
		public static MessageParser<CampaignIdentifier> Parser
		{
			[Address(RVA="0x1F8E720", Offset="0x1F8E720", VA="0x1F8E720")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096BA0", Offset="0x1096BA0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F8E878", Offset="0x1F8E878", VA="0x1F8E878", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F8EFC0", Offset="0x1F8EFC0", VA="0x1F8EFC0")]
		static CampaignIdentifier()
		{
		}

		[Address(RVA="0x1F86428", Offset="0x1F86428", VA="0x1F86428")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F11C", Offset="0x107F11C")]
		public CampaignIdentifier()
		{
		}

		[Address(RVA="0x1F8E8D4", Offset="0x1F8E8D4", VA="0x1F8E8D4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F12C", Offset="0x107F12C")]
		public CampaignIdentifier(CampaignIdentifier other)
		{
		}

		[Address(RVA="0x1F8ED78", Offset="0x1F8ED78", VA="0x1F8ED78", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F19C", Offset="0x107F19C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F85F08", Offset="0x1F85F08", VA="0x1F85F08", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F13C", Offset="0x107F13C")]
		public CampaignIdentifier Clone()
		{
			return null;
		}

		[Address(RVA="0x1F8E9CC", Offset="0x1F8E9CC", VA="0x1F8E9CC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F14C", Offset="0x107F14C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8EA40", Offset="0x1F8EA40", VA="0x1F8EA40", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F15C", Offset="0x107F15C")]
		public bool Equals(CampaignIdentifier other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8EAAC", Offset="0x1F8EAAC", VA="0x1F8EAAC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F16C", Offset="0x107F16C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F86430", Offset="0x1F86430", VA="0x1F86430", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F1AC", Offset="0x107F1AC")]
		public void MergeFrom(CampaignIdentifier other)
		{
		}

		[Address(RVA="0x1F8EEC4", Offset="0x1F8EEC4", VA="0x1F8EEC4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F1BC", Offset="0x107F1BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F8EB68", Offset="0x1F8EB68", VA="0x1F8EB68", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F17C", Offset="0x107F17C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F8EBD0", Offset="0x1F8EBD0", VA="0x1F8EBD0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F18C", Offset="0x107F18C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FD38", Offset="0x104FD38")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CampaignIdentifier.<>c <>9;

			[Address(RVA="0x1F8F098", Offset="0x1F8F098", VA="0x1F8F098")]
			static <>c()
			{
			}

			[Address(RVA="0x1F8F0FC", Offset="0x1F8F0FC", VA="0x1F8F0FC")]
			public <>c()
			{
			}

			[Address(RVA="0x1F8F104", Offset="0x1F8F104", VA="0x1F8F104")]
			internal CampaignIdentifier <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}