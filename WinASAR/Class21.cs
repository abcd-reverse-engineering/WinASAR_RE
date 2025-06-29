using System;
using System.Reflection;
using System.Windows.Forms;

// Token: 0x020001E2 RID: 482
internal static class Class21
{
	// Token: 0x060014DB RID: 5339 RVA: 0x0009EF40 File Offset: 0x0009D140
	internal static string smethod_0(Assembly assembly)
	{
		if (assembly == typeof(Class21).Assembly)
		{
			return Application.ExecutablePath;
		}
		return assembly.Location;
	}
}
