using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Attribute(Name="CreateAssetMenuAttribute", RVA="0x1049B24", Offset="0x1049B24")]
	public class Sequence : ScriptableObject
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private List<ASequenceAction> _actions;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private List<BindingDefinition> _bindingDefinitions;

		public List<ASequenceAction> Actions
		{
			[Address(RVA="0x1533364", Offset="0x1533364", VA="0x1533364")]
			get
			{
				return null;
			}
		}

		public List<BindingDefinition> BindingDefinitions
		{
			[Address(RVA="0x153336C", Offset="0x153336C", VA="0x153336C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1533374", Offset="0x1533374", VA="0x1533374")]
		public Sequence()
		{
		}
	}
}