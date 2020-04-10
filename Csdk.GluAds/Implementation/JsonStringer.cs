using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csdk.GluAds.Implementation
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

		[Address(RVA="0x15575D4", Offset="0x15575D4", VA="0x15575D4")]
		static JsonStringer()
		{
		}

		[Address(RVA="0x15567EC", Offset="0x15567EC", VA="0x15567EC")]
		public JsonStringer()
		{
		}

		[Address(RVA="0x1556858", Offset="0x1556858", VA="0x1556858")]
		public JsonStringer Array()
		{
			return null;
		}

		[Address(RVA="0x15573EC", Offset="0x15573EC", VA="0x15573EC")]
		private static IDictionary<char, string> CreateEscapedCharacters()
		{
			return null;
		}

		[Address(RVA="0x155704C", Offset="0x155704C", VA="0x155704C")]
		private void DoAppendString(string val)
		{
		}

		[Address(RVA="0x1557004", Offset="0x1557004", VA="0x1557004")]
		private void DoBeginScope(char scope, string key)
		{
		}

		[Address(RVA="0x1556938", Offset="0x1556938", VA="0x1556938")]
		private void DoEndScope(char scopeBegin, char scopeEnd)
		{
		}

		[Address(RVA="0x1556910", Offset="0x1556910", VA="0x1556910")]
		public JsonStringer EndArray()
		{
			return null;
		}

		[Address(RVA="0x1556988", Offset="0x1556988", VA="0x1556988")]
		public JsonStringer EndObject()
		{
			return null;
		}

		[Address(RVA="0x1556884", Offset="0x1556884", VA="0x1556884")]
		public JsonStringer KeyArray(string key)
		{
			return null;
		}

		[Address(RVA="0x15569B8", Offset="0x15569B8", VA="0x15569B8")]
		public JsonStringer KeyNull(string key)
		{
			return null;
		}

		[Address(RVA="0x15568E0", Offset="0x15568E0", VA="0x15568E0")]
		public JsonStringer KeyObject(string key)
		{
			return null;
		}

		[Address(RVA="0x1556A4C", Offset="0x1556A4C", VA="0x1556A4C")]
		public JsonStringer KeyValue(string key, bool val)
		{
			return null;
		}

		[Address(RVA="0x1556AFC", Offset="0x1556AFC", VA="0x1556AFC")]
		public JsonStringer KeyValue(string key, long val)
		{
			return null;
		}

		[Address(RVA="0x1556BCC", Offset="0x1556BCC", VA="0x1556BCC")]
		public JsonStringer KeyValue(string key, ulong val)
		{
			return null;
		}

		[Address(RVA="0x1556C94", Offset="0x1556C94", VA="0x1556C94")]
		public JsonStringer KeyValue(string key, double val)
		{
			return null;
		}

		[Address(RVA="0x1556E1C", Offset="0x1556E1C", VA="0x1556E1C")]
		public JsonStringer KeyValue(string key, decimal val)
		{
			return null;
		}

		[Address(RVA="0x1556EF4", Offset="0x1556EF4", VA="0x1556EF4")]
		public JsonStringer KeyValue(string key, string val)
		{
			return null;
		}

		[Address(RVA="0x15569B0", Offset="0x15569B0", VA="0x15569B0")]
		public JsonStringer Null()
		{
			return null;
		}

		[Address(RVA="0x15568B4", Offset="0x15568B4", VA="0x15568B4")]
		public JsonStringer Object()
		{
			return null;
		}

		[Address(RVA="0x1556F44", Offset="0x1556F44", VA="0x1556F44")]
		private void PreCommon(string key, bool newHasElements)
		{
		}

		[Address(RVA="0x15573B8", Offset="0x15573B8", VA="0x15573B8", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1556A40", Offset="0x1556A40", VA="0x1556A40")]
		public JsonStringer Value(bool val)
		{
			return null;
		}

		[Address(RVA="0x1556AEC", Offset="0x1556AEC", VA="0x1556AEC")]
		public JsonStringer Value(long val)
		{
			return null;
		}

		[Address(RVA="0x1556BBC", Offset="0x1556BBC", VA="0x1556BBC")]
		public JsonStringer Value(ulong val)
		{
			return null;
		}

		[Address(RVA="0x1556C8C", Offset="0x1556C8C", VA="0x1556C8C")]
		public JsonStringer Value(double val)
		{
			return null;
		}

		[Address(RVA="0x1556E04", Offset="0x1556E04", VA="0x1556E04")]
		public JsonStringer Value(decimal val)
		{
			return null;
		}

		[Address(RVA="0x1556EE4", Offset="0x1556EE4", VA="0x1556EE4")]
		public JsonStringer Value(string val)
		{
			return null;
		}
	}
}