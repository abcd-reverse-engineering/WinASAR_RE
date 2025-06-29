using System;

// Token: 0x0200040B RID: 1035
internal sealed class Delegate507 : MulticastDelegate
{
	// Token: 0x06001FC0 RID: 8128
	public extern void Invoke(object object_0, object object_1, object object_2);

	// Token: 0x06001FC1 RID: 8129 RVA: 0x0000B3D3 File Offset: 0x000095D3
	public static void smethod_0(object object_0, object object_1, object object_2, Delegate507 delegate507_1)
	{
		delegate507_1(object_0, object_1, object_2);
	}

	// Token: 0x06001FC2 RID: 8130
	public extern Delegate507(object object_0, IntPtr intptr_0);

	// Token: 0x06001FC3 RID: 8131 RVA: 0x0000B3E2 File Offset: 0x000095E2
	static Delegate507()
	{
		Class15.smethod_14(typeof(Delegate507).TypeHandle);
	}

	// Token: 0x04000BDB RID: 3035
	internal static Delegate507 delegate507_0;
}
