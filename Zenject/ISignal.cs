using System;

namespace Zenject
{
	public interface ISignal : ISignalBase
	{
		void Fire();

		void Listen(Action listener);

		void Unlisten(Action listener);
	}
}