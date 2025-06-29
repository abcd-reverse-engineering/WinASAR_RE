using System;

// Token: 0x020002B8 RID: 696
internal sealed class Delegate168 : MulticastDelegate
{
	// Token: 0x06001A74 RID: 6772
	public extern void Invoke(object object_0);

	// Token: 0x06001A75 RID: 6773 RVA: 0x000091D1 File Offset: 0x000073D1
	public static void smethod_0(object object_0, Delegate168 delegate168_1)
	{
		delegate168_1(object_0);
	}

	// Token: 0x06001A76 RID: 6774
	public extern Delegate168(object object_0, IntPtr intptr_0);

	// Token: 0x06001A77 RID: 6775 RVA: 0x000091DC File Offset: 0x000073DC
	static Delegate168()
	{
		Class15.smethod_14(typeof(Delegate168).TypeHandle);
	}

	// Token: 0x04000A88 RID: 2696
	internal static Delegate168 delegate168_0;
}
