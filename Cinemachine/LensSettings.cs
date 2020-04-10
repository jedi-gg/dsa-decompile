using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104ABCC", Offset="0x104ABCC")]
	[Serializable]
	public struct LensSettings
	{
		[FieldOffset(Offset="0x0")]
		public static LensSettings Default;

		[Attribute(Name="RangeAttribute", RVA="0x10692C0", Offset="0x10692C0")]
		[Attribute(Name="TooltipAttribute", RVA="0x10692C0", Offset="0x10692C0")]
		[FieldOffset(Offset="0x0")]
		public float FieldOfView;

		[Attribute(Name="TooltipAttribute", RVA="0x1069318", Offset="0x1069318")]
		[FieldOffset(Offset="0x4")]
		public float OrthographicSize;

		[Attribute(Name="TooltipAttribute", RVA="0x1069350", Offset="0x1069350")]
		[FieldOffset(Offset="0x8")]
		public float NearClipPlane;

		[Attribute(Name="TooltipAttribute", RVA="0x1069388", Offset="0x1069388")]
		[FieldOffset(Offset="0xC")]
		public float FarClipPlane;

		[Attribute(Name="RangeAttribute", RVA="0x10693C0", Offset="0x10693C0")]
		[Attribute(Name="TooltipAttribute", RVA="0x10693C0", Offset="0x10693C0")]
		[FieldOffset(Offset="0x10")]
		public float Dutch;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106941C", Offset="0x106941C")]
		[FieldOffset(Offset="0x14")]
		private bool <Orthographic>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106942C", Offset="0x106942C")]
		[FieldOffset(Offset="0x18")]
		private float <Aspect>k__BackingField;

		internal float Aspect
		{
			[Address(RVA="0xF011AC", Offset="0xF011AC", VA="0xF011AC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AF74", Offset="0x108AF74")]
			get
			{
				return new float();
			}
			[Address(RVA="0xF011B4", Offset="0xF011B4", VA="0xF011B4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AF84", Offset="0x108AF84")]
			set
			{
			}
		}

		internal bool Orthographic
		{
			[Address(RVA="0xF01198", Offset="0xF01198", VA="0xF01198")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AF54", Offset="0x108AF54")]
			get
			{
				return new bool();
			}
			[Address(RVA="0xF011A0", Offset="0xF011A0", VA="0xF011A0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AF64", Offset="0x108AF64")]
			set
			{
			}
		}

		[Address(RVA="0x145FD10", Offset="0x145FD10", VA="0x145FD10")]
		static LensSettings()
		{
		}

		[Address(RVA="0xF011BC", Offset="0xF011BC", VA="0xF011BC")]
		public LensSettings(float fov, float orthographicSize, float nearClip, float farClip, float dutch, bool ortho, float aspect)
		{
		}

		[Address(RVA="0x145F998", Offset="0x145F998", VA="0x145F998")]
		public static LensSettings FromCamera(Camera fromCamera)
		{
			return new LensSettings();
		}

		[Address(RVA="0x145FBB8", Offset="0x145FBB8", VA="0x145FBB8")]
		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t)
		{
			return new LensSettings();
		}

		[Address(RVA="0xF011E0", Offset="0xF011E0", VA="0xF011E0")]
		public void Validate()
		{
		}
	}
}