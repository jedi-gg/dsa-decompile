using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeStoreResponse : IMessage<HomeStoreResponse>, IMessage, IEquatable<HomeStoreResponse>, IDeepCloneable<HomeStoreResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeStoreResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NumAvailableFreeItemsFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private uint numAvailableFreeItems_;

		[FieldOffset(Offset="0x0")]
		public const int NextFreeItemTimestampFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong nextFreeItemTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int SpecialOfferItemFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private StoreItem specialOfferItem_;

		[FieldOffset(Offset="0x0")]
		public const int StoreFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private StoreResponse store_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097D48", Offset="0x1097D48")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D6D98", Offset="0x18D6D98", VA="0x18D6D98")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097D78", Offset="0x1097D78")]
		public ulong NextFreeItemTimestamp
		{
			[Address(RVA="0x18D7024", Offset="0x18D7024", VA="0x18D7024")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18D702C", Offset="0x18D702C", VA="0x18D702C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097D68", Offset="0x1097D68")]
		public uint NumAvailableFreeItems
		{
			[Address(RVA="0x18D7014", Offset="0x18D7014", VA="0x18D7014")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x18D701C", Offset="0x18D701C", VA="0x18D701C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097D38", Offset="0x1097D38")]
		public static MessageParser<HomeStoreResponse> Parser
		{
			[Address(RVA="0x18D6D30", Offset="0x18D6D30", VA="0x18D6D30")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097D58", Offset="0x1097D58")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D6E88", Offset="0x18D6E88", VA="0x18D6E88", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097D88", Offset="0x1097D88")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1097D88", Offset="0x1097D88")]
		public StoreItem SpecialOfferItem
		{
			[Address(RVA="0x18D6F94", Offset="0x18D6F94", VA="0x18D6F94")]
			get
			{
				return null;
			}
			[Address(RVA="0x18D6F9C", Offset="0x18D6F9C", VA="0x18D6F9C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097DC0", Offset="0x1097DC0")]
		public StoreResponse Store
		{
			[Address(RVA="0x18D6FA4", Offset="0x18D6FA4", VA="0x18D6FA4")]
			get
			{
				return null;
			}
			[Address(RVA="0x18D6FAC", Offset="0x18D6FAC", VA="0x18D6FAC")]
			set
			{
			}
		}

		[Address(RVA="0x18D77DC", Offset="0x18D77DC", VA="0x18D77DC")]
		static HomeStoreResponse()
		{
		}

		[Address(RVA="0x18D6EE4", Offset="0x18D6EE4", VA="0x18D6EE4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10809DC", Offset="0x10809DC")]
		public HomeStoreResponse()
		{
		}

		[Address(RVA="0x18D6EEC", Offset="0x18D6EEC", VA="0x18D6EEC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10809EC", Offset="0x10809EC")]
		public HomeStoreResponse(HomeStoreResponse other)
		{
		}

		[Address(RVA="0x18D7408", Offset="0x18D7408", VA="0x18D7408", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080A5C", Offset="0x1080A5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D6FB4", Offset="0x18D6FB4", VA="0x18D6FB4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10809FC", Offset="0x10809FC")]
		public HomeStoreResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18D7034", Offset="0x18D7034", VA="0x18D7034", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080A0C", Offset="0x1080A0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D70A8", Offset="0x18D70A8", VA="0x18D70A8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080A1C", Offset="0x1080A1C")]
		public bool Equals(HomeStoreResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18D7140", Offset="0x18D7140", VA="0x18D7140", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080A2C", Offset="0x1080A2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18D7554", Offset="0x18D7554", VA="0x18D7554", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080A6C", Offset="0x1080A6C")]
		public void MergeFrom(HomeStoreResponse other)
		{
		}

		[Address(RVA="0x18D7670", Offset="0x18D7670", VA="0x18D7670", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080A7C", Offset="0x1080A7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18D71F8", Offset="0x18D71F8", VA="0x18D71F8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080A3C", Offset="0x1080A3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18D7260", Offset="0x18D7260", VA="0x18D7260", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080A4C", Offset="0x1080A4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FF78", Offset="0x104FF78")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeStoreResponse.<>c <>9;

			[Address(RVA="0x18D78B4", Offset="0x18D78B4", VA="0x18D78B4")]
			static <>c()
			{
			}

			[Address(RVA="0x18D7918", Offset="0x18D7918", VA="0x18D7918")]
			public <>c()
			{
			}

			[Address(RVA="0x18D7920", Offset="0x18D7920", VA="0x18D7920")]
			internal HomeStoreResponse <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}