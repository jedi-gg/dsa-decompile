using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class SignalHandlerBinder
	{
		[FieldOffset(Offset="0x10")]
		private readonly BindFinalizerWrapper _finalizerWrapper;

		[FieldOffset(Offset="0x18")]
		private readonly Type _signalType;

		[FieldOffset(Offset="0x20")]
		private readonly DiContainer _container;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10609F4", Offset="0x10609F4")]
		[FieldOffset(Offset="0x28")]
		private object <Identifier>k__BackingField;

		protected object Identifier
		{
			[Address(RVA="0x23321DC", Offset="0x23321DC", VA="0x23321DC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073F0C", Offset="0x1073F0C")]
			get
			{
				return null;
			}
			[Address(RVA="0x23321E4", Offset="0x23321E4", VA="0x23321E4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1073F1C", Offset="0x1073F1C")]
			set
			{
			}
		}

		[Address(RVA="0x233219C", Offset="0x233219C", VA="0x233219C")]
		public SignalHandlerBinder(DiContainer container, Type signalType, BindFinalizerWrapper finalizerWrapper)
		{
		}

		[Address(RVA="0x2AFC120", Offset="0x2AFC120", VA="0x2AFC120")]
		public SignalFromBinder<THandler> To<THandler>(Action<THandler> method)
		{
			return null;
		}

		[Address(RVA="0x2AFC534", Offset="0x2AFC534", VA="0x2AFC534")]
		public SignalFromBinder<THandler> To<THandler>(Func<THandler, Action> methodGetter)
		{
			return null;
		}

		[Address(RVA="0x23321EC", Offset="0x23321EC", VA="0x23321EC")]
		public void To(Action method)
		{
		}
	}
}