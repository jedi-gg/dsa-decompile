using System;

namespace Zenject
{
	public interface ISignal<TParam1> : ISignalBase
	{
		void Fire(TParam1 p1);

		void Listen(Action<TParam1> listener);

		void Unlisten(Action<TParam1> listener);
	}
}