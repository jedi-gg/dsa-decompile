using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class TransformScopeConditionCopyNonLazyBinder : ScopeConditionCopyNonLazyBinder
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FF68", Offset="0x105FF68")]
		[FieldOffset(Offset="0x18")]
		private GameObjectCreationParameters <GameObjectInfo>k__BackingField;

		protected GameObjectCreationParameters GameObjectInfo
		{
			[Address(RVA="0x233C52C", Offset="0x233C52C", VA="0x233C52C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10722D4", Offset="0x10722D4")]
			get
			{
				return null;
			}
			[Address(RVA="0x233C524", Offset="0x233C524", VA="0x233C524")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10722E4", Offset="0x10722E4")]
			private set
			{
			}
		}

		[Address(RVA="0x233C4F8", Offset="0x233C4F8", VA="0x233C4F8")]
		public TransformScopeConditionCopyNonLazyBinder(Zenject.BindInfo bindInfo, GameObjectCreationParameters gameObjectInfo)
		{
		}

		[Address(RVA="0x233C534", Offset="0x233C534", VA="0x233C534")]
		public ScopeConditionCopyNonLazyBinder UnderTransform(Transform parent)
		{
			return null;
		}

		[Address(RVA="0x233C580", Offset="0x233C580", VA="0x233C580")]
		public ScopeConditionCopyNonLazyBinder UnderTransform(Func<InjectContext, Transform> parentGetter)
		{
			return null;
		}

		[Address(RVA="0x233C5CC", Offset="0x233C5CC", VA="0x233C5CC")]
		public ScopeConditionCopyNonLazyBinder UnderTransformGroup(string transformGroupname)
		{
			return null;
		}
	}
}