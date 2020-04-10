using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	[DebuggerStepThrough]
	public abstract class TaskUpdater<TTask>
	{
		[FieldOffset(Offset="0x0")]
		private readonly LinkedList<TaskUpdater<TTask>.TaskInfo> _tasks;

		[FieldOffset(Offset="0x0")]
		private readonly List<TaskUpdater<TTask>.TaskInfo> _queuedTasks;

		private IEnumerable<TaskUpdater<TTask>.TaskInfo> ActiveTasks
		{
			[Address(RVA="0x2BAE20C", Offset="0x2BAE20C", VA="0x2BAE20C")]
			get
			{
				return null;
			}
		}

		private IEnumerable<TaskUpdater<TTask>.TaskInfo> AllTasks
		{
			[Address(RVA="0x2BAE1B8", Offset="0x2BAE1B8", VA="0x2BAE1B8")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2BAEBC4", Offset="0x2BAEBC4", VA="0x2BAEBC4")]
		protected TaskUpdater()
		{
		}

		[Address(RVA="0x2BAE9D0", Offset="0x2BAE9D0", VA="0x2BAE9D0")]
		private void AddQueuedTasks()
		{
		}

		[Address(RVA="0x2BAE214", Offset="0x2BAE214", VA="0x2BAE214")]
		public void AddTask(TTask task, int priority)
		{
		}

		[Address(RVA="0x2BAE268", Offset="0x2BAE268", VA="0x2BAE268")]
		private void AddTaskInternal(TTask task, int priority)
		{
		}

		[Address(RVA="0x2BAE8FC", Offset="0x2BAE8FC", VA="0x2BAE8FC")]
		private void ClearRemovedTasks(LinkedList<TaskUpdater<TTask>.TaskInfo> tasks)
		{
		}

		[Address(RVA="0x2BAEAA8", Offset="0x2BAEAA8", VA="0x2BAEAA8")]
		private void InsertTaskSorted(TaskUpdater<TTask>.TaskInfo task)
		{
		}

		[Address(RVA="0x2BAE750", Offset="0x2BAE750", VA="0x2BAE750")]
		public void OnFrameStart()
		{
		}

		[Address(RVA="0x2BAE598", Offset="0x2BAE598", VA="0x2BAE598")]
		public void RemoveTask(TTask task)
		{
		}

		[Address(RVA="0x2BAE78C", Offset="0x2BAE78C", VA="0x2BAE78C")]
		public void UpdateAll()
		{
		}

		protected abstract void UpdateItem(TTask task);

		[Address(RVA="0x2BAE7D0", Offset="0x2BAE7D0", VA="0x2BAE7D0")]
		public void UpdateRange(int minPriority, int maxPriority)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E158", Offset="0x104E158")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TaskUpdater<TTask>.<>c <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<TaskUpdater<TTask>.TaskInfo, TTask> <>9__7_0;

			[Address(RVA="0x2BADFD8", Offset="0x2BADFD8", VA="0x2BADFD8")]
			static <>c()
			{
			}

			[Address(RVA="0x2BAE0B0", Offset="0x2BAE0B0", VA="0x2BAE0B0")]
			public <>c()
			{
			}

			[Address(RVA="0x2BAE0DC", Offset="0x2BAE0DC", VA="0x2BAE0DC")]
			internal TTask <AddTaskInternal>b__7_0(TaskUpdater<TTask>.TaskInfo x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E168", Offset="0x104E168")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset="0x0")]
			public TTask task;

			[Address(RVA="0x2BAE108", Offset="0x2BAE108", VA="0x2BAE108")]
			public <>c__DisplayClass8_0()
			{
			}

			[Address(RVA="0x2BAE134", Offset="0x2BAE134", VA="0x2BAE134")]
			internal bool <RemoveTask>b__0(TaskUpdater<TTask>.TaskInfo x)
			{
				return new bool();
			}
		}

		private class TaskInfo
		{
			[FieldOffset(Offset="0x0")]
			public TTask Task;

			[FieldOffset(Offset="0x0")]
			public int Priority;

			[FieldOffset(Offset="0x0")]
			public bool IsRemoved;

			[Address(RVA="0x2BAE170", Offset="0x2BAE170", VA="0x2BAE170")]
			public TaskInfo(TTask task, int priority)
			{
			}
		}
	}
}