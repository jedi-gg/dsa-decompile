using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class ZenjectIntegrationTestFixture
	{
		protected DiContainer Container
		{
			[Address(RVA="0x23404C8", Offset="0x23404C8", VA="0x23404C8")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2340690", Offset="0x2340690", VA="0x2340690")]
		protected ZenjectIntegrationTestFixture()
		{
		}

		[Address(RVA="0x2340514", Offset="0x2340514", VA="0x2340514")]
		private Exception CreateException()
		{
			return null;
		}

		[Address(RVA="0x2340644", Offset="0x2340644", VA="0x2340644")]
		protected void DestroyAll()
		{
		}

		[Address(RVA="0x23405F8", Offset="0x23405F8", VA="0x23405F8")]
		protected void PostInstall()
		{
		}

		[Address(RVA="0x23405AC", Offset="0x23405AC", VA="0x23405AC")]
		protected void PreInstall()
		{
		}

		[Address(RVA="0x2340560", Offset="0x2340560", VA="0x2340560")]
		protected void SkipInstall()
		{
		}
	}
}