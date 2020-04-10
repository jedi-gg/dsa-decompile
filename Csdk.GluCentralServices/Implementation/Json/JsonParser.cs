using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluCentralServices.Implementation.Json
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
			[Address(RVA="0x21D689C", Offset="0x21D689C", VA="0x21D689C")]
			get
			{
				return new JsonToken();
			}
		}

		[Address(RVA="0x21D6894", Offset="0x21D6894", VA="0x21D6894")]
		public JsonParser()
		{
		}

		[Address(RVA="0x21D6B74", Offset="0x21D6B74", VA="0x21D6B74")]
		private void MoveNext()
		{
		}

		[Address(RVA="0x21D7394", Offset="0x21D7394", VA="0x21D7394")]
		private void Munch(Csdk.GluCentralServices.Implementation.Json.TokenType token)
		{
		}

		[Address(RVA="0x21D68A8", Offset="0x21D68A8", VA="0x21D68A8")]
		public JsonResult Parse(IEnumerable<JsonToken> tokens)
		{
			return new JsonResult();
		}

		[Address(RVA="0x21D7008", Offset="0x21D7008", VA="0x21D7008")]
		private void ParseArray(string key)
		{
		}

		[Address(RVA="0x21D6CB8", Offset="0x21D6CB8", VA="0x21D6CB8")]
		private void ParseObject(string key)
		{
		}

		[Address(RVA="0x21D74B4", Offset="0x21D74B4", VA="0x21D74B4")]
		private string ParseString()
		{
			return null;
		}

		[Address(RVA="0x21D7574", Offset="0x21D7574", VA="0x21D7574")]
		private void ParseValue(string key)
		{
		}

		[Address(RVA="0x21D777C", Offset="0x21D777C", VA="0x21D777C")]
		private Exception ThrowInvalidJsonException(string message)
		{
			return null;
		}

		[Address(RVA="0x21D7340", Offset="0x21D7340", VA="0x21D7340")]
		private Exception ThrowInvalidJsonException(string format, params object[] args)
		{
			return null;
		}
	}
}