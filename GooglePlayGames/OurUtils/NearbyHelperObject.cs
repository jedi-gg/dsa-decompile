using GooglePlayGames.BasicApi.Nearby;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
	public class NearbyHelperObject : MonoBehaviour
	{
		[FieldOffset(Offset="0x0")]
		private static NearbyHelperObject instance;

		[FieldOffset(Offset="0x8")]
		private static double mAdvertisingRemaining;

		[FieldOffset(Offset="0x10")]
		private static double mDiscoveryRemaining;

		[FieldOffset(Offset="0x18")]
		private static INearbyConnectionClient mClient;

		[Address(RVA="0x12D545C", Offset="0x12D545C", VA="0x12D545C")]
		static NearbyHelperObject()
		{
		}

		[Address(RVA="0x12D4E44", Offset="0x12D4E44", VA="0x12D4E44")]
		public NearbyHelperObject()
		{
		}

		[Address(RVA="0x12D5014", Offset="0x12D5014", VA="0x12D5014")]
		public void Awake()
		{
		}

		[Address(RVA="0x12D4CA4", Offset="0x12D4CA4", VA="0x12D4CA4")]
		public static void CreateObject(INearbyConnectionClient client)
		{
		}

		[Address(RVA="0x12D5090", Offset="0x12D5090", VA="0x12D5090")]
		public void OnDisable()
		{
		}

		[Address(RVA="0x12D4F0C", Offset="0x12D4F0C", VA="0x12D4F0C")]
		public static void StartAdvertisingTimer(TimeSpan? span)
		{
		}

		[Address(RVA="0x12D4F90", Offset="0x12D4F90", VA="0x12D4F90")]
		public static void StartDiscoveryTimer(TimeSpan? span)
		{
		}

		[Address(RVA="0x12D4E4C", Offset="0x12D4E4C", VA="0x12D4E4C")]
		private static double ToSeconds(TimeSpan? span)
		{
			return new double();
		}

		[Address(RVA="0x12D5160", Offset="0x12D5160", VA="0x12D5160")]
		public void Update()
		{
		}
	}
}