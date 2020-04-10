using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Csdk.GluIAP.Implementation.Json
{
	[Attribute(Name="DefaultMemberAttribute", RVA="0x1049638", Offset="0x1049638")]
	public struct JsonResult : IEnumerable<JsonResult>, IEnumerable
	{
		[FieldOffset(Offset="0x0")]
		private readonly static JsonResult Empty;

		[FieldOffset(Offset="0x10")]
		private readonly static IList<JsonResult> EmptyList;

		[FieldOffset(Offset="0x0")]
		private readonly IList<JsonNode> mNodes;

		[FieldOffset(Offset="0x8")]
		private readonly int mIndex;

		[FieldOffset(Offset="0xC")]
		private readonly int mEnd;

		public bool HasValue
		{
			[Address(RVA="0xF37CFC", Offset="0xF37CFC", VA="0xF37CFC")]
			get
			{
				return new bool();
			}
		}

		public bool IsArray
		{
			[Address(RVA="0xF37D14", Offset="0xF37D14", VA="0xF37D14")]
			get
			{
				return new bool();
			}
		}

		public bool IsBoolean
		{
			[Address(RVA="0xF37D24", Offset="0xF37D24", VA="0xF37D24")]
			get
			{
				return new bool();
			}
		}

		public bool IsNull
		{
			[Address(RVA="0xF37D1C", Offset="0xF37D1C", VA="0xF37D1C")]
			get
			{
				return new bool();
			}
		}

		public bool IsNumber
		{
			[Address(RVA="0xF37D34", Offset="0xF37D34", VA="0xF37D34")]
			get
			{
				return new bool();
			}
		}

		public bool IsObject
		{
			[Address(RVA="0xF37D0C", Offset="0xF37D0C", VA="0xF37D0C")]
			get
			{
				return new bool();
			}
		}

		public bool IsString
		{
			[Address(RVA="0xF37D2C", Offset="0xF37D2C", VA="0xF37D2C")]
			get
			{
				return new bool();
			}
		}

		public JsonResult Item(int index)
		{
			[Address(RVA="0xF37D3C", Offset="0xF37D3C", VA="0xF37D3C")]
			get
			{
				return new JsonResult();
			}
		}

		public JsonResult Item(string key)
		{
			[Address(RVA="0xF37D44", Offset="0xF37D44", VA="0xF37D44")]
			get
			{
				return new JsonResult();
			}
		}

		[Address(RVA="0x21E7DE4", Offset="0x21E7DE4", VA="0x21E7DE4")]
		static JsonResult()
		{
		}

		[Address(RVA="0xF37CE8", Offset="0xF37CE8", VA="0xF37CE8")]
		internal JsonResult(IList<JsonNode> nodes)
		{
		}

		[Address(RVA="0xF37CF4", Offset="0xF37CF4", VA="0xF37CF4")]
		private JsonResult(IList<JsonNode> nodes, int index)
		{
		}

		[Address(RVA="0xF37D8C", Offset="0xF37D8C", VA="0xF37D8C")]
		public bool AsBoolean()
		{
			return new bool();
		}

		[Address(RVA="0xF37D7C", Offset="0xF37D7C", VA="0xF37D7C")]
		public decimal AsDecimal()
		{
			return new decimal();
		}

		[Address(RVA="0xF37DA4", Offset="0xF37DA4", VA="0xF37DA4")]
		public IDictionary<string, JsonResult> AsDictionary()
		{
			return null;
		}

		[Address(RVA="0xF37D74", Offset="0xF37D74", VA="0xF37D74")]
		public double AsDouble()
		{
			return new double();
		}

		[Address(RVA="0xF37D9C", Offset="0xF37D9C", VA="0xF37D9C")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10749C4", Offset="0x10749C4")]
		public IEnumerable<JsonResult> AsEnumerable()
		{
			return null;
		}

		[Address(RVA="0xF37D5C", Offset="0xF37D5C", VA="0xF37D5C")]
		public int AsInt32()
		{
			return new int();
		}

		[Address(RVA="0xF37D64", Offset="0xF37D64", VA="0xF37D64")]
		public long AsInt64()
		{
			return new long();
		}

		[Address(RVA="0xF37D94", Offset="0xF37D94", VA="0xF37D94")]
		public IList<JsonResult> AsList()
		{
			return null;
		}

		[Address(RVA="0xF37D6C", Offset="0xF37D6C", VA="0xF37D6C")]
		public float AsSingle()
		{
			return new float();
		}

		[Address(RVA="0xF37D84", Offset="0xF37D84", VA="0xF37D84")]
		public string AsString()
		{
			return null;
		}

		[Address(RVA="0xF37D4C", Offset="0xF37D4C", VA="0xF37D4C")]
		public int Count()
		{
			return new int();
		}

		[Address(RVA="0xF37DCC", Offset="0xF37DCC", VA="0xF37DCC")]
		private JsonResult FromIndex(int index)
		{
			return new JsonResult();
		}

		[Address(RVA="0xF37D54", Offset="0xF37D54", VA="0xF37D54")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074960", Offset="0x1074960")]
		public IEnumerable<string> GetKeys()
		{
			return null;
		}

		[Address(RVA="0xF37DC4", Offset="0xF37DC4", VA="0xF37DC4")]
		private int GetNextNodeIndex(int index)
		{
			return new int();
		}

		[Address(RVA="0xF37DBC", Offset="0xF37DBC", VA="0xF37DBC")]
		private JsonNode GetNode()
		{
			return new JsonNode();
		}

		[Address(RVA="0x21E755C", Offset="0x21E755C", VA="0x21E755C")]
		public static implicit operator Int32(JsonResult result)
		{
			return new int();
		}

		[Address(RVA="0x21E75FC", Offset="0x21E75FC", VA="0x21E75FC")]
		public static implicit operator Int64(JsonResult result)
		{
			return new long();
		}

		[Address(RVA="0x21E769C", Offset="0x21E769C", VA="0x21E769C")]
		public static implicit operator Single(JsonResult result)
		{
			return new float();
		}

		[Address(RVA="0x21E773C", Offset="0x21E773C", VA="0x21E773C")]
		public static implicit operator Double(JsonResult result)
		{
			return new double();
		}

		[Address(RVA="0x21E77DC", Offset="0x21E77DC", VA="0x21E77DC")]
		public static implicit operator Decimal(JsonResult result)
		{
			return new decimal();
		}

		[Address(RVA="0x21E7800", Offset="0x21E7800", VA="0x21E7800")]
		public static implicit operator Boolean(JsonResult result)
		{
			return new bool();
		}

		[Address(RVA="0x21E7828", Offset="0x21E7828", VA="0x21E7828")]
		public static implicit operator String(JsonResult result)
		{
			return null;
		}

		[Address(RVA="0xF37DAC", Offset="0xF37DAC", VA="0xF37DAC", Slot="4")]
		private IEnumerator<JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluIAP.Implementation.Json.JsonResult>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0xF37DB4", Offset="0xF37DB4", VA="0xF37DB4", Slot="5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E4A8", Offset="0x104E4A8")]
		private sealed class <AsEnumerable>d__42 : IEnumerable<JsonResult>, IEnumerable, IEnumerator<JsonResult>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private JsonResult <>2__current;

			[FieldOffset(Offset="0x28")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x30")]
			public JsonResult <>4__this;

			[FieldOffset(Offset="0x40")]
			public JsonResult <>3__<>4__this;

			[FieldOffset(Offset="0x50")]
			private int <nodeIndex>5__2;

			private JsonResult System.Collections.Generic.IEnumerator<Csdk.GluIAP.Implementation.Json.JsonResult>.Current
			{
				[Address(RVA="0x21E7F90", Offset="0x21E7F90", VA="0x21E7F90", Slot="6")]
				[DebuggerHidden]
				get
				{
					return new JsonResult();
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x21E8004", Offset="0x21E8004", VA="0x21E8004", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x21E7A74", Offset="0x21E7A74", VA="0x21E7A74")]
			[DebuggerHidden]
			public <AsEnumerable>d__42(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x21E7E58", Offset="0x21E7E58", VA="0x21E7E58", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x21E8068", Offset="0x21E8068", VA="0x21E8068", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluIAP.Implementation.Json.JsonResult>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21E812C", Offset="0x21E812C", VA="0x21E812C", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21E7F9C", Offset="0x21E7F9C", VA="0x21E7F9C", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x21E7E54", Offset="0x21E7E54", VA="0x21E7E54", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E498", Offset="0x104E498")]
		private sealed class <GetKeys>d__33 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private string <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public JsonResult <>4__this;

			[FieldOffset(Offset="0x38")]
			public JsonResult <>3__<>4__this;

			[FieldOffset(Offset="0x48")]
			private int <nodeIndex>5__2;

			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Address(RVA="0x21E82B0", Offset="0x21E82B0", VA="0x21E82B0", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x21E8320", Offset="0x21E8320", VA="0x21E8320", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x21E78F8", Offset="0x21E78F8", VA="0x21E78F8")]
			[DebuggerHidden]
			public <GetKeys>d__33(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x21E8134", Offset="0x21E8134", VA="0x21E8134", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x21E8328", Offset="0x21E8328", VA="0x21E8328", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21E83EC", Offset="0x21E83EC", VA="0x21E83EC", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21E82B8", Offset="0x21E82B8", VA="0x21E82B8", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x21E8130", Offset="0x21E8130", VA="0x21E8130", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}