using System;

// Token: 0x0200038B RID: 907
internal sealed class Delegate379 : MulticastDelegate
{
	// Token: 0x06001DC0 RID: 7616
	public extern bool Invoke(char char_0);

	// Token: 0x06001DC1 RID: 7617 RVA: 0x0000A6F5 File Offset: 0x000088F5
	public static bool smethod_0(char char_0, Delegate379 delegate379_1)
	{
		return delegate379_1(char_0);
	}

	// Token: 0x06001DC2 RID: 7618
	public extern Delegate379(object object_0, IntPtr intptr_0);

	// Token: 0x06001DC3 RID: 7619 RVA: 0x0000A700 File Offset: 0x00008900
	static Delegate379()
	{
		Class15.smethod_14(typeof(Delegate379).TypeHandle);
	}

	// Token: 0x04000B5B RID: 2907
	internal static Delegate379 delegate379_0;
}
