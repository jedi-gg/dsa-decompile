using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class TransformScopeArgConditionCopyNonLazyBinder : ScopeArgConditionCopyNonLazyBinder
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FF48", Offset="0x105FF48")]
		[FieldOffset(Offset="0x18")]
		private GameObjectCreationParameters <GameObjectInfo>k__BackingField;

		protected GameObjectCreationParameters GameObjectInfo
		{
			[Address(RVA="0x233C2EC", Offset="0x233C2EC", VA="0x233C2EC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072294", Offset="0x1072294")]
			get
			{
				return null;
			}
			[Address(RVA="0x233C2E4", Offset="0x233C2E4", VA="0x233C2E4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10722A4", Offset="0x10722A4")]
			private set
			{
			}
		}

		[Address(RVA="0x233C2B8", Offset="0x233C2B8", VA="0x233C2B8")]
		public TransformScopeArgConditionCopyNonLazyBinder(Zenject.BindInfo bindInfo, GameObjectCreationParameters gameObjectInfo)
		{
		}

		[Address(RVA="0x233C2F4", Offset="0x233C2F4", VA="0x233C2F4")]
		public ScopeArgConditionCopyNonLazyBinder UnderTransform(Transform parent)
		{
			return null;
		}

		[Address(RVA="0x233C340", Offset="0x233C340", VA="0x233C340")]
		public ScopeArgConditionCopyNonLazyBinder UnderTransform(Func<InjectContext, Transform> parentGetter)
		{
			return null;
		}

		[Address(RVA="0x233C38C", Offset="0x233C38C", VA="0x233C38C")]
		public ScopeArgConditionCopyNonLazyBinder UnderTransformGroup(string transformGroupname)
		{
			return null;
		}
	}
}