using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace UTNotifications
{
	[Attribute(Name="DefaultMemberAttribute", RVA="0x10494F0", Offset="0x10494F0")]
	public class JSONNode
	{
		public virtual JSONArray AsArray
		{
			[Address(RVA="0x1443EE0", Offset="0x1443EE0", VA="0x1443EE0", Slot="26")]
			get
			{
				return null;
			}
		}

		public virtual bool AsBool
		{
			[Address(RVA="0x1443D94", Offset="0x1443D94", VA="0x1443D94", Slot="24")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1443E5C", Offset="0x1443E5C", VA="0x1443E5C", Slot="25")]
			set
			{
			}
		}

		public virtual double AsDouble
		{
			[Address(RVA="0x1443CB0", Offset="0x1443CB0", VA="0x1443CB0", Slot="22")]
			get
			{
				return new double();
			}
			[Address(RVA="0x1443D54", Offset="0x1443D54", VA="0x1443D54", Slot="23")]
			set
			{
			}
		}

		public virtual float AsFloat
		{
			[Address(RVA="0x1443C2C", Offset="0x1443C2C", VA="0x1443C2C", Slot="20")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1443C70", Offset="0x1443C70", VA="0x1443C70", Slot="21")]
			set
			{
			}
		}

		public virtual int AsInt
		{
			[Address(RVA="0x1443BAC", Offset="0x1443BAC", VA="0x1443BAC", Slot="18")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1443BEC", Offset="0x1443BEC", VA="0x1443BEC", Slot="19")]
			set
			{
			}
		}

		public virtual JSONClass AsObject
		{
			[Address(RVA="0x1443F60", Offset="0x1443F60", VA="0x1443F60", Slot="27")]
			get
			{
				return null;
			}
		}

		public virtual IEnumerable<JSONNode> Childs
		{
			[Address(RVA="0x14439B8", Offset="0x14439B8", VA="0x14439B8", Slot="16")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074248", Offset="0x1074248")]
			get
			{
				return null;
			}
		}

		public virtual int Count
		{
			[Address(RVA="0x1443930", Offset="0x1443930", VA="0x1443930", Slot="11")]
			get
			{
				return new int();
			}
		}

		public IEnumerable<JSONNode> DeepChilds
		{
			[Address(RVA="0x1443A60", Offset="0x1443A60", VA="0x1443A60")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10742AC", Offset="0x10742AC")]
			get
			{
				return null;
			}
		}

		public virtual JSONNode Item(int aIndex)
		{
			[Address(RVA="0x14438CC", Offset="0x14438CC", VA="0x14438CC", Slot="5")]
			get
			{
				return null;
			}
			[Address(RVA="0x14438D4", Offset="0x14438D4", VA="0x14438D4", Slot="6")]
			set
			{
			}
		}

		public virtual JSONNode Item(string aKey)
		{
			[Address(RVA="0x14438D8", Offset="0x14438D8", VA="0x14438D8", Slot="7")]
			get
			{
				return null;
			}
			[Address(RVA="0x14438E0", Offset="0x14438E0", VA="0x14438E0", Slot="8")]
			set
			{
			}
		}

		public virtual string Value
		{
			[Address(RVA="0x14438E4", Offset="0x14438E4", VA="0x14438E4", Slot="9")]
			get
			{
				return null;
			}
			[Address(RVA="0x144392C", Offset="0x144392C", VA="0x144392C", Slot="10")]
			set
			{
			}
		}

		[Address(RVA="0x1440734", Offset="0x1440734", VA="0x1440734")]
		public JSONNode()
		{
		}

		[Address(RVA="0x14438C8", Offset="0x14438C8", VA="0x14438C8", Slot="4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Address(RVA="0x1443938", Offset="0x1443938", VA="0x1443938", Slot="12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Address(RVA="0x14445BC", Offset="0x14445BC", VA="0x14445BC")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Address(RVA="0x14440B0", Offset="0x14440B0", VA="0x14440B0", Slot="0")]
		public override bool Equals(object obj)
		{
			return new bool();
		}

		[Address(RVA="0x1441AB8", Offset="0x1441AB8", VA="0x1441AB8")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Address(RVA="0x1443330", Offset="0x1443330", VA="0x1443330", Slot="2")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1444D04", Offset="0x1444D04", VA="0x1444D04")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Address(RVA="0x1444A44", Offset="0x1444A44", VA="0x1444A44")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Address(RVA="0x144495C", Offset="0x144495C", VA="0x144495C")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Address(RVA="0x14449D0", Offset="0x14449D0", VA="0x14449D0")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Address(RVA="0x1444BE8", Offset="0x1444BE8", VA="0x1444BE8")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Address(RVA="0x1444AB8", Offset="0x1444AB8", VA="0x1444AB8")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Address(RVA="0x14423A4", Offset="0x14423A4", VA="0x14423A4")]
		public static bool operator ==(JSONNode a, object b)
		{
			return new bool();
		}

		[Address(RVA="0x1443FE0", Offset="0x1443FE0", VA="0x1443FE0")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Address(RVA="0x1444044", Offset="0x1444044", VA="0x1444044")]
		public static implicit operator String(JSONNode d)
		{
			return null;
		}

		[Address(RVA="0x1444094", Offset="0x1444094", VA="0x1444094")]
		public static bool operator !=(JSONNode a, object b)
		{
			return new bool();
		}

		[Address(RVA="0x143F3F8", Offset="0x143F3F8", VA="0x143F3F8")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Address(RVA="0x14439A0", Offset="0x14439A0", VA="0x14439A0", Slot="13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Address(RVA="0x14439A8", Offset="0x14439A8", VA="0x14439A8", Slot="14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Address(RVA="0x14439B0", Offset="0x14439B0", VA="0x14439B0", Slot="15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Address(RVA="0x1444420", Offset="0x1444420", VA="0x1444420")]
		public string SaveToBase64()
		{
			return null;
		}

		[Address(RVA="0x1444228", Offset="0x1444228", VA="0x1444228")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Address(RVA="0x14441B4", Offset="0x14441B4", VA="0x14441B4")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Address(RVA="0x1444140", Offset="0x1444140", VA="0x1444140")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Address(RVA="0x144429C", Offset="0x144429C", VA="0x144429C")]
		public void SaveToFile(string aFileName)
		{
		}

		[Address(RVA="0x14440C0", Offset="0x14440C0", VA="0x14440C0")]
		public void SaveToStream(Stream aData)
		{
		}

		[Address(RVA="0x14440BC", Offset="0x14440BC", VA="0x14440BC", Slot="28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Address(RVA="0x1443B1C", Offset="0x1443B1C", VA="0x1443B1C", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1443B64", Offset="0x1443B64", VA="0x1443B64", Slot="17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E2A8", Offset="0x104E2A8")]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private JSONNode <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			private JSONNode System.Collections.Generic.IEnumerator<UTNotifications.JSONNode>.Current
			{
				[Address(RVA="0x1444DD8", Offset="0x1444DD8", VA="0x1444DD8", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1444E48", Offset="0x1444E48", VA="0x1444E48", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1443A28", Offset="0x1443A28", VA="0x1443A28")]
			[DebuggerHidden]
			public <get_Childs>d__17(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1444DC0", Offset="0x1444DC0", VA="0x1444DC0", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1444E50", Offset="0x1444E50", VA="0x1444E50", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<UTNotifications.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1444EE8", Offset="0x1444EE8", VA="0x1444EE8", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1444DE0", Offset="0x1444DE0", VA="0x1444DE0", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1444DBC", Offset="0x1444DBC", VA="0x1444DBC", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E2B8", Offset="0x104E2B8")]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private JSONNode <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			public JSONNode <>4__this;

			[FieldOffset(Offset="0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			private JSONNode System.Collections.Generic.IEnumerator<UTNotifications.JSONNode>.Current
			{
				[Address(RVA="0x1445520", Offset="0x1445520", VA="0x1445520", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1445590", Offset="0x1445590", VA="0x1445590", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1443AE4", Offset="0x1443AE4", VA="0x1443AE4")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1445024", Offset="0x1445024", VA="0x1445024")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x1444F64", Offset="0x1444F64", VA="0x1444F64")]
			private void <>m__Finally2()
			{
			}

			[Address(RVA="0x14450E4", Offset="0x14450E4", VA="0x14450E4", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1445598", Offset="0x1445598", VA="0x1445598", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<UTNotifications.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1445648", Offset="0x1445648", VA="0x1445648", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1445528", Offset="0x1445528", VA="0x1445528", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1444EEC", Offset="0x1444EEC", VA="0x1444EEC", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}