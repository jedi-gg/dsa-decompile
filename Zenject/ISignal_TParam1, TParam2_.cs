using System;

namespace Zenject
{
	public interface ISignal<TParam1, TParam2> : ISignalBase
	{
		void Fire(TParam1 p1, TParam2 p2);

		void Listen(Action<TParam1, TParam2> listener);

		void Unlisten(Action<TParam1, TParam2> listener);
	}
}