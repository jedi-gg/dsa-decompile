using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluAds.Implementation.Json
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
			[Address(RVA="0x1554874", Offset="0x1554874", VA="0x1554874")]
			get
			{
				return new JsonToken();
			}
		}

		[Address(RVA="0x15516C0", Offset="0x15516C0", VA="0x15516C0")]
		public JsonParser()
		{
		}

		[Address(RVA="0x1554880", Offset="0x1554880", VA="0x1554880")]
		private void MoveNext()
		{
		}

		[Address(RVA="0x15550A0", Offset="0x15550A0", VA="0x15550A0")]
		private void Munch(Csdk.GluAds.Implementation.Json.TokenType token)
		{
		}

		[Address(RVA="0x15516C8", Offset="0x15516C8", VA="0x15516C8")]
		public JsonResult Parse(IEnumerable<JsonToken> tokens)
		{
			return new JsonResult();
		}

		[Address(RVA="0x1554D14", Offset="0x1554D14", VA="0x1554D14")]
		private void ParseArray(string key)
		{
		}

		[Address(RVA="0x15549C4", Offset="0x15549C4", VA="0x15549C4")]
		private void ParseObject(string key)
		{
		}

		[Address(RVA="0x15551C0", Offset="0x15551C0", VA="0x15551C0")]
		private string ParseString()
		{
			return null;
		}

		[Address(RVA="0x1555280", Offset="0x1555280", VA="0x1555280")]
		private void ParseValue(string key)
		{
		}

		[Address(RVA="0x155547C", Offset="0x155547C", VA="0x155547C")]
		private Exception ThrowInvalidJsonException(string message)
		{
			return null;
		}

		[Address(RVA="0x155504C", Offset="0x155504C", VA="0x155504C")]
		private Exception ThrowInvalidJsonException(string format, params object[] args)
		{
			return null;
		}
	}
}