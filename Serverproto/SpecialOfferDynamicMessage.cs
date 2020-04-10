using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class SpecialOfferDynamicMessage : IMessage<SpecialOfferDynamicMessage>, IMessage, IEquatable<SpecialOfferDynamicMessage>, IDeepCloneable<SpecialOfferDynamicMessage>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<SpecialOfferDynamicMessage> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StoreItemFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.StoreItem storeItem_;

		[FieldOffset(Offset="0x0")]
		public const int AvailableStoreItemIdsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_availableStoreItemIds_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> availableStoreItemIds_;

		[FieldOffset(Offset="0x0")]
		public const int StoreItemsFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<Serverproto.StoreItem> _repeated_storeItems_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<Serverproto.StoreItem> storeItems_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BD48", Offset="0x109BD48")]
		public RepeatedField<ulong> AvailableStoreItemIds
		{
			[Address(RVA="0x1BD6CCC", Offset="0x1BD6CCC", VA="0x1BD6CCC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BCF0", Offset="0x109BCF0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD6990", Offset="0x1BD6990", VA="0x1BD6990")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BCE0", Offset="0x109BCE0")]
		public static MessageParser<SpecialOfferDynamicMessage> Parser
		{
			[Address(RVA="0x1BCEA18", Offset="0x1BCEA18", VA="0x1BCEA18")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BD00", Offset="0x109BD00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD6A7C", Offset="0x1BD6A7C", VA="0x1BD6A7C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BD10", Offset="0x109BD10")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x109BD10", Offset="0x109BD10")]
		public Serverproto.StoreItem StoreItem
		{
			[Address(RVA="0x1BD6C5C", Offset="0x1BD6C5C", VA="0x1BD6C5C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BD6C64", Offset="0x1BD6C64", VA="0x1BD6C64")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BD58", Offset="0x109BD58")]
		public RepeatedField<Serverproto.StoreItem> StoreItems
		{
			[Address(RVA="0x1BD6CD4", Offset="0x1BD6CD4", VA="0x1BD6CD4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BD74AC", Offset="0x1BD74AC", VA="0x1BD74AC")]
		static SpecialOfferDynamicMessage()
		{
		}

		[Address(RVA="0x1BD6AD8", Offset="0x1BD6AD8", VA="0x1BD6AD8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087D9C", Offset="0x1087D9C")]
		public SpecialOfferDynamicMessage()
		{
		}

		[Address(RVA="0x1BD6B70", Offset="0x1BD6B70", VA="0x1BD6B70")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087DAC", Offset="0x1087DAC")]
		public SpecialOfferDynamicMessage(SpecialOfferDynamicMessage other)
		{
		}

		[Address(RVA="0x1BD70B8", Offset="0x1BD70B8", VA="0x1BD70B8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087E1C", Offset="0x1087E1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD6C6C", Offset="0x1BD6C6C", VA="0x1BD6C6C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087DBC", Offset="0x1087DBC")]
		public SpecialOfferDynamicMessage Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD6CDC", Offset="0x1BD6CDC", VA="0x1BD6CDC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087DCC", Offset="0x1087DCC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD6D50", Offset="0x1BD6D50", VA="0x1BD6D50", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087DDC", Offset="0x1087DDC")]
		public bool Equals(SpecialOfferDynamicMessage other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD6E44", Offset="0x1BD6E44", VA="0x1BD6E44", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087DEC", Offset="0x1087DEC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD71F4", Offset="0x1BD71F4", VA="0x1BD71F4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087E2C", Offset="0x1087E2C")]
		public void MergeFrom(SpecialOfferDynamicMessage other)
		{
		}

		[Address(RVA="0x1BD72F8", Offset="0x1BD72F8", VA="0x1BD72F8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087E3C", Offset="0x1087E3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD6EF0", Offset="0x1BD6EF0", VA="0x1BD6EF0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087DFC", Offset="0x1087DFC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD6F58", Offset="0x1BD6F58", VA="0x1BD6F58", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087E0C", Offset="0x1087E0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10509F8", Offset="0x10509F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static SpecialOfferDynamicMessage.<>c <>9;

			[Address(RVA="0x1BD764C", Offset="0x1BD764C", VA="0x1BD764C")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD76B0", Offset="0x1BD76B0", VA="0x1BD76B0")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD76B8", Offset="0x1BD76B8", VA="0x1BD76B8")]
			internal SpecialOfferDynamicMessage <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}