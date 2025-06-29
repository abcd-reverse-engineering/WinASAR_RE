using System;

// Token: 0x020004E8 RID: 1256
internal sealed class Delegate728 : MulticastDelegate
{
	// Token: 0x06002334 RID: 9012
	public extern string Invoke(object object_0);

	// Token: 0x06002335 RID: 9013 RVA: 0x0000C9CA File Offset: 0x0000ABCA
	public static string smethod_0(object object_0, Delegate728 delegate728_1)
	{
		return delegate728_1(object_0);
	}

	// Token: 0x06002336 RID: 9014
	public extern Delegate728(object object_0, IntPtr intptr_0);

	// Token: 0x06002337 RID: 9015 RVA: 0x0000C9D5 File Offset: 0x0000ABD5
	static Delegate728()
	{
		Class15.smethod_14(typeof(Delegate728).TypeHandle);
	}

	// Token: 0x04000CB8 RID: 3256
	internal static Delegate728 delegate728_0;
}
