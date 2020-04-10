using Il2CppDummyDll;
using ModestTree.Util;
using System;

namespace Zenject
{
	public abstract class SignalHandlerBinder<TParam1, TParam2, TParam3, TParam4>
	{
		[FieldOffset(Offset="0x0")]
		private readonly BindFinalizerWrapper _finalizerWrapper;

		[FieldOffset(Offset="0x0")]
		private readonly Type _signalType;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060A34", Offset="0x1060A34")]
		[FieldOffset(Offset="0x0")]
		private object <Identifier>k__BackingField;

		protected object Identifier
		{
			[Address(RVA="0x2BA59B0", Offset="0x2BA59B0", VA="0x2BA59B0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073F8C", Offset="0x1073F8C")]
			get
			{
				return null;
			}
			[Address(RVA="0x2BA59B8", Offset="0x2BA59B8", VA="0x2BA59B8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073F9C", Offset="0x1073F9C")]
			set
			{
			}
		}

		[Address(RVA="0x2BA5964", Offset="0x2BA5964", VA="0x2BA5964")]
		public SignalHandlerBinder(DiContainer container, Type signalType, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x2AFE208", Offset="0x2AFE208", VA="0x2AFE208")]
		public SignalFromBinder<THandler> To<THandler>(ModestTree.Util.Action<THandler, TParam1, TParam2, TParam3, TParam4> method)
		{
			return null;
		}

		[Address(RVA="0x2AFE628", Offset="0x2AFE628", VA="0x2AFE628")]
		public SignalFromBinder<THandler> To<THandler>(Func<THandler, Action<TParam1, TParam2, TParam3, TParam4>> methodGetter)
		{
			return null;
		}

		[Address(RVA="0x2BA59C0", Offset="0x2BA59C0", VA="0x2BA59C0")]
		public void To(Action<TParam1, TParam2, TParam3, TParam4> method)
		{
		}
	}
}