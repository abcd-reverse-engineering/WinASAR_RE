using System;

// Token: 0x02000612 RID: 1554
internal sealed class Delegate1026 : MulticastDelegate
{
	// Token: 0x060027DC RID: 10204
	public unsafe extern void* Invoke(IntPtr intptr_0);

	// Token: 0x060027DD RID: 10205 RVA: 0x0000E75A File Offset: 0x0000C95A
	public unsafe static void* smethod_0(IntPtr intptr_0, Delegate1026 delegate1026_1)
	{
		return delegate1026_1(intptr_0);
	}

	// Token: 0x060027DE RID: 10206
	public extern Delegate1026(object object_0, IntPtr intptr_0);

	// Token: 0x060027DF RID: 10207 RVA: 0x0000E765 File Offset: 0x0000C965
	static Delegate1026()
	{
		Class15.smethod_14(typeof(Delegate1026).TypeHandle);
	}

	// Token: 0x04000DE2 RID: 3554
	internal static Delegate1026 delegate1026_0;
}
