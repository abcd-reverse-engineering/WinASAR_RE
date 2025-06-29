using System;

// Token: 0x020004CE RID: 1230
internal sealed class Delegate702 : MulticastDelegate
{
	// Token: 0x060022CC RID: 8908
	public extern bool Invoke(object object_0);

	// Token: 0x060022CD RID: 8909 RVA: 0x0000C74E File Offset: 0x0000A94E
	public static bool smethod_0(object object_0, Delegate702 delegate702_1)
	{
		return delegate702_1(object_0);
	}

	// Token: 0x060022CE RID: 8910
	public extern Delegate702(object object_0, IntPtr intptr_0);

	// Token: 0x060022CF RID: 8911 RVA: 0x0000C759 File Offset: 0x0000A959
	static Delegate702()
	{
		Class15.smethod_14(typeof(Delegate702).TypeHandle);
	}

	// Token: 0x04000C9E RID: 3230
	internal static Delegate702 delegate702_0;
}
