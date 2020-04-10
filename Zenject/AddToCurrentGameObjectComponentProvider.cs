using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class AddToCurrentGameObjectComponentProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly object _concreteIdentifier;

		[FieldOffset(Offset="0x18")]
		private readonly Type _componentType;

		[FieldOffset(Offset="0x20")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x28")]
		private readonly List<TypeValuePair> _extraArguments;

		protected Type ComponentType
		{
			[Address(RVA="0x15A9204", Offset="0x15A9204", VA="0x15A9204")]
			get
			{
				return null;
			}
		}

		protected object ConcreteIdentifier
		{
			[Address(RVA="0x15A920C", Offset="0x15A920C", VA="0x15A920C")]
			get
			{
				return null;
			}
		}

		protected DiContainer Container
		{
			[Address(RVA="0x15A91FC", Offset="0x15A91FC", VA="0x15A91FC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x15A9168", Offset="0x15A9168", VA="0x15A9168")]
		public AddToCurrentGameObjectComponentProvider(DiContainer container, Type componentType, object concreteIdentifier, List<TypeValuePair> extraArguments)
		{
		}

		[Address(RVA="0x15A921C", Offset="0x15A921C", VA="0x15A921C", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072D84", Offset="0x1072D84")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x15A9214", Offset="0x15A9214", VA="0x15A9214", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DDE8", Offset="0x104DDE8")]
		private sealed class <GetAllInstancesWithInjectSplit>d__12 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public InjectContext context;

			[FieldOffset(Offset="0x28")]
			public AddToCurrentGameObjectComponentProvider <>4__this;

			[FieldOffset(Offset="0x30")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x38")]
			private object <instance>5__2;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x15AA824", Offset="0x15AA824", VA="0x15AA824", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x15AA894", Offset="0x15AA894", VA="0x15AA894", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x15A92C8", Offset="0x15A92C8", VA="0x15A92C8")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__12(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x15A92F8", Offset="0x15A92F8", VA="0x15A92F8", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x15AA82C", Offset="0x15AA82C", VA="0x15AA82C", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x15A92F4", Offset="0x15A92F4", VA="0x15A92F4", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}