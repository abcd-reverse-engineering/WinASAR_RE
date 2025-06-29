using System;
using System.Reflection;

// Token: 0x020005FA RID: 1530
internal sealed class Delegate1002 : MulticastDelegate
{
	// Token: 0x0600277C RID: 10108
	public extern FieldInfo[] Invoke(object object_0);

	// Token: 0x0600277D RID: 10109 RVA: 0x0000E504 File Offset: 0x0000C704
	public static FieldInfo[] smethod_0(object object_0, Delegate1002 delegate1002_1)
	{
		return delegate1002_1(object_0);
	}

	// Token: 0x0600277E RID: 10110
	public extern Delegate1002(object object_0, IntPtr intptr_0);

	// Token: 0x0600277F RID: 10111 RVA: 0x0000E50F File Offset: 0x0000C70F
	static Delegate1002()
	{
		Class15.smethod_14(typeof(Delegate1002).TypeHandle);
	}

	// Token: 0x04000DCA RID: 3530
	internal static Delegate1002 delegate1002_0;
}
