using System;
using System.Collections.Generic;

namespace Zenject
{
	public interface IProvider
	{
		IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args);

		Type GetInstanceType(InjectContext context);
	}
}