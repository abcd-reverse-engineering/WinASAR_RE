using System;

// Token: 0x02000405 RID: 1029
internal sealed class Delegate501 : MulticastDelegate
{
	// Token: 0x06001FA8 RID: 8104
	public extern void Invoke(object object_0, object object_1, object object_2);

	// Token: 0x06001FA9 RID: 8105 RVA: 0x0000B339 File Offset: 0x00009539
	public static void smethod_0(object object_0, object object_1, object object_2, Delegate501 delegate501_1)
	{
		delegate501_1(object_0, object_1, object_2);
	}

	// Token: 0x06001FAA RID: 8106
	public extern Delegate501(object object_0, IntPtr intptr_0);

	// Token: 0x06001FAB RID: 8107 RVA: 0x0000B348 File Offset: 0x00009548
	static Delegate501()
	{
		Class15.smethod_14(typeof(Delegate501).TypeHandle);
	}

	// Token: 0x04000BD5 RID: 3029
	internal static Delegate501 delegate501_0;
}
