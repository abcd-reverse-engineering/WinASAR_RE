using System;

// Token: 0x02000408 RID: 1032
internal sealed class Delegate504 : MulticastDelegate
{
	// Token: 0x06001FB4 RID: 8116
	public extern void Invoke(object object_0, object object_1);

	// Token: 0x06001FB5 RID: 8117 RVA: 0x0000B387 File Offset: 0x00009587
	public static void smethod_0(object object_0, object object_1, Delegate504 delegate504_1)
	{
		delegate504_1(object_0, object_1);
	}

	// Token: 0x06001FB6 RID: 8118
	public extern Delegate504(object object_0, IntPtr intptr_0);

	// Token: 0x06001FB7 RID: 8119 RVA: 0x0000B394 File Offset: 0x00009594
	static Delegate504()
	{
		Class15.smethod_14(typeof(Delegate504).TypeHandle);
	}

	// Token: 0x04000BD8 RID: 3032
	internal static Delegate504 delegate504_0;
}
