using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace UTNotifications
{
	[Attribute(Name="DefaultMemberAttribute", RVA="0x1049528", Offset="0x1049528")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[FieldOffset(Offset="0x10")]
		private List<JSONNode> m_List;

		public override IEnumerable<JSONNode> Childs
		{
			[Address(RVA="0x1440044", Offset="0x1440044", VA="0x1440044", Slot="16")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074310", Offset="0x1074310")]
			get
			{
				return null;
			}
		}

		public override int Count
		{
			[Address(RVA="0x143FE20", Offset="0x143FE20", VA="0x143FE20", Slot="11")]
			get
			{
				return new int();
			}
		}

		public override JSONNode Item(int aIndex)
		{
			[Address(RVA="0x143FB74", Offset="0x143FB74", VA="0x143FB74", Slot="5")]
			get
			{
				return null;
			}
			[Address(RVA="0x143FC70", Offset="0x143FC70", VA="0x143FC70", Slot="6")]
			set
			{
			}
		}

		public override JSONNode Item(string aKey)
		{
			[Address(RVA="0x143FD4C", Offset="0x143FD4C", VA="0x143FD4C", Slot="7")]
			get
			{
				return null;
			}
			[Address(RVA="0x143FDB0", Offset="0x143FDB0", VA="0x143FDB0", Slot="8")]
			set
			{
			}
		}

		[Address(RVA="0x14406C4", Offset="0x14406C4", VA="0x14406C4")]
		public JSONArray()
		{
		}

		[Address(RVA="0x143FE80", Offset="0x143FE80", VA="0x143FE80", Slot="4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Address(RVA="0x1440100", Offset="0x1440100", VA="0x1440100", Slot="29")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074374", Offset="0x1074374")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x143FEF0", Offset="0x143FEF0", VA="0x143FEF0", Slot="14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Address(RVA="0x143FFCC", Offset="0x143FFCC", VA="0x143FFCC", Slot="15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Address(RVA="0x1440598", Offset="0x1440598", VA="0x1440598", Slot="28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Address(RVA="0x14401A0", Offset="0x14401A0", VA="0x14401A0", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x144036C", Offset="0x144036C", VA="0x144036C", Slot="17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E2C8", Offset="0x104E2C8")]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private JSONNode <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public JSONArray <>4__this;

			[FieldOffset(Offset="0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			private JSONNode System.Collections.Generic.IEnumerator<UTNotifications.JSONNode>.Current
			{
				[Address(RVA="0x1440B84", Offset="0x1440B84", VA="0x1440B84", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1440BF4", Offset="0x1440BF4", VA="0x1440BF4", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x14400C8", Offset="0x14400C8", VA="0x14400C8")]
			[DebuggerHidden]
			public <get_Childs>d__13(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x14409B8", Offset="0x14409B8", VA="0x14409B8")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x1440A10", Offset="0x1440A10", VA="0x1440A10", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1440BFC", Offset="0x1440BFC", VA="0x1440BFC", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<UTNotifications.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1440CAC", Offset="0x1440CAC", VA="0x1440CAC", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1440B8C", Offset="0x1440B8C", VA="0x1440B8C", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x144099C", Offset="0x144099C", VA="0x144099C", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E2D8", Offset="0x104E2D8")]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private object <>2__current;

			[FieldOffset(Offset="0x20")]
			public JSONArray <>4__this;

			[FieldOffset(Offset="0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA="0x1440924", Offset="0x1440924", VA="0x1440924", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1440994", Offset="0x1440994", VA="0x1440994", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1440174", Offset="0x1440174", VA="0x1440174")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1440758", Offset="0x1440758", VA="0x1440758")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x14407B0", Offset="0x14407B0", VA="0x14407B0", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x144092C", Offset="0x144092C", VA="0x144092C", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x144073C", Offset="0x144073C", VA="0x144073C", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}