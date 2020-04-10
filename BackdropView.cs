using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BackdropView : AView, IDispatchHandler<DBackdropViewShowPatternAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	public const int DEFAULT_PATTERN = 0;

	[FieldOffset(Offset="0x0")]
	public const int ANIMATED_STARS = 1;

	[FieldOffset(Offset="0x0")]
	public const int ABILITY_UPGRADE = 2;

	[FieldOffset(Offset="0x68")]
	private List<BackdropStar> _animatedStars;

	[FieldOffset(Offset="0x70")]
	private List<BackdropSparkle> _backdropSparkles;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x1160010", Offset="0x1160010", VA="0x1160010", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x1160000", Offset="0x1160000", VA="0x1160000", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private BackdropView.SerializedFields Fields
	{
		[Address(RVA="0x1160018", Offset="0x1160018", VA="0x1160018")]
		get
		{
			return null;
		}
	}

	public override RenderMode MainCanvasRenderMode
	{
		[Address(RVA="0x1160008", Offset="0x1160008", VA="0x1160008", Slot="6")]
		get
		{
			return new RenderMode();
		}
	}

	[Address(RVA="0x11607E4", Offset="0x11607E4", VA="0x11607E4")]
	public BackdropView()
	{
	}

	[Address(RVA="0x11600F8", Offset="0x11600F8", VA="0x11600F8", Slot="21")]
	public void HandleDispatchAction(DBackdropViewShowPatternAction action)
	{
	}

	[Address(RVA="0x115ED1C", Offset="0x115ED1C", VA="0x115ED1C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11601F4", Offset="0x11601F4", VA="0x11601F4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11605FC", Offset="0x11605FC", VA="0x11605FC", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class BackdropStarGroup
	{
		[FieldOffset(Offset="0x10")]
		public BackdropStar AnimatedStarArchetype;

		[FieldOffset(Offset="0x18")]
		public int StarsToCreate;

		[Address(RVA="0x1160854", Offset="0x1160854", VA="0x1160854")]
		public BackdropStarGroup()
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x1069904", Offset="0x1069904")]
		[FieldOffset(Offset="0x28")]
		public List<UnityEngine.GameObject> CustomPatterns;

		[Attribute(Name="HeaderAttribute", RVA="0x106993C", Offset="0x106993C")]
		[FieldOffset(Offset="0x30")]
		public List<BackdropView.BackdropStarGroup> BackdropStarGroups;

		[Address(RVA="0x116085C", Offset="0x116085C", VA="0x116085C")]
		public SerializedFields()
		{
		}
	}
}