using System;

namespace Glunies
{
	public interface IJob
	{
		void Execute(Action executed);
	}
}