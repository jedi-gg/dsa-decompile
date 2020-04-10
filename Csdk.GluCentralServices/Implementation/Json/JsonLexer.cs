using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Csdk.GluCentralServices.Implementation.Json
{
	internal class JsonLexer
	{
		[FieldOffset(Offset="0x0")]
		private const string Whitespaces = " \t\r\n";

		[FieldOffset(Offset="0x0")]
		private readonly static IDictionary<char, Csdk.GluCentralServices.Implementation.Json.TokenType> OtherTokens;

		[FieldOffset(Offset="0x8")]
		private readonly static IDictionary<char, char> EscapedCharacters;

		[FieldOffset(Offset="0x10")]
		private readonly static object TrueValue;

		[FieldOffset(Offset="0x18")]
		private readonly static object FalseValue;

		[FieldOffset(Offset="0x10")]
		private readonly StringBuilder mStringBuilder;

		[FieldOffset(Offset="0x18")]
		private string mCurrentString;

		[FieldOffset(Offset="0x20")]
		private int mCurrentStringOffset;

		[Address(RVA="0x155E948", Offset="0x155E948", VA="0x155E948")]
		static JsonLexer()
		{
		}

		[Address(RVA="0x155DBC8", Offset="0x155DBC8", VA="0x155DBC8")]
		private JsonLexer()
		{
		}

		[Address(RVA="0x155DEA4", Offset="0x155DEA4", VA="0x155DEA4")]
		private static IDictionary<char, char> CreateEscapedCharacters()
		{
			return null;
		}

		[Address(RVA="0x155DD14", Offset="0x155DD14", VA="0x155DD14")]
		private static IDictionary<char, Csdk.GluCentralServices.Implementation.Json.TokenType> CreateOtherTokens()
		{
			return null;
		}

		[Address(RVA="0x155E12C", Offset="0x155E12C", VA="0x155E12C")]
		private bool DoTryMunchString(ref string value)
		{
			return new bool();
		}

		[Address(RVA="0x155E3F0", Offset="0x155E3F0", VA="0x155E3F0")]
		private StringBuilder GetEmptyStringBuilder()
		{
			return null;
		}

		[Address(RVA="0x155DFD4", Offset="0x155DFD4", VA="0x155DFD4")]
		private void MunchWhitespaces()
		{
		}

		[Address(RVA="0x155E090", Offset="0x155E090", VA="0x155E090")]
		private char PeekCurrentCharacter()
		{
			return new char();
		}

		[Address(RVA="0x155DC34", Offset="0x155DC34", VA="0x155DC34")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074AD8", Offset="0x1074AD8")]
		public IEnumerable<JsonToken> Process(string text)
		{
			return null;
		}

		[Address(RVA="0x155CF60", Offset="0x155CF60", VA="0x155CF60")]
		public static IEnumerable<JsonToken> ProcessString(string str)
		{
			return null;
		}

		[Address(RVA="0x155E468", Offset="0x155E468", VA="0x155E468")]
		private bool ReadNextCharacter(ref char c)
		{
			return new bool();
		}

		[Address(RVA="0x155E69C", Offset="0x155E69C", VA="0x155E69C")]
		private bool TryMunchBool(ref bool value)
		{
			return new bool();
		}

		[Address(RVA="0x155E734", Offset="0x155E734", VA="0x155E734")]
		private bool TryMunchKeyword(string str)
		{
			return new bool();
		}

		[Address(RVA="0x155E4D8", Offset="0x155E4D8", VA="0x155E4D8")]
		private bool TryMunchNumber(ref decimal value)
		{
			return new bool();
		}

		[Address(RVA="0x155E804", Offset="0x155E804", VA="0x155E804")]
		private bool TryMunchOther(ref Csdk.GluCentralServices.Implementation.Json.TokenType tokenType)
		{
			return new bool();
		}

		[Address(RVA="0x155E0C8", Offset="0x155E0C8", VA="0x155E0C8")]
		private bool TryMunchString(ref string value)
		{
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E4B8", Offset="0x104E4B8")]
		private sealed class <Process>d__10 : IEnumerable<JsonToken>, IEnumerable, IEnumerator<JsonToken>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private JsonToken <>2__current;

			[FieldOffset(Offset="0x28")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x30")]
			private string text;

			[FieldOffset(Offset="0x38")]
			public string <>3__text;

			[FieldOffset(Offset="0x40")]
			public JsonLexer <>4__this;

			[FieldOffset(Offset="0x48")]
			private string <stringValue>5__2;

			[FieldOffset(Offset="0x50")]
			private decimal <numberValue>5__3;

			[FieldOffset(Offset="0x60")]
			private bool <boolValue>5__4;

			[FieldOffset(Offset="0x64")]
			private Csdk.GluCentralServices.Implementation.Json.TokenType <otherValue>5__5;

			private JsonToken System.Collections.Generic.IEnumerator<Csdk.GluCentralServices.Implementation.Json.JsonToken>.Current
			{
				[Address(RVA="0x155ED74", Offset="0x155ED74", VA="0x155ED74", Slot="6")]
				[DebuggerHidden]
				get
				{
					return new JsonToken();
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x155EDE8", Offset="0x155EDE8", VA="0x155EDE8", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x155DCDC", Offset="0x155DCDC", VA="0x155DCDC")]
			[DebuggerHidden]
			public <Process>d__10(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x155E9FC", Offset="0x155E9FC", VA="0x155E9FC", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x155EE4C", Offset="0x155EE4C", VA="0x155EE4C", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JsonToken> System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonToken>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x155EF0C", Offset="0x155EF0C", VA="0x155EF0C", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x155ED80", Offset="0x155ED80", VA="0x155ED80", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x155E9F8", Offset="0x155E9F8", VA="0x155E9F8", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}