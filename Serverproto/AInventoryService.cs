using Glunies;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public abstract class AInventoryService : AGameServiceClient
	{
		[Address(RVA="0x15FE4B4", Offset="0x15FE4B4", VA="0x15FE4B4")]
		protected AInventoryService()
		{
		}

		[Address(RVA="0x15FD344", Offset="0x15FD344", VA="0x15FD344")]
		public void AbilityUpgrade(AbilityUpgradeRequest request, Action<AbilityUpgradeResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::AbilityUpgrade(Serverproto.AbilityUpgradeRequest,System.Action`1<Serverproto.AbilityUpgradeResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void AbilityUpgrade(Serverproto.AbilityUpgradeRequest,System.Action<Serverproto.AbilityUpgradeResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FD438", Offset="0x15FD438", VA="0x15FD438", Slot="12")]
		protected virtual void AbilityUpgradeServiceSuccess(AbilityUpgradeResponse response)
		{
		}

		[Address(RVA="0x15FE2C4", Offset="0x15FE2C4", VA="0x15FE2C4")]
		public void BuyAndEquipAllGear(BuyAndEquipAllGearRequest request, Action<BuyAndEquipAllGearResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::BuyAndEquipAllGear(Serverproto.BuyAndEquipAllGearRequest,System.Action`1<Serverproto.BuyAndEquipAllGearResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void BuyAndEquipAllGear(Serverproto.BuyAndEquipAllGearRequest,System.Action<Serverproto.BuyAndEquipAllGearResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FE3B8", Offset="0x15FE3B8", VA="0x15FE3B8", Slot="20")]
		protected virtual void BuyAndEquipAllGearServiceSuccess(BuyAndEquipAllGearResponse response)
		{
		}

		[Address(RVA="0x15FE0D4", Offset="0x15FE0D4", VA="0x15FE0D4")]
		public void BuyAndEquipGear(BuyAndEquipGearRequest request, Action<BuyAndEquipGearResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::BuyAndEquipGear(Serverproto.BuyAndEquipGearRequest,System.Action`1<Serverproto.BuyAndEquipGearResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void BuyAndEquipGear(Serverproto.BuyAndEquipGearRequest,System.Action<Serverproto.BuyAndEquipGearResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FE1C8", Offset="0x15FE1C8", VA="0x15FE1C8", Slot="19")]
		protected virtual void BuyAndEquipGearServiceSuccess(BuyAndEquipGearResponse response)
		{
		}

		[Address(RVA="0x15FC728", Offset="0x15FC728", VA="0x15FC728")]
		protected void CacheResponse(PromoteUnitRequest request, PromoteUnitResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FC918", Offset="0x15FC918", VA="0x15FC918")]
		protected void CacheResponse(TrainUnitRequest request, TrainUnitResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FCB08", Offset="0x15FCB08", VA="0x15FCB08")]
		protected void CacheResponse(CraftInventoryItemRequest request, CraftInventoryItemResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FCCF8", Offset="0x15FCCF8", VA="0x15FCCF8")]
		protected void CacheResponse(EquipGearRequest request, EquipGearResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FCEE8", Offset="0x15FCEE8", VA="0x15FCEE8")]
		protected void CacheResponse(EquipAllGearRequest request, EquipAllGearResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FD0D8", Offset="0x15FD0D8", VA="0x15FD0D8")]
		protected void CacheResponse(GearTierUpRequest request, GearTierUpResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FD2C8", Offset="0x15FD2C8", VA="0x15FD2C8")]
		protected void CacheResponse(ItemFindRequest request, ItemFindResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FD4B8", Offset="0x15FD4B8", VA="0x15FD4B8")]
		protected void CacheResponse(AbilityUpgradeRequest request, AbilityUpgradeResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FD6A8", Offset="0x15FD6A8", VA="0x15FD6A8")]
		protected void CacheResponse(SpellUpgradeRequest request, SpellUpgradeResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FD898", Offset="0x15FD898", VA="0x15FD898")]
		protected void CacheResponse(EquipUnitSkinRequest request, EquipUnitSkinResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FDA88", Offset="0x15FDA88", VA="0x15FDA88")]
		protected void CacheResponse(EquipEmoteRequest request, EquipEmoteResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FDC78", Offset="0x15FDC78", VA="0x15FDC78")]
		protected void CacheResponse(EquipSorcererStoneRequest request, EquipSorcererStoneResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FDE68", Offset="0x15FDE68", VA="0x15FDE68")]
		protected void CacheResponse(UnequipSorcererStoneRequest request, UnequipSorcererStoneResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FE058", Offset="0x15FE058", VA="0x15FE058")]
		protected void CacheResponse(SwapSorcererStoneRequest request, SwapSorcererStoneResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FE248", Offset="0x15FE248", VA="0x15FE248")]
		protected void CacheResponse(BuyAndEquipGearRequest request, BuyAndEquipGearResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FE438", Offset="0x15FE438", VA="0x15FE438")]
		protected void CacheResponse(BuyAndEquipAllGearRequest request, BuyAndEquipAllGearResponse response, CacheSettings settings)
		{
		}

		[Address(RVA="0x15FC994", Offset="0x15FC994", VA="0x15FC994")]
		public void CraftItem(CraftInventoryItemRequest request, Action<CraftInventoryItemResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::CraftItem(Serverproto.CraftInventoryItemRequest,System.Action`1<Serverproto.CraftInventoryItemResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void CraftItem(Serverproto.CraftInventoryItemRequest,System.Action<Serverproto.CraftInventoryItemResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FCA88", Offset="0x15FCA88", VA="0x15FCA88", Slot="7")]
		protected virtual void CraftItemServiceSuccess(CraftInventoryItemResponse response)
		{
		}

		[Address(RVA="0x15FCD74", Offset="0x15FCD74", VA="0x15FCD74")]
		public void EquipAllGear(EquipAllGearRequest request, Action<EquipAllGearResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::EquipAllGear(Serverproto.EquipAllGearRequest,System.Action`1<Serverproto.EquipAllGearResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EquipAllGear(Serverproto.EquipAllGearRequest,System.Action<Serverproto.EquipAllGearResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FCE68", Offset="0x15FCE68", VA="0x15FCE68", Slot="9")]
		protected virtual void EquipAllGearServiceSuccess(EquipAllGearResponse response)
		{
		}

		[Address(RVA="0x15FD914", Offset="0x15FD914", VA="0x15FD914")]
		public void EquipEmote(EquipEmoteRequest request, Action<EquipEmoteResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::EquipEmote(Serverproto.EquipEmoteRequest,System.Action`1<Serverproto.EquipEmoteResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EquipEmote(Serverproto.EquipEmoteRequest,System.Action<Serverproto.EquipEmoteResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FDA08", Offset="0x15FDA08", VA="0x15FDA08", Slot="15")]
		protected virtual void EquipEmoteServiceSuccess(EquipEmoteResponse response)
		{
		}

		[Address(RVA="0x15FCB84", Offset="0x15FCB84", VA="0x15FCB84")]
		public void EquipGear(EquipGearRequest request, Action<EquipGearResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::EquipGear(Serverproto.EquipGearRequest,System.Action`1<Serverproto.EquipGearResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EquipGear(Serverproto.EquipGearRequest,System.Action<Serverproto.EquipGearResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FCC78", Offset="0x15FCC78", VA="0x15FCC78", Slot="8")]
		protected virtual void EquipGearServiceSuccess(EquipGearResponse response)
		{
		}

		[Address(RVA="0x15FDB04", Offset="0x15FDB04", VA="0x15FDB04")]
		public void EquipSorcererStone(EquipSorcererStoneRequest request, Action<EquipSorcererStoneResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::EquipSorcererStone(Serverproto.EquipSorcererStoneRequest,System.Action`1<Serverproto.EquipSorcererStoneResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EquipSorcererStone(Serverproto.EquipSorcererStoneRequest,System.Action<Serverproto.EquipSorcererStoneResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FDBF8", Offset="0x15FDBF8", VA="0x15FDBF8", Slot="16")]
		protected virtual void EquipSorcererStoneServiceSuccess(EquipSorcererStoneResponse response)
		{
		}

		[Address(RVA="0x15FD724", Offset="0x15FD724", VA="0x15FD724")]
		public void EquipUnitSkin(EquipUnitSkinRequest request, Action<EquipUnitSkinResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::EquipUnitSkin(Serverproto.EquipUnitSkinRequest,System.Action`1<Serverproto.EquipUnitSkinResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EquipUnitSkin(Serverproto.EquipUnitSkinRequest,System.Action<Serverproto.EquipUnitSkinResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FD818", Offset="0x15FD818", VA="0x15FD818", Slot="14")]
		protected virtual void EquipUnitSkinServiceSuccess(EquipUnitSkinResponse response)
		{
		}

		[Address(RVA="0x15FCF64", Offset="0x15FCF64", VA="0x15FCF64")]
		public void GearTierUp(GearTierUpRequest request, Action<GearTierUpResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::GearTierUp(Serverproto.GearTierUpRequest,System.Action`1<Serverproto.GearTierUpResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void GearTierUp(Serverproto.GearTierUpRequest,System.Action<Serverproto.GearTierUpResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FD058", Offset="0x15FD058", VA="0x15FD058", Slot="10")]
		protected virtual void GearTierUpServiceSuccess(GearTierUpResponse response)
		{
		}

		[Address(RVA="0x15FC6AC", Offset="0x15FC6AC", VA="0x15FC6AC")]
		protected PromoteUnitResponse GetCachedResponse(PromoteUnitRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FC89C", Offset="0x15FC89C", VA="0x15FC89C")]
		protected TrainUnitResponse GetCachedResponse(TrainUnitRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FCA8C", Offset="0x15FCA8C", VA="0x15FCA8C")]
		protected CraftInventoryItemResponse GetCachedResponse(CraftInventoryItemRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FCC7C", Offset="0x15FCC7C", VA="0x15FCC7C")]
		protected EquipGearResponse GetCachedResponse(EquipGearRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FCE6C", Offset="0x15FCE6C", VA="0x15FCE6C")]
		protected EquipAllGearResponse GetCachedResponse(EquipAllGearRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FD05C", Offset="0x15FD05C", VA="0x15FD05C")]
		protected GearTierUpResponse GetCachedResponse(GearTierUpRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FD24C", Offset="0x15FD24C", VA="0x15FD24C")]
		protected ItemFindResponse GetCachedResponse(ItemFindRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FD43C", Offset="0x15FD43C", VA="0x15FD43C")]
		protected AbilityUpgradeResponse GetCachedResponse(AbilityUpgradeRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FD62C", Offset="0x15FD62C", VA="0x15FD62C")]
		protected SpellUpgradeResponse GetCachedResponse(SpellUpgradeRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FD81C", Offset="0x15FD81C", VA="0x15FD81C")]
		protected EquipUnitSkinResponse GetCachedResponse(EquipUnitSkinRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FDA0C", Offset="0x15FDA0C", VA="0x15FDA0C")]
		protected EquipEmoteResponse GetCachedResponse(EquipEmoteRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FDBFC", Offset="0x15FDBFC", VA="0x15FDBFC")]
		protected EquipSorcererStoneResponse GetCachedResponse(EquipSorcererStoneRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FDDEC", Offset="0x15FDDEC", VA="0x15FDDEC")]
		protected UnequipSorcererStoneResponse GetCachedResponse(UnequipSorcererStoneRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FDFDC", Offset="0x15FDFDC", VA="0x15FDFDC")]
		protected SwapSorcererStoneResponse GetCachedResponse(SwapSorcererStoneRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FE1CC", Offset="0x15FE1CC", VA="0x15FE1CC")]
		protected BuyAndEquipGearResponse GetCachedResponse(BuyAndEquipGearRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FE3BC", Offset="0x15FE3BC", VA="0x15FE3BC")]
		protected BuyAndEquipAllGearResponse GetCachedResponse(BuyAndEquipAllGearRequest request)
		{
			return null;
		}

		[Address(RVA="0x15FD154", Offset="0x15FD154", VA="0x15FD154")]
		public void ItemFind(ItemFindRequest request, Action<ItemFindResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::ItemFind(Serverproto.ItemFindRequest,System.Action`1<Serverproto.ItemFindResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ItemFind(Serverproto.ItemFindRequest,System.Action<Serverproto.ItemFindResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FD248", Offset="0x15FD248", VA="0x15FD248", Slot="11")]
		protected virtual void ItemFindServiceSuccess(ItemFindResponse response)
		{
		}

		[Address(RVA="0x15FC5B4", Offset="0x15FC5B4", VA="0x15FC5B4")]
		public void PromoteUnit(PromoteUnitRequest request, Action<PromoteUnitResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::PromoteUnit(Serverproto.PromoteUnitRequest,System.Action`1<Serverproto.PromoteUnitResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void PromoteUnit(Serverproto.PromoteUnitRequest,System.Action<Serverproto.PromoteUnitResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FC6A8", Offset="0x15FC6A8", VA="0x15FC6A8", Slot="5")]
		protected virtual void PromoteUnitServiceSuccess(PromoteUnitResponse response)
		{
		}

		[Address(RVA="0x15FD534", Offset="0x15FD534", VA="0x15FD534")]
		public void SpellUpgrade(SpellUpgradeRequest request, Action<SpellUpgradeResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::SpellUpgrade(Serverproto.SpellUpgradeRequest,System.Action`1<Serverproto.SpellUpgradeResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void SpellUpgrade(Serverproto.SpellUpgradeRequest,System.Action<Serverproto.SpellUpgradeResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FD628", Offset="0x15FD628", VA="0x15FD628", Slot="13")]
		protected virtual void SpellUpgradeServiceSuccess(SpellUpgradeResponse response)
		{
		}

		[Address(RVA="0x15FDEE4", Offset="0x15FDEE4", VA="0x15FDEE4")]
		public void SwapSorcererStone(SwapSorcererStoneRequest request, Action<SwapSorcererStoneResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::SwapSorcererStone(Serverproto.SwapSorcererStoneRequest,System.Action`1<Serverproto.SwapSorcererStoneResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void SwapSorcererStone(Serverproto.SwapSorcererStoneRequest,System.Action<Serverproto.SwapSorcererStoneResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FDFD8", Offset="0x15FDFD8", VA="0x15FDFD8", Slot="18")]
		protected virtual void SwapSorcererStoneServiceSuccess(SwapSorcererStoneResponse response)
		{
		}

		[Address(RVA="0x15FC7A4", Offset="0x15FC7A4", VA="0x15FC7A4")]
		public void TrainUnit(TrainUnitRequest request, Action<TrainUnitResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::TrainUnit(Serverproto.TrainUnitRequest,System.Action`1<Serverproto.TrainUnitResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void TrainUnit(Serverproto.TrainUnitRequest,System.Action<Serverproto.TrainUnitResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FC898", Offset="0x15FC898", VA="0x15FC898", Slot="6")]
		protected virtual void TrainUnitServiceSuccess(TrainUnitResponse response)
		{
		}

		[Address(RVA="0x15FDCF4", Offset="0x15FDCF4", VA="0x15FDCF4")]
		public void UnequipSorcererStone(UnequipSorcererStoneRequest request, Action<UnequipSorcererStoneResponse> success, Action<long> failure, Func<bool> silence, Action done = // 
		// Current member / type: System.Void Serverproto.AInventoryService::UnequipSorcererStone(Serverproto.UnequipSorcererStoneRequest,System.Action`1<Serverproto.UnequipSorcererStoneResponse>,System.Action`1<System.Int64>,System.Func`1<System.Boolean>,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void UnequipSorcererStone(Serverproto.UnequipSorcererStoneRequest,System.Action<Serverproto.UnequipSorcererStoneResponse>,System.Action<System.Int64>,System.Func<System.Boolean>,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15FDDE8", Offset="0x15FDDE8", VA="0x15FDDE8", Slot="17")]
		protected virtual void UnequipSorcererStoneServiceSuccess(UnequipSorcererStoneResponse response)
		{
		}
	}
}