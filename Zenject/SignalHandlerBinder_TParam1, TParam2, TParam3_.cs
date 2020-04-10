using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class SignalHandlerBinder<TParam1, TParam2, TParam3>
	{
		[FieldOffset(Offset="0x0")]
		private readonly BindFinalizerWrapper _finalizerWrapper;

		[FieldOffset(Offset="0x0")]
		private readonly Type _signalType;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060A24", Offset="0x1060A24")]
		[FieldOffset(Offset="0x0")]
		private object <Identifier>k__BackingField;

		protected object Identifier
		{
			[Address(RVA="0x2BA56E0", Offset="0x2BA56E0", VA="0x2BA56E0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073F6C", Offset="0x1073F6C")]
			get
			{
				return null;
			}
			[Address(RVA="0x2BA56E8", Offset="0x2BA56E8", VA="0x2BA56E8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073F7C", Offset="0x1073F7C")]
			set
			{
			}
		}

		[Address(RVA="0x2BA5694", Offset="0x2BA5694", VA="0x2BA5694")]
		public SignalHandlerBinder(DiContainer container, Type signalType, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x2AFD9C8", Offset="0x2AFD9C8", VA="0x2AFD9C8")]
		public SignalFromBinder<THandler> To<THandler>(Action<THandler, TParam1, TParam2, TParam3> method)
		{
			return null;
		}

		[Address(RVA="0x2AFDDE8", Offset="0x2AFDDE8", VA="0x2AFDDE8")]
		public SignalFromBinder<THandler> To<THandler>(Func<THandler, Action<TParam1, TParam2, TParam3>> methodGetter)
		{
			return null;
		}

		[Address(RVA="0x2BA56F0", Offset="0x2BA56F0", VA="0x2BA56F0")]
		public void To(Action<TParam1, TParam2, TParam3> method)
		{
		}
	}
}