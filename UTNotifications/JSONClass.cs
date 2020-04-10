using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace UTNotifications
{
	[Attribute(Name="DefaultMemberAttribute", RVA="0x1049560", Offset="0x1049560")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[FieldOffset(Offset="0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		public override IEnumerable<JSONNode> Childs
		{
			[Address(RVA="0x144156C", Offset="0x144156C", VA="0x144156C", Slot="16")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10743D8", Offset="0x10743D8")]
			get
			{
				return null;
			}
		}

		public override int Count
		{
			[Address(RVA="0x1441040", Offset="0x1441040", VA="0x1441040", Slot="11")]
			get
			{
				return new int();
			}
		}

		public override JSONNode Item(string aKey)
		{
			[Address(RVA="0x1440CB0", Offset="0x1440CB0", VA="0x1440CB0", Slot="7")]
			get
			{
				return null;
			}
			[Address(RVA="0x1440DB8", Offset="0x1440DB8", VA="0x1440DB8", Slot="8")]
			set
			{
			}
		}

		public override JSONNode Item(int aIndex)
		{
			[Address(RVA="0x1440E8C", Offset="0x1440E8C", VA="0x1440E8C", Slot="5")]
			get
			{
				return null;
			}
			[Address(RVA="0x1440F50", Offset="0x1440F50", VA="0x1440F50", Slot="6")]
			set
			{
			}
		}

		[Address(RVA="0x14422C8", Offset="0x14422C8", VA="0x14422C8")]
		public JSONClass()
		{
		}

		[Address(RVA="0x14410A0", Offset="0x14410A0", VA="0x14410A0", Slot="4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Address(RVA="0x1441628", Offset="0x1441628", VA="0x1441628", Slot="29")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x107443C", Offset="0x107443C")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x14411D8", Offset="0x14411D8", VA="0x14411D8", Slot="13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Address(RVA="0x14412B0", Offset="0x14412B0", VA="0x14412B0", Slot="14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Address(RVA="0x14413B0", Offset="0x14413B0", VA="0x14413B0", Slot="15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Address(RVA="0x14420B8", Offset="0x14420B8", VA="0x14420B8", Slot="28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Address(RVA="0x14416C8", Offset="0x14416C8", VA="0x14416C8", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1441C44", Offset="0x1441C44", VA="0x1441C44", Slot="17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E2E8", Offset="0x104E2E8")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset="0x10")]
			public JSONNode aNode;

			[Address(RVA="0x1441564", Offset="0x1441564", VA="0x1441564")]
			public <>c__DisplayClass12_0()
			{
			}

			[Address(RVA="0x1442338", Offset="0x1442338", VA="0x1442338")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E2F8", Offset="0x104E2F8")]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private JSONNode <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public JSONClass <>4__this;

			[FieldOffset(Offset="0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			private JSONNode System.Collections.Generic.IEnumerator<UTNotifications.JSONNode>.Current
			{
				[Address(RVA="0x14428E0", Offset="0x14428E0", VA="0x14428E0", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1442950", Offset="0x1442950", VA="0x1442950", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x14415F0", Offset="0x14415F0", VA="0x14415F0")]
			[DebuggerHidden]
			public <get_Childs>d__14(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x14426E4", Offset="0x14426E4", VA="0x14426E4")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x144273C", Offset="0x144273C", VA="0x144273C", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1442958", Offset="0x1442958", VA="0x1442958", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<UTNotifications.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1442A08", Offset="0x1442A08", VA="0x1442A08", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x14428E8", Offset="0x14428E8", VA="0x14428E8", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x14426C8", Offset="0x14426C8", VA="0x14426C8", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E308", Offset="0x104E308")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private object <>2__current;

			[FieldOffset(Offset="0x20")]
			public JSONClass <>4__this;

			[FieldOffset(Offset="0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA="0x1442650", Offset="0x1442650", VA="0x1442650", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x14426C0", Offset="0x14426C0", VA="0x14426C0", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x144169C", Offset="0x144169C", VA="0x144169C")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1442458", Offset="0x1442458", VA="0x1442458")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x14424B0", Offset="0x14424B0", VA="0x14424B0", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1442658", Offset="0x1442658", VA="0x1442658", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x144243C", Offset="0x144243C", VA="0x144243C", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}