using Glunies;
using Il2CppDummyDll;
using System;
using Zenject;

namespace Glunies.Inferno
{
	public class MainInfernoState : AInfernoState
	{
		[Attribute(Name="InjectAttribute", RVA="0x1064AE0", Offset="0x1064AE0")]
		[FieldOffset(Offset="0x10")]
		private DiContainer _container;

		[FieldOffset(Offset="0x18")]
		private MainController _mainController;

		[FieldOffset(Offset="0x20")]
		private uint _timeScaleId;

		[Address(RVA="0x1525458", Offset="0x1525458", VA="0x1525458")]
		public MainInfernoState()
		{
		}

		[Address(RVA="0x152530C", Offset="0x152530C", VA="0x152530C", Slot="4")]
		public override void Entering(ITransitionContext context)
		{
		}

		[Address(RVA="0x1525390", Offset="0x1525390", VA="0x1525390", Slot="5")]
		public override void Exiting()
		{
		}

		[Address(RVA="0x1525424", Offset="0x1525424", VA="0x1525424", Slot="6")]
		public override void TickUpdate()
		{
		}
	}
}