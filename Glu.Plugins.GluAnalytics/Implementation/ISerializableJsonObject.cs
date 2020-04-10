using System;

namespace Glu.Plugins.GluAnalytics.Implementation
{
	public interface ISerializableJsonObject
	{
		void WriteObject(JsonStringer json);
	}
}