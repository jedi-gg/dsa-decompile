using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class UnitDetailsWorldSpaceComponent
{
	[Attribute(Name="InjectAttribute", RVA="0x105F4B0", Offset="0x105F4B0")]
	[FieldOffset(Offset="0x10")]
	private SingleAssetRegistry _unitModelAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105F4C0", Offset="0x105F4C0")]
	[FieldOffset(Offset="0x18")]
	private UnitVisualSequencerFactory _unitVisualSequencerFactory;

	[FieldOffset(Offset="0x20")]
	private UnitDetailsWorldSpaceComponent.SerializedFields _serializedFields;

	[FieldOffset(Offset="0x28")]
	private Transform _modelTransform;

	[FieldOffset(Offset="0x30")]
	private UnitVisualSequencer _idleSequencer;

	[FieldOffset(Offset="0x38")]
	private UnitVisualSequencer _idleSequencerImmediate;

	[FieldOffset(Offset="0x40")]
	private UnitVisualSequencer _upgradeCelebrationSequencer;

	[FieldOffset(Offset="0x48")]
	private UnitVisualSequencer _skinEquippedSequencer;

	[FieldOffset(Offset="0x50")]
	private string _loadedPrefabName;

	[Address(RVA="0x11EC2A8", Offset="0x11EC2A8", VA="0x11EC2A8")]
	public UnitDetailsWorldSpaceComponent()
	{
	}

	[Address(RVA="0x11EC04C", Offset="0x11EC04C", VA="0x11EC04C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071014", Offset="0x1071014")]
	private void <ShutdownSequencers>g__ShutdownSequencer|8_0(ref UnitVisualSequencer sequencer)
	{
	}

	[Address(RVA="0x11DD770", Offset="0x11DD770", VA="0x11DD770")]
	public void Initialize(UnitDetailsWorldSpaceComponent.SerializedFields serializedFields)
	{
	}

	[Address(RVA="0x11DDB00", Offset="0x11DDB00", VA="0x11DDB00")]
	public void LoadModel(string prefabName, UnitVisualSequencerType initialAnim = 0)
	{
	}

	[Address(RVA="0x11DD874", Offset="0x11DD874", VA="0x11DD874")]
	public void LoadVisualSequencers(DiContainer diContainer, Action finished)
	{
	}

	[Address(RVA="0x11EC1C4", Offset="0x11EC1C4", VA="0x11EC1C4")]
	private void ModelDragged(PointerEventData pointerData)
	{
	}

	[Address(RVA="0x11DE9FC", Offset="0x11DE9FC", VA="0x11DE9FC")]
	public void PlayCelebration()
	{
	}

	[Address(RVA="0x11EBEB0", Offset="0x11EBEB0", VA="0x11EBEB0")]
	public void PlaySkinAnimation()
	{
	}

	[Address(RVA="0x11E658C", Offset="0x11E658C", VA="0x11E658C")]
	public void ResetUnitRotation()
	{
	}

	[Address(RVA="0x11E84C4", Offset="0x11E84C4", VA="0x11E84C4")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x11EBE64", Offset="0x11EBE64", VA="0x11EBE64")]
	private void ShutdownSequencers()
	{
	}

	[Address(RVA="0x11E4E60", Offset="0x11E4E60", VA="0x11E4E60")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D0AC", Offset="0x104D0AC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitDetailsWorldSpaceComponent <>4__this;

		[FieldOffset(Offset="0x18")]
		public UnitVisualSequencerType initialAnim;

		[Address(RVA="0x11EBEA8", Offset="0x11EBEA8", VA="0x11EBEA8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x11EC2B0", Offset="0x11EC2B0", VA="0x11EC2B0")]
		internal void <LoadModel>b__0(AssetHandle assetHandle)
		{
		}
	}

	private struct DScreenRatioCameraDistance
	{
		[FieldOffset(Offset="0x0")]
		public Vector2 ScreenRatio;

		[FieldOffset(Offset="0x8")]
		public float CameraDistance;
	}

	[Serializable]
	public class SerializedFields
	{
		[FieldOffset(Offset="0x10")]
		public Transform UnitObjectWorldParent;

		[FieldOffset(Offset="0x18")]
		public Camera WorldSpaceCamera;

		[FieldOffset(Offset="0x20")]
		public GameObject LoadingSpinner;

		[FieldOffset(Offset="0x28")]
		public UiDragHandler DragHandler;

		[Address(RVA="0x11EC864", Offset="0x11EC864", VA="0x11EC864")]
		public SerializedFields()
		{
		}
	}
}