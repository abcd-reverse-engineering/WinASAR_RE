using System;

// Token: 0x020004BD RID: 1213
internal sealed class Delegate685 : MulticastDelegate
{
	// Token: 0x06002288 RID: 8840
	public extern bool Invoke(char char_0);

	// Token: 0x06002289 RID: 8841 RVA: 0x0000C5AE File Offset: 0x0000A7AE
	public static bool smethod_0(char char_0, Delegate685 delegate685_1)
	{
		return delegate685_1(char_0);
	}

	// Token: 0x0600228A RID: 8842
	public extern Delegate685(object object_0, IntPtr intptr_0);

	// Token: 0x0600228B RID: 8843 RVA: 0x0000C5B9 File Offset: 0x0000A7B9
	static Delegate685()
	{
		Class15.smethod_14(typeof(Delegate685).TypeHandle);
	}

	// Token: 0x04000C8D RID: 3213
	internal static Delegate685 delegate685_0;
}
