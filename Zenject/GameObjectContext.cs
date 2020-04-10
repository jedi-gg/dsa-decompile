using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class GameObjectContext : RunnableContext
	{
		[FieldOffset(Offset="0x48")]
		private readonly List<object> _dependencyRoots;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x10602A4", Offset="0x10602A4")]
		[Attribute(Name="TooltipAttribute", RVA="0x10602A4", Offset="0x10602A4")]
		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private MonoKernel _kernel;

		[FieldOffset(Offset="0x58")]
		private DiContainer _container;

		public override DiContainer Container
		{
			[Address(RVA="0x18367A0", Offset="0x18367A0", VA="0x18367A0", Slot="4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1837648", Offset="0x1837648", VA="0x1837648")]
		public GameObjectContext()
		{
		}

		[Address(RVA="0x183686C", Offset="0x183686C", VA="0x183686C")]
		[Attribute(Name="InjectAttribute", RVA="0x1072B98", Offset="0x1072B98")]
		public void Construct(DiContainer parentContainer)
		{
		}

		[Address(RVA="0x1836FE0", Offset="0x1836FE0", VA="0x1836FE0", Slot="6")]
		protected override void GetInjectableMonoBehaviours(List<MonoBehaviour> monoBehaviours)
		{
		}

		[Address(RVA="0x18367A8", Offset="0x18367A8", VA="0x18367A8", Slot="5")]
		public override IEnumerable<GameObject> GetRootGameObjects()
		{
			return null;
		}

		[Address(RVA="0x1836D5C", Offset="0x1836D5C", VA="0x1836D5C")]
		private void InstallBindings(List<MonoBehaviour> injectableMonoBehaviours)
		{
		}

		[Address(RVA="0x1836964", Offset="0x1836964", VA="0x1836964", Slot="7")]
		protected override void RunInternal()
		{
		}
	}
}