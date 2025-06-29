using System;

// Token: 0x020004FA RID: 1274
internal sealed class Delegate746 : MulticastDelegate
{
	// Token: 0x0600237C RID: 9084
	public extern int Invoke(object object_0, int int_0);

	// Token: 0x0600237D RID: 9085 RVA: 0x0000CB90 File Offset: 0x0000AD90
	public static int smethod_0(object object_0, int int_0, Delegate746 delegate746_1)
	{
		return delegate746_1(object_0, int_0);
	}

	// Token: 0x0600237E RID: 9086
	public extern Delegate746(object object_0, IntPtr intptr_0);

	// Token: 0x0600237F RID: 9087 RVA: 0x0000CB9D File Offset: 0x0000AD9D
	static Delegate746()
	{
		Class15.smethod_14(typeof(Delegate746).TypeHandle);
	}

	// Token: 0x04000CCA RID: 3274
	internal static Delegate746 delegate746_0;
}
