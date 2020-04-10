using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreShelf : IMessage<StoreShelf>, IMessage, IEquatable<StoreShelf>, IDeepCloneable<StoreShelf>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreShelf> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NameKeyFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string nameKey_;

		[FieldOffset(Offset="0x0")]
		public const int BackgroundFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string background_;

		[FieldOffset(Offset="0x0")]
		public const int ItemsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<StoreItem> _repeated_items_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<StoreItem> items_;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong id_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C1C0", Offset="0x109C1C0")]
		public string Background
		{
			[Address(RVA="0x1B692F8", Offset="0x1B692F8", VA="0x1B692F8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B69300", Offset="0x1B69300", VA="0x1B69300")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C190", Offset="0x109C190")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B68F7C", Offset="0x1B68F7C", VA="0x1B68F7C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C1E0", Offset="0x109C1E0")]
		public ulong Id
		{
			[Address(RVA="0x1B69378", Offset="0x1B69378", VA="0x1B69378")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B69380", Offset="0x1B69380", VA="0x1B69380")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C1D0", Offset="0x109C1D0")]
		public RepeatedField<StoreItem> Items
		{
			[Address(RVA="0x1B69370", Offset="0x1B69370", VA="0x1B69370")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C1B0", Offset="0x109C1B0")]
		public string NameKey
		{
			[Address(RVA="0x1B69280", Offset="0x1B69280", VA="0x1B69280")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B69288", Offset="0x1B69288", VA="0x1B69288")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C180", Offset="0x109C180")]
		public static MessageParser<StoreShelf> Parser
		{
			[Address(RVA="0x1B67734", Offset="0x1B67734", VA="0x1B67734")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C1A0", Offset="0x109C1A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B69068", Offset="0x1B69068", VA="0x1B69068", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B69C6C", Offset="0x1B69C6C", VA="0x1B69C6C")]
		static StoreShelf()
		{
		}

		[Address(RVA="0x1B690C4", Offset="0x1B690C4", VA="0x1B690C4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108805C", Offset="0x108805C")]
		public StoreShelf()
		{
		}

		[Address(RVA="0x1B69144", Offset="0x1B69144", VA="0x1B69144")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108806C", Offset="0x108806C")]
		public StoreShelf(StoreShelf other)
		{
		}

		[Address(RVA="0x1B6985C", Offset="0x1B6985C", VA="0x1B6985C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10880DC", Offset="0x10880DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B69220", Offset="0x1B69220", VA="0x1B69220", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108807C", Offset="0x108807C")]
		public StoreShelf Clone()
		{
			return null;
		}

		[Address(RVA="0x1B69388", Offset="0x1B69388", VA="0x1B69388", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108808C", Offset="0x108808C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B693FC", Offset="0x1B693FC", VA="0x1B693FC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108809C", Offset="0x108809C")]
		public bool Equals(StoreShelf other)
		{
			return new bool();
		}

		[Address(RVA="0x1B694E4", Offset="0x1B694E4", VA="0x1B694E4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10880AC", Offset="0x10880AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B69A04", Offset="0x1B69A04", VA="0x1B69A04", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10880EC", Offset="0x10880EC")]
		public void MergeFrom(StoreShelf other)
		{
		}

		[Address(RVA="0x1B69AF8", Offset="0x1B69AF8", VA="0x1B69AF8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10880FC", Offset="0x10880FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B695F8", Offset="0x1B695F8", VA="0x1B695F8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10880BC", Offset="0x10880BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B69660", Offset="0x1B69660", VA="0x1B69660", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10880CC", Offset="0x10880CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050A48", Offset="0x1050A48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreShelf.<>c <>9;

			[Address(RVA="0x1B69D90", Offset="0x1B69D90", VA="0x1B69D90")]
			static <>c()
			{
			}

			[Address(RVA="0x1B69DF4", Offset="0x1B69DF4", VA="0x1B69DF4")]
			public <>c()
			{
			}

			[Address(RVA="0x1B69DFC", Offset="0x1B69DFC", VA="0x1B69DFC")]
			internal StoreShelf <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}