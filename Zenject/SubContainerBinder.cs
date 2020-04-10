using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class SubContainerBinder
	{
		[FieldOffset(Offset="0x10")]
		private readonly BindInfo _bindInfo;

		[FieldOffset(Offset="0x18")]
		private readonly BindFinalizerWrapper _finalizerWrapper;

		[FieldOffset(Offset="0x20")]
		private readonly object _subIdentifier;

		protected IBindingFinalizer SubFinalizer
		{
			[Address(RVA="0x2334D80", Offset="0x2334D80", VA="0x2334D80")]
			set
			{
			}
		}

		[Address(RVA="0x2334D28", Offset="0x2334D28", VA="0x2334D28")]
		public SubContainerBinder(BindInfo bindInfo, BindFinalizerWrapper finalizerWrapper, object subIdentifier)
		{
		}

		[Address(RVA="0x2AFBDE4", Offset="0x2AFBDE4", VA="0x2AFBDE4")]
		public ScopeConditionCopyNonLazyBinder ByInstaller<TInstaller>()
		where TInstaller : InstallerBase
		{
			return null;
		}

		[Address(RVA="0x2334DB8", Offset="0x2334DB8", VA="0x2334DB8")]
		public ScopeConditionCopyNonLazyBinder ByInstaller(Type installerType)
		{
			return null;
		}

		[Address(RVA="0x2334ED4", Offset="0x2334ED4", VA="0x2334ED4")]
		public ScopeConditionCopyNonLazyBinder ByMethod(Action<DiContainer> installerMethod)
		{
			return null;
		}

		[Address(RVA="0x2334FC0", Offset="0x2334FC0", VA="0x2334FC0")]
		public NameTransformScopeConditionCopyNonLazyBinder ByNewPrefab(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x23350E4", Offset="0x23350E4", VA="0x23350E4")]
		public NameTransformScopeConditionCopyNonLazyBinder ByNewPrefabResource(string resourcePath)
		{
			return null;
		}
	}
}