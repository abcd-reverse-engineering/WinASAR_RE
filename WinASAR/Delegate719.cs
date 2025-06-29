using System;

// Token: 0x020004DF RID: 1247
internal sealed class Delegate719 : MulticastDelegate
{
	// Token: 0x06002310 RID: 8976
	public extern bool Invoke(object object_0);

	// Token: 0x06002311 RID: 8977 RVA: 0x0000C8EA File Offset: 0x0000AAEA
	public static bool smethod_0(object object_0, Delegate719 delegate719_1)
	{
		return delegate719_1(object_0);
	}

	// Token: 0x06002312 RID: 8978
	public extern Delegate719(object object_0, IntPtr intptr_0);

	// Token: 0x06002313 RID: 8979 RVA: 0x0000C8F5 File Offset: 0x0000AAF5
	static Delegate719()
	{
		Class15.smethod_14(typeof(Delegate719).TypeHandle);
	}

	// Token: 0x04000CAF RID: 3247
	internal static Delegate719 delegate719_0;
}
