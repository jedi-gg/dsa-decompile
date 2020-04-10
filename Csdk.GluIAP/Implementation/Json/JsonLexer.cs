using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Csdk.GluIAP.Implementation.Json
{
	internal class JsonLexer
	{
		[FieldOffset(Offset="0x0")]
		private const string Whitespaces = " \t\r\n";

		[FieldOffset(Offset="0x0")]
		private readonly static IDictionary<char, Csdk.GluIAP.Implementation.Json.TokenType> OtherTokens;

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

		[Address(RVA="0x21E54F4", Offset="0x21E54F4", VA="0x21E54F4")]
		static JsonLexer()
		{
		}

		[Address(RVA="0x21E4774", Offset="0x21E4774", VA="0x21E4774")]
		private JsonLexer()
		{
		}

		[Address(RVA="0x21E4A50", Offset="0x21E4A50", VA="0x21E4A50")]
		private static IDictionary<char, char> CreateEscapedCharacters()
		{
			return null;
		}

		[Address(RVA="0x21E48C0", Offset="0x21E48C0", VA="0x21E48C0")]
		private static IDictionary<char, Csdk.GluIAP.Implementation.Json.TokenType> CreateOtherTokens()
		{
			return null;
		}

		[Address(RVA="0x21E4CD8", Offset="0x21E4CD8", VA="0x21E4CD8")]
		private bool DoTryMunchString(ref string value)
		{
			return new bool();
		}

		[Address(RVA="0x21E4F9C", Offset="0x21E4F9C", VA="0x21E4F9C")]
		private StringBuilder GetEmptyStringBuilder()
		{
			return null;
		}

		[Address(RVA="0x21E4B80", Offset="0x21E4B80", VA="0x21E4B80")]
		private void MunchWhitespaces()
		{
		}

		[Address(RVA="0x21E4C3C", Offset="0x21E4C3C", VA="0x21E4C3C")]
		private char PeekCurrentCharacter()
		{
			return new char();
		}

		[Address(RVA="0x21E47E0", Offset="0x21E47E0", VA="0x21E47E0")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10748FC", Offset="0x10748FC")]
		public IEnumerable<JsonToken> Process(string text)
		{
			return null;
		}

		[Address(RVA="0x21E3258", Offset="0x21E3258", VA="0x21E3258")]
		public static IEnumerable<JsonToken> ProcessString(string str)
		{
			return null;
		}

		[Address(RVA="0x21E5014", Offset="0x21E5014", VA="0x21E5014")]
		private bool ReadNextCharacter(ref char c)
		{
			return new bool();
		}

		[Address(RVA="0x21E5248", Offset="0x21E5248", VA="0x21E5248")]
		private bool TryMunchBool(ref bool value)
		{
			return new bool();
		}

		[Address(RVA="0x21E52E0", Offset="0x21E52E0", VA="0x21E52E0")]
		private bool TryMunchKeyword(string str)
		{
			return new bool();
		}

		[Address(RVA="0x21E5084", Offset="0x21E5084", VA="0x21E5084")]
		private bool TryMunchNumber(ref decimal value)
		{
			return new bool();
		}

		[Address(RVA="0x21E53B0", Offset="0x21E53B0", VA="0x21E53B0")]
		private bool TryMunchOther(ref Csdk.GluIAP.Implementation.Json.TokenType tokenType)
		{
			return new bool();
		}

		[Address(RVA="0x21E4C74", Offset="0x21E4C74", VA="0x21E4C74")]
		private bool TryMunchString(ref string value)
		{
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E488", Offset="0x104E488")]
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
			private Csdk.GluIAP.Implementation.Json.TokenType <otherValue>5__5;

			private JsonToken System.Collections.Generic.IEnumerator<Csdk.GluIAP.Implementation.Json.JsonToken>.Current
			{
				[Address(RVA="0x21E58C8", Offset="0x21E58C8", VA="0x21E58C8", Slot="6")]
				[DebuggerHidden]
				get
				{
					return new JsonToken();
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x21E593C", Offset="0x21E593C", VA="0x21E593C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x21E4888", Offset="0x21E4888", VA="0x21E4888")]
			[DebuggerHidden]
			public <Process>d__10(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x21E55A8", Offset="0x21E55A8", VA="0x21E55A8", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x21E59A0", Offset="0x21E59A0", VA="0x21E59A0", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JsonToken> System.Collections.Generic.IEnumerable<Csdk.GluIAP.Implementation.Json.JsonToken>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21E5A60", Offset="0x21E5A60", VA="0x21E5A60", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21E58D4", Offset="0x21E58D4", VA="0x21E58D4", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x21E55A4", Offset="0x21E55A4", VA="0x21E55A4", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}