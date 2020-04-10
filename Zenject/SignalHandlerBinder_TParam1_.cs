using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class SignalHandlerBinder<TParam1>
	{
		[FieldOffset(Offset="0x0")]
		private readonly BindFinalizerWrapper _finalizerWrapper;

		[FieldOffset(Offset="0x0")]
		private readonly Type _signalType;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060A04", Offset="0x1060A04")]
		[FieldOffset(Offset="0x0")]
		private object <Identifier>k__BackingField;

		protected object Identifier
		{
			[Address(RVA="0x2BA5140", Offset="0x2BA5140", VA="0x2BA5140")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073F2C", Offset="0x1073F2C")]
			get
			{
				return null;
			}
			[Address(RVA="0x2BA5148", Offset="0x2BA5148", VA="0x2BA5148")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073F3C", Offset="0x1073F3C")]
			set
			{
			}
		}

		[Address(RVA="0x2BA50F4", Offset="0x2BA50F4", VA="0x2BA50F4")]
		public SignalHandlerBinder(DiContainer container, Type signalType, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x2AFC948", Offset="0x2AFC948", VA="0x2AFC948")]
		public SignalFromBinder<THandler> To<THandler>(Action<THandler, TParam1> method)
		{
			return null;
		}

		[Address(RVA="0x2AFCD68", Offset="0x2AFCD68", VA="0x2AFCD68")]
		public SignalFromBinder<THandler> To<THandler>(Func<THandler, Action<TParam1>> methodGetter)
		{
			return null;
		}

		[Address(RVA="0x2BA5150", Offset="0x2BA5150", VA="0x2BA5150")]
		public void To(Action<TParam1> method)
		{
		}
	}
}