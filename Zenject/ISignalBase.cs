using System;

namespace Zenject
{
	public interface ISignalBase
	{
		bool HasHandler
		{
			get;
		}

		int NumHandlers
		{
			get;
		}
	}
}