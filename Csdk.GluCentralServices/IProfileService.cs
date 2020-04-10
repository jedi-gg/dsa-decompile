using System;

namespace Csdk.GluCentralServices
{
	public interface IProfileService
	{
		void SetValue(string name, object val, string op = "upsert");

		void UpdateValue(UpdateValueInput val);
	}
}