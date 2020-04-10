using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class SubObjectRefComponent : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		protected GameObject _defaultReference;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		protected List<DSubObjectReference> _references;

		public GameObject DefaultReference
		{
			[Address(RVA="0x15363E0", Offset="0x15363E0", VA="0x15363E0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1536470", Offset="0x1536470", VA="0x1536470")]
			set
			{
			}
		}

		public List<DSubObjectReference> References
		{
			[Address(RVA="0x1536478", Offset="0x1536478", VA="0x1536478")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1536480", Offset="0x1536480", VA="0x1536480")]
		public SubObjectRefComponent()
		{
		}

		[Address(RVA="0x152E508", Offset="0x152E508", VA="0x152E508")]
		public GameObject GetReferencedObject(string id)
		{
			return null;
		}
	}
}