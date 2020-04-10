using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class FeatureLockController : IDispatchHandler<DLockableFeatureUpdatedDynamicMessage>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	private readonly static Dictionary<Type, LockableFeature> s_typeToLockableFeature;

	[FieldOffset(Offset="0x8")]
	private readonly static Dictionary<LockableFeature, BadgingSource> s_lockableFeatureToBadgingSource;

	[FieldOffset(Offset="0x10")]
	private readonly static Dictionary<DeepLinkLocation, LockableFeature> s_deepLinkLocationToLockableFeature;

	[Attribute(Name="InjectAttribute", RVA="0x1058400", Offset="0x1058400")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1058410", Offset="0x1058410")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058420", Offset="0x1058420")]
	[FieldOffset(Offset="0x20")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058430", Offset="0x1058430")]
	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1058440", Offset="0x1058440")]
	[FieldOffset(Offset="0x30")]
	private SystemDialogManager _systemDialogManager;

	[FieldOffset(Offset="0x38")]
	private List<List<LockableFeature>> _recentlyUnlockedFeatures;

	[Address(RVA="0x12BA510", Offset="0x12BA510", VA="0x12BA510")]
	static FeatureLockController()
	{
	}

	[Address(RVA="0x12BA4A0", Offset="0x12BA4A0", VA="0x12BA4A0")]
	public FeatureLockController()
	{
	}

	[Address(RVA="0x12BA2E4", Offset="0x12BA2E4", VA="0x12BA2E4")]
	public void ClearRecentlyUnlockedFeatures(FeatureLockController.RecentlyUnlockedListener listener)
	{
	}

	[Address(RVA="0x12BA194", Offset="0x12BA194", VA="0x12BA194")]
	public BadgingSource GetAssociatedBadgingSource(LockableFeature lockableFeature)
	{
		return new BadgingSource();
	}

	[Address(RVA="0x12BA238", Offset="0x12BA238", VA="0x12BA238")]
	public List<LockableFeature> GetRecentlyUnlockedFeatures(FeatureLockController.RecentlyUnlockedListener listener)
	{
		return null;
	}

	[Address(RVA="0x12BA3B4", Offset="0x12BA3B4", VA="0x12BA3B4", Slot="4")]
	public void HandleDispatchAction(DLockableFeatureUpdatedDynamicMessage action)
	{
	}

	[Address(RVA="0x12B95CC", Offset="0x12B95CC", VA="0x12B95CC")]
	public void Initialize()
	{
	}

	[Address(RVA="0x12B9868", Offset="0x12B9868", VA="0x12B9868")]
	private bool IsDisabled(LockableFeature feature)
	{
		return new bool();
	}

	[Address(RVA="0x12B97A4", Offset="0x12B97A4", VA="0x12B97A4")]
	public bool IsUnlocked(Type type, bool showLockedMessage)
	{
		return new bool();
	}

	[Address(RVA="0x12B540C", Offset="0x12B540C", VA="0x12B540C")]
	public bool IsUnlocked(LockableFeature feature, bool showLockedMessage)
	{
		return new bool();
	}

	[Address(RVA="0x12BA0D0", Offset="0x12BA0D0", VA="0x12BA0D0")]
	public bool IsUnlocked(DeepLinkLocation deepLinkLocation, bool showLockedMessage)
	{
		return new bool();
	}

	[Address(RVA="0x12B9B50", Offset="0x12B9B50", VA="0x12B9B50")]
	private bool IsUnlocked(LockableFeature feature)
	{
		return new bool();
	}

	[Address(RVA="0x12B9E38", Offset="0x12B9E38", VA="0x12B9E38")]
	private void ShowLockedMessage(LockableFeature feature)
	{
	}

	[Address(RVA="0x12B9724", Offset="0x12B9724", VA="0x12B9724")]
	public void Shutdown()
	{
	}

	public enum RecentlyUnlockedListener
	{
		[FieldOffset(Offset="0x0")]
		PlayerLevelUp,
		[FieldOffset(Offset="0x0")]
		Home
	}
}