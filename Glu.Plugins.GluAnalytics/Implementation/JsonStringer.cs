using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text;

namespace Glu.Plugins.GluAnalytics.Implementation
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

		[Address(RVA="0x14F2494", Offset="0x14F2494", VA="0x14F2494")]
		static JsonStringer()
		{
		}

		[Address(RVA="0x14F16AC", Offset="0x14F16AC", VA="0x14F16AC")]
		public JsonStringer()
		{
		}

		[Address(RVA="0x14F1718", Offset="0x14F1718", VA="0x14F1718")]
		public JsonStringer Array()
		{
			return null;
		}

		[Address(RVA="0x14F22AC", Offset="0x14F22AC", VA="0x14F22AC")]
		private static IDictionary<char, string> CreateEscapedCharacters()
		{
			return null;
		}

		[Address(RVA="0x14F1F0C", Offset="0x14F1F0C", VA="0x14F1F0C")]
		private void DoAppendString(string val)
		{
		}

		[Address(RVA="0x14F1EC4", Offset="0x14F1EC4", VA="0x14F1EC4")]
		private void DoBeginScope(char scope, string key)
		{
		}

		[Address(RVA="0x14F17F8", Offset="0x14F17F8", VA="0x14F17F8")]
		private void DoEndScope(char scopeBegin, char scopeEnd)
		{
		}

		[Address(RVA="0x14F17D0", Offset="0x14F17D0", VA="0x14F17D0")]
		public JsonStringer EndArray()
		{
			return null;
		}

		[Address(RVA="0x14F1848", Offset="0x14F1848", VA="0x14F1848")]
		public JsonStringer EndObject()
		{
			return null;
		}

		[Address(RVA="0x14F1744", Offset="0x14F1744", VA="0x14F1744")]
		public JsonStringer KeyArray(string key)
		{
			return null;
		}

		[Address(RVA="0x14F1878", Offset="0x14F1878", VA="0x14F1878")]
		public JsonStringer KeyNull(string key)
		{
			return null;
		}

		[Address(RVA="0x14F17A0", Offset="0x14F17A0", VA="0x14F17A0")]
		public JsonStringer KeyObject(string key)
		{
			return null;
		}

		[Address(RVA="0x14F190C", Offset="0x14F190C", VA="0x14F190C")]
		public JsonStringer KeyValue(string key, bool val)
		{
			return null;
		}

		[Address(RVA="0x14F19BC", Offset="0x14F19BC", VA="0x14F19BC")]
		public JsonStringer KeyValue(string key, long val)
		{
			return null;
		}

		[Address(RVA="0x14F1A8C", Offset="0x14F1A8C", VA="0x14F1A8C")]
		public JsonStringer KeyValue(string key, ulong val)
		{
			return null;
		}

		[Address(RVA="0x14F1B54", Offset="0x14F1B54", VA="0x14F1B54")]
		public JsonStringer KeyValue(string key, double val)
		{
			return null;
		}

		[Address(RVA="0x14F1CDC", Offset="0x14F1CDC", VA="0x14F1CDC")]
		public JsonStringer KeyValue(string key, decimal val)
		{
			return null;
		}

		[Address(RVA="0x14F1DB4", Offset="0x14F1DB4", VA="0x14F1DB4")]
		public JsonStringer KeyValue(string key, string val)
		{
			return null;
		}

		[Address(RVA="0x14F1870", Offset="0x14F1870", VA="0x14F1870")]
		public JsonStringer Null()
		{
			return null;
		}

		[Address(RVA="0x14F1774", Offset="0x14F1774", VA="0x14F1774")]
		public JsonStringer Object()
		{
			return null;
		}

		[Address(RVA="0x14F1E04", Offset="0x14F1E04", VA="0x14F1E04")]
		private void PreCommon(string key, bool newHasElements)
		{
		}

		[Address(RVA="0x14F2278", Offset="0x14F2278", VA="0x14F2278", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14F1900", Offset="0x14F1900", VA="0x14F1900")]
		public JsonStringer Value(bool val)
		{
			return null;
		}

		[Address(RVA="0x14F19AC", Offset="0x14F19AC", VA="0x14F19AC")]
		public JsonStringer Value(long val)
		{
			return null;
		}

		[Address(RVA="0x14F1A7C", Offset="0x14F1A7C", VA="0x14F1A7C")]
		public JsonStringer Value(ulong val)
		{
			return null;
		}

		[Address(RVA="0x14F1B4C", Offset="0x14F1B4C", VA="0x14F1B4C")]
		public JsonStringer Value(double val)
		{
			return null;
		}

		[Address(RVA="0x14F1CC4", Offset="0x14F1CC4", VA="0x14F1CC4")]
		public JsonStringer Value(decimal val)
		{
			return null;
		}

		[Address(RVA="0x14F1DA4", Offset="0x14F1DA4", VA="0x14F1DA4")]
		public JsonStringer Value(string val)
		{
			return null;
		}
	}
}