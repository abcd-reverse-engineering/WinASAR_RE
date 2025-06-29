using System;

// Token: 0x020003FF RID: 1023
internal sealed class Delegate495 : MulticastDelegate
{
	// Token: 0x06001F90 RID: 8080
	public extern int Invoke(ref DateTime dateTime_0);

	// Token: 0x06001F91 RID: 8081 RVA: 0x0000B2A9 File Offset: 0x000094A9
	public static int smethod_0(ref DateTime dateTime_0, Delegate495 delegate495_1)
	{
		return delegate495_1(ref dateTime_0);
	}

	// Token: 0x06001F92 RID: 8082
	public extern Delegate495(object object_0, IntPtr intptr_0);

	// Token: 0x06001F93 RID: 8083 RVA: 0x0000B2B4 File Offset: 0x000094B4
	static Delegate495()
	{
		Class15.smethod_14(typeof(Delegate495).TypeHandle);
	}

	// Token: 0x04000BCF RID: 3023
	internal static Delegate495 delegate495_0;
}
