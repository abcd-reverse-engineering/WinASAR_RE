using System;

// Token: 0x02000221 RID: 545
internal sealed class Delegate17 : MulticastDelegate
{
	// Token: 0x06001818 RID: 6168
	public extern void Invoke();

	// Token: 0x06001819 RID: 6169 RVA: 0x00008305 File Offset: 0x00006505
	public static void smethod_0(Delegate17 delegate17_1)
	{
		delegate17_1();
	}

	// Token: 0x0600181A RID: 6170
	public extern Delegate17(object object_0, IntPtr intptr_0);

	// Token: 0x0600181B RID: 6171 RVA: 0x0000830E File Offset: 0x0000650E
	static Delegate17()
	{
		Class15.smethod_14(typeof(Delegate17).TypeHandle);
	}

	// Token: 0x040009F1 RID: 2545
	internal static Delegate17 delegate17_0;
}
