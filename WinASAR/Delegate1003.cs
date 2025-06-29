using System;

// Token: 0x020005FB RID: 1531
internal sealed class Delegate1003 : MulticastDelegate
{
	// Token: 0x06002780 RID: 10112
	public extern int Invoke(object object_0);

	// Token: 0x06002781 RID: 10113 RVA: 0x0000E51C File Offset: 0x0000C71C
	public static int smethod_0(object object_0, Delegate1003 delegate1003_1)
	{
		return delegate1003_1(object_0);
	}

	// Token: 0x06002782 RID: 10114
	public extern Delegate1003(object object_0, IntPtr intptr_0);

	// Token: 0x06002783 RID: 10115 RVA: 0x0000E527 File Offset: 0x0000C727
	static Delegate1003()
	{
		Class15.smethod_14(typeof(Delegate1003).TypeHandle);
	}

	// Token: 0x04000DCB RID: 3531
	internal static Delegate1003 delegate1003_0;
}
