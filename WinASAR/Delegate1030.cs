using System;

// Token: 0x02000616 RID: 1558
internal sealed class Delegate1030 : MulticastDelegate
{
	// Token: 0x060027EC RID: 10220
	public extern uint Invoke(ref UIntPtr uintptr_0);

	// Token: 0x060027ED RID: 10221 RVA: 0x0000E7BA File Offset: 0x0000C9BA
	public static uint smethod_0(ref UIntPtr uintptr_0, Delegate1030 delegate1030_1)
	{
		return delegate1030_1(ref uintptr_0);
	}

	// Token: 0x060027EE RID: 10222
	public extern Delegate1030(object object_0, IntPtr intptr_0);

	// Token: 0x060027EF RID: 10223 RVA: 0x0000E7C5 File Offset: 0x0000C9C5
	static Delegate1030()
	{
		Class15.smethod_14(typeof(Delegate1030).TypeHandle);
	}

	// Token: 0x04000DE6 RID: 3558
	internal static Delegate1030 delegate1030_0;
}
