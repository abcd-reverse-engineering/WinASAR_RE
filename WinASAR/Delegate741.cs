using System;

// Token: 0x020004F5 RID: 1269
internal sealed class Delegate741 : MulticastDelegate
{
	// Token: 0x06002368 RID: 9064
	public extern StringComparer Invoke();

	// Token: 0x06002369 RID: 9065 RVA: 0x0000CB0C File Offset: 0x0000AD0C
	public static StringComparer smethod_0(Delegate741 delegate741_1)
	{
		return delegate741_1();
	}

	// Token: 0x0600236A RID: 9066
	public extern Delegate741(object object_0, IntPtr intptr_0);

	// Token: 0x0600236B RID: 9067 RVA: 0x0000CB15 File Offset: 0x0000AD15
	static Delegate741()
	{
		Class15.smethod_14(typeof(Delegate741).TypeHandle);
	}

	// Token: 0x04000CC5 RID: 3269
	internal static Delegate741 delegate741_0;
}
