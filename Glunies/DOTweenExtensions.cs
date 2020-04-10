using DG.Tweening;
using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies
{
	public static class DOTweenExtensions
	{
		[Address(RVA="0x1420A64", Offset="0x1420A64", VA="0x1420A64")]
		public static Tweener DOAlpha(CanvasRenderer canvasRenderer, float endValue, float duration)
		{
			return null;
		}

		[Address(RVA="0x1420BD0", Offset="0x1420BD0", VA="0x1420BD0")]
		public static Tweener DOAlpha(Graphic graphic, float endValue, float duration)
		{
			return null;
		}

		[Address(RVA="0x1420C18", Offset="0x1420C18", VA="0x1420C18")]
		public static Tweener DoColor(CanvasRenderer canvasRenderer, Color endValue, float duration)
		{
			return null;
		}

		[Address(RVA="0x1420DAC", Offset="0x1420DAC", VA="0x1420DAC")]
		public static Tweener DoColor(Graphic graphic, Color endValue, float duration)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050D78", Offset="0x1050D78")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public CanvasRenderer canvasRenderer;

			[Address(RVA="0x1420BC8", Offset="0x1420BC8", VA="0x1420BC8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x1420E1C", Offset="0x1420E1C", VA="0x1420E1C")]
			internal void <DOAlpha>b__0(float x)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050D88", Offset="0x1050D88")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public CanvasRenderer canvasRenderer;

			[Address(RVA="0x1420DA4", Offset="0x1420DA4", VA="0x1420DA4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x1420E5C", Offset="0x1420E5C", VA="0x1420E5C")]
			internal void <DoColor>b__0(Color x)
			{
			}
		}
	}
}