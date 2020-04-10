using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csdk.GluCentralServices.Implementation
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

		[Address(RVA="0x21D9EF4", Offset="0x21D9EF4", VA="0x21D9EF4")]
		static JsonStringer()
		{
		}

		[Address(RVA="0x21D910C", Offset="0x21D910C", VA="0x21D910C")]
		public JsonStringer()
		{
		}

		[Address(RVA="0x21D9178", Offset="0x21D9178", VA="0x21D9178")]
		public JsonStringer Array()
		{
			return null;
		}

		[Address(RVA="0x21D9D0C", Offset="0x21D9D0C", VA="0x21D9D0C")]
		private static IDictionary<char, string> CreateEscapedCharacters()
		{
			return null;
		}

		[Address(RVA="0x21D996C", Offset="0x21D996C", VA="0x21D996C")]
		private void DoAppendString(string val)
		{
		}

		[Address(RVA="0x21D9924", Offset="0x21D9924", VA="0x21D9924")]
		private void DoBeginScope(char scope, string key)
		{
		}

		[Address(RVA="0x21D9258", Offset="0x21D9258", VA="0x21D9258")]
		private void DoEndScope(char scopeBegin, char scopeEnd)
		{
		}

		[Address(RVA="0x21D9230", Offset="0x21D9230", VA="0x21D9230")]
		public JsonStringer EndArray()
		{
			return null;
		}

		[Address(RVA="0x21D92A8", Offset="0x21D92A8", VA="0x21D92A8")]
		public JsonStringer EndObject()
		{
			return null;
		}

		[Address(RVA="0x21D91A4", Offset="0x21D91A4", VA="0x21D91A4")]
		public JsonStringer KeyArray(string key)
		{
			return null;
		}

		[Address(RVA="0x21D92D8", Offset="0x21D92D8", VA="0x21D92D8")]
		public JsonStringer KeyNull(string key)
		{
			return null;
		}

		[Address(RVA="0x21D9200", Offset="0x21D9200", VA="0x21D9200")]
		public JsonStringer KeyObject(string key)
		{
			return null;
		}

		[Address(RVA="0x21D936C", Offset="0x21D936C", VA="0x21D936C")]
		public JsonStringer KeyValue(string key, bool val)
		{
			return null;
		}

		[Address(RVA="0x21D941C", Offset="0x21D941C", VA="0x21D941C")]
		public JsonStringer KeyValue(string key, long val)
		{
			return null;
		}

		[Address(RVA="0x21D94EC", Offset="0x21D94EC", VA="0x21D94EC")]
		public JsonStringer KeyValue(string key, ulong val)
		{
			return null;
		}

		[Address(RVA="0x21D95B4", Offset="0x21D95B4", VA="0x21D95B4")]
		public JsonStringer KeyValue(string key, double val)
		{
			return null;
		}

		[Address(RVA="0x21D973C", Offset="0x21D973C", VA="0x21D973C")]
		public JsonStringer KeyValue(string key, decimal val)
		{
			return null;
		}

		[Address(RVA="0x21D9814", Offset="0x21D9814", VA="0x21D9814")]
		public JsonStringer KeyValue(string key, string val)
		{
			return null;
		}

		[Address(RVA="0x21D92D0", Offset="0x21D92D0", VA="0x21D92D0")]
		public JsonStringer Null()
		{
			return null;
		}

		[Address(RVA="0x21D91D4", Offset="0x21D91D4", VA="0x21D91D4")]
		public JsonStringer Object()
		{
			return null;
		}

		[Address(RVA="0x21D9864", Offset="0x21D9864", VA="0x21D9864")]
		private void PreCommon(string key, bool newHasElements)
		{
		}

		[Address(RVA="0x21D9CD8", Offset="0x21D9CD8", VA="0x21D9CD8", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x21D9360", Offset="0x21D9360", VA="0x21D9360")]
		public JsonStringer Value(bool val)
		{
			return null;
		}

		[Address(RVA="0x21D940C", Offset="0x21D940C", VA="0x21D940C")]
		public JsonStringer Value(long val)
		{
			return null;
		}

		[Address(RVA="0x21D94DC", Offset="0x21D94DC", VA="0x21D94DC")]
		public JsonStringer Value(ulong val)
		{
			return null;
		}

		[Address(RVA="0x21D95AC", Offset="0x21D95AC", VA="0x21D95AC")]
		public JsonStringer Value(double val)
		{
			return null;
		}

		[Address(RVA="0x21D9724", Offset="0x21D9724", VA="0x21D9724")]
		public JsonStringer Value(decimal val)
		{
			return null;
		}

		[Address(RVA="0x21D9804", Offset="0x21D9804", VA="0x21D9804")]
		public JsonStringer Value(string val)
		{
			return null;
		}
	}
}