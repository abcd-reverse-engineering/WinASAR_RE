using System;

// Token: 0x0200026E RID: 622
internal sealed class Delegate94 : MulticastDelegate
{
	// Token: 0x0600194C RID: 6476
	public extern void Invoke(object object_0);

	// Token: 0x0600194D RID: 6477 RVA: 0x00008A8F File Offset: 0x00006C8F
	public static void smethod_0(object object_0, Delegate94 delegate94_1)
	{
		delegate94_1(object_0);
	}

	// Token: 0x0600194E RID: 6478
	public extern Delegate94(object object_0, IntPtr intptr_0);

	// Token: 0x0600194F RID: 6479 RVA: 0x00008A9A File Offset: 0x00006C9A
	static Delegate94()
	{
		Class15.smethod_14(typeof(Delegate94).TypeHandle);
	}

	// Token: 0x04000A3E RID: 2622
	internal static Delegate94 delegate94_0;
}
