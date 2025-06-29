using System;

// Token: 0x0200038F RID: 911
internal sealed class Delegate383 : MulticastDelegate
{
	// Token: 0x06001DD0 RID: 7632
	public extern int Invoke(string string_0, int int_0);

	// Token: 0x06001DD1 RID: 7633 RVA: 0x0000A757 File Offset: 0x00008957
	public static int smethod_0(string string_0, int int_0, Delegate383 delegate383_1)
	{
		return delegate383_1(string_0, int_0);
	}

	// Token: 0x06001DD2 RID: 7634
	public extern Delegate383(object object_0, IntPtr intptr_0);

	// Token: 0x06001DD3 RID: 7635 RVA: 0x0000A764 File Offset: 0x00008964
	static Delegate383()
	{
		Class15.smethod_14(typeof(Delegate383).TypeHandle);
	}

	// Token: 0x04000B5F RID: 2911
	internal static Delegate383 delegate383_0;
}
