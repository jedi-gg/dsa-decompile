using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class ResourceProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly Type _resourceType;

		[FieldOffset(Offset="0x18")]
		private readonly string _resourcePath;

		[Address(RVA="0x18365D0", Offset="0x18365D0", VA="0x18365D0")]
		public ResourceProvider(string resourcePath, Type resourceType)
		{
		}

		[Address(RVA="0x18449F8", Offset="0x18449F8", VA="0x18449F8", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073AF8", Offset="0x1073AF8")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x18449F0", Offset="0x18449F0", VA="0x18449F0", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DFF8", Offset="0x104DFF8")]
		private sealed class <GetAllInstancesWithInjectSplit>d__4 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x28")]
			public InjectContext context;

			[FieldOffset(Offset="0x30")]
			public ResourceProvider <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x1844C30", Offset="0x1844C30", VA="0x1844C30", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1844CA0", Offset="0x1844CA0", VA="0x1844CA0", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1844AA4", Offset="0x1844AA4", VA="0x1844AA4")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1844AD4", Offset="0x1844AD4", VA="0x1844AD4", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1844C38", Offset="0x1844C38", VA="0x1844C38", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1844AD0", Offset="0x1844AD0", VA="0x1844AD0", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}