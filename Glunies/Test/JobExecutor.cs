using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Glunies.Test
{
	public class JobExecutor
	{
		[Address(RVA="0x1614BFC", Offset="0x1614BFC", VA="0x1614BFC")]
		public JobExecutor()
		{
		}

		[Address(RVA="0x1614B70", Offset="0x1614B70", VA="0x1614B70")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x108A76C", Offset="0x108A76C")]
		[Attribute(Name="UnityTestAttribute", RVA="0x108A76C", Offset="0x108A76C")]
		public IEnumerator AsyncJobExecutor_Execute()
		{
			return null;
		}

		[Address(RVA="0x1614AE4", Offset="0x1614AE4", VA="0x1614AE4")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x108A6F8", Offset="0x108A6F8")]
		[Attribute(Name="UnityTestAttribute", RVA="0x108A6F8", Offset="0x108A6F8")]
		public IEnumerator SyncJobExecutor_Execute()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051138", Offset="0x1051138")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public bool executorFinished;

			[Address(RVA="0x1614C04", Offset="0x1614C04", VA="0x1614C04")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x1614C0C", Offset="0x1614C0C", VA="0x1614C0C")]
			internal void <SyncJobExecutor_Execute>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051158", Offset="0x1051158")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x10")]
			public bool executorFinished;

			[Address(RVA="0x1614C18", Offset="0x1614C18", VA="0x1614C18")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x1614C20", Offset="0x1614C20", VA="0x1614C20")]
			internal void <AsyncJobExecutor_Execute>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051168", Offset="0x1051168")]
		private sealed class <AsyncJobExecutor_Execute>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private object <>2__current;

			[FieldOffset(Offset="0x20")]
			private JobExecutor.<>c__DisplayClass1_0 <>8__1;

			[FieldOffset(Offset="0x28")]
			private JobExecutor.AsyncJob[] <jobs>5__2;

			[FieldOffset(Offset="0x30")]
			private Dictionary<JobExecutor.AsyncJob, int> <expectedExecutionOrder>5__3;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA="0x1615268", Offset="0x1615268", VA="0x1615268", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x16152D8", Offset="0x16152D8", VA="0x16152D8", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1614BD0", Offset="0x1614BD0", VA="0x1614BD0")]
			[DebuggerHidden]
			public <AsyncJobExecutor_Execute>d__1(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1614C30", Offset="0x1614C30", VA="0x1614C30", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1615270", Offset="0x1615270", VA="0x1615270", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1614C2C", Offset="0x1614C2C", VA="0x1614C2C", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051148", Offset="0x1051148")]
		private sealed class <SyncJobExecutor_Execute>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private object <>2__current;

			[FieldOffset(Offset="0x20")]
			private JobExecutor.<>c__DisplayClass0_0 <>8__1;

			[FieldOffset(Offset="0x28")]
			private JobExecutor.AsyncJob[] <jobs>5__2;

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Address(RVA="0x161578C", Offset="0x161578C", VA="0x161578C", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x16157FC", Offset="0x16157FC", VA="0x16157FC", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1614B44", Offset="0x1614B44", VA="0x1614B44")]
			[DebuggerHidden]
			public <SyncJobExecutor_Execute>d__0(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x16152E4", Offset="0x16152E4", VA="0x16152E4", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1615794", Offset="0x1615794", VA="0x1615794", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x16152E0", Offset="0x16152E0", VA="0x16152E0", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		private class AsyncJob : IJob
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CCE0", Offset="0x106CCE0")]
			[FieldOffset(Offset="0x10")]
			private int <CompletedOrder>k__BackingField;

			[FieldOffset(Offset="0x0")]
			private static int s_numCompleted;

			[FieldOffset(Offset="0x14")]
			private int _delayMS;

			public int CompletedOrder
			{
				[Address(RVA="0x1615260", Offset="0x1615260", VA="0x1615260")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E490", Offset="0x108E490")]
				get
				{
					return new int();
				}
				[Address(RVA="0x1615804", Offset="0x1615804", VA="0x1615804")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E4A0", Offset="0x108E4A0")]
				private set
				{
				}
			}

			[Address(RVA="0x1615234", Offset="0x1615234", VA="0x1615234")]
			public AsyncJob(int delayMS)
			{
			}

			[Address(RVA="0x1615810", Offset="0x1615810", VA="0x1615810")]
			[Attribute(Name="AsyncStateMachineAttribute", RVA="0x108E4B0", Offset="0x108E4B0")]
			private void Delay(Action finished)
			{
			}

			[Address(RVA="0x161580C", Offset="0x161580C", VA="0x161580C", Slot="4")]
			public void Execute(Action executed)
			{
			}

			[Address(RVA="0x16151E4", Offset="0x16151E4", VA="0x16151E4")]
			public static void Reset()
			{
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10516A8", Offset="0x10516A8")]
			private struct <Delay>d__7 : IAsyncStateMachine
			{
				[FieldOffset(Offset="0x0")]
				public int <>1__state;

				[FieldOffset(Offset="0x8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[FieldOffset(Offset="0x28")]
				public JobExecutor.AsyncJob <>4__this;

				[FieldOffset(Offset="0x30")]
				public Action finished;

				[FieldOffset(Offset="0x38")]
				private TaskAwaiter <>u__1;

				[Address(RVA="0xF0AFC0", Offset="0xF0AFC0", VA="0xF0AFC0", Slot="4")]
				private void MoveNext()
				{
				}

				[Address(RVA="0xF0AFC8", Offset="0xF0AFC8", VA="0xF0AFC8", Slot="5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}
		}
	}
}