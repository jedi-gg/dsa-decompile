using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Glunies
{
	public class AsyncOperator<T> : ILoggable<LogCategory>
	where T : AAsyncOperation
	{
		[FieldOffset(Offset="0x0")]
		protected Action<T> _operationFinished;

		[FieldOffset(Offset="0x0")]
		private List<T> _operations;

		public LogCategory LogCategory
		{
			[Address(RVA="0x1C001D0", Offset="0x1C001D0", VA="0x1C001D0", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		public int NumActiveOperations
		{
			[Address(RVA="0x1C001D8", Offset="0x1C001D8", VA="0x1C001D8")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x1C00354", Offset="0x1C00354", VA="0x1C00354")]
		public AsyncOperator(Action<T> requestFinished)
		{
		}

		[Address(RVA="0x1C003DC", Offset="0x1C003DC", VA="0x1C003DC")]
		public void AddOperation(T request)
		{
		}

		[Address(RVA="0x1C0042C", Offset="0x1C0042C", VA="0x1C0042C")]
		public T FindOperation(Predicate<T> match)
		{
			return null;
		}

		[Address(RVA="0x1C00598", Offset="0x1C00598", VA="0x1C00598")]
		private void FinishOperation(T operation)
		{
		}

		[Address(RVA="0x1C00218", Offset="0x1C00218", VA="0x1C00218")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x1C0047C", Offset="0x1C0047C", VA="0x1C0047C")]
		public void TickUpdate()
		{
		}
	}
}