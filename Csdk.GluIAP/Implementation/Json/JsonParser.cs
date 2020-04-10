using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluIAP.Implementation.Json
{
	internal class JsonParser
	{
		[FieldOffset(Offset="0x10")]
		private IList<JsonNode> mNodes;

		[FieldOffset(Offset="0x18")]
		private IEnumerator<JsonToken> mEnum;

		[FieldOffset(Offset="0x20")]
		private JsonToken mCurrentToken;

		private JsonToken CurrentToken
		{
			[Address(RVA="0x21E6478", Offset="0x21E6478", VA="0x21E6478")]
			get
			{
				return new JsonToken();
			}
		}

		[Address(RVA="0x21E32C4", Offset="0x21E32C4", VA="0x21E32C4")]
		public JsonParser()
		{
		}

		[Address(RVA="0x21E6484", Offset="0x21E6484", VA="0x21E6484")]
		private void MoveNext()
		{
		}

		[Address(RVA="0x21E6CA4", Offset="0x21E6CA4", VA="0x21E6CA4")]
		private void Munch(Csdk.GluIAP.Implementation.Json.TokenType token)
		{
		}

		[Address(RVA="0x21E32CC", Offset="0x21E32CC", VA="0x21E32CC")]
		public JsonResult Parse(IEnumerable<JsonToken> tokens)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21E6918", Offset="0x21E6918", VA="0x21E6918")]
		private void ParseArray(string key)
		{
		}

		[Address(RVA="0x21E65C8", Offset="0x21E65C8", VA="0x21E65C8")]
		private void ParseObject(string key)
		{
		}

		[Address(RVA="0x21E6DC4", Offset="0x21E6DC4", VA="0x21E6DC4")]
		private string ParseString()
		{
			return null;
		}

		[Address(RVA="0x21E6E84", Offset="0x21E6E84", VA="0x21E6E84")]
		private void ParseValue(string key)
		{
		}

		[Address(RVA="0x21E7080", Offset="0x21E7080", VA="0x21E7080")]
		private Exception ThrowInvalidJsonException(string message)
		{
			return null;
		}

		[Address(RVA="0x21E6C50", Offset="0x21E6C50", VA="0x21E6C50")]
		private Exception ThrowInvalidJsonException(string format, params object[] args)
		{
			return null;
		}
	}
}