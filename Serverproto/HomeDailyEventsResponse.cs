using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeDailyEventsResponse : IMessage<HomeDailyEventsResponse>, IMessage, IEquatable<HomeDailyEventsResponse>, IDeepCloneable<HomeDailyEventsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeDailyEventsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int AvailableBattlesFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private uint availableBattles_;

		[FieldOffset(Offset="0x0")]
		public const int TotalBattlesFieldNumber = 2;

		[FieldOffset(Offset="0x1C")]
		private uint totalBattles_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097988", Offset="0x1097988")]
		public uint AvailableBattles
		{
			[Address(RVA="0x1D0373C", Offset="0x1D0373C", VA="0x1D0373C")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1D03744", Offset="0x1D03744", VA="0x1D03744")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097968", Offset="0x1097968")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D0350C", Offset="0x1D0350C", VA="0x1D0350C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097958", Offset="0x1097958")]
		public static MessageParser<HomeDailyEventsResponse> Parser
		{
			[Address(RVA="0x1D034A4", Offset="0x1D034A4", VA="0x1D034A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097978", Offset="0x1097978")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D035F8", Offset="0x1D035F8", VA="0x1D035F8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097998", Offset="0x1097998")]
		public uint TotalBattles
		{
			[Address(RVA="0x1D0374C", Offset="0x1D0374C", VA="0x1D0374C")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1D03754", Offset="0x1D03754", VA="0x1D03754")]
			set
			{
			}
		}

		[Address(RVA="0x1D03BC4", Offset="0x1D03BC4", VA="0x1D03BC4")]
		static HomeDailyEventsResponse()
		{
		}

		[Address(RVA="0x1D03654", Offset="0x1D03654", VA="0x1D03654")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108019C", Offset="0x108019C")]
		public HomeDailyEventsResponse()
		{
		}

		[Address(RVA="0x1D0365C", Offset="0x1D0365C", VA="0x1D0365C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10801AC", Offset="0x10801AC")]
		public HomeDailyEventsResponse(HomeDailyEventsResponse other)
		{
		}

		[Address(RVA="0x1D03A00", Offset="0x1D03A00", VA="0x1D03A00", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108021C", Offset="0x108021C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D036DC", Offset="0x1D036DC", VA="0x1D036DC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10801BC", Offset="0x10801BC")]
		public HomeDailyEventsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1D0375C", Offset="0x1D0375C", VA="0x1D0375C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10801CC", Offset="0x10801CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D037D0", Offset="0x1D037D0", VA="0x1D037D0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10801DC", Offset="0x10801DC")]
		public bool Equals(HomeDailyEventsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1D0381C", Offset="0x1D0381C", VA="0x1D0381C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10801EC", Offset="0x10801EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D03AD4", Offset="0x1D03AD4", VA="0x1D03AD4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108022C", Offset="0x108022C")]
		public void MergeFrom(HomeDailyEventsResponse other)
		{
		}

		[Address(RVA="0x1D03B20", Offset="0x1D03B20", VA="0x1D03B20", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108023C", Offset="0x108023C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D038A0", Offset="0x1D038A0", VA="0x1D038A0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10801FC", Offset="0x10801FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D03908", Offset="0x1D03908", VA="0x1D03908", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108020C", Offset="0x108020C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FEB8", Offset="0x104FEB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeDailyEventsResponse.<>c <>9;

			[Address(RVA="0x1D03C9C", Offset="0x1D03C9C", VA="0x1D03C9C")]
			static <>c()
			{
			}

			[Address(RVA="0x1D03D00", Offset="0x1D03D00", VA="0x1D03D00")]
			public <>c()
			{
			}

			[Address(RVA="0x1D03D08", Offset="0x1D03D08", VA="0x1D03D08")]
			internal HomeDailyEventsResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}