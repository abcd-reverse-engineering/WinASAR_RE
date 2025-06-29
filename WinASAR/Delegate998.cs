using System;

// Token: 0x020005F6 RID: 1526
internal sealed class Delegate998 : MulticastDelegate
{
	// Token: 0x0600276C RID: 10092
	public extern int Invoke(object object_0);

	// Token: 0x0600276D RID: 10093 RVA: 0x0000E4A2 File Offset: 0x0000C6A2
	public static int smethod_0(object object_0, Delegate998 delegate998_1)
	{
		return delegate998_1(object_0);
	}

	// Token: 0x0600276E RID: 10094
	public extern Delegate998(object object_0, IntPtr intptr_0);

	// Token: 0x0600276F RID: 10095 RVA: 0x0000E4AD File Offset: 0x0000C6AD
	static Delegate998()
	{
		Class15.smethod_14(typeof(Delegate998).TypeHandle);
	}

	// Token: 0x04000DC6 RID: 3526
	internal static Delegate998 delegate998_0;
}
