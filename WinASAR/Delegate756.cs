using System;

// Token: 0x02000504 RID: 1284
internal sealed class Delegate756 : MulticastDelegate
{
	// Token: 0x060023A4 RID: 9124
	public extern void Invoke(object object_0);

	// Token: 0x060023A5 RID: 9125 RVA: 0x0000CC8C File Offset: 0x0000AE8C
	public static void smethod_0(object object_0, Delegate756 delegate756_1)
	{
		delegate756_1(object_0);
	}

	// Token: 0x060023A6 RID: 9126
	public extern Delegate756(object object_0, IntPtr intptr_0);

	// Token: 0x060023A7 RID: 9127 RVA: 0x0000CC97 File Offset: 0x0000AE97
	static Delegate756()
	{
		Class15.smethod_14(typeof(Delegate756).TypeHandle);
	}

	// Token: 0x04000CD4 RID: 3284
	internal static Delegate756 delegate756_0;
}
