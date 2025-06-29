using System;

// Token: 0x020003C9 RID: 969
internal sealed class Delegate441 : MulticastDelegate
{
	// Token: 0x06001EB8 RID: 7864
	public extern void Invoke(object object_0, int int_0, object object_1);

	// Token: 0x06001EB9 RID: 7865 RVA: 0x0000AD29 File Offset: 0x00008F29
	public static void smethod_0(object object_0, int int_0, object object_1, Delegate441 delegate441_1)
	{
		delegate441_1(object_0, int_0, object_1);
	}

	// Token: 0x06001EBA RID: 7866
	public extern Delegate441(object object_0, IntPtr intptr_0);

	// Token: 0x06001EBB RID: 7867 RVA: 0x0000AD38 File Offset: 0x00008F38
	static Delegate441()
	{
		Class15.smethod_14(typeof(Delegate441).TypeHandle);
	}

	// Token: 0x04000B99 RID: 2969
	internal static Delegate441 delegate441_0;
}
