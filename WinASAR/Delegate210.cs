using System;

// Token: 0x020002E2 RID: 738
internal sealed class Delegate210 : MulticastDelegate
{
	// Token: 0x06001B1C RID: 6940
	public extern string Invoke();

	// Token: 0x06001B1D RID: 6941 RVA: 0x000095F5 File Offset: 0x000077F5
	public static string smethod_0(Delegate210 delegate210_1)
	{
		return delegate210_1();
	}

	// Token: 0x06001B1E RID: 6942
	public extern Delegate210(object object_0, IntPtr intptr_0);

	// Token: 0x06001B1F RID: 6943 RVA: 0x000095FE File Offset: 0x000077FE
	static Delegate210()
	{
		Class15.smethod_14(typeof(Delegate210).TypeHandle);
	}

	// Token: 0x04000AB2 RID: 2738
	internal static Delegate210 delegate210_0;
}
