using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class CachedProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly IProvider _creator;

		[FieldOffset(Offset="0x18")]
		private List<object> _instances;

		[FieldOffset(Offset="0x20")]
		private bool _isCreatingInstance;

		[Address(RVA="0x15AEA38", Offset="0x15AEA38", VA="0x15AEA38")]
		public CachedProvider(IProvider creator)
		{
		}

		[Address(RVA="0x15AEB28", Offset="0x15AEB28", VA="0x15AEB28", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072D20", Offset="0x1072D20")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x15AEA64", Offset="0x15AEA64", VA="0x15AEA64", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DDD8", Offset="0x104DDD8")]
		private sealed class <GetAllInstancesWithInjectSplit>d__5 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public InjectContext context;

			[FieldOffset(Offset="0x28")]
			public CachedProvider <>4__this;

			[FieldOffset(Offset="0x30")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<List<object>> <runner>5__2;

			[FieldOffset(Offset="0x40")]
			private bool <hasMore>5__3;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x15AF05C", Offset="0x15AF05C", VA="0x15AF05C", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x15AF0CC", Offset="0x15AF0CC", VA="0x15AF0CC", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x15AEBD4", Offset="0x15AEBD4", VA="0x15AEBD4")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__5(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x15AEC04", Offset="0x15AEC04", VA="0x15AEC04", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x15AF064", Offset="0x15AF064", VA="0x15AF064", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x15AEC00", Offset="0x15AEC00", VA="0x15AEC00", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}