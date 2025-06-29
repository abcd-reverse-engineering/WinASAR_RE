using System;

// Token: 0x0200053F RID: 1343
internal sealed class Delegate815 : MulticastDelegate
{
	// Token: 0x06002490 RID: 9360
	public extern string Invoke(object object_0, char[] char_0);

	// Token: 0x06002491 RID: 9361 RVA: 0x0000D25E File Offset: 0x0000B45E
	public static string smethod_0(object object_0, char[] char_0, Delegate815 delegate815_1)
	{
		return delegate815_1(object_0, char_0);
	}

	// Token: 0x06002492 RID: 9362
	public extern Delegate815(object object_0, IntPtr intptr_0);

	// Token: 0x06002493 RID: 9363 RVA: 0x0000D26B File Offset: 0x0000B46B
	static Delegate815()
	{
		Class15.smethod_14(typeof(Delegate815).TypeHandle);
	}

	// Token: 0x04000D0F RID: 3343
	internal static Delegate815 delegate815_0;
}
