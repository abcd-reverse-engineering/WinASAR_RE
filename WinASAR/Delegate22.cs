using System;
using System.Security.Principal;

// Token: 0x02000226 RID: 550
internal sealed class Delegate22 : MulticastDelegate
{
	// Token: 0x0600182C RID: 6188
	public extern WindowsIdentity Invoke();

	// Token: 0x0600182D RID: 6189 RVA: 0x0000837B File Offset: 0x0000657B
	public static WindowsIdentity smethod_0(Delegate22 delegate22_1)
	{
		return delegate22_1();
	}

	// Token: 0x0600182E RID: 6190
	public extern Delegate22(object object_0, IntPtr intptr_0);

	// Token: 0x0600182F RID: 6191 RVA: 0x00008384 File Offset: 0x00006584
	static Delegate22()
	{
		Class15.smethod_14(typeof(Delegate22).TypeHandle);
	}

	// Token: 0x040009F6 RID: 2550
	internal static Delegate22 delegate22_0;
}
