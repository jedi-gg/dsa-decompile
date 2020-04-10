using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class SignalHandlerBinder<TParam1, TParam2>
	{
		[FieldOffset(Offset="0x0")]
		private readonly BindFinalizerWrapper _finalizerWrapper;

		[FieldOffset(Offset="0x0")]
		private readonly Type _signalType;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060A14", Offset="0x1060A14")]
		[FieldOffset(Offset="0x0")]
		private object <Identifier>k__BackingField;

		protected object Identifier
		{
			[Address(RVA="0x2BA5410", Offset="0x2BA5410", VA="0x2BA5410")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073F4C", Offset="0x1073F4C")]
			get
			{
				return null;
			}
			[Address(RVA="0x2BA5418", Offset="0x2BA5418", VA="0x2BA5418")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073F5C", Offset="0x1073F5C")]
			set
			{
			}
		}

		[Address(RVA="0x2BA53C4", Offset="0x2BA53C4", VA="0x2BA53C4")]
		public SignalHandlerBinder(DiContainer container, Type signalType, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x2AFD188", Offset="0x2AFD188", VA="0x2AFD188")]
		public SignalFromBinder<THandler> To<THandler>(Action<THandler, TParam1, TParam2> method)
		{
			return null;
		}

		[Address(RVA="0x2AFD5A8", Offset="0x2AFD5A8", VA="0x2AFD5A8")]
		public SignalFromBinder<THandler> To<THandler>(Func<THandler, Action<TParam1, TParam2>> methodGetter)
		{
			return null;
		}

		[Address(RVA="0x2BA5420", Offset="0x2BA5420", VA="0x2BA5420")]
		public void To(Action<TParam1, TParam2> method)
		{
		}
	}
}