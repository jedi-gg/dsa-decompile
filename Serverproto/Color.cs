using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class Color : IMessage<Color>, IMessage, IEquatable<Color>, IDeepCloneable<Color>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<Color> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private int r_;

		[FieldOffset(Offset="0x0")]
		public const int GFieldNumber = 2;

		[FieldOffset(Offset="0x1C")]
		private int g_;

		[FieldOffset(Offset="0x0")]
		public const int BFieldNumber = 3;

		[FieldOffset(Offset="0x20")]
		private int b_;

		[FieldOffset(Offset="0x0")]
		public const int AFieldNumber = 4;

		[FieldOffset(Offset="0x24")]
		private float a_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096DF0", Offset="0x1096DF0")]
		public float A
		{
			[Address(RVA="0x1EE92A8", Offset="0x1EE92A8", VA="0x1EE92A8")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1EE92B0", Offset="0x1EE92B0", VA="0x1EE92B0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096DE0", Offset="0x1096DE0")]
		public int B
		{
			[Address(RVA="0x1EE9298", Offset="0x1EE9298", VA="0x1EE9298")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1EE92A0", Offset="0x1EE92A0", VA="0x1EE92A0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096DA0", Offset="0x1096DA0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE8FA8", Offset="0x1EE8FA8", VA="0x1EE8FA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096DD0", Offset="0x1096DD0")]
		public int G
		{
			[Address(RVA="0x1EE9288", Offset="0x1EE9288", VA="0x1EE9288")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1EE9290", Offset="0x1EE9290", VA="0x1EE9290")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096D90", Offset="0x1096D90")]
		public static MessageParser<Color> Parser
		{
			[Address(RVA="0x1EE8F40", Offset="0x1EE8F40", VA="0x1EE8F40")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096DB0", Offset="0x1096DB0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE90FC", Offset="0x1EE90FC", VA="0x1EE90FC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096DC0", Offset="0x1096DC0")]
		public int R
		{
			[Address(RVA="0x1EE9278", Offset="0x1EE9278", VA="0x1EE9278")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1EE9280", Offset="0x1EE9280", VA="0x1EE9280")]
			set
			{
			}
		}

		[Address(RVA="0x1EE9A1C", Offset="0x1EE9A1C", VA="0x1EE9A1C")]
		static Color()
		{
		}

		[Address(RVA="0x1EE9158", Offset="0x1EE9158", VA="0x1EE9158")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F48C", Offset="0x107F48C")]
		public Color()
		{
		}

		[Address(RVA="0x1EE9160", Offset="0x1EE9160", VA="0x1EE9160")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F49C", Offset="0x107F49C")]
		public Color(Color other)
		{
		}

		[Address(RVA="0x1EE9790", Offset="0x1EE9790", VA="0x1EE9790", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F50C", Offset="0x107F50C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE9218", Offset="0x1EE9218", VA="0x1EE9218", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F4AC", Offset="0x107F4AC")]
		public Color Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE92B8", Offset="0x1EE92B8", VA="0x1EE92B8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F4BC", Offset="0x107F4BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE932C", Offset="0x1EE932C", VA="0x1EE932C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F4CC", Offset="0x107F4CC")]
		public bool Equals(Color other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE9440", Offset="0x1EE9440", VA="0x1EE9440", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F4DC", Offset="0x107F4DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE98B8", Offset="0x1EE98B8", VA="0x1EE98B8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F51C", Offset="0x107F51C")]
		public void MergeFrom(Color other)
		{
		}

		[Address(RVA="0x1EE9920", Offset="0x1EE9920", VA="0x1EE9920", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F52C", Offset="0x107F52C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE9570", Offset="0x1EE9570", VA="0x1EE9570", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F4EC", Offset="0x107F4EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE95D8", Offset="0x1EE95D8", VA="0x1EE95D8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107F4FC", Offset="0x107F4FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FD88", Offset="0x104FD88")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static Color.<>c <>9;

			[Address(RVA="0x1EE9AF4", Offset="0x1EE9AF4", VA="0x1EE9AF4")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE9B58", Offset="0x1EE9B58", VA="0x1EE9B58")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE9B60", Offset="0x1EE9B60", VA="0x1EE9B60")]
			internal Color <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}