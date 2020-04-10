using System;

namespace Zenject
{
	public interface IMemoryPool<TValue, in TParam1> : IMemoryPool
	{
		void Despawn(TValue item);

		TValue Spawn(TParam1 param);
	}
}