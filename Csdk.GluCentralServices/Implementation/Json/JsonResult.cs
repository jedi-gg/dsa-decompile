using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Csdk.GluCentralServices.Implementation.Json
{
	[Attribute(Name="DefaultMemberAttribute", RVA="0x1049680", Offset="0x1049680")]
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
			[Address(RVA="0xF37858", Offset="0xF37858", VA="0xF37858")]
			get
			{
				return new bool();
			}
		}

		public bool IsArray
		{
			[Address(RVA="0xF37870", Offset="0xF37870", VA="0xF37870")]
			get
			{
				return new bool();
			}
		}

		public bool IsBoolean
		{
			[Address(RVA="0xF37880", Offset="0xF37880", VA="0xF37880")]
			get
			{
				return new bool();
			}
		}

		public bool IsNull
		{
			[Address(RVA="0xF37878", Offset="0xF37878", VA="0xF37878")]
			get
			{
				return new bool();
			}
		}

		public bool IsNumber
		{
			[Address(RVA="0xF37890", Offset="0xF37890", VA="0xF37890")]
			get
			{
				return new bool();
			}
		}

		public bool IsObject
		{
			[Address(RVA="0xF37868", Offset="0xF37868", VA="0xF37868")]
			get
			{
				return new bool();
			}
		}

		public bool IsString
		{
			[Address(RVA="0xF37888", Offset="0xF37888", VA="0xF37888")]
			get
			{
				return new bool();
			}
		}

		public JsonResult Item(int index)
		{
			[Address(RVA="0xF37898", Offset="0xF37898", VA="0xF37898")]
			get
			{
				return new JsonResult();
			}
		}

		public JsonResult Item(string key)
		{
			[Address(RVA="0xF378A0", Offset="0xF378A0", VA="0xF378A0")]
			get
			{
				return new JsonResult();
			}
		}

		[Address(RVA="0x21D8B00", Offset="0x21D8B00", VA="0x21D8B00")]
		static JsonResult()
		{
		}

		[Address(RVA="0xF37844", Offset="0xF37844", VA="0xF37844")]
		internal JsonResult(IList<JsonNode> nodes)
		{
		}

		[Address(RVA="0xF37850", Offset="0xF37850", VA="0xF37850")]
		private JsonResult(IList<JsonNode> nodes, int index)
		{
		}

		[Address(RVA="0xF378E8", Offset="0xF378E8", VA="0xF378E8")]
		public bool AsBoolean()
		{
			return new bool();
		}

		[Address(RVA="0xF378D8", Offset="0xF378D8", VA="0xF378D8")]
		public decimal AsDecimal()
		{
			return new decimal();
		}

		[Address(RVA="0xF37900", Offset="0xF37900", VA="0xF37900")]
		public IDictionary<string, JsonResult> AsDictionary()
		{
			return null;
		}

		[Address(RVA="0xF378D0", Offset="0xF378D0", VA="0xF378D0")]
		public double AsDouble()
		{
			return new double();
		}

		[Address(RVA="0xF378F8", Offset="0xF378F8", VA="0xF378F8")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074BA0", Offset="0x1074BA0")]
		public IEnumerable<JsonResult> AsEnumerable()
		{
			return null;
		}

		[Address(RVA="0xF378B8", Offset="0xF378B8", VA="0xF378B8")]
		public int AsInt32()
		{
			return new int();
		}

		[Address(RVA="0xF378C0", Offset="0xF378C0", VA="0xF378C0")]
		public long AsInt64()
		{
			return new long();
		}

		[Address(RVA="0xF378F0", Offset="0xF378F0", VA="0xF378F0")]
		public IList<JsonResult> AsList()
		{
			return null;
		}

		[Address(RVA="0xF378C8", Offset="0xF378C8", VA="0xF378C8")]
		public float AsSingle()
		{
			return new float();
		}

		[Address(RVA="0xF378E0", Offset="0xF378E0", VA="0xF378E0")]
		public string AsString()
		{
			return null;
		}

		[Address(RVA="0xF378A8", Offset="0xF378A8", VA="0xF378A8")]
		public int Count()
		{
			return new int();
		}

		[Address(RVA="0xF37928", Offset="0xF37928", VA="0xF37928")]
		private JsonResult FromIndex(int index)
		{
			return new JsonResult();
		}

		[Address(RVA="0xF378B0", Offset="0xF378B0", VA="0xF378B0")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074B3C", Offset="0x1074B3C")]
		public IEnumerable<string> GetKeys()
		{
			return null;
		}

		[Address(RVA="0xF37920", Offset="0xF37920", VA="0xF37920")]
		private int GetNextNodeIndex(int index)
		{
			return new int();
		}

		[Address(RVA="0xF37918", Offset="0xF37918", VA="0xF37918")]
		private JsonNode GetNode()
		{
			return new JsonNode();
		}

		[Address(RVA="0x21D802C", Offset="0x21D802C", VA="0x21D802C")]
		public static implicit operator Int32(JsonResult result)
		{
			return new int();
		}

		[Address(RVA="0x21D80CC", Offset="0x21D80CC", VA="0x21D80CC")]
		public static implicit operator Int64(JsonResult result)
		{
			return new long();
		}

		[Address(RVA="0x21D816C", Offset="0x21D816C", VA="0x21D816C")]
		public static implicit operator Single(JsonResult result)
		{
			return new float();
		}

		[Address(RVA="0x21D820C", Offset="0x21D820C", VA="0x21D820C")]
		public static implicit operator Double(JsonResult result)
		{
			return new double();
		}

		[Address(RVA="0x21D82AC", Offset="0x21D82AC", VA="0x21D82AC")]
		public static implicit operator Decimal(JsonResult result)
		{
			return new decimal();
		}

		[Address(RVA="0x21D834C", Offset="0x21D834C", VA="0x21D834C")]
		public static implicit operator Boolean(JsonResult result)
		{
			return new bool();
		}

		[Address(RVA="0x21D83CC", Offset="0x21D83CC", VA="0x21D83CC")]
		public static implicit operator String(JsonResult result)
		{
			return null;
		}

		[Address(RVA="0xF37908", Offset="0xF37908", VA="0xF37908", Slot="4")]
		private IEnumerator<JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonResult>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0xF37910", Offset="0xF37910", VA="0xF37910", Slot="5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E4D8", Offset="0x104E4D8")]
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

			private JsonResult System.Collections.Generic.IEnumerator<Csdk.GluCentralServices.Implementation.Json.JsonResult>.Current
			{
				[Address(RVA="0x21D8CAC", Offset="0x21D8CAC", VA="0x21D8CAC", Slot="6")]
				[DebuggerHidden]
				get
				{
					return new JsonResult();
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x21D8D20", Offset="0x21D8D20", VA="0x21D8D20", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x21D8790", Offset="0x21D8790", VA="0x21D8790")]
			[DebuggerHidden]
			public <AsEnumerable>d__42(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x21D8B74", Offset="0x21D8B74", VA="0x21D8B74", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x21D8D84", Offset="0x21D8D84", VA="0x21D8D84", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonResult>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21D8E48", Offset="0x21D8E48", VA="0x21D8E48", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21D8CB8", Offset="0x21D8CB8", VA="0x21D8CB8", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x21D8B70", Offset="0x21D8B70", VA="0x21D8B70", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E4C8", Offset="0x104E4C8")]
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
				[Address(RVA="0x21D8FCC", Offset="0x21D8FCC", VA="0x21D8FCC", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x21D903C", Offset="0x21D903C", VA="0x21D903C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x21D8584", Offset="0x21D8584", VA="0x21D8584")]
			[DebuggerHidden]
			public <GetKeys>d__33(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x21D8E50", Offset="0x21D8E50", VA="0x21D8E50", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x21D9044", Offset="0x21D9044", VA="0x21D9044", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21D9108", Offset="0x21D9108", VA="0x21D9108", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x21D8FD4", Offset="0x21D8FD4", VA="0x21D8FD4", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x21D8E4C", Offset="0x21D8E4C", VA="0x21D8E4C", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}