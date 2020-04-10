using Il2CppDummyDll;
using System;

namespace Csdk.GluAds.Implementation.Json
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
			[Address(RVA="0xF05824", Offset="0xF05824", VA="0xF05824")]
			get
			{
				return new bool();
			}
		}

		public bool IsBoolean
		{
			[Address(RVA="0xF05834", Offset="0xF05834", VA="0xF05834")]
			get
			{
				return new bool();
			}
		}

		public bool IsNull
		{
			[Address(RVA="0xF0582C", Offset="0xF0582C", VA="0xF0582C")]
			get
			{
				return new bool();
			}
		}

		public bool IsNumber
		{
			[Address(RVA="0xF05844", Offset="0xF05844", VA="0xF05844")]
			get
			{
				return new bool();
			}
		}

		public bool IsObject
		{
			[Address(RVA="0xF0581C", Offset="0xF0581C", VA="0xF0581C")]
			get
			{
				return new bool();
			}
		}

		public bool IsString
		{
			[Address(RVA="0xF0583C", Offset="0xF0583C", VA="0xF0583C")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x15547C0", Offset="0x15547C0", VA="0x15547C0")]
		static JsonNode()
		{
		}

		[Address(RVA="0xF0580C", Offset="0xF0580C", VA="0xF0580C")]
		private JsonNode(object value, string key, int size)
		{
		}

		[Address(RVA="0x15542F0", Offset="0x15542F0", VA="0x15542F0")]
		public static JsonNode Array(int size, string key)
		{
			return new JsonNode();
		}

		[Address(RVA="0xF0585C", Offset="0xF0585C", VA="0xF0585C")]
		public bool AsBoolean()
		{
			return new bool();
		}

		[Address(RVA="0xF0584C", Offset="0xF0584C", VA="0xF0584C")]
		public decimal AsDecimal()
		{
			return new decimal();
		}

		[Address(RVA="0xF05854", Offset="0xF05854", VA="0xF05854")]
		public string AsString()
		{
			return null;
		}

		[Address(RVA="0x15541D0", Offset="0x15541D0", VA="0x15541D0")]
		public static JsonNode Create(object value, string key)
		{
			return new JsonNode();
		}

		[Address(RVA="0x1554264", Offset="0x1554264", VA="0x1554264")]
		public static JsonNode Object(int size, string key)
		{
			return new JsonNode();
		}
	}
}