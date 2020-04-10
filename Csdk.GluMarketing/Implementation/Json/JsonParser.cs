using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluMarketing.Implementation.Json
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
			[Address(RVA="0x21F09D4", Offset="0x21F09D4", VA="0x21F09D4")]
			get
			{
				return new JsonToken();
			}
		}

		[Address(RVA="0x21ED7E8", Offset="0x21ED7E8", VA="0x21ED7E8")]
		public JsonParser()
		{
		}

		[Address(RVA="0x21F09E0", Offset="0x21F09E0", VA="0x21F09E0")]
		private void MoveNext()
		{
		}

		[Address(RVA="0x21F1220", Offset="0x21F1220", VA="0x21F1220")]
		private void Munch(Csdk.GluMarketing.Implementation.Json.TokenType token)
		{
		}

		[Address(RVA="0x21ED7F0", Offset="0x21ED7F0", VA="0x21ED7F0")]
		public JsonResult Parse(IEnumerable<JsonToken> tokens)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21F0E94", Offset="0x21F0E94", VA="0x21F0E94")]
		private void ParseArray(string key)
		{
		}

		[Address(RVA="0x21F0B44", Offset="0x21F0B44", VA="0x21F0B44")]
		private void ParseObject(string key)
		{
		}

		[Address(RVA="0x21F1340", Offset="0x21F1340", VA="0x21F1340")]
		private string ParseString()
		{
			return null;
		}

		[Address(RVA="0x21F1400", Offset="0x21F1400", VA="0x21F1400")]
		private void ParseValue(string key)
		{
		}

		[Address(RVA="0x21F15FC", Offset="0x21F15FC", VA="0x21F15FC")]
		private Exception ThrowInvalidJsonException(string message)
		{
			return null;
		}

		[Address(RVA="0x21F11CC", Offset="0x21F11CC", VA="0x21F11CC")]
		private Exception ThrowInvalidJsonException(string format, params object[] args)
		{
			return null;
		}
	}
}