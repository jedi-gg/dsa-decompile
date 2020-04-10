using Il2CppDummyDll;
using System;

namespace Csdk.GluMarketing.Implementation.Json
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
			[Address(RVA="0xF380A4", Offset="0xF380A4", VA="0xF380A4")]
			get
			{
				return new bool();
			}
		}

		public bool IsBoolean
		{
			[Address(RVA="0xF380B4", Offset="0xF380B4", VA="0xF380B4")]
			get
			{
				return new bool();
			}
		}

		public bool IsNull
		{
			[Address(RVA="0xF380AC", Offset="0xF380AC", VA="0xF380AC")]
			get
			{
				return new bool();
			}
		}

		public bool IsNumber
		{
			[Address(RVA="0xF380C4", Offset="0xF380C4", VA="0xF380C4")]
			get
			{
				return new bool();
			}
		}

		public bool IsObject
		{
			[Address(RVA="0xF3809C", Offset="0xF3809C", VA="0xF3809C")]
			get
			{
				return new bool();
			}
		}

		public bool IsString
		{
			[Address(RVA="0xF380BC", Offset="0xF380BC", VA="0xF380BC")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x21F0920", Offset="0x21F0920", VA="0x21F0920")]
		static JsonNode()
		{
		}

		[Address(RVA="0xF3808C", Offset="0xF3808C", VA="0xF3808C")]
		private JsonNode(object value, string key, int size)
		{
		}

		[Address(RVA="0x21F0450", Offset="0x21F0450", VA="0x21F0450")]
		public static JsonNode Array(int size, string key)
		{
			return new JsonNode();
		}

		[Address(RVA="0xF380DC", Offset="0xF380DC", VA="0xF380DC")]
		public bool AsBoolean()
		{
			return new bool();
		}

		[Address(RVA="0xF380CC", Offset="0xF380CC", VA="0xF380CC")]
		public decimal AsDecimal()
		{
			return new decimal();
		}

		[Address(RVA="0xF380D4", Offset="0xF380D4", VA="0xF380D4")]
		public string AsString()
		{
			return null;
		}

		[Address(RVA="0x21F0330", Offset="0x21F0330", VA="0x21F0330")]
		public static JsonNode Create(object value, string key)
		{
			return new JsonNode();
		}

		[Address(RVA="0x21F03C4", Offset="0x21F03C4", VA="0x21F03C4")]
		public static JsonNode Object(int size, string key)
		{
			return new JsonNode();
		}
	}
}