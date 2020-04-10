using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreItemGrant : IMessage<StoreItemGrant>, IMessage, IEquatable<StoreItemGrant>, IDeepCloneable<StoreItemGrant>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreItemGrant> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TitleLocKeyFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string titleLocKey_;

		[FieldOffset(Offset="0x0")]
		public const int OptionsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<StoreItemGrantOption> _repeated_options_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<StoreItemGrantOption> options_;

		[FieldOffset(Offset="0x0")]
		public const int PercentChanceFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private float percentChance_;

		[FieldOffset(Offset="0x0")]
		public const int IsClubGiftFieldNumber = 4;

		[FieldOffset(Offset="0x2C")]
		private bool isClubGift_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C938", Offset="0x109C938")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BDE884", Offset="0x1BDE884", VA="0x1BDE884")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C988", Offset="0x109C988")]
		public bool IsClubGift
		{
			[Address(RVA="0x1BDEC08", Offset="0x1BDEC08", VA="0x1BDEC08")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BDEC10", Offset="0x1BDEC10", VA="0x1BDEC10")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C968", Offset="0x109C968")]
		public RepeatedField<StoreItemGrantOption> Options
		{
			[Address(RVA="0x1BDEBF0", Offset="0x1BDEBF0", VA="0x1BDEBF0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C928", Offset="0x109C928")]
		public static MessageParser<StoreItemGrant> Parser
		{
			[Address(RVA="0x1BDE81C", Offset="0x1BDE81C", VA="0x1BDE81C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C948", Offset="0x109C948")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BDE974", Offset="0x1BDE974", VA="0x1BDE974", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C978", Offset="0x109C978")]
		public float PercentChance
		{
			[Address(RVA="0x1BDEBF8", Offset="0x1BDEBF8", VA="0x1BDEBF8")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1BDEC00", Offset="0x1BDEC00", VA="0x1BDEC00")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C958", Offset="0x109C958")]
		public string TitleLocKey
		{
			[Address(RVA="0x1BDEB78", Offset="0x1BDEB78", VA="0x1BDEB78")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDEB80", Offset="0x1BDEB80", VA="0x1BDEB80")]
			set
			{
			}
		}

		[Address(RVA="0x1BDF518", Offset="0x1BDF518", VA="0x1BDF518")]
		static StoreItemGrant()
		{
		}

		[Address(RVA="0x1BDE9D0", Offset="0x1BDE9D0", VA="0x1BDE9D0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088CBC", Offset="0x1088CBC")]
		public StoreItemGrant()
		{
		}

		[Address(RVA="0x1BDEA50", Offset="0x1BDEA50", VA="0x1BDEA50")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088CCC", Offset="0x1088CCC")]
		public StoreItemGrant(StoreItemGrant other)
		{
		}

		[Address(RVA="0x1BDF19C", Offset="0x1BDF19C", VA="0x1BDF19C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088D3C", Offset="0x1088D3C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BDEB18", Offset="0x1BDEB18", VA="0x1BDEB18", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088CDC", Offset="0x1088CDC")]
		public StoreItemGrant Clone()
		{
			return null;
		}

		[Address(RVA="0x1BDEC1C", Offset="0x1BDEC1C", VA="0x1BDEC1C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088CEC", Offset="0x1088CEC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BDEC90", Offset="0x1BDEC90", VA="0x1BDEC90", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088CFC", Offset="0x1088CFC")]
		public bool Equals(StoreItemGrant other)
		{
			return new bool();
		}

		[Address(RVA="0x1BDEDD8", Offset="0x1BDEDD8", VA="0x1BDEDD8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088D0C", Offset="0x1088D0C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BDF2D0", Offset="0x1BDF2D0", VA="0x1BDF2D0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088D4C", Offset="0x1088D4C")]
		public void MergeFrom(StoreItemGrant other)
		{
		}

		[Address(RVA="0x1BDF3A8", Offset="0x1BDF3A8", VA="0x1BDF3A8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088D5C", Offset="0x1088D5C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BDEF3C", Offset="0x1BDEF3C", VA="0x1BDEF3C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088D1C", Offset="0x1088D1C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BDEFA4", Offset="0x1BDEFA4", VA="0x1BDEFA4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088D2C", Offset="0x1088D2C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050B68", Offset="0x1050B68")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreItemGrant.<>c <>9;

			[Address(RVA="0x1BDF6A0", Offset="0x1BDF6A0", VA="0x1BDF6A0")]
			static <>c()
			{
			}

			[Address(RVA="0x1BDF704", Offset="0x1BDF704", VA="0x1BDF704")]
			public <>c()
			{
			}

			[Address(RVA="0x1BDF70C", Offset="0x1BDF70C", VA="0x1BDF70C")]
			internal StoreItemGrant <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}