using Il2CppDummyDll;
using System;

namespace Glunies
{
	public class AnonymousJob : IJob
	{
		[FieldOffset(Offset="0x10")]
		private AnonymousJob.Work _work;

		[Address(RVA="0x14F6BA0", Offset="0x14F6BA0", VA="0x14F6BA0")]
		public AnonymousJob(AnonymousJob.Work work)
		{
		}

		[Address(RVA="0x14FA5FC", Offset="0x14FA5FC", VA="0x14FA5FC", Slot="4")]
		public void Execute(Action executed)
		{
		}

		public delegate void Work(Action finished);
	}
}