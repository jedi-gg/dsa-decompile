using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PersistentRewards : IMessage<PersistentRewards>, IMessage, IEquatable<PersistentRewards>, IDeepCloneable<PersistentRewards>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PersistentRewards> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong itemId_;

		[FieldOffset(Offset="0x0")]
		public const int GoalFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong goal_;

		[FieldOffset(Offset="0x0")]
		public const int RewardCountFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong rewardCount_;

		[FieldOffset(Offset="0x0")]
		public const int TierIndexFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong tierIndex_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10973C8", Offset="0x10973C8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A263A4", Offset="0x1A263A4", VA="0x1A263A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10973F8", Offset="0x10973F8")]
		public ulong Goal
		{
			[Address(RVA="0x1A26620", Offset="0x1A26620", VA="0x1A26620")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A26628", Offset="0x1A26628", VA="0x1A26628")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10973E8", Offset="0x10973E8")]
		public ulong ItemId
		{
			[Address(RVA="0x1A26610", Offset="0x1A26610", VA="0x1A26610")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A26618", Offset="0x1A26618", VA="0x1A26618")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10973B8", Offset="0x10973B8")]
		public static MessageParser<PersistentRewards> Parser
		{
			[Address(RVA="0x1A2633C", Offset="0x1A2633C", VA="0x1A2633C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10973D8", Offset="0x10973D8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A26494", Offset="0x1A26494", VA="0x1A26494", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097408", Offset="0x1097408")]
		public ulong RewardCount
		{
			[Address(RVA="0x1A26630", Offset="0x1A26630", VA="0x1A26630")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A26638", Offset="0x1A26638", VA="0x1A26638")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097418", Offset="0x1097418")]
		public ulong TierIndex
		{
			[Address(RVA="0x1A26640", Offset="0x1A26640", VA="0x1A26640")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A26648", Offset="0x1A26648", VA="0x1A26648")]
			set
			{
			}
		}

		[Address(RVA="0x1A26CA8", Offset="0x1A26CA8", VA="0x1A26CA8")]
		static PersistentRewards()
		{
		}

		[Address(RVA="0x1A264F0", Offset="0x1A264F0", VA="0x1A264F0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FA0C", Offset="0x107FA0C")]
		public PersistentRewards()
		{
		}

		[Address(RVA="0x1A264F8", Offset="0x1A264F8", VA="0x1A264F8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FA1C", Offset="0x107FA1C")]
		public PersistentRewards(PersistentRewards other)
		{
		}

		[Address(RVA="0x1A269FC", Offset="0x1A269FC", VA="0x1A269FC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FA8C", Offset="0x107FA8C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A265B0", Offset="0x1A265B0", VA="0x1A265B0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FA2C", Offset="0x107FA2C")]
		public PersistentRewards Clone()
		{
			return null;
		}

		[Address(RVA="0x1A26650", Offset="0x1A26650", VA="0x1A26650", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FA3C", Offset="0x107FA3C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A266C4", Offset="0x1A266C4", VA="0x1A266C4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FA4C", Offset="0x107FA4C")]
		public bool Equals(PersistentRewards other)
		{
			return new bool();
		}

		[Address(RVA="0x1A26730", Offset="0x1A26730", VA="0x1A26730", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FA5C", Offset="0x107FA5C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A26B48", Offset="0x1A26B48", VA="0x1A26B48", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FA9C", Offset="0x107FA9C")]
		public void MergeFrom(PersistentRewards other)
		{
		}

		[Address(RVA="0x1A26BAC", Offset="0x1A26BAC", VA="0x1A26BAC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FAAC", Offset="0x107FAAC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A267EC", Offset="0x1A267EC", VA="0x1A267EC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FA6C", Offset="0x107FA6C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A26854", Offset="0x1A26854", VA="0x1A26854", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FA7C", Offset="0x107FA7C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FE08", Offset="0x104FE08")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PersistentRewards.<>c <>9;

			[Address(RVA="0x1A26D80", Offset="0x1A26D80", VA="0x1A26D80")]
			static <>c()
			{
			}

			[Address(RVA="0x1A26DE4", Offset="0x1A26DE4", VA="0x1A26DE4")]
			public <>c()
			{
			}

			[Address(RVA="0x1A26DEC", Offset="0x1A26DEC", VA="0x1A26DEC")]
			internal PersistentRewards <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}