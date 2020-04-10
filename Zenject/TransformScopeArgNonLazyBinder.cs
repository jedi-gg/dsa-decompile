using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class TransformScopeArgNonLazyBinder : ScopeArgNonLazyBinder
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FF58", Offset="0x105FF58")]
		[FieldOffset(Offset="0x18")]
		private GameObjectCreationParameters <GameObjectInfo>k__BackingField;

		protected GameObjectCreationParameters GameObjectInfo
		{
			[Address(RVA="0x233C40C", Offset="0x233C40C", VA="0x233C40C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10722B4", Offset="0x10722B4")]
			get
			{
				return null;
			}
			[Address(RVA="0x233C404", Offset="0x233C404", VA="0x233C404")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10722C4", Offset="0x10722C4")]
			private set
			{
			}
		}

		[Address(RVA="0x233C3D8", Offset="0x233C3D8", VA="0x233C3D8")]
		public TransformScopeArgNonLazyBinder(Zenject.BindInfo bindInfo, GameObjectCreationParameters gameObjectInfo)
		{
		}

		[Address(RVA="0x233C414", Offset="0x233C414", VA="0x233C414")]
		public ScopeArgNonLazyBinder UnderTransform(Transform parent)
		{
			return null;
		}

		[Address(RVA="0x233C460", Offset="0x233C460", VA="0x233C460")]
		public ScopeArgNonLazyBinder UnderTransform(Func<InjectContext, Transform> parentGetter)
		{
			return null;
		}

		[Address(RVA="0x233C4AC", Offset="0x233C4AC", VA="0x233C4AC")]
		public ScopeArgNonLazyBinder UnderTransformGroup(string transformGroupname)
		{
			return null;
		}
	}
}