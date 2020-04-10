using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Csdk.GluAds.Implementation.Json
{
	[Attribute(Name="DefaultMemberAttribute", RVA="0x10496D8", Offset="0x10496D8")]
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
			[Address(RVA="0xF058C4", Offset="0xF058C4", VA="0xF058C4")]
			get
			{
				return new bool();
			}
		}

		public bool IsArray
		{
			[Address(RVA="0xF058DC", Offset="0xF058DC", VA="0xF058DC")]
			get
			{
				return new bool();
			}
		}

		public bool IsBoolean
		{
			[Address(RVA="0xF058EC", Offset="0xF058EC", VA="0xF058EC")]
			get
			{
				return new bool();
			}
		}

		public bool IsNull
		{
			[Address(RVA="0xF058E4", Offset="0xF058E4", VA="0xF058E4")]
			get
			{
				return new bool();
			}
		}

		public bool IsNumber
		{
			[Address(RVA="0xF058FC", Offset="0xF058FC", VA="0xF058FC")]
			get
			{
				return new bool();
			}
		}

		public bool IsObject
		{
			[Address(RVA="0xF058D4", Offset="0xF058D4", VA="0xF058D4")]
			get
			{
				return new bool();
			}
		}

		public bool IsString
		{
			[Address(RVA="0xF058F4", Offset="0xF058F4", VA="0xF058F4")]
			get
			{
				return new bool();
			}
		}

		public JsonResult Item(int index)
		{
			[Address(RVA="0xF05904", Offset="0xF05904", VA="0xF05904")]
			get
			{
				return new JsonResult();
			}
		}

		public JsonResult Item(string key)
		{
			[Address(RVA="0xF0590C", Offset="0xF0590C", VA="0xF0590C")]
			get
			{
				return new JsonResult();
			}
		}

		[Address(RVA="0x15561E0", Offset="0x15561E0", VA="0x15561E0")]
		static JsonResult()
		{
		}

		[Address(RVA="0xF058B0", Offset="0xF058B0", VA="0xF058B0")]
		internal JsonResult(IList<JsonNode> nodes)
		{
		}

		[Address(RVA="0xF058BC", Offset="0xF058BC", VA="0xF058BC")]
		private JsonResult(IList<JsonNode> nodes, int index)
		{
		}

		[Address(RVA="0xF05954", Offset="0xF05954", VA="0xF05954")]
		public bool AsBoolean()
		{
			return new bool();
		}

		[Address(RVA="0xF05944", Offset="0xF05944", VA="0xF05944")]
		public decimal AsDecimal()
		{
			return new decimal();
		}

		[Address(RVA="0xF0596C", Offset="0xF0596C", VA="0xF0596C")]
		public IDictionary<string, JsonResult> AsDictionary()
		{
			return null;
		}

		[Address(RVA="0xF0593C", Offset="0xF0593C", VA="0xF0593C")]
		public double AsDouble()
		{
			return new double();
		}

		[Address(RVA="0xF05964", Offset="0xF05964", VA="0xF05964")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074E84", Offset="0x1074E84")]
		public IEnumerable<JsonResult> AsEnumerable()
		{
			return null;
		}

		[Address(RVA="0xF05924", Offset="0xF05924", VA="0xF05924")]
		public int AsInt32()
		{
			return new int();
		}

		[Address(RVA="0xF0592C", Offset="0xF0592C", VA="0xF0592C")]
		public long AsInt64()
		{
			return new long();
		}

		[Address(RVA="0xF0595C", Offset="0xF0595C", VA="0xF0595C")]
		public IList<JsonResult> AsList()
		{
			return null;
		}

		[Address(RVA="0xF05934", Offset="0xF05934", VA="0xF05934")]
		public float AsSingle()
		{
			return new float();
		}

		[Address(RVA="0xF0594C", Offset="0xF0594C", VA="0xF0594C")]
		public string AsString()
		{
			return null;
		}

		[Address(RVA="0xF05914", Offset="0xF05914", VA="0xF05914")]
		public int Count()
		{
			return new int();
		}

		[Address(RVA="0xF05994", Offset="0xF05994", VA="0xF05994")]
		private JsonResult FromIndex(int index)
		{
			return new JsonResult();
		}

		[Address(RVA="0xF0591C", Offset="0xF0591C", VA="0xF0591C")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074E20", Offset="0x1074E20")]
		public IEnumerable<string> GetKeys()
		{
			return null;
		}

		[Address(RVA="0xF0598C", Offset="0xF0598C", VA="0xF0598C")]
		private int GetNextNodeIndex(int index)
		{
			return new int();
		}

		[Address(RVA="0xF05984", Offset="0xF05984", VA="0xF05984")]
		private JsonNode GetNode()
		{
			return new JsonNode();
		}

		[Address(RVA="0x1555958", Offset="0x1555958", VA="0x1555958")]
		public static implicit operator Int32(JsonResult result)
		{
			return new int();
		}

		[Address(RVA="0x15559F8", Offset="0x15559F8", VA="0x15559F8")]
		public static implicit operator Int64(JsonResult result)
		{
			return new long();
		}

		[Address(RVA="0x1555A98", Offset="0x1555A98", VA="0x1555A98")]
		public static implicit operator Single(JsonResult result)
		{
			return new float();
		}

		[Address(RVA="0x1555B38", Offset="0x1555B38", VA="0x1555B38")]
		public static implicit operator Double(JsonResult result)
		{
			return new double();
		}

		[Address(RVA="0x1555BD8", Offset="0x1555BD8", VA="0x1555BD8")]
		public static implicit operator Decimal(JsonResult result)
		{
			return new decimal();
		}

		[Address(RVA="0x1555BFC", Offset="0x1555BFC", VA="0x1555BFC")]
		public static implicit operator Boolean(JsonResult result)
		{
			return new bool();
		}

		[Address(RVA="0x1555C24", Offset="0x1555C24", VA="0x1555C24")]
		public static implicit operator String(JsonResult result)
		{
			return null;
		}

		[Address(RVA="0xF05974", Offset="0xF05974", VA="0xF05974", Slot="4")]
		private IEnumerator<JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonResult>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0xF0597C", Offset="0xF0597C", VA="0xF0597C", Slot="5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E578", Offset="0x104E578")]
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

			private JsonResult System.Collections.Generic.IEnumerator<Csdk.GluAds.Implementation.Json.JsonResult>.Current
			{
				[Address(RVA="0x155638C", Offset="0x155638C", VA="0x155638C", Slot="6")]
				[DebuggerHidden]
				get
				{
					return new JsonResult();
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1556400", Offset="0x1556400", VA="0x1556400", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1555E70", Offset="0x1555E70", VA="0x1555E70")]
			[DebuggerHidden]
			public <AsEnumerable>d__42(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1556254", Offset="0x1556254", VA="0x1556254", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1556464", Offset="0x1556464", VA="0x1556464", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonResult>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1556528", Offset="0x1556528", VA="0x1556528", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1556398", Offset="0x1556398", VA="0x1556398", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1556250", Offset="0x1556250", VA="0x1556250", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E568", Offset="0x104E568")]
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
				[Address(RVA="0x15566AC", Offset="0x15566AC", VA="0x15566AC", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x155671C", Offset="0x155671C", VA="0x155671C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1555CF4", Offset="0x1555CF4", VA="0x1555CF4")]
			[DebuggerHidden]
			public <GetKeys>d__33(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1556530", Offset="0x1556530", VA="0x1556530", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1556724", Offset="0x1556724", VA="0x1556724", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x15567E8", Offset="0x15567E8", VA="0x15567E8", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x15566B4", Offset="0x15566B4", VA="0x15566B4", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x155652C", Offset="0x155652C", VA="0x155652C", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}