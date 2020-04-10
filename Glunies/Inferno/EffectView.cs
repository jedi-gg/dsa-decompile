using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies.Inferno
{
	public class EffectView : AStandardView, IDispatchHandler<DMenuToggleAction>, IDispatchHandler
	{
		[FieldOffset(Offset="0x0")]
		private const float DEFAULT_EXPIRE_TIME = 2f;

		[Attribute(Name="InjectAttribute", RVA="0x106495C", Offset="0x106495C")]
		[FieldOffset(Offset="0x68")]
		private AssetIdCache _assetIdCache;

		[FieldOffset(Offset="0x70")]
		private List<string> _effectAssetIds;

		private EffectView.SerializedFields Fields
		{
			[Address(RVA="0x1521C94", Offset="0x1521C94", VA="0x1521C94")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1522688", Offset="0x1522688", VA="0x1522688")]
		public EffectView()
		{
		}

		[Address(RVA="0x1522708", Offset="0x1522708", VA="0x1522708")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A810", Offset="0x108A810")]
		private string <UpdateEffectOptions>b__11_0(string e)
		{
			return null;
		}

		[Address(RVA="0x15226F8", Offset="0x15226F8", VA="0x15226F8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A7F0", Offset="0x108A7F0")]
		private void <ViewAssetLoaded>b__6_0()
		{
		}

		[Address(RVA="0x1522700", Offset="0x1522700", VA="0x1522700")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A800", Offset="0x108A800")]
		private void <ViewAssetLoaded>b__6_1()
		{
		}

		[Address(RVA="0x1521754", Offset="0x1521754", VA="0x1521754")]
		public void ClearEffects()
		{
		}

		[Address(RVA="0x1522454", Offset="0x1522454", VA="0x1522454")]
		private void DispatchViewAction(DEffectMenuViewAction.Type actionType)
		{
		}

		[Address(RVA="0x1521EFC", Offset="0x1521EFC", VA="0x1521EFC")]
		private void EnableEffectControls(bool enable)
		{
		}

		[Address(RVA="0x1521F84", Offset="0x1521F84", VA="0x1521F84", Slot="21")]
		public void HandleDispatchAction(DMenuToggleAction action)
		{
		}

		[Address(RVA="0x15224D8", Offset="0x15224D8", VA="0x15224D8")]
		private void PlayEffectVisual()
		{
		}

		[Address(RVA="0x15216CC", Offset="0x15216CC", VA="0x15216CC")]
		public void SetEffects(List<string> effectAssetIds)
		{
		}

		[Address(RVA="0x15210AC", Offset="0x15210AC", VA="0x15210AC")]
		public void SetRemaingTime(float remainingTime)
		{
		}

		[Address(RVA="0x1521AE4", Offset="0x1521AE4", VA="0x1521AE4")]
		public void ShowCreateTarget(bool show)
		{
		}

		[Address(RVA="0x1520FF0", Offset="0x1520FF0", VA="0x1520FF0")]
		public void ShowStop(bool show)
		{
		}

		[Address(RVA="0x152260C", Offset="0x152260C", VA="0x152260C")]
		private void StopEffectVisual()
		{
		}

		[Address(RVA="0x1521D74", Offset="0x1521D74", VA="0x1521D74")]
		private void UpdateEffectOptions(List<string> effectAssetIds)
		{
		}

		[Address(RVA="0x1521FE8", Offset="0x1521FE8", VA="0x1521FE8", Slot="11")]
		protected override void ViewAssetLoaded()
		{
		}

		[Address(RVA="0x15222CC", Offset="0x15222CC", VA="0x15222CC", Slot="12")]
		protected override void ViewShuttingDown()
		{
		}

		[Serializable]
		public class SerializedFields : ViewSerializedFields
		{
			[FieldOffset(Offset="0x28")]
			[SerializeField]
			public TMP_Dropdown EffectDropdown;

			[FieldOffset(Offset="0x30")]
			[SerializeField]
			public Button PlayButton;

			[FieldOffset(Offset="0x38")]
			[SerializeField]
			public Button StopButton;

			[FieldOffset(Offset="0x40")]
			[SerializeField]
			public TMP_InputField EffectExpireLabel;

			[FieldOffset(Offset="0x48")]
			[SerializeField]
			public Button CreateTargetButton;

			[FieldOffset(Offset="0x50")]
			[SerializeField]
			public Button DestroyTargetButton;

			[FieldOffset(Offset="0x58")]
			[SerializeField]
			public TMP_Text EffectRemainingTimeLabel;

			[Address(RVA="0x1522754", Offset="0x1522754", VA="0x1522754")]
			public SerializedFields()
			{
			}
		}
	}
}