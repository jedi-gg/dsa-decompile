using System;

namespace Glunies
{
	public interface IDispatchHandler<T> : IDispatchHandler
	where T : struct
	{
		void HandleDispatchAction(T action);
	}
}