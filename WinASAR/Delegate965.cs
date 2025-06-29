using System;

// Token: 0x020005D5 RID: 1493
internal sealed class Delegate965 : MulticastDelegate
{
	// Token: 0x060026E8 RID: 9960
	public extern int Invoke(object object_0, string string_0);

	// Token: 0x060026E9 RID: 9961 RVA: 0x0000E128 File Offset: 0x0000C328
	public static int smethod_0(object object_0, string string_0, Delegate965 delegate965_1)
	{
		return delegate965_1(object_0, string_0);
	}

	// Token: 0x060026EA RID: 9962
	public extern Delegate965(object object_0, IntPtr intptr_0);

	// Token: 0x060026EB RID: 9963 RVA: 0x0000E135 File Offset: 0x0000C335
	static Delegate965()
	{
		Class15.smethod_14(typeof(Delegate965).TypeHandle);
	}

	// Token: 0x04000DA5 RID: 3493
	internal static Delegate965 delegate965_0;
}
