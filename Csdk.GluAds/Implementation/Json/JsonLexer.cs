using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Csdk.GluAds.Implementation.Json
{
	internal class JsonLexer
	{
		[FieldOffset(Offset="0x0")]
		private const string Whitespaces = " \t\r\n";

		[FieldOffset(Offset="0x0")]
		private readonly static IDictionary<char, Csdk.GluAds.Implementation.Json.TokenType> OtherTokens;

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

		[Address(RVA="0x15538F0", Offset="0x15538F0", VA="0x15538F0")]
		static JsonLexer()
		{
		}

		[Address(RVA="0x1552B70", Offset="0x1552B70", VA="0x1552B70")]
		private JsonLexer()
		{
		}

		[Address(RVA="0x1552E4C", Offset="0x1552E4C", VA="0x1552E4C")]
		private static IDictionary<char, char> CreateEscapedCharacters()
		{
			return null;
		}

		[Address(RVA="0x1552CBC", Offset="0x1552CBC", VA="0x1552CBC")]
		private static IDictionary<char, Csdk.GluAds.Implementation.Json.TokenType> CreateOtherTokens()
		{
			return null;
		}

		[Address(RVA="0x15530D4", Offset="0x15530D4", VA="0x15530D4")]
		private bool DoTryMunchString(ref string value)
		{
			return new bool();
		}

		[Address(RVA="0x1553398", Offset="0x1553398", VA="0x1553398")]
		private StringBuilder GetEmptyStringBuilder()
		{
			return null;
		}

		[Address(RVA="0x1552F7C", Offset="0x1552F7C", VA="0x1552F7C")]
		private void MunchWhitespaces()
		{
		}

		[Address(RVA="0x1553038", Offset="0x1553038", VA="0x1553038")]
		private char PeekCurrentCharacter()
		{
			return new char();
		}

		[Address(RVA="0x1552BDC", Offset="0x1552BDC", VA="0x1552BDC")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074DBC", Offset="0x1074DBC")]
		public IEnumerable<JsonToken> Process(string text)
		{
			return null;
		}

		[Address(RVA="0x1551654", Offset="0x1551654", VA="0x1551654")]
		public static IEnumerable<JsonToken> ProcessString(string str)
		{
			return null;
		}

		[Address(RVA="0x1553410", Offset="0x1553410", VA="0x1553410")]
		private bool ReadNextCharacter(ref char c)
		{
			return new bool();
		}

		[Address(RVA="0x1553644", Offset="0x1553644", VA="0x1553644")]
		private bool TryMunchBool(ref bool value)
		{
			return new bool();
		}

		[Address(RVA="0x15536DC", Offset="0x15536DC", VA="0x15536DC")]
		private bool TryMunchKeyword(string str)
		{
			return new bool();
		}

		[Address(RVA="0x1553480", Offset="0x1553480", VA="0x1553480")]
		private bool TryMunchNumber(ref decimal value)
		{
			return new bool();
		}

		[Address(RVA="0x15537AC", Offset="0x15537AC", VA="0x15537AC")]
		private bool TryMunchOther(ref Csdk.GluAds.Implementation.Json.TokenType tokenType)
		{
			return new bool();
		}

		[Address(RVA="0x1553070", Offset="0x1553070", VA="0x1553070")]
		private bool TryMunchString(ref string value)
		{
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E558", Offset="0x104E558")]
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
			private Csdk.GluAds.Implementation.Json.TokenType <otherValue>5__5;

			private JsonToken System.Collections.Generic.IEnumerator<Csdk.GluAds.Implementation.Json.JsonToken>.Current
			{
				[Address(RVA="0x1553CC4", Offset="0x1553CC4", VA="0x1553CC4", Slot="6")]
				[DebuggerHidden]
				get
				{
					return new JsonToken();
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1553D38", Offset="0x1553D38", VA="0x1553D38", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1552C84", Offset="0x1552C84", VA="0x1552C84")]
			[DebuggerHidden]
			public <Process>d__10(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x15539A4", Offset="0x15539A4", VA="0x15539A4", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1553D9C", Offset="0x1553D9C", VA="0x1553D9C", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JsonToken> System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonToken>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1553E5C", Offset="0x1553E5C", VA="0x1553E5C", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1553CD0", Offset="0x1553CD0", VA="0x1553CD0", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x15539A0", Offset="0x15539A0", VA="0x15539A0", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}