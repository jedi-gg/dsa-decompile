using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubWarScene : AFeatureScene
{
	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Transform _nodesRoot;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private ClubWarSceneEdge _edgeArchetype;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Vector3 _minExtentAdjust;

	[FieldOffset(Offset="0x6C")]
	[SerializeField]
	private Vector3 _maxExtentAdjust;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private GameObject _battleRoot;

	public ClubWarSceneEdge EdgeArchetype
	{
		[Address(RVA="0x14DADD0", Offset="0x14DADD0", VA="0x14DADD0")]
		get
		{
			return null;
		}
	}

	public Vector3 MaxExtentAdjust
	{
		[Address(RVA="0x14DADE4", Offset="0x14DADE4", VA="0x14DADE4")]
		get
		{
			return new Vector3();
		}
	}

	public Vector3 MinExtentAdjust
	{
		[Address(RVA="0x14DADD8", Offset="0x14DADD8", VA="0x14DADD8")]
		get
		{
			return new Vector3();
		}
	}

	[Address(RVA="0x14DAF00", Offset="0x14DAF00", VA="0x14DAF00")]
	public ClubWarScene()
	{
	}

	[Address(RVA="0x14DAE50", Offset="0x14DAE50", VA="0x14DAE50")]
	public void EnableBattle(bool enable)
	{
	}

	[Address(RVA="0x14DADF0", Offset="0x14DADF0", VA="0x14DADF0")]
	public ClubWarSceneNode[] GetNodes()
	{
		return null;
	}
}