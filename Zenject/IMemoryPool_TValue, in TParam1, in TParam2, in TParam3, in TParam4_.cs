using System;

namespace Zenject
{
	public interface IMemoryPool<TValue, in TParam1, in TParam2, in TParam3, in TParam4> : IMemoryPool
	{
		void Despawn(TValue item);

		TValue Spawn(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
	}
}