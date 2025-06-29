using System;

// Token: 0x020005DF RID: 1503
internal sealed class Delegate975 : MulticastDelegate
{
	// Token: 0x06002710 RID: 10000
	public extern long Invoke(object object_0);

	// Token: 0x06002711 RID: 10001 RVA: 0x0000E232 File Offset: 0x0000C432
	public static long smethod_0(object object_0, Delegate975 delegate975_1)
	{
		return delegate975_1(object_0);
	}

	// Token: 0x06002712 RID: 10002
	public extern Delegate975(object object_0, IntPtr intptr_0);

	// Token: 0x06002713 RID: 10003 RVA: 0x0000E23D File Offset: 0x0000C43D
	static Delegate975()
	{
		Class15.smethod_14(typeof(Delegate975).TypeHandle);
	}

	// Token: 0x04000DAF RID: 3503
	internal static Delegate975 delegate975_0;
}
