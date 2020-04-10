using Il2CppDummyDll;
using System;
using UnityEngine;

namespace TechArt
{
	public class BattleAreaProxyCameraComponent : MonoBehaviour
	{
		[FieldOffset(Offset="0x0")]
		[SerializeField]
		public static GameObject battleProxyCameraGameObject;

		[Address(RVA="0x1321730", Offset="0x1321730", VA="0x1321730")]
		public BattleAreaProxyCameraComponent()
		{
		}

		[Address(RVA="0x13216D0", Offset="0x13216D0", VA="0x13216D0")]
		private void Awake()
		{
		}
	}
}