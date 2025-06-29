using System;
using System.Security.Principal;

// Token: 0x02000227 RID: 551
internal sealed class Delegate23 : MulticastDelegate
{
	// Token: 0x06001830 RID: 6192
	public extern bool Invoke(object object_0, WindowsBuiltInRole windowsBuiltInRole_0);

	// Token: 0x06001831 RID: 6193 RVA: 0x00008391 File Offset: 0x00006591
	public static bool smethod_0(object object_0, WindowsBuiltInRole windowsBuiltInRole_0, Delegate23 delegate23_1)
	{
		return delegate23_1(object_0, windowsBuiltInRole_0);
	}

	// Token: 0x06001832 RID: 6194
	public extern Delegate23(object object_0, IntPtr intptr_0);

	// Token: 0x06001833 RID: 6195 RVA: 0x0000839E File Offset: 0x0000659E
	static Delegate23()
	{
		Class15.smethod_14(typeof(Delegate23).TypeHandle);
	}

	// Token: 0x040009F7 RID: 2551
	internal static Delegate23 delegate23_0;
}
