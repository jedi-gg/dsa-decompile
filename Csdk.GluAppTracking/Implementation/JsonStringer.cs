using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csdk.GluAppTracking.Implementation
{
	public class JsonStringer
	{
		[FieldOffset(Offset="0x0")]
		private const char RootScope = '.';

		[FieldOffset(Offset="0x0")]
		private readonly static IDictionary<char, string> EscapedCharacters;

		[FieldOffset(Offset="0x10")]
		private readonly StringBuilder sb;

		[FieldOffset(Offset="0x18")]
		private bool hasElements;

		[Address(RVA="0x155ADBC", Offset="0x155ADBC", VA="0x155ADBC")]
		static JsonStringer()
		{
		}

		[Address(RVA="0x1559FD4", Offset="0x1559FD4", VA="0x1559FD4")]
		public JsonStringer()
		{
		}

		[Address(RVA="0x155A040", Offset="0x155A040", VA="0x155A040")]
		public JsonStringer Array()
		{
			return null;
		}

		[Address(RVA="0x155ABD4", Offset="0x155ABD4", VA="0x155ABD4")]
		private static IDictionary<char, string> CreateEscapedCharacters()
		{
			return null;
		}

		[Address(RVA="0x155A834", Offset="0x155A834", VA="0x155A834")]
		private void DoAppendString(string val)
		{
		}

		[Address(RVA="0x155A7EC", Offset="0x155A7EC", VA="0x155A7EC")]
		private void DoBeginScope(char scope, string key)
		{
		}

		[Address(RVA="0x155A120", Offset="0x155A120", VA="0x155A120")]
		private void DoEndScope(char scopeBegin, char scopeEnd)
		{
		}

		[Address(RVA="0x155A0F8", Offset="0x155A0F8", VA="0x155A0F8")]
		public JsonStringer EndArray()
		{
			return null;
		}

		[Address(RVA="0x155A170", Offset="0x155A170", VA="0x155A170")]
		public JsonStringer EndObject()
		{
			return null;
		}

		[Address(RVA="0x155A06C", Offset="0x155A06C", VA="0x155A06C")]
		public JsonStringer KeyArray(string key)
		{
			return null;
		}

		[Address(RVA="0x155A1A0", Offset="0x155A1A0", VA="0x155A1A0")]
		public JsonStringer KeyNull(string key)
		{
			return null;
		}

		[Address(RVA="0x155A0C8", Offset="0x155A0C8", VA="0x155A0C8")]
		public JsonStringer KeyObject(string key)
		{
			return null;
		}

		[Address(RVA="0x155A234", Offset="0x155A234", VA="0x155A234")]
		public JsonStringer KeyValue(string key, bool val)
		{
			return null;
		}

		[Address(RVA="0x155A2E4", Offset="0x155A2E4", VA="0x155A2E4")]
		public JsonStringer KeyValue(string key, long val)
		{
			return null;
		}

		[Address(RVA="0x155A3B4", Offset="0x155A3B4", VA="0x155A3B4")]
		public JsonStringer KeyValue(string key, ulong val)
		{
			return null;
		}

		[Address(RVA="0x155A47C", Offset="0x155A47C", VA="0x155A47C")]
		public JsonStringer KeyValue(string key, double val)
		{
			return null;
		}

		[Address(RVA="0x155A604", Offset="0x155A604", VA="0x155A604")]
		public JsonStringer KeyValue(string key, decimal val)
		{
			return null;
		}

		[Address(RVA="0x155A6DC", Offset="0x155A6DC", VA="0x155A6DC")]
		public JsonStringer KeyValue(string key, string val)
		{
			return null;
		}

		[Address(RVA="0x155A198", Offset="0x155A198", VA="0x155A198")]
		public JsonStringer Null()
		{
			return null;
		}

		[Address(RVA="0x155A09C", Offset="0x155A09C", VA="0x155A09C")]
		public JsonStringer Object()
		{
			return null;
		}

		[Address(RVA="0x155A72C", Offset="0x155A72C", VA="0x155A72C")]
		private void PreCommon(string key, bool newHasElements)
		{
		}

		[Address(RVA="0x155ABA0", Offset="0x155ABA0", VA="0x155ABA0", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x155A228", Offset="0x155A228", VA="0x155A228")]
		public JsonStringer Value(bool val)
		{
			return null;
		}

		[Address(RVA="0x155A2D4", Offset="0x155A2D4", VA="0x155A2D4")]
		public JsonStringer Value(long val)
		{
			return null;
		}

		[Address(RVA="0x155A3A4", Offset="0x155A3A4", VA="0x155A3A4")]
		public JsonStringer Value(ulong val)
		{
			return null;
		}

		[Address(RVA="0x155A474", Offset="0x155A474", VA="0x155A474")]
		public JsonStringer Value(double val)
		{
			return null;
		}

		[Address(RVA="0x155A5EC", Offset="0x155A5EC", VA="0x155A5EC")]
		public JsonStringer Value(decimal val)
		{
			return null;
		}

		[Address(RVA="0x155A6CC", Offset="0x155A6CC", VA="0x155A6CC")]
		public JsonStringer Value(string val)
		{
			return null;
		}
	}
}