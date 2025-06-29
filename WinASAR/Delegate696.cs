using System;

// Token: 0x020004C8 RID: 1224
internal sealed class Delegate696 : MulticastDelegate
{
	// Token: 0x060022B4 RID: 8884
	public extern bool Invoke(object object_0);

	// Token: 0x060022B5 RID: 8885 RVA: 0x0000C6BE File Offset: 0x0000A8BE
	public static bool smethod_0(object object_0, Delegate696 delegate696_1)
	{
		return delegate696_1(object_0);
	}

	// Token: 0x060022B6 RID: 8886
	public extern Delegate696(object object_0, IntPtr intptr_0);

	// Token: 0x060022B7 RID: 8887 RVA: 0x0000C6C9 File Offset: 0x0000A8C9
	static Delegate696()
	{
		Class15.smethod_14(typeof(Delegate696).TypeHandle);
	}

	// Token: 0x04000C98 RID: 3224
	internal static Delegate696 delegate696_0;
}
