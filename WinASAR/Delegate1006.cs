using System;
using System.Reflection;

// Token: 0x020005FE RID: 1534
internal sealed class Delegate1006 : MulticastDelegate
{
	// Token: 0x0600278C RID: 10124
	public extern Module Invoke(object object_0);

	// Token: 0x0600278D RID: 10125 RVA: 0x0000E568 File Offset: 0x0000C768
	public static Module smethod_0(object object_0, Delegate1006 delegate1006_1)
	{
		return delegate1006_1(object_0);
	}

	// Token: 0x0600278E RID: 10126
	public extern Delegate1006(object object_0, IntPtr intptr_0);

	// Token: 0x0600278F RID: 10127 RVA: 0x0000E573 File Offset: 0x0000C773
	static Delegate1006()
	{
		Class15.smethod_14(typeof(Delegate1006).TypeHandle);
	}

	// Token: 0x04000DCE RID: 3534
	internal static Delegate1006 delegate1006_0;
}
