using System;

// Token: 0x02000396 RID: 918
internal sealed class Delegate390 : MulticastDelegate
{
	// Token: 0x06001DEC RID: 7660
	public extern void Invoke(object object_0);

	// Token: 0x06001DED RID: 7661 RVA: 0x0000A805 File Offset: 0x00008A05
	public static void smethod_0(object object_0, Delegate390 delegate390_1)
	{
		delegate390_1(object_0);
	}

	// Token: 0x06001DEE RID: 7662
	public extern Delegate390(object object_0, IntPtr intptr_0);

	// Token: 0x06001DEF RID: 7663 RVA: 0x0000A810 File Offset: 0x00008A10
	static Delegate390()
	{
		Class15.smethod_14(typeof(Delegate390).TypeHandle);
	}

	// Token: 0x04000B66 RID: 2918
	internal static Delegate390 delegate390_0;
}
