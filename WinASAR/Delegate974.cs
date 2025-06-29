using System;

// Token: 0x020005DE RID: 1502
internal sealed class Delegate974 : MulticastDelegate
{
	// Token: 0x0600270C RID: 9996
	public extern int Invoke(object object_0);

	// Token: 0x0600270D RID: 9997 RVA: 0x0000E21A File Offset: 0x0000C41A
	public static int smethod_0(object object_0, Delegate974 delegate974_1)
	{
		return delegate974_1(object_0);
	}

	// Token: 0x0600270E RID: 9998
	public extern Delegate974(object object_0, IntPtr intptr_0);

	// Token: 0x0600270F RID: 9999 RVA: 0x0000E225 File Offset: 0x0000C425
	static Delegate974()
	{
		Class15.smethod_14(typeof(Delegate974).TypeHandle);
	}

	// Token: 0x04000DAE RID: 3502
	internal static Delegate974 delegate974_0;
}
