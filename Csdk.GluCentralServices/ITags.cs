using System;

namespace Csdk.GluCentralServices
{
	public interface ITags
	{
		void GetTag(string tagName, string currentTag, TagCallback tagCallback, PayloadCallback payloadCallback);
	}
}