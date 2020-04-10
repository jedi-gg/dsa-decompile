using System;

namespace Zenject
{
	public interface ISignalHandler
	{
		void Execute(object[] args);
	}
}