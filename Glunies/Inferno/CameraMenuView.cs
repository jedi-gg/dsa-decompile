using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

namespace Glunies.Inferno
{
	public class CameraMenuView : AStandardView, IDispatchHandler<DMenuToggleAction>, IDispatchHandler
	{
		[FieldOffset(Offset="0x68")]
		private bool _manuallyUpdatingZoomValue;

		private CameraMenuView.SerializedFields Fields
		{
			[Address(RVA="0x151FFB4", Offset="0x151FFB4", VA="0x151FFB4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x15205D0", Offset="0x15205D0", VA="0x15205D0")]
		public CameraMenuView()
		{
		}

		[Address(RVA="0x1520094", Offset="0x1520094", VA="0x1520094", Slot="21")]
		public void HandleDispatchAction(DMenuToggleAction action)
		{
		}

		[Address(RVA="0x1520540", Offset="0x1520540", VA="0x1520540")]
		private void MoveToggleChanged(bool isOn)
		{
		}

		[Address(RVA="0x15204A0", Offset="0x15204A0", VA="0x15204A0")]
		private void RotateToggleChanged(bool isOn)
		{
		}

		[Address(RVA="0x151FEA8", Offset="0x151FEA8", VA="0x151FEA8")]
		public void SetZoom(float zoomPercent)
		{
		}

		[Address(RVA="0x15200F8", Offset="0x15200F8", VA="0x15200F8", Slot="11")]
		protected override void ViewAssetLoaded()
		{
		}

		[Address(RVA="0x15202E8", Offset="0x15202E8", VA="0x15202E8", Slot="12")]
		protected override void ViewShuttingDown()
		{
		}

		[Address(RVA="0x15203F4", Offset="0x15203F4", VA="0x15203F4")]
		private void ZoomSliderChanged(float zoomPercent)
		{
		}

		[Serializable]
		public class SerializedFields : ViewSerializedFields
		{
			[FieldOffset(Offset="0x28")]
			public Slider ZoomSlider;

			[FieldOffset(Offset="0x30")]
			public Toggle RotateToggle;

			[FieldOffset(Offset="0x38")]
			public Toggle MoveToggle;

			[Address(RVA="0x15205D8", Offset="0x15205D8", VA="0x15205D8")]
			public SerializedFields()
			{
			}
		}
	}
}