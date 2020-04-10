using System;

namespace Zenject
{
	public interface IMemoryPool<TValue> : IMemoryPool
	{
		void Despawn(TValue item);

		TValue Spawn();
	}
}