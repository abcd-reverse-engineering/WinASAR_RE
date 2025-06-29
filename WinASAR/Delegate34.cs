using System;

// Token: 0x02000232 RID: 562
internal sealed class Delegate34 : MulticastDelegate
{
	// Token: 0x0600185C RID: 6236
	public extern Type Invoke(RuntimeTypeHandle runtimeTypeHandle_0);

	// Token: 0x0600185D RID: 6237 RVA: 0x000084A1 File Offset: 0x000066A1
	public static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0, Delegate34 delegate34_1)
	{
		return delegate34_1(runtimeTypeHandle_0);
	}

	// Token: 0x0600185E RID: 6238
	public extern Delegate34(object object_0, IntPtr intptr_0);

	// Token: 0x0600185F RID: 6239 RVA: 0x000084AC File Offset: 0x000066AC
	static Delegate34()
	{
		Class15.smethod_14(typeof(Delegate34).TypeHandle);
	}

	// Token: 0x04000A02 RID: 2562
	internal static Delegate34 delegate34_0;
}
