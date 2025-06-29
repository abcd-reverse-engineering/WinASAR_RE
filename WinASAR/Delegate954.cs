using System;

// Token: 0x020005CA RID: 1482
internal sealed class Delegate954 : MulticastDelegate
{
	// Token: 0x060026BC RID: 9916
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x060026BD RID: 9917 RVA: 0x0000DFFE File Offset: 0x0000C1FE
	public static void smethod_0(object object_0, int int_0, Delegate954 delegate954_1)
	{
		delegate954_1(object_0, int_0);
	}

	// Token: 0x060026BE RID: 9918
	public extern Delegate954(object object_0, IntPtr intptr_0);

	// Token: 0x060026BF RID: 9919 RVA: 0x0000E00B File Offset: 0x0000C20B
	static Delegate954()
	{
		Class15.smethod_14(typeof(Delegate954).TypeHandle);
	}

	// Token: 0x04000D9A RID: 3482
	internal static Delegate954 delegate954_0;
}
