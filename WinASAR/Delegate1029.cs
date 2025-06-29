using System;

// Token: 0x02000615 RID: 1557
internal sealed class Delegate1029 : MulticastDelegate
{
	// Token: 0x060027E8 RID: 10216
	public extern ulong Invoke(ref UIntPtr uintptr_0);

	// Token: 0x060027E9 RID: 10217 RVA: 0x0000E7A2 File Offset: 0x0000C9A2
	public static ulong smethod_0(ref UIntPtr uintptr_0, Delegate1029 delegate1029_1)
	{
		return delegate1029_1(ref uintptr_0);
	}

	// Token: 0x060027EA RID: 10218
	public extern Delegate1029(object object_0, IntPtr intptr_0);

	// Token: 0x060027EB RID: 10219 RVA: 0x0000E7AD File Offset: 0x0000C9AD
	static Delegate1029()
	{
		Class15.smethod_14(typeof(Delegate1029).TypeHandle);
	}

	// Token: 0x04000DE5 RID: 3557
	internal static Delegate1029 delegate1029_0;
}
