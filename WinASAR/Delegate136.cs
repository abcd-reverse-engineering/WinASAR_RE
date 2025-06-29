using System;

// Token: 0x02000298 RID: 664
internal sealed class Delegate136 : MulticastDelegate
{
	// Token: 0x060019F4 RID: 6644
	public extern long Invoke(object object_0);

	// Token: 0x060019F5 RID: 6645 RVA: 0x00008EAB File Offset: 0x000070AB
	public static long smethod_0(object object_0, Delegate136 delegate136_1)
	{
		return delegate136_1(object_0);
	}

	// Token: 0x060019F6 RID: 6646
	public extern Delegate136(object object_0, IntPtr intptr_0);

	// Token: 0x060019F7 RID: 6647 RVA: 0x00008EB6 File Offset: 0x000070B6
	static Delegate136()
	{
		Class15.smethod_14(typeof(Delegate136).TypeHandle);
	}

	// Token: 0x04000A68 RID: 2664
	internal static Delegate136 delegate136_0;
}
