using System;

// Token: 0x02000337 RID: 823
internal sealed class Delegate295 : MulticastDelegate
{
	// Token: 0x06001C70 RID: 7280
	public extern int Invoke(object object_0, object object_1, object object_2);

	// Token: 0x06001C71 RID: 7281 RVA: 0x00009E59 File Offset: 0x00008059
	public static int smethod_0(object object_0, object object_1, object object_2, Delegate295 delegate295_1)
	{
		return delegate295_1(object_0, object_1, object_2);
	}

	// Token: 0x06001C72 RID: 7282
	public extern Delegate295(object object_0, IntPtr intptr_0);

	// Token: 0x06001C73 RID: 7283 RVA: 0x00009E68 File Offset: 0x00008068
	static Delegate295()
	{
		Class15.smethod_14(typeof(Delegate295).TypeHandle);
	}

	// Token: 0x04000B07 RID: 2823
	internal static Delegate295 delegate295_0;
}
