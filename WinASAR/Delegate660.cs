using System;

// Token: 0x020004A4 RID: 1188
internal sealed class Delegate660 : MulticastDelegate
{
	// Token: 0x06002224 RID: 8740
	public extern void Invoke(object object_0, object object_1, object object_2);

	// Token: 0x06002225 RID: 8741 RVA: 0x0000C323 File Offset: 0x0000A523
	public static void smethod_0(object object_0, object object_1, object object_2, Delegate660 delegate660_1)
	{
		delegate660_1(object_0, object_1, object_2);
	}

	// Token: 0x06002226 RID: 8742
	public extern Delegate660(object object_0, IntPtr intptr_0);

	// Token: 0x06002227 RID: 8743 RVA: 0x0000C332 File Offset: 0x0000A532
	static Delegate660()
	{
		Class15.smethod_14(typeof(Delegate660).TypeHandle);
	}

	// Token: 0x04000C74 RID: 3188
	internal static Delegate660 delegate660_0;
}
