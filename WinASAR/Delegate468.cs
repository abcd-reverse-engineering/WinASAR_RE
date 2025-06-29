using System;

// Token: 0x020003E4 RID: 996
internal sealed class Delegate468 : MulticastDelegate
{
	// Token: 0x06001F24 RID: 7972
	public extern decimal Invoke(decimal decimal_0);

	// Token: 0x06001F25 RID: 7973 RVA: 0x0000AFEB File Offset: 0x000091EB
	public static decimal smethod_0(decimal decimal_0, Delegate468 delegate468_1)
	{
		return delegate468_1(decimal_0);
	}

	// Token: 0x06001F26 RID: 7974
	public extern Delegate468(object object_0, IntPtr intptr_0);

	// Token: 0x06001F27 RID: 7975 RVA: 0x0000AFF6 File Offset: 0x000091F6
	static Delegate468()
	{
		Class15.smethod_14(typeof(Delegate468).TypeHandle);
	}

	// Token: 0x04000BB4 RID: 2996
	internal static Delegate468 delegate468_0;
}
