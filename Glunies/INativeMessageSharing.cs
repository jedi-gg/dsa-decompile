using System;

namespace Glunies
{
	public interface INativeMessageSharing
	{
		void ShareText(string message, string subject, string chooserTitle);
	}
}