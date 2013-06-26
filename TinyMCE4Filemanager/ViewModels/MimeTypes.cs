using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinyMCE4Filemanager.ViewModels
{
    public static class MimeTypes
    {
        public static Dictionary<string, string> ImageMimeTypes = new Dictionary<string, string>
		{
			{ ".gif", "image/gif" },
            { ".jpeg", "image/jpeg" },
			{ ".jpg", "image/jpeg" },
			{ ".png", "image/png" },
		};
    }
}