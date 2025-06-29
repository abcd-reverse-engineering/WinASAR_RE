using System;

// Token: 0x0200032B RID: 811
internal sealed class Delegate283 : MulticastDelegate
{
	// Token: 0x06001C40 RID: 7232
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001C41 RID: 7233 RVA: 0x00009D29 File Offset: 0x00007F29
	public static void smethod_0(object object_0, bool bool_0, Delegate283 delegate283_1)
	{
		delegate283_1(object_0, bool_0);
	}

	// Token: 0x06001C42 RID: 7234
	public extern Delegate283(object object_0, IntPtr intptr_0);

	// Token: 0x06001C43 RID: 7235 RVA: 0x00009D36 File Offset: 0x00007F36
	static Delegate283()
	{
		Class15.smethod_14(typeof(Delegate283).TypeHandle);
	}

	// Token: 0x04000AFB RID: 2811
	internal static Delegate283 delegate283_0;
}
