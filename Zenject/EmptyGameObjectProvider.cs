using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class EmptyGameObjectProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x18")]
		private readonly GameObjectCreationParameters _gameObjectBindInfo;

		[Address(RVA="0x1833A40", Offset="0x1833A40", VA="0x1833A40")]
		public EmptyGameObjectProvider(DiContainer container, GameObjectCreationParameters gameObjectBindInfo)
		{
		}

		[Address(RVA="0x1833AE8", Offset="0x1833AE8", VA="0x1833AE8", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x107318C", Offset="0x107318C")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x1833A78", Offset="0x1833A78", VA="0x1833A78", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DE88", Offset="0x104DE88")]
		private sealed class <GetAllInstancesWithInjectSplit>d__4 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x28")]
			public EmptyGameObjectProvider <>4__this;

			[FieldOffset(Offset="0x30")]
			public InjectContext context;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x1833CF4", Offset="0x1833CF4", VA="0x1833CF4", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1833D64", Offset="0x1833D64", VA="0x1833D64", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1833B94", Offset="0x1833B94", VA="0x1833B94")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1833BC4", Offset="0x1833BC4", VA="0x1833BC4", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1833CFC", Offset="0x1833CFC", VA="0x1833CFC", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1833BC0", Offset="0x1833BC0", VA="0x1833BC0", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}