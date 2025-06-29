using System;

// Token: 0x0200036B RID: 875
internal sealed class Delegate347 : MulticastDelegate
{
	// Token: 0x06001D40 RID: 7488
	public extern void Invoke(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0);

	// Token: 0x06001D41 RID: 7489 RVA: 0x0000A3A7 File Offset: 0x000085A7
	public static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, Delegate347 delegate347_1)
	{
		delegate347_1(array_0, runtimeFieldHandle_0);
	}

	// Token: 0x06001D42 RID: 7490
	public extern Delegate347(object object_0, IntPtr intptr_0);

	// Token: 0x06001D43 RID: 7491 RVA: 0x0000A3B4 File Offset: 0x000085B4
	static Delegate347()
	{
		Class15.smethod_14(typeof(Delegate347).TypeHandle);
	}

	// Token: 0x04000B3B RID: 2875
	internal static Delegate347 delegate347_0;
}
