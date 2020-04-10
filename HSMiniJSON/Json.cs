using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HSMiniJSON
{
	public static class Json
	{
		[Address(RVA="0x12E0BE4", Offset="0x12E0BE4", VA="0x12E0BE4")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Address(RVA="0x12E0D34", Offset="0x12E0D34", VA="0x12E0D34")]
		public static string Serialize(object obj)
		{
			return null;
		}

		private sealed class Parser : IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private const string WORD_BREAK = "{}[],:\"";

			[FieldOffset(Offset="0x10")]
			private StringReader json;

			private char NextChar
			{
				[Address(RVA="0x12E1824", Offset="0x12E1824", VA="0x12E1824")]
				get
				{
					return new char();
				}
			}

			private Json.Parser.TOKEN NextToken
			{
				[Address(RVA="0x12E109C", Offset="0x12E109C", VA="0x12E109C")]
				get
				{
					return new Json.Parser.TOKEN();
				}
			}

			private string NextWord
			{
				[Address(RVA="0x12E18B4", Offset="0x12E18B4", VA="0x12E18B4")]
				get
				{
					return null;
				}
			}

			private char PeekChar
			{
				[Address(RVA="0x12E1A58", Offset="0x12E1A58", VA="0x12E1A58")]
				get
				{
					return new char();
				}
			}

			[Address(RVA="0x12E0E80", Offset="0x12E0E80", VA="0x12E0E80")]
			private Parser(string jsonString)
			{
			}

			[Address(RVA="0x12E0F24", Offset="0x12E0F24", VA="0x12E0F24", Slot="4")]
			public void Dispose()
			{
			}

			[Address(RVA="0x12E1990", Offset="0x12E1990", VA="0x12E1990")]
			private void EatWhitespace()
			{
			}

			[Address(RVA="0x12E0DDC", Offset="0x12E0DDC", VA="0x12E0DDC")]
			public static bool IsWordBreak(char c)
			{
				return new bool();
			}

			[Address(RVA="0x12E0BF0", Offset="0x12E0BF0", VA="0x12E0BF0")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Address(RVA="0x12E157C", Offset="0x12E157C", VA="0x12E157C")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Address(RVA="0x12E1668", Offset="0x12E1668", VA="0x12E1668")]
			private object ParseByToken(Json.Parser.TOKEN token)
			{
				return null;
			}

			[Address(RVA="0x12E1744", Offset="0x12E1744", VA="0x12E1744")]
			private object ParseNumber()
			{
				return null;
			}

			[Address(RVA="0x12E0F60", Offset="0x12E0F60", VA="0x12E0F60")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Address(RVA="0x12E1278", Offset="0x12E1278", VA="0x12E1278")]
			private string ParseString()
			{
				return null;
			}

			[Address(RVA="0x12E0EFC", Offset="0x12E0EFC", VA="0x12E0EFC")]
			private object ParseValue()
			{
				return null;
			}

			private enum TOKEN
			{
				[FieldOffset(Offset="0x0")]
				NONE,
				[FieldOffset(Offset="0x0")]
				CURLY_OPEN,
				[FieldOffset(Offset="0x0")]
				CURLY_CLOSE,
				[FieldOffset(Offset="0x0")]
				SQUARED_OPEN,
				[FieldOffset(Offset="0x0")]
				SQUARED_CLOSE,
				[FieldOffset(Offset="0x0")]
				COLON,
				[FieldOffset(Offset="0x0")]
				COMMA,
				[FieldOffset(Offset="0x0")]
				STRING,
				[FieldOffset(Offset="0x0")]
				NUMBER,
				[FieldOffset(Offset="0x0")]
				TRUE,
				[FieldOffset(Offset="0x0")]
				FALSE,
				[FieldOffset(Offset="0x0")]
				NULL
			}
		}

		private sealed class Serializer
		{
			[FieldOffset(Offset="0x10")]
			private StringBuilder builder;

			[Address(RVA="0x12E1AE8", Offset="0x12E1AE8", VA="0x12E1AE8")]
			private Serializer()
			{
			}

			[Address(RVA="0x12E0D38", Offset="0x12E0D38", VA="0x12E0D38")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Address(RVA="0x12E1FE0", Offset="0x12E1FE0", VA="0x12E1FE0")]
			private void SerializeArray(IList anArray)
			{
			}

			[Address(RVA="0x12E22DC", Offset="0x12E22DC", VA="0x12E22DC")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Address(RVA="0x12E2720", Offset="0x12E2720", VA="0x12E2720")]
			private void SerializeOther(object value)
			{
			}

			[Address(RVA="0x12E1D10", Offset="0x12E1D10", VA="0x12E1D10")]
			private void SerializeString(string str)
			{
			}

			[Address(RVA="0x12E1B54", Offset="0x12E1B54", VA="0x12E1B54")]
			private void SerializeValue(object value)
			{
			}
		}
	}
}