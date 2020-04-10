using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class TransformConditionCopyNonLazyBinder : ConditionCopyNonLazyBinder
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FF38", Offset="0x105FF38")]
		[FieldOffset(Offset="0x18")]
		private GameObjectCreationParameters <GameObjectInfo>k__BackingField;

		protected GameObjectCreationParameters GameObjectInfo
		{
			[Address(RVA="0x233C1CC", Offset="0x233C1CC", VA="0x233C1CC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072274", Offset="0x1072274")]
			get
			{
				return null;
			}
			[Address(RVA="0x233C1C4", Offset="0x233C1C4", VA="0x233C1C4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072284", Offset="0x1072284")]
			private set
			{
			}
		}

		[Address(RVA="0x233C198", Offset="0x233C198", VA="0x233C198")]
		public TransformConditionCopyNonLazyBinder(Zenject.BindInfo bindInfo, GameObjectCreationParameters gameObjInfo)
		{
		}

		[Address(RVA="0x233C1D4", Offset="0x233C1D4", VA="0x233C1D4")]
		public ConditionCopyNonLazyBinder UnderTransform(Transform parent)
		{
			return null;
		}

		[Address(RVA="0x233C220", Offset="0x233C220", VA="0x233C220")]
		public ConditionCopyNonLazyBinder UnderTransform(Func<InjectContext, Transform> parentGetter)
		{
			return null;
		}

		[Address(RVA="0x233C26C", Offset="0x233C26C", VA="0x233C26C")]
		public ConditionCopyNonLazyBinder UnderTransformGroup(string transformGroupname)
		{
			return null;
		}
	}
}