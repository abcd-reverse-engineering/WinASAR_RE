using System;

// Token: 0x0200037B RID: 891
internal sealed class Delegate363 : MulticastDelegate
{
	// Token: 0x06001D80 RID: 7552
	public extern decimal Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D81 RID: 7553 RVA: 0x0000A545 File Offset: 0x00008745
	public static decimal smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate363 delegate363_1)
	{
		return delegate363_1(object_0, iformatProvider_0);
	}

	// Token: 0x06001D82 RID: 7554
	public extern Delegate363(object object_0, IntPtr intptr_0);

	// Token: 0x06001D83 RID: 7555 RVA: 0x0000A552 File Offset: 0x00008752
	static Delegate363()
	{
		Class15.smethod_14(typeof(Delegate363).TypeHandle);
	}

	// Token: 0x04000B4B RID: 2891
	internal static Delegate363 delegate363_0;
}
