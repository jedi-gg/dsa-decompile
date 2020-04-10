using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeShowcase : IMessage<HomeShowcase>, IMessage, IEquatable<HomeShowcase>, IDeepCloneable<HomeShowcase>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeShowcase> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ImageFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string image_;

		[FieldOffset(Offset="0x0")]
		public const int TextFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string text_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkLocationFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong deepLinkLocation_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkSublocationFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string deepLinkSublocation_;

		[FieldOffset(Offset="0x0")]
		public const int EndTimestampFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong endTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ShowTimerFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private bool showTimer_;

		[FieldOffset(Offset="0x0")]
		public const int PriorityFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private long priority_;

		[FieldOffset(Offset="0x0")]
		public const int StoreItemHighlightsFieldNumber = 8;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ItemCount> _repeated_storeItemHighlights_codec;

		[FieldOffset(Offset="0x50")]
		private readonly RepeatedField<ItemCount> storeItemHighlights_;

		[FieldOffset(Offset="0x0")]
		public const int ImageMaterialFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private string imageMaterial_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097F90", Offset="0x1097F90")]
		public ulong DeepLinkLocation
		{
			[Address(RVA="0x18D453C", Offset="0x18D453C", VA="0x18D453C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18D4544", Offset="0x18D4544", VA="0x18D4544")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097FA0", Offset="0x1097FA0")]
		public string DeepLinkSublocation
		{
			[Address(RVA="0x18D454C", Offset="0x18D454C", VA="0x18D454C")]
			get
			{
				return null;
			}
			[Address(RVA="0x18D4554", Offset="0x18D4554", VA="0x18D4554")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097F50", Offset="0x1097F50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D40A8", Offset="0x18D40A8", VA="0x18D40A8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097FB0", Offset="0x1097FB0")]
		public ulong EndTimestamp
		{
			[Address(RVA="0x18D45C4", Offset="0x18D45C4", VA="0x18D45C4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18D45CC", Offset="0x18D45CC", VA="0x18D45CC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097F70", Offset="0x1097F70")]
		public string Image
		{
			[Address(RVA="0x18D444C", Offset="0x18D444C", VA="0x18D444C")]
			get
			{
				return null;
			}
			[Address(RVA="0x18D4454", Offset="0x18D4454", VA="0x18D4454")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097FF0", Offset="0x1097FF0")]
		public string ImageMaterial
		{
			[Address(RVA="0x18D4600", Offset="0x18D4600", VA="0x18D4600")]
			get
			{
				return null;
			}
			[Address(RVA="0x18D4608", Offset="0x18D4608", VA="0x18D4608")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097F40", Offset="0x1097F40")]
		public static MessageParser<HomeShowcase> Parser
		{
			[Address(RVA="0x18D4040", Offset="0x18D4040", VA="0x18D4040")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097F60", Offset="0x1097F60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D4198", Offset="0x18D4198", VA="0x18D4198", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097FD0", Offset="0x1097FD0")]
		public long Priority
		{
			[Address(RVA="0x18D45E8", Offset="0x18D45E8", VA="0x18D45E8")]
			get
			{
				return new long();
			}
			[Address(RVA="0x18D45F0", Offset="0x18D45F0", VA="0x18D45F0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097FC0", Offset="0x1097FC0")]
		public bool ShowTimer
		{
			[Address(RVA="0x18D45D4", Offset="0x18D45D4", VA="0x18D45D4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x18D45DC", Offset="0x18D45DC", VA="0x18D45DC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097FE0", Offset="0x1097FE0")]
		public RepeatedField<ItemCount> StoreItemHighlights
		{
			[Address(RVA="0x18D45F8", Offset="0x18D45F8", VA="0x18D45F8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097F80", Offset="0x1097F80")]
		public string Text
		{
			[Address(RVA="0x18D44C4", Offset="0x18D44C4", VA="0x18D44C4")]
			get
			{
				return null;
			}
			[Address(RVA="0x18D44CC", Offset="0x18D44CC", VA="0x18D44CC")]
			set
			{
			}
		}

		[Address(RVA="0x18D5548", Offset="0x18D5548", VA="0x18D5548")]
		static HomeShowcase()
		{
		}

		[Address(RVA="0x18D41F4", Offset="0x18D41F4", VA="0x18D41F4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080EAC", Offset="0x1080EAC")]
		public HomeShowcase()
		{
		}

		[Address(RVA="0x18D4284", Offset="0x18D4284", VA="0x18D4284")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080EBC", Offset="0x1080EBC")]
		public HomeShowcase(HomeShowcase other)
		{
		}

		[Address(RVA="0x18D4E94", Offset="0x18D4E94", VA="0x18D4E94", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080F2C", Offset="0x1080F2C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D43EC", Offset="0x18D43EC", VA="0x18D43EC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080ECC", Offset="0x1080ECC")]
		public HomeShowcase Clone()
		{
			return null;
		}

		[Address(RVA="0x18D4678", Offset="0x18D4678", VA="0x18D4678", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080EDC", Offset="0x1080EDC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D46EC", Offset="0x18D46EC", VA="0x18D46EC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080EEC", Offset="0x1080EEC")]
		public bool Equals(HomeShowcase other)
		{
			return new bool();
		}

		[Address(RVA="0x18D483C", Offset="0x18D483C", VA="0x18D483C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080EFC", Offset="0x1080EFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18D5178", Offset="0x18D5178", VA="0x18D5178", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080F3C", Offset="0x1080F3C")]
		public void MergeFrom(HomeShowcase other)
		{
		}

		[Address(RVA="0x18D52E8", Offset="0x18D52E8", VA="0x18D52E8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080F4C", Offset="0x1080F4C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18D4A44", Offset="0x18D4A44", VA="0x18D4A44", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080F0C", Offset="0x1080F0C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18D4AAC", Offset="0x18D4AAC", VA="0x18D4AAC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080F1C", Offset="0x1080F1C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FFE8", Offset="0x104FFE8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeShowcase.<>c <>9;

			[Address(RVA="0x18D566C", Offset="0x18D566C", VA="0x18D566C")]
			static <>c()
			{
			}

			[Address(RVA="0x18D56D0", Offset="0x18D56D0", VA="0x18D56D0")]
			public <>c()
			{
			}

			[Address(RVA="0x18D56D8", Offset="0x18D56D8", VA="0x18D56D8")]
			internal HomeShowcase <.cctor>b__65_0()
			{
				return null;
			}
		}
	}
}