using Il2CppDummyDll;
using System;

namespace Csdk.GluCentralServices.Implementation.Json
{
	internal struct JsonNode
	{
		[FieldOffset(Offset="0x0")]
		public readonly string Key;

		[FieldOffset(Offset="0x8")]
		public readonly int Size;

		[FieldOffset(Offset="0x0")]
		private readonly static object ObjectValue;

		[FieldOffset(Offset="0x8")]
		private readonly static object ArrayValue;

		[FieldOffset(Offset="0x10")]
		private readonly static object NullValue;

		[FieldOffset(Offset="0x10")]
		private readonly object Value;

		public bool IsArray
		{
			[Address(RVA="0xF377B8", Offset="0xF377B8", VA="0xF377B8")]
			get
			{
				return new bool();
			}
		}

		public bool IsBoolean
		{
			[Address(RVA="0xF377C8", Offset="0xF377C8", VA="0xF377C8")]
			get
			{
				return new bool();
			}
		}

		public bool IsNull
		{
			[Address(RVA="0xF377C0", Offset="0xF377C0", VA="0xF377C0")]
			get
			{
				return new bool();
			}
		}

		public bool IsNumber
		{
			[Address(RVA="0xF377D8", Offset="0xF377D8", VA="0xF377D8")]
			get
			{
				return new bool();
			}
		}

		public bool IsObject
		{
			[Address(RVA="0xF377B0", Offset="0xF377B0", VA="0xF377B0")]
			get
			{
				return new bool();
			}
		}

		public bool IsString
		{
			[Address(RVA="0xF377D0", Offset="0xF377D0", VA="0xF377D0")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x21D67E0", Offset="0x21D67E0", VA="0x21D67E0")]
		static JsonNode()
		{
		}

		[Address(RVA="0xF377A0", Offset="0xF377A0", VA="0xF377A0")]
		private JsonNode(object value, string key, int size)
		{
		}

		[Address(RVA="0x21D6310", Offset="0x21D6310", VA="0x21D6310")]
		public static JsonNode Array(int size, string key)
		{
			return new JsonNode();
		}

		[Address(RVA="0xF377F0", Offset="0xF377F0", VA="0xF377F0")]
		public bool AsBoolean()
		{
			return new bool();
		}

		[Address(RVA="0xF377E0", Offset="0xF377E0", VA="0xF377E0")]
		public decimal AsDecimal()
		{
			return new decimal();
		}

		[Address(RVA="0xF377E8", Offset="0xF377E8", VA="0xF377E8")]
		public string AsString()
		{
			return null;
		}

		[Address(RVA="0x21D61F0", Offset="0x21D61F0", VA="0x21D61F0")]
		public static JsonNode Create(object value, string key)
		{
			return new JsonNode();
		}

		[Address(RVA="0x21D6284", Offset="0x21D6284", VA="0x21D6284")]
		public static JsonNode Object(int size, string key)
		{
			return new JsonNode();
		}
	}
}