using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class GuiRenderer : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		private GuiRenderableManager _renderableManager;

		[Address(RVA="0x1838A88", Offset="0x1838A88", VA="0x1838A88")]
		public GuiRenderer()
		{
		}

		[Address(RVA="0x1838A54", Offset="0x1838A54", VA="0x1838A54")]
		[Attribute(Name="InjectAttribute", RVA="0x1073D9C", Offset="0x1073D9C")]
		private void Construct(GuiRenderableManager renderableManager)
		{
		}

		[Address(RVA="0x1838A5C", Offset="0x1838A5C", VA="0x1838A5C")]
		public void OnGUI()
		{
		}
	}
}