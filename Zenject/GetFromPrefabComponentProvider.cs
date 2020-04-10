using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Zenject
{
	public class GetFromPrefabComponentProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly IPrefabInstantiator _prefabInstantiator;

		[FieldOffset(Offset="0x18")]
		private readonly Type _componentType;

		[Address(RVA="0x1835EB4", Offset="0x1835EB4", VA="0x1835EB4")]
		public GetFromPrefabComponentProvider(Type componentType, IPrefabInstantiator prefabInstantiator)
		{
		}

		[Address(RVA="0x1837C88", Offset="0x1837C88", VA="0x1837C88", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072E4C", Offset="0x1072E4C")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x1837C80", Offset="0x1837C80", VA="0x1837C80", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DE08", Offset="0x104DE08")]
		private sealed class <GetAllInstancesWithInjectSplit>d__4 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public InjectContext context;

			[FieldOffset(Offset="0x28")]
			public GetFromPrefabComponentProvider <>4__this;

			[FieldOffset(Offset="0x30")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<GameObject> <gameObjectRunner>5__2;

			[FieldOffset(Offset="0x40")]
			private bool <hasMore>5__3;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x1838120", Offset="0x1838120", VA="0x1838120", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1838190", Offset="0x1838190", VA="0x1838190", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1837D34", Offset="0x1837D34", VA="0x1837D34")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1837D64", Offset="0x1837D64", VA="0x1837D64", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1838128", Offset="0x1838128", VA="0x1838128", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1837D60", Offset="0x1837D60", VA="0x1837D60", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}