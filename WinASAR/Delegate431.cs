using System;

// Token: 0x020003BF RID: 959
internal sealed class Delegate431 : MulticastDelegate
{
	// Token: 0x06001E90 RID: 7824
	public extern void Invoke(object object_0);

	// Token: 0x06001E91 RID: 7825 RVA: 0x0000AC29 File Offset: 0x00008E29
	public static void smethod_0(object object_0, Delegate431 delegate431_1)
	{
		delegate431_1(object_0);
	}

	// Token: 0x06001E92 RID: 7826
	public extern Delegate431(object object_0, IntPtr intptr_0);

	// Token: 0x06001E93 RID: 7827 RVA: 0x0000AC34 File Offset: 0x00008E34
	static Delegate431()
	{
		Class15.smethod_14(typeof(Delegate431).TypeHandle);
	}

	// Token: 0x04000B8F RID: 2959
	internal static Delegate431 delegate431_0;
}
