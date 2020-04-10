using Il2CppDummyDll;
using System;

namespace Csdk.GluIAP.Implementation.Json
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
			[Address(RVA="0xF37C5C", Offset="0xF37C5C", VA="0xF37C5C")]
			get
			{
				return new bool();
			}
		}

		public bool IsBoolean
		{
			[Address(RVA="0xF37C6C", Offset="0xF37C6C", VA="0xF37C6C")]
			get
			{
				return new bool();
			}
		}

		public bool IsNull
		{
			[Address(RVA="0xF37C64", Offset="0xF37C64", VA="0xF37C64")]
			get
			{
				return new bool();
			}
		}

		public bool IsNumber
		{
			[Address(RVA="0xF37C7C", Offset="0xF37C7C", VA="0xF37C7C")]
			get
			{
				return new bool();
			}
		}

		public bool IsObject
		{
			[Address(RVA="0xF37C54", Offset="0xF37C54", VA="0xF37C54")]
			get
			{
				return new bool();
			}
		}

		public bool IsString
		{
			[Address(RVA="0xF37C74", Offset="0xF37C74", VA="0xF37C74")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x21E63C4", Offset="0x21E63C4", VA="0x21E63C4")]
		static JsonNode()
		{
		}

		[Address(RVA="0xF37C44", Offset="0xF37C44", VA="0xF37C44")]
		private JsonNode(object value, string key, int size)
		{
		}

		[Address(RVA="0x21E5EF4", Offset="0x21E5EF4", VA="0x21E5EF4")]
		public static JsonNode Array(int size, string key)
		{
			return new JsonNode();
		}

		[Address(RVA="0xF37C94", Offset="0xF37C94", VA="0xF37C94")]
		public bool AsBoolean()
		{
			return new bool();
		}

		[Address(RVA="0xF37C84", Offset="0xF37C84", VA="0xF37C84")]
		public decimal AsDecimal()
		{
			return new decimal();
		}

		[Address(RVA="0xF37C8C", Offset="0xF37C8C", VA="0xF37C8C")]
		public string AsString()
		{
			return null;
		}

		[Address(RVA="0x21E5DD4", Offset="0x21E5DD4", VA="0x21E5DD4")]
		public static JsonNode Create(object value, string key)
		{
			return new JsonNode();
		}

		[Address(RVA="0x21E5E68", Offset="0x21E5E68", VA="0x21E5E68")]
		public static JsonNode Object(int size, string key)
		{
			return new JsonNode();
		}
	}
}