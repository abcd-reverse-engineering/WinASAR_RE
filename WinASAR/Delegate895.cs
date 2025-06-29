using System;

// Token: 0x0200058F RID: 1423
internal sealed class Delegate895 : MulticastDelegate
{
	// Token: 0x060025D0 RID: 9680
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060025D1 RID: 9681 RVA: 0x0000DA50 File Offset: 0x0000BC50
	public static void smethod_0(object object_0, string string_0, Delegate895 delegate895_1)
	{
		delegate895_1(object_0, string_0);
	}

	// Token: 0x060025D2 RID: 9682
	public extern Delegate895(object object_0, IntPtr intptr_0);

	// Token: 0x060025D3 RID: 9683 RVA: 0x0000DA5D File Offset: 0x0000BC5D
	static Delegate895()
	{
		Class15.smethod_14(typeof(Delegate895).TypeHandle);
	}

	// Token: 0x04000D5F RID: 3423
	internal static Delegate895 delegate895_0;
}
