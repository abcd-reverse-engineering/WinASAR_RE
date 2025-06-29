using System;

// Token: 0x020005C9 RID: 1481
internal sealed class Delegate953 : MulticastDelegate
{
	// Token: 0x060026B8 RID: 9912
	public extern void Invoke(object object_0);

	// Token: 0x060026B9 RID: 9913 RVA: 0x0000DFE6 File Offset: 0x0000C1E6
	public static void smethod_0(object object_0, Delegate953 delegate953_1)
	{
		delegate953_1(object_0);
	}

	// Token: 0x060026BA RID: 9914
	public extern Delegate953(object object_0, IntPtr intptr_0);

	// Token: 0x060026BB RID: 9915 RVA: 0x0000DFF1 File Offset: 0x0000C1F1
	static Delegate953()
	{
		Class15.smethod_14(typeof(Delegate953).TypeHandle);
	}

	// Token: 0x04000D99 RID: 3481
	internal static Delegate953 delegate953_0;
}
