using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Glunies
{
	public abstract class AJobExecutor : ILoggable<LogCategory>
	{
		[FieldOffset(Offset="0x10")]
		protected List<IJob> _jobs;

		[FieldOffset(Offset="0x18")]
		protected int _remainingJobs;

		[FieldOffset(Offset="0x20")]
		protected Action _executed;

		[FieldOffset(Offset="0x28")]
		private bool _clearOnFinish;

		public bool HasJobs
		{
			[Address(RVA="0x14F6984", Offset="0x14F6984", VA="0x14F6984")]
			get
			{
				return new bool();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x14F697C", Offset="0x14F697C", VA="0x14F697C", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x14F6E10", Offset="0x14F6E10", VA="0x14F6E10")]
		protected AJobExecutor()
		{
		}

		[Address(RVA="0x14F69F0", Offset="0x14F69F0", VA="0x14F69F0")]
		public void Add(IJob job)
		{
		}

		[Address(RVA="0x14F6AB8", Offset="0x14F6AB8", VA="0x14F6AB8")]
		public void Add(AnonymousJob.Work work)
		{
		}

		protected abstract void BeginExecution();

		[Address(RVA="0x14F6BCC", Offset="0x14F6BCC", VA="0x14F6BCC")]
		public void ClearJobs()
		{
		}

		[Address(RVA="0x14F6C80", Offset="0x14F6C80", VA="0x14F6C80")]
		public void Execute(Action executed, bool clearOnFinish = false)
		{
		}

		[Address(RVA="0x14F6DCC", Offset="0x14F6DCC", VA="0x14F6DCC")]
		protected void FinishExecuting()
		{
		}

		protected abstract void FinishJob();
	}
}