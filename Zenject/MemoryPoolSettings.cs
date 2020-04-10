using Il2CppDummyDll;
using System;

namespace Zenject
{
	[Serializable]
	public class MemoryPoolSettings
	{
		[FieldOffset(Offset="0x10")]
		public int InitialSize;

		[FieldOffset(Offset="0x14")]
		public PoolExpandMethods ExpandMethod;

		[Address(RVA="0x183D770", Offset="0x183D770", VA="0x183D770")]
		public MemoryPoolSettings()
		{
		}
	}
}