using System;

namespace Zenject
{
	public interface IMemoryPool
	{
		Type ItemType
		{
			get;
		}

		int NumActive
		{
			get;
		}

		int NumInactive
		{
			get;
		}

		int NumTotal
		{
			get;
		}
	}
}