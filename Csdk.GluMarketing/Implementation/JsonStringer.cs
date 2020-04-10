using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csdk.GluMarketing.Implementation
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

		[Address(RVA="0x153889C", Offset="0x153889C", VA="0x153889C")]
		static JsonStringer()
		{
		}

		[Address(RVA="0x1537AB4", Offset="0x1537AB4", VA="0x1537AB4")]
		public JsonStringer()
		{
		}

		[Address(RVA="0x1537B20", Offset="0x1537B20", VA="0x1537B20")]
		public JsonStringer Array()
		{
			return null;
		}

		[Address(RVA="0x15386B4", Offset="0x15386B4", VA="0x15386B4")]
		private static IDictionary<char, string> CreateEscapedCharacters()
		{
			return null;
		}

		[Address(RVA="0x1538314", Offset="0x1538314", VA="0x1538314")]
		private void DoAppendString(string val)
		{
		}

		[Address(RVA="0x15382CC", Offset="0x15382CC", VA="0x15382CC")]
		private void DoBeginScope(char scope, string key)
		{
		}

		[Address(RVA="0x1537C00", Offset="0x1537C00", VA="0x1537C00")]
		private void DoEndScope(char scopeBegin, char scopeEnd)
		{
		}

		[Address(RVA="0x1537BD8", Offset="0x1537BD8", VA="0x1537BD8")]
		public JsonStringer EndArray()
		{
			return null;
		}

		[Address(RVA="0x1537C50", Offset="0x1537C50", VA="0x1537C50")]
		public JsonStringer EndObject()
		{
			return null;
		}

		[Address(RVA="0x1537B4C", Offset="0x1537B4C", VA="0x1537B4C")]
		public JsonStringer KeyArray(string key)
		{
			return null;
		}

		[Address(RVA="0x1537C80", Offset="0x1537C80", VA="0x1537C80")]
		public JsonStringer KeyNull(string key)
		{
			return null;
		}

		[Address(RVA="0x1537BA8", Offset="0x1537BA8", VA="0x1537BA8")]
		public JsonStringer KeyObject(string key)
		{
			return null;
		}

		[Address(RVA="0x1537D14", Offset="0x1537D14", VA="0x1537D14")]
		public JsonStringer KeyValue(string key, bool val)
		{
			return null;
		}

		[Address(RVA="0x1537DC4", Offset="0x1537DC4", VA="0x1537DC4")]
		public JsonStringer KeyValue(string key, long val)
		{
			return null;
		}

		[Address(RVA="0x1537E94", Offset="0x1537E94", VA="0x1537E94")]
		public JsonStringer KeyValue(string key, ulong val)
		{
			return null;
		}

		[Address(RVA="0x1537F5C", Offset="0x1537F5C", VA="0x1537F5C")]
		public JsonStringer KeyValue(string key, double val)
		{
			return null;
		}

		[Address(RVA="0x15380E4", Offset="0x15380E4", VA="0x15380E4")]
		public JsonStringer KeyValue(string key, decimal val)
		{
			return null;
		}

		[Address(RVA="0x15381BC", Offset="0x15381BC", VA="0x15381BC")]
		public JsonStringer KeyValue(string key, string val)
		{
			return null;
		}

		[Address(RVA="0x1537C78", Offset="0x1537C78", VA="0x1537C78")]
		public JsonStringer Null()
		{
			return null;
		}

		[Address(RVA="0x1537B7C", Offset="0x1537B7C", VA="0x1537B7C")]
		public JsonStringer Object()
		{
			return null;
		}

		[Address(RVA="0x153820C", Offset="0x153820C", VA="0x153820C")]
		private void PreCommon(string key, bool newHasElements)
		{
		}

		[Address(RVA="0x1538680", Offset="0x1538680", VA="0x1538680", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1537D08", Offset="0x1537D08", VA="0x1537D08")]
		public JsonStringer Value(bool val)
		{
			return null;
		}

		[Address(RVA="0x1537DB4", Offset="0x1537DB4", VA="0x1537DB4")]
		public JsonStringer Value(long val)
		{
			return null;
		}

		[Address(RVA="0x1537E84", Offset="0x1537E84", VA="0x1537E84")]
		public JsonStringer Value(ulong val)
		{
			return null;
		}

		[Address(RVA="0x1537F54", Offset="0x1537F54", VA="0x1537F54")]
		public JsonStringer Value(double val)
		{
			return null;
		}

		[Address(RVA="0x15380CC", Offset="0x15380CC", VA="0x15380CC")]
		public JsonStringer Value(decimal val)
		{
			return null;
		}

		[Address(RVA="0x15381AC", Offset="0x15381AC", VA="0x15381AC")]
		public JsonStringer Value(string val)
		{
			return null;
		}
	}
}