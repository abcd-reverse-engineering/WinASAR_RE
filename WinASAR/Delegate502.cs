using System;

// Token: 0x02000406 RID: 1030
internal sealed class Delegate502 : MulticastDelegate
{
	// Token: 0x06001FAC RID: 8108
	public extern bool Invoke(object object_0, object object_1);

	// Token: 0x06001FAD RID: 8109 RVA: 0x0000B355 File Offset: 0x00009555
	public static bool smethod_0(object object_0, object object_1, Delegate502 delegate502_1)
	{
		return delegate502_1(object_0, object_1);
	}

	// Token: 0x06001FAE RID: 8110
	public extern Delegate502(object object_0, IntPtr intptr_0);

	// Token: 0x06001FAF RID: 8111 RVA: 0x0000B362 File Offset: 0x00009562
	static Delegate502()
	{
		Class15.smethod_14(typeof(Delegate502).TypeHandle);
	}

	// Token: 0x04000BD6 RID: 3030
	internal static Delegate502 delegate502_0;
}
