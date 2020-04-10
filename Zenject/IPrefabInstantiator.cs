using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public interface IPrefabInstantiator
	{
		Type ArgumentTarget
		{
			get;
		}

		List<TypeValuePair> ExtraArguments
		{
			get;
		}

		Zenject.GameObjectCreationParameters GameObjectCreationParameters
		{
			get;
		}

		UnityEngine.Object GetPrefab();

		IEnumerator<GameObject> Instantiate(List<TypeValuePair> args);
	}
}