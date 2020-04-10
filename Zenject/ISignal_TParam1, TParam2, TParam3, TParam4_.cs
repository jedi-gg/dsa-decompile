using System;

namespace Zenject
{
	public interface ISignal<TParam1, TParam2, TParam3, TParam4> : ISignalBase
	{
		void Fire(TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4);

		void Listen(Action<TParam1, TParam2, TParam3, TParam4> listener);

		void Unlisten(Action<TParam1, TParam2, TParam3, TParam4> listener);
	}
}