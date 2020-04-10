using Cinemachine;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

public class BattleCamera : MonoBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x0")]
	private const int ARRAY_GROWTH_COUNT = 5;

	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private CinemachineVirtualCamera _battleCam;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private CinemachineTargetGroup _transitionTargetGroup;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private PlayableDirector _introDirector;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private GameObject _victoryCameraRoot;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private PlayableDirector _victoryDirector;

	[FieldOffset(Offset="0x40")]
	private GluniesBattleComposer _battleComposer;

	public LogCategory LogCategory
	{
		[Address(RVA="0x11380D0", Offset="0x11380D0", VA="0x11380D0", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x11398C0", Offset="0x11398C0", VA="0x11398C0")]
	public BattleCamera()
	{
	}

	[Address(RVA="0x113838C", Offset="0x113838C", VA="0x113838C")]
	public void AddOpenSpawnPosition(Vector3 pos)
	{
	}

	[Address(RVA="0x1139624", Offset="0x1139624", VA="0x1139624")]
	public void CopyTransformAndLens(CinemachineVirtualCameraBase camera, float fovZoomPercent)
	{
	}

	[Address(RVA="0x11380D8", Offset="0x11380D8", VA="0x11380D8")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1138CC8", Offset="0x1138CC8", VA="0x1138CC8")]
	public void PlayIntro()
	{
	}

	[Address(RVA="0x11390D4", Offset="0x11390D4", VA="0x11390D4")]
	public void PlayVictory()
	{
	}

	[Address(RVA="0x1138454", Offset="0x1138454", VA="0x1138454")]
	public void RemoveOpenSpawnPositions()
	{
	}

	[Address(RVA="0x113828C", Offset="0x113828C", VA="0x113828C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x11384EC", Offset="0x11384EC", VA="0x11384EC")]
	public void StartTracking(BattleUnit unit)
	{
	}

	[Address(RVA="0x11389AC", Offset="0x11389AC", VA="0x11389AC")]
	public void StopTracking(BattleUnit unit)
	{
	}

	[Address(RVA="0x1138388", Offset="0x1138388", VA="0x1138388")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1138C18", Offset="0x1138C18", VA="0x1138C18")]
	public void TrackTarget(BattleUnit unit)
	{
	}
}