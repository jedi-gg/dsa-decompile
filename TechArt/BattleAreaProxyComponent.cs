using Il2CppDummyDll;
using System;
using UnityEngine;

namespace TechArt
{
	public class BattleAreaProxyComponent : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		public string[] Areas;

		[Address(RVA="0x1321AD0", Offset="0x1321AD0", VA="0x1321AD0")]
		public BattleAreaProxyComponent()
		{
		}

		[Address(RVA="0x1321A54", Offset="0x1321A54", VA="0x1321A54")]
		public void CleanUp()
		{
		}

		[Address(RVA="0x1321738", Offset="0x1321738", VA="0x1321738")]
		private void OnDrawGizmosSelected()
		{
		}

		[Address(RVA="0x13218D0", Offset="0x13218D0", VA="0x13218D0")]
		public void SetArea(string areaString)
		{
		}
	}
}