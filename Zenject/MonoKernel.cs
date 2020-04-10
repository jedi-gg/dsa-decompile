using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public abstract class MonoKernel : MonoBehaviour
	{
		[Attribute(Name="InjectLocalAttribute", RVA="0x1060774", Offset="0x1060774")]
		[FieldOffset(Offset="0x18")]
		private TickableManager _tickableManager;

		[Attribute(Name="InjectLocalAttribute", RVA="0x1060784", Offset="0x1060784")]
		[FieldOffset(Offset="0x20")]
		private InitializableManager _initializableManager;

		[Attribute(Name="InjectLocalAttribute", RVA="0x1060794", Offset="0x1060794")]
		[FieldOffset(Offset="0x28")]
		private DisposableManager _disposablesManager;

		[FieldOffset(Offset="0x30")]
		private bool _hasInitialized;

		[FieldOffset(Offset="0x31")]
		private bool _isDestroyed;

		protected bool IsDestroyed
		{
			[Address(RVA="0x183DC00", Offset="0x183DC00", VA="0x183DC00")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x183DCC0", Offset="0x183DCC0", VA="0x183DCC0")]
		protected MonoKernel()
		{
		}

		[Address(RVA="0x183DC20", Offset="0x183DC20", VA="0x183DC20", Slot="6")]
		public virtual void FixedUpdate()
		{
		}

		[Address(RVA="0x1836FA0", Offset="0x1836FA0", VA="0x1836FA0")]
		public void Initialize()
		{
		}

		[Address(RVA="0x183DC34", Offset="0x183DC34", VA="0x183DC34", Slot="7")]
		public virtual void LateUpdate()
		{
		}

		[Address(RVA="0x183DC48", Offset="0x183DC48", VA="0x183DC48", Slot="8")]
		public virtual void OnDestroy()
		{
		}

		[Address(RVA="0x183DC08", Offset="0x183DC08", VA="0x183DC08", Slot="4")]
		public virtual void Start()
		{
		}

		[Address(RVA="0x183DC0C", Offset="0x183DC0C", VA="0x183DC0C", Slot="5")]
		public virtual void Update()
		{
		}
	}
}