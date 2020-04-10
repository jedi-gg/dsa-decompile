using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ShowVipProfileBgUpdated : IMessage<ShowVipProfileBgUpdated>, IMessage, IEquatable<ShowVipProfileBgUpdated>, IDeepCloneable<ShowVipProfileBgUpdated>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ShowVipProfileBgUpdated> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ShowVipProfileBgFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private bool showVipProfileBg_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AE80", Offset="0x109AE80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BD629C", Offset="0x1BD629C", VA="0x1BD629C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AE70", Offset="0x109AE70")]
		public static MessageParser<ShowVipProfileBgUpdated> Parser
		{
			[Address(RVA="0x1BD6234", Offset="0x1BD6234", VA="0x1BD6234")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AE90", Offset="0x109AE90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BD638C", Offset="0x1BD638C", VA="0x1BD638C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AEA0", Offset="0x109AEA0")]
		public bool ShowVipProfileBg
		{
			[Address(RVA="0x1BD64B4", Offset="0x1BD64B4", VA="0x1BD64B4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BD64BC", Offset="0x1BD64BC", VA="0x1BD64BC")]
			set
			{
			}
		}

		[Address(RVA="0x1BD67F0", Offset="0x1BD67F0", VA="0x1BD67F0")]
		static ShowVipProfileBgUpdated()
		{
		}

		[Address(RVA="0x1BD63E8", Offset="0x1BD63E8", VA="0x1BD63E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085DFC", Offset="0x1085DFC")]
		public ShowVipProfileBgUpdated()
		{
		}

		[Address(RVA="0x1BD63F0", Offset="0x1BD63F0", VA="0x1BD63F0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085E0C", Offset="0x1085E0C")]
		public ShowVipProfileBgUpdated(ShowVipProfileBgUpdated other)
		{
		}

		[Address(RVA="0x1BD66F8", Offset="0x1BD66F8", VA="0x1BD66F8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085E7C", Offset="0x1085E7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD6454", Offset="0x1BD6454", VA="0x1BD6454", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085E1C", Offset="0x1085E1C")]
		public ShowVipProfileBgUpdated Clone()
		{
			return null;
		}

		[Address(RVA="0x1BD64C8", Offset="0x1BD64C8", VA="0x1BD64C8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085E2C", Offset="0x1085E2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD653C", Offset="0x1BD653C", VA="0x1BD653C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085E3C", Offset="0x1085E3C")]
		public bool Equals(ShowVipProfileBgUpdated other)
		{
			return new bool();
		}

		[Address(RVA="0x1BD6588", Offset="0x1BD6588", VA="0x1BD6588", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085E4C", Offset="0x1085E4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD6730", Offset="0x1BD6730", VA="0x1BD6730", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085E8C", Offset="0x1085E8C")]
		public void MergeFrom(ShowVipProfileBgUpdated other)
		{
		}

		[Address(RVA="0x1BD6770", Offset="0x1BD6770", VA="0x1BD6770", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085E9C", Offset="0x1085E9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BD65EC", Offset="0x1BD65EC", VA="0x1BD65EC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085E5C", Offset="0x1085E5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BD6654", Offset="0x1BD6654", VA="0x1BD6654", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085E6C", Offset="0x1085E6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050718", Offset="0x1050718")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ShowVipProfileBgUpdated.<>c <>9;

			[Address(RVA="0x1BD68C8", Offset="0x1BD68C8", VA="0x1BD68C8")]
			static <>c()
			{
			}

			[Address(RVA="0x1BD692C", Offset="0x1BD692C", VA="0x1BD692C")]
			public <>c()
			{
			}

			[Address(RVA="0x1BD6934", Offset="0x1BD6934", VA="0x1BD6934")]
			internal ShowVipProfileBgUpdated <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}