using System.Text;
using System.Threading;

namespace luaBytec
{
	public class Library
	{
		private string dynamicString1;
		public string EncryptForRoblox(string script)
		{
			dynamicString1 = string.Empty;
			byte[] bytes = Encoding.ASCII.GetBytes(script);
			foreach (byte b in bytes)
			{
				dynamicString1 = dynamicString1 + int.Parse(b.ToString()).ToString() + "\\";
			}
			string text = "function ____________(_____________)\n	local ______________ = ''\n		for _______________, ________________ in pairs(_____________) do\n			______________ = ______________ .. string.char(________________ * 2)\n		end\n	return ______________\nend\n\ngetfenv()[____________({\n    -44 + 98,\n    20 + 35.5,\n    -22.5 + 71,\n    -11 + 61,\n    -23 + 80.5,\n    11 + 47,\n    -8.5 + 65.5,\n    -69 + 121.5,\n    -62 + 117,\n    -30 + 81.5\n})]('\\" + dynamicString1 + "QWE";
			return text.Replace("\\QWE", "')()");
		}

		private string dynamicString2;
		public string EncryptByteCode(string script)
		{
			dynamicString2 = string.Empty;
			byte[] bytes = Encoding.ASCII.GetBytes(script);
			foreach (byte b in bytes)
			{
				dynamicString2 = dynamicString2 + int.Parse(b.ToString()).ToString() + "\\";
			}
			string text = "load('\\" + dynamicString2 + "ASD";
			return text.Replace("\\ASD", "')()");
		}
	}
}