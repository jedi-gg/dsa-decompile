using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class LockableFeatureUpdatedEntry : IMessage<LockableFeatureUpdatedEntry>, IMessage, IEquatable<LockableFeatureUpdatedEntry>, IDeepCloneable<LockableFeatureUpdatedEntry>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<LockableFeatureUpdatedEntry> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int FeatureIndexFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong featureIndex_;

		[FieldOffset(Offset="0x0")]
		public const int IsUnlockedFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool isUnlocked_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BB80", Offset="0x109BB80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A18A00", Offset="0x1A18A00", VA="0x1A18A00")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BBA0", Offset="0x109BBA0")]
		public ulong FeatureIndex
		{
			[Address(RVA="0x1A18C34", Offset="0x1A18C34", VA="0x1A18C34")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A18C3C", Offset="0x1A18C3C", VA="0x1A18C3C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BBB0", Offset="0x109BBB0")]
		public bool IsUnlocked
		{
			[Address(RVA="0x1A18C44", Offset="0x1A18C44", VA="0x1A18C44")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A18C4C", Offset="0x1A18C4C", VA="0x1A18C4C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BB70", Offset="0x109BB70")]
		public static MessageParser<LockableFeatureUpdatedEntry> Parser
		{
			[Address(RVA="0x1A188D4", Offset="0x1A188D4", VA="0x1A188D4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BB90", Offset="0x109BB90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A18AF0", Offset="0x1A18AF0", VA="0x1A18AF0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A190B4", Offset="0x1A190B4", VA="0x1A190B4")]
		static LockableFeatureUpdatedEntry()
		{
		}

		[Address(RVA="0x1A18B4C", Offset="0x1A18B4C", VA="0x1A18B4C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087A2C", Offset="0x1087A2C")]
		public LockableFeatureUpdatedEntry()
		{
		}

		[Address(RVA="0x1A18B54", Offset="0x1A18B54", VA="0x1A18B54")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087A3C", Offset="0x1087A3C")]
		public LockableFeatureUpdatedEntry(LockableFeatureUpdatedEntry other)
		{
		}

		[Address(RVA="0x1A18F18", Offset="0x1A18F18", VA="0x1A18F18", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087AAC", Offset="0x1087AAC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A18BD4", Offset="0x1A18BD4", VA="0x1A18BD4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087A4C", Offset="0x1087A4C")]
		public LockableFeatureUpdatedEntry Clone()
		{
			return null;
		}

		[Address(RVA="0x1A18C58", Offset="0x1A18C58", VA="0x1A18C58", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087A5C", Offset="0x1087A5C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A18CCC", Offset="0x1A18CCC", VA="0x1A18CCC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087A6C", Offset="0x1087A6C")]
		public bool Equals(LockableFeatureUpdatedEntry other)
		{
			return new bool();
		}

		[Address(RVA="0x1A18D28", Offset="0x1A18D28", VA="0x1A18D28", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087A7C", Offset="0x1087A7C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A18FC0", Offset="0x1A18FC0", VA="0x1A18FC0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087ABC", Offset="0x1087ABC")]
		public void MergeFrom(LockableFeatureUpdatedEntry other)
		{
		}

		[Address(RVA="0x1A1900C", Offset="0x1A1900C", VA="0x1A1900C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087ACC", Offset="0x1087ACC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A18DB4", Offset="0x1A18DB4", VA="0x1A18DB4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087A8C", Offset="0x1087A8C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A18E1C", Offset="0x1A18E1C", VA="0x1A18E1C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087A9C", Offset="0x1087A9C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10509A8", Offset="0x10509A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static LockableFeatureUpdatedEntry.<>c <>9;

			[Address(RVA="0x1A1918C", Offset="0x1A1918C", VA="0x1A1918C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A191F0", Offset="0x1A191F0", VA="0x1A191F0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A191F8", Offset="0x1A191F8", VA="0x1A191F8")]
			internal LockableFeatureUpdatedEntry <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}