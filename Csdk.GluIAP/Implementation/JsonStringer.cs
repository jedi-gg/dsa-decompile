using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csdk.GluIAP.Implementation
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

		[Address(RVA="0x21E91D8", Offset="0x21E91D8", VA="0x21E91D8")]
		static JsonStringer()
		{
		}

		[Address(RVA="0x21E83F0", Offset="0x21E83F0", VA="0x21E83F0")]
		public JsonStringer()
		{
		}

		[Address(RVA="0x21E845C", Offset="0x21E845C", VA="0x21E845C")]
		public JsonStringer Array()
		{
			return null;
		}

		[Address(RVA="0x21E8FF0", Offset="0x21E8FF0", VA="0x21E8FF0")]
		private static IDictionary<char, string> CreateEscapedCharacters()
		{
			return null;
		}

		[Address(RVA="0x21E8C50", Offset="0x21E8C50", VA="0x21E8C50")]
		private void DoAppendString(string val)
		{
		}

		[Address(RVA="0x21E8C08", Offset="0x21E8C08", VA="0x21E8C08")]
		private void DoBeginScope(char scope, string key)
		{
		}

		[Address(RVA="0x21E853C", Offset="0x21E853C", VA="0x21E853C")]
		private void DoEndScope(char scopeBegin, char scopeEnd)
		{
		}

		[Address(RVA="0x21E8514", Offset="0x21E8514", VA="0x21E8514")]
		public JsonStringer EndArray()
		{
			return null;
		}

		[Address(RVA="0x21E858C", Offset="0x21E858C", VA="0x21E858C")]
		public JsonStringer EndObject()
		{
			return null;
		}

		[Address(RVA="0x21E8488", Offset="0x21E8488", VA="0x21E8488")]
		public JsonStringer KeyArray(string key)
		{
			return null;
		}

		[Address(RVA="0x21E85BC", Offset="0x21E85BC", VA="0x21E85BC")]
		public JsonStringer KeyNull(string key)
		{
			return null;
		}

		[Address(RVA="0x21E84E4", Offset="0x21E84E4", VA="0x21E84E4")]
		public JsonStringer KeyObject(string key)
		{
			return null;
		}

		[Address(RVA="0x21E8650", Offset="0x21E8650", VA="0x21E8650")]
		public JsonStringer KeyValue(string key, bool val)
		{
			return null;
		}

		[Address(RVA="0x21E8700", Offset="0x21E8700", VA="0x21E8700")]
		public JsonStringer KeyValue(string key, long val)
		{
			return null;
		}

		[Address(RVA="0x21E87D0", Offset="0x21E87D0", VA="0x21E87D0")]
		public JsonStringer KeyValue(string key, ulong val)
		{
			return null;
		}

		[Address(RVA="0x21E8898", Offset="0x21E8898", VA="0x21E8898")]
		public JsonStringer KeyValue(string key, double val)
		{
			return null;
		}

		[Address(RVA="0x21E8A20", Offset="0x21E8A20", VA="0x21E8A20")]
		public JsonStringer KeyValue(string key, decimal val)
		{
			return null;
		}

		[Address(RVA="0x21E8AF8", Offset="0x21E8AF8", VA="0x21E8AF8")]
		public JsonStringer KeyValue(string key, string val)
		{
			return null;
		}

		[Address(RVA="0x21E85B4", Offset="0x21E85B4", VA="0x21E85B4")]
		public JsonStringer Null()
		{
			return null;
		}

		[Address(RVA="0x21E84B8", Offset="0x21E84B8", VA="0x21E84B8")]
		public JsonStringer Object()
		{
			return null;
		}

		[Address(RVA="0x21E8B48", Offset="0x21E8B48", VA="0x21E8B48")]
		private void PreCommon(string key, bool newHasElements)
		{
		}

		[Address(RVA="0x21E8FBC", Offset="0x21E8FBC", VA="0x21E8FBC", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x21E8644", Offset="0x21E8644", VA="0x21E8644")]
		public JsonStringer Value(bool val)
		{
			return null;
		}

		[Address(RVA="0x21E86F0", Offset="0x21E86F0", VA="0x21E86F0")]
		public JsonStringer Value(long val)
		{
			return null;
		}

		[Address(RVA="0x21E87C0", Offset="0x21E87C0", VA="0x21E87C0")]
		public JsonStringer Value(ulong val)
		{
			return null;
		}

		[Address(RVA="0x21E8890", Offset="0x21E8890", VA="0x21E8890")]
		public JsonStringer Value(double val)
		{
			return null;
		}

		[Address(RVA="0x21E8A08", Offset="0x21E8A08", VA="0x21E8A08")]
		public JsonStringer Value(decimal val)
		{
			return null;
		}

		[Address(RVA="0x21E8AE8", Offset="0x21E8AE8", VA="0x21E8AE8")]
		public JsonStringer Value(string val)
		{
			return null;
		}
	}
}