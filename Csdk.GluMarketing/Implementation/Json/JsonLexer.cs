using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Csdk.GluMarketing.Implementation.Json
{
	internal class JsonLexer
	{
		[FieldOffset(Offset="0x0")]
		private const string Whitespaces = " \t\r\n";

		[FieldOffset(Offset="0x0")]
		private readonly static IDictionary<char, Csdk.GluMarketing.Implementation.Json.TokenType> OtherTokens;

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

		[Address(RVA="0x21EF9F8", Offset="0x21EF9F8", VA="0x21EF9F8")]
		static JsonLexer()
		{
		}

		[Address(RVA="0x21EEC78", Offset="0x21EEC78", VA="0x21EEC78")]
		private JsonLexer()
		{
		}

		[Address(RVA="0x21EEF54", Offset="0x21EEF54", VA="0x21EEF54")]
		private static IDictionary<char, char> CreateEscapedCharacters()
		{
			return null;
		}

		[Address(RVA="0x21EEDC4", Offset="0x21EEDC4", VA="0x21EEDC4")]
		private static IDictionary<char, Csdk.GluMarketing.Implementation.Json.TokenType> CreateOtherTokens()
		{
			return null;
		}

		[Address(RVA="0x21EF1DC", Offset="0x21EF1DC", VA="0x21EF1DC")]
		private bool DoTryMunchString(ref string value)
		{
			return new bool();
		}

		[Address(RVA="0x21EF4A0", Offset="0x21EF4A0", VA="0x21EF4A0")]
		private StringBuilder GetEmptyStringBuilder()
		{
			return null;
		}

		[Address(RVA="0x21EF084", Offset="0x21EF084", VA="0x21EF084")]
		private void MunchWhitespaces()
		{
		}

		[Address(RVA="0x21EF140", Offset="0x21EF140", VA="0x21EF140")]
		private char PeekCurrentCharacter()
		{
			return new char();
		}

		[Address(RVA="0x21EECE4", Offset="0x21EECE4", VA="0x21EECE4")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074620", Offset="0x1074620")]
		public IEnumerable<JsonToken> Process(string text)
		{
			return null;
		}

		[Address(RVA="0x21ED77C", Offset="0x21ED77C", VA="0x21ED77C")]
		public static IEnumerable<JsonToken> ProcessString(string str)
		{
			return null;
		}

		[Address(RVA="0x21EF518", Offset="0x21EF518", VA="0x21EF518")]
		private bool ReadNextCharacter(ref char c)
		{
			return new bool();
		}

		[Address(RVA="0x21EF74C", Offset="0x21EF74C", VA="0x21EF74C")]
		private bool TryMunchBool(ref bool value)
		{
			return new bool();
		}

		[Address(RVA="0x21EF7E4", Offset="0x21EF7E4", VA="0x21EF7E4")]
		private bool TryMunchKeyword(string str)
		{
			return new bool();
		}

		[Address(RVA="0x21EF588", Offset="0x21EF588", VA="0x21EF588")]
		private bool TryMunchNumber(ref decimal value)
		{
			return new bool();
		}

		[Address(RVA="0x21EF8B4", Offset="0x21EF8B4", VA="0x21EF8B4")]
		private bool TryMunchOther(ref Csdk.GluMarketing.Implementation.Json.TokenType tokenType)
		{
			return new bool();
		}

		[Address(RVA="0x21EF178", Offset="0x21EF178", VA="0x21EF178")]
		private bool TryMunchString(ref string value)
		{
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E458", Offset="0x104E458")]
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
			private Csdk.GluMarketing.Implementation.Json.TokenType <otherValue>5__5;

			private JsonToken System.Collections.Generic.IEnumerator<Csdk.GluMarketing.Implementation.Json.JsonToken>.Current
			{
				[Address(RVA="0x21EFE24", Offset="0x21EFE24", VA="0x21EFE24", Slot="6")]
				[DebuggerHidden]
				get
				{
					return new JsonToken();
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x21EFE98", Offset="0x21EFE98", VA="0x21EFE98", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x21EED8C", Offset="0x21EED8C", VA="0x21EED8C")]
			[DebuggerHidden]
			public <Process>d__10(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x21EFAAC", Offset="0x21EFAAC", VA="0x21EFAAC", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x21EFEFC", Offset="0x21EFEFC", VA="0x21EFEFC", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JsonToken> System.Collections.Generic.IEnumerable<Csdk.GluMarketing.Implementation.Json.JsonToken>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21EFFBC", Offset="0x21EFFBC", VA="0x21EFFBC", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21EFE30", Offset="0x21EFE30", VA="0x21EFE30", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x21EFAA8", Offset="0x21EFAA8", VA="0x21EFAA8", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}