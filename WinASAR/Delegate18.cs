using System;

// Token: 0x02000222 RID: 546
internal sealed class Delegate18 : MulticastDelegate
{
	// Token: 0x0600181C RID: 6172
	public extern void Invoke(bool bool_0);

	// Token: 0x0600181D RID: 6173 RVA: 0x0000831B File Offset: 0x0000651B
	public static void smethod_0(bool bool_0, Delegate18 delegate18_1)
	{
		delegate18_1(bool_0);
	}

	// Token: 0x0600181E RID: 6174
	public extern Delegate18(object object_0, IntPtr intptr_0);

	// Token: 0x0600181F RID: 6175 RVA: 0x00008326 File Offset: 0x00006526
	static Delegate18()
	{
		Class15.smethod_14(typeof(Delegate18).TypeHandle);
	}

	// Token: 0x040009F2 RID: 2546
	internal static Delegate18 delegate18_0;
}
