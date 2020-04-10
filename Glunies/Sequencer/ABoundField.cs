using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public abstract class ABoundField
	{
		[FieldOffset(Offset="0x10")]
		[SerializeField]
		private BindingDefinition _bindingDefinition;

		[FieldOffset(Offset="0x18")]
		protected Binding _binding;

		public bool IsBound
		{
			[Address(RVA="0x152AE30", Offset="0x152AE30", VA="0x152AE30")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x152AFF4", Offset="0x152AFF4", VA="0x152AFF4")]
		protected ABoundField()
		{
		}

		[Address(RVA="0x152AE40", Offset="0x152AE40", VA="0x152AE40")]
		public void Initialize(List<Binding> bindings)
		{
		}
	}
}