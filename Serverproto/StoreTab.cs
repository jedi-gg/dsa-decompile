using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreTab : IMessage<StoreTab>, IMessage, IEquatable<StoreTab>, IDeepCloneable<StoreTab>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreTab> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong id_;

		[FieldOffset(Offset="0x0")]
		public const int SortOrderFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong sortOrder_;

		[FieldOffset(Offset="0x0")]
		public const int NameKeyFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string nameKey_;

		[FieldOffset(Offset="0x0")]
		public const int IconFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string icon_;

		[FieldOffset(Offset="0x0")]
		public const int ShelvesFieldNumber = 5;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<StoreShelf> _repeated_shelves_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<StoreShelf> shelves_;

		[FieldOffset(Offset="0x0")]
		public const int ItemSizeFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private StoreItemSize itemSize_;

		[FieldOffset(Offset="0x0")]
		public const int ItemsFieldNumber = 7;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<StoreItem> _repeated_items_codec;

		[FieldOffset(Offset="0x48")]
		private readonly RepeatedField<StoreItem> items_;

		[FieldOffset(Offset="0x0")]
		public const int ShowcaseItemFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private StoreItem showcaseItem_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C200", Offset="0x109C200")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B69E54", Offset="0x1B69E54", VA="0x1B69E54")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C250", Offset="0x109C250")]
		public string Icon
		{
			[Address(RVA="0x1B6A29C", Offset="0x1B6A29C", VA="0x1B6A29C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B6A2A4", Offset="0x1B6A2A4", VA="0x1B6A2A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C220", Offset="0x109C220")]
		public ulong Id
		{
			[Address(RVA="0x1B6A204", Offset="0x1B6A204", VA="0x1B6A204")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B6A20C", Offset="0x1B6A20C", VA="0x1B6A20C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C2A8", Offset="0x109C2A8")]
		public RepeatedField<StoreItem> Items
		{
			[Address(RVA="0x1B6A32C", Offset="0x1B6A32C", VA="0x1B6A32C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C298", Offset="0x109C298")]
		public StoreItemSize ItemSize
		{
			[Address(RVA="0x1B6A31C", Offset="0x1B6A31C", VA="0x1B6A31C")]
			get
			{
				return new StoreItemSize();
			}
			[Address(RVA="0x1B6A324", Offset="0x1B6A324", VA="0x1B6A324")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C240", Offset="0x109C240")]
		public string NameKey
		{
			[Address(RVA="0x1B6A224", Offset="0x1B6A224", VA="0x1B6A224")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B6A22C", Offset="0x1B6A22C", VA="0x1B6A22C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C1F0", Offset="0x109C1F0")]
		public static MessageParser<StoreTab> Parser
		{
			[Address(RVA="0x1B6779C", Offset="0x1B6779C", VA="0x1B6779C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C210", Offset="0x109C210")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B69F40", Offset="0x1B69F40", VA="0x1B69F40", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C260", Offset="0x109C260")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x109C260", Offset="0x109C260")]
		public RepeatedField<StoreShelf> Shelves
		{
			[Address(RVA="0x1B6A314", Offset="0x1B6A314", VA="0x1B6A314")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C2B8", Offset="0x109C2B8")]
		public StoreItem ShowcaseItem
		{
			[Address(RVA="0x1B6A194", Offset="0x1B6A194", VA="0x1B6A194")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B6A19C", Offset="0x1B6A19C", VA="0x1B6A19C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C230", Offset="0x109C230")]
		public ulong SortOrder
		{
			[Address(RVA="0x1B6A214", Offset="0x1B6A214", VA="0x1B6A214")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B6A21C", Offset="0x1B6A21C", VA="0x1B6A21C")]
			set
			{
			}
		}

		[Address(RVA="0x1B6B10C", Offset="0x1B6B10C", VA="0x1B6B10C")]
		static StoreTab()
		{
		}

		[Address(RVA="0x1B69F9C", Offset="0x1B69F9C", VA="0x1B69F9C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108810C", Offset="0x108810C")]
		public StoreTab()
		{
		}

		[Address(RVA="0x1B6A044", Offset="0x1B6A044", VA="0x1B6A044")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108811C", Offset="0x108811C")]
		public StoreTab(StoreTab other)
		{
		}

		[Address(RVA="0x1B6AA50", Offset="0x1B6AA50", VA="0x1B6AA50", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108818C", Offset="0x108818C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B6A1A4", Offset="0x1B6A1A4", VA="0x1B6A1A4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108812C", Offset="0x108812C")]
		public StoreTab Clone()
		{
			return null;
		}

		[Address(RVA="0x1B6A334", Offset="0x1B6A334", VA="0x1B6A334", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108813C", Offset="0x108813C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6A3A8", Offset="0x1B6A3A8", VA="0x1B6A3A8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108814C", Offset="0x108814C")]
		public bool Equals(StoreTab other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6A4F4", Offset="0x1B6A4F4", VA="0x1B6A4F4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108815C", Offset="0x108815C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B6AD04", Offset="0x1B6AD04", VA="0x1B6AD04", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108819C", Offset="0x108819C")]
		public void MergeFrom(StoreTab other)
		{
		}

		[Address(RVA="0x1B6AE8C", Offset="0x1B6AE8C", VA="0x1B6AE8C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10881AC", Offset="0x10881AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B6A688", Offset="0x1B6A688", VA="0x1B6A688", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108816C", Offset="0x108816C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B6A6F0", Offset="0x1B6A6F0", VA="0x1B6A6F0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108817C", Offset="0x108817C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050A58", Offset="0x1050A58")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreTab.<>c <>9;

			[Address(RVA="0x1B6B278", Offset="0x1B6B278", VA="0x1B6B278")]
			static <>c()
			{
			}

			[Address(RVA="0x1B6B2DC", Offset="0x1B6B2DC", VA="0x1B6B2DC")]
			public <>c()
			{
			}

			[Address(RVA="0x1B6B2E4", Offset="0x1B6B2E4", VA="0x1B6B2E4")]
			internal StoreTab <.cctor>b__60_0()
			{
				return null;
			}
		}
	}
}