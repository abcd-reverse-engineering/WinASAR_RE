using System;

// Token: 0x020003C3 RID: 963
internal sealed class Delegate435 : MulticastDelegate
{
	// Token: 0x06001EA0 RID: 7840
	public extern void Invoke(object object_0, object object_1);

	// Token: 0x06001EA1 RID: 7841 RVA: 0x0000AC8F File Offset: 0x00008E8F
	public static void smethod_0(object object_0, object object_1, Delegate435 delegate435_1)
	{
		delegate435_1(object_0, object_1);
	}

	// Token: 0x06001EA2 RID: 7842
	public extern Delegate435(object object_0, IntPtr intptr_0);

	// Token: 0x06001EA3 RID: 7843 RVA: 0x0000AC9C File Offset: 0x00008E9C
	static Delegate435()
	{
		Class15.smethod_14(typeof(Delegate435).TypeHandle);
	}

	// Token: 0x04000B93 RID: 2963
	internal static Delegate435 delegate435_0;
}
