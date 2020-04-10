using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Glunies.Sequencer
{
	public class TriggerAnimationAction : ASequenceAction, IDiContainerSequenceAction
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065518", Offset="0x1065518")]
		[FieldOffset(Offset="0x28")]
		private Zenject.DiContainer <DiContainer>k__BackingField;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundString _triggerName;

		[FieldOffset(Offset="0x40")]
		private BattleUnitsController _battleUnitsController;

		public Zenject.DiContainer DiContainer
		{
			[Address(RVA="0x16136C0", Offset="0x16136C0", VA="0x16136C0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A8D0", Offset="0x108A8D0")]
			get
			{
				return JustDecompileGenerated_get_DiContainer();
			}
			[Address(RVA="0x16136C8", Offset="0x16136C8", VA="0x16136C8", Slot="12")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A8E0", Offset="0x108A8E0")]
			set
			{
				JustDecompileGenerated_set_DiContainer(value);
			}
		}

		private Zenject.DiContainer JustDecompileGenerated_get_DiContainer()
		{
			return null;
		}

		public void JustDecompileGenerated_set_DiContainer(Zenject.DiContainer value)
		{
		}

		[Address(RVA="0x16139E8", Offset="0x16139E8", VA="0x16139E8")]
		public TriggerAnimationAction()
		{
		}

		[Address(RVA="0x16136D0", Offset="0x16136D0", VA="0x16136D0", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1613774", Offset="0x1613774", VA="0x1613774", Slot="8")]
		protected override void InternalPlay()
		{
		}
	}
}