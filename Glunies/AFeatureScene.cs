using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies
{
	public abstract class AFeatureScene : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		protected Camera _mainCamera;

		[FieldOffset(Offset="0x20")]
		private float _originalFov;

		[FieldOffset(Offset="0x24")]
		private Color _originalBackgroundColor;

		[FieldOffset(Offset="0x34")]
		private float _originalNearClip;

		[FieldOffset(Offset="0x38")]
		private float _originalFarClip;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private GameObject _rootObject;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		protected Camera _camera;

		[Address(RVA="0x14F5F6C", Offset="0x14F5F6C", VA="0x14F5F6C")]
		protected AFeatureScene()
		{
		}

		[Address(RVA="0x14F585C", Offset="0x14F585C", VA="0x14F585C", Slot="4")]
		public virtual void Initialize()
		{
		}

		[Address(RVA="0x14F5EBC", Offset="0x14F5EBC", VA="0x14F5EBC", Slot="6")]
		public virtual void Show(bool show)
		{
		}

		[Address(RVA="0x14F5CD8", Offset="0x14F5CD8", VA="0x14F5CD8", Slot="5")]
		public virtual void Shutdown()
		{
		}
	}
}