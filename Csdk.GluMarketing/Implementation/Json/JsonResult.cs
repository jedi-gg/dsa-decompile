using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Csdk.GluMarketing.Implementation.Json
{
	[Attribute(Name="DefaultMemberAttribute", RVA="0x10495F0", Offset="0x10495F0")]
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
			[Address(RVA="0xF38144", Offset="0xF38144", VA="0xF38144")]
			get
			{
				return new bool();
			}
		}

		public bool IsArray
		{
			[Address(RVA="0xF3815C", Offset="0xF3815C", VA="0xF3815C")]
			get
			{
				return new bool();
			}
		}

		public bool IsBoolean
		{
			[Address(RVA="0xF3816C", Offset="0xF3816C", VA="0xF3816C")]
			get
			{
				return new bool();
			}
		}

		public bool IsNull
		{
			[Address(RVA="0xF38164", Offset="0xF38164", VA="0xF38164")]
			get
			{
				return new bool();
			}
		}

		public bool IsNumber
		{
			[Address(RVA="0xF3817C", Offset="0xF3817C", VA="0xF3817C")]
			get
			{
				return new bool();
			}
		}

		public bool IsObject
		{
			[Address(RVA="0xF38154", Offset="0xF38154", VA="0xF38154")]
			get
			{
				return new bool();
			}
		}

		public bool IsString
		{
			[Address(RVA="0xF38174", Offset="0xF38174", VA="0xF38174")]
			get
			{
				return new bool();
			}
		}

		public JsonResult Item(int index)
		{
			[Address(RVA="0xF38184", Offset="0xF38184", VA="0xF38184")]
			get
			{
				return new JsonResult();
			}
		}

		public JsonResult Item(string key)
		{
			[Address(RVA="0xF3818C", Offset="0xF3818C", VA="0xF3818C")]
			get
			{
				return new JsonResult();
			}
		}

		[Address(RVA="0x21F22F0", Offset="0x21F22F0", VA="0x21F22F0")]
		static JsonResult()
		{
		}

		[Address(RVA="0xF38130", Offset="0xF38130", VA="0xF38130")]
		internal JsonResult(IList<JsonNode> nodes)
		{
		}

		[Address(RVA="0xF3813C", Offset="0xF3813C", VA="0xF3813C")]
		private JsonResult(IList<JsonNode> nodes, int index)
		{
		}

		[Address(RVA="0xF381D4", Offset="0xF381D4", VA="0xF381D4")]
		public bool AsBoolean()
		{
			return new bool();
		}

		[Address(RVA="0xF381C4", Offset="0xF381C4", VA="0xF381C4")]
		public decimal AsDecimal()
		{
			return new decimal();
		}

		[Address(RVA="0xF381EC", Offset="0xF381EC", VA="0xF381EC")]
		public IDictionary<string, JsonResult> AsDictionary()
		{
			return null;
		}

		[Address(RVA="0xF381BC", Offset="0xF381BC", VA="0xF381BC")]
		public double AsDouble()
		{
			return new double();
		}

		[Address(RVA="0xF381E4", Offset="0xF381E4", VA="0xF381E4")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10746E8", Offset="0x10746E8")]
		public IEnumerable<JsonResult> AsEnumerable()
		{
			return null;
		}

		[Address(RVA="0xF381A4", Offset="0xF381A4", VA="0xF381A4")]
		public int AsInt32()
		{
			return new int();
		}

		[Address(RVA="0xF381AC", Offset="0xF381AC", VA="0xF381AC")]
		public long AsInt64()
		{
			return new long();
		}

		[Address(RVA="0xF381DC", Offset="0xF381DC", VA="0xF381DC")]
		public IList<JsonResult> AsList()
		{
			return null;
		}

		[Address(RVA="0xF381B4", Offset="0xF381B4", VA="0xF381B4")]
		public float AsSingle()
		{
			return new float();
		}

		[Address(RVA="0xF381CC", Offset="0xF381CC", VA="0xF381CC")]
		public string AsString()
		{
			return null;
		}

		[Address(RVA="0xF38194", Offset="0xF38194", VA="0xF38194")]
		public int Count()
		{
			return new int();
		}

		[Address(RVA="0xF38214", Offset="0xF38214", VA="0xF38214")]
		private JsonResult FromIndex(int index)
		{
			return new JsonResult();
		}

		[Address(RVA="0xF3819C", Offset="0xF3819C", VA="0xF3819C")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074684", Offset="0x1074684")]
		public IEnumerable<string> GetKeys()
		{
			return null;
		}

		[Address(RVA="0xF3820C", Offset="0xF3820C", VA="0xF3820C")]
		private int GetNextNodeIndex(int index)
		{
			return new int();
		}

		[Address(RVA="0xF38204", Offset="0xF38204", VA="0xF38204")]
		private JsonNode GetNode()
		{
			return new JsonNode();
		}

		[Address(RVA="0x21F1AD8", Offset="0x21F1AD8", VA="0x21F1AD8")]
		public static implicit operator Int32(JsonResult result)
		{
			return new int();
		}

		[Address(RVA="0x21F1B78", Offset="0x21F1B78", VA="0x21F1B78")]
		public static implicit operator Int64(JsonResult result)
		{
			return new long();
		}

		[Address(RVA="0x21F1C18", Offset="0x21F1C18", VA="0x21F1C18")]
		public static implicit operator Single(JsonResult result)
		{
			return new float();
		}

		[Address(RVA="0x21F1CB8", Offset="0x21F1CB8", VA="0x21F1CB8")]
		public static implicit operator Double(JsonResult result)
		{
			return new double();
		}

		[Address(RVA="0x21F1D58", Offset="0x21F1D58", VA="0x21F1D58")]
		public static implicit operator Decimal(JsonResult result)
		{
			return new decimal();
		}

		[Address(RVA="0x21F1D7C", Offset="0x21F1D7C", VA="0x21F1D7C")]
		public static implicit operator Boolean(JsonResult result)
		{
			return new bool();
		}

		[Address(RVA="0x21F1DA4", Offset="0x21F1DA4", VA="0x21F1DA4")]
		public static implicit operator String(JsonResult result)
		{
			return null;
		}

		[Address(RVA="0xF381F4", Offset="0xF381F4", VA="0xF381F4", Slot="4")]
		private IEnumerator<JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluMarketing.Implementation.Json.JsonResult>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0xF381FC", Offset="0xF381FC", VA="0xF381FC", Slot="5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E478", Offset="0x104E478")]
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

			private JsonResult System.Collections.Generic.IEnumerator<Csdk.GluMarketing.Implementation.Json.JsonResult>.Current
			{
				[Address(RVA="0x1537608", Offset="0x1537608", VA="0x1537608", Slot="6")]
				[DebuggerHidden]
				get
				{
					return new JsonResult();
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x153767C", Offset="0x153767C", VA="0x153767C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1537488", Offset="0x1537488", VA="0x1537488")]
			[DebuggerHidden]
			public <AsEnumerable>d__42(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x15374C4", Offset="0x15374C4", VA="0x15374C4", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x15376E0", Offset="0x15376E0", VA="0x15376E0", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluMarketing.Implementation.Json.JsonResult>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x15377A4", Offset="0x15377A4", VA="0x15377A4", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1537614", Offset="0x1537614", VA="0x1537614", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x15374C0", Offset="0x15374C0", VA="0x15374C0", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E468", Offset="0x104E468")]
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
				[Address(RVA="0x1537968", Offset="0x1537968", VA="0x1537968", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x15379D8", Offset="0x15379D8", VA="0x15379D8", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x15377A8", Offset="0x15377A8", VA="0x15377A8")]
			[DebuggerHidden]
			public <GetKeys>d__33(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x15377E4", Offset="0x15377E4", VA="0x15377E4", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x15379E0", Offset="0x15379E0", VA="0x15379E0", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1537AA4", Offset="0x1537AA4", VA="0x1537AA4", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1537970", Offset="0x1537970", VA="0x1537970", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x15377E0", Offset="0x15377E0", VA="0x15377E0", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}