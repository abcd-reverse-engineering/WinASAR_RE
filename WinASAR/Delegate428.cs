using System;

// Token: 0x020003BC RID: 956
internal sealed class Delegate428 : MulticastDelegate
{
	// Token: 0x06001E84 RID: 7812
	public extern int Invoke(object object_0, int int_0);

	// Token: 0x06001E85 RID: 7813 RVA: 0x0000ABDB File Offset: 0x00008DDB
	public static int smethod_0(object object_0, int int_0, Delegate428 delegate428_1)
	{
		return delegate428_1(object_0, int_0);
	}

	// Token: 0x06001E86 RID: 7814
	public extern Delegate428(object object_0, IntPtr intptr_0);

	// Token: 0x06001E87 RID: 7815 RVA: 0x0000ABE8 File Offset: 0x00008DE8
	static Delegate428()
	{
		Class15.smethod_14(typeof(Delegate428).TypeHandle);
	}

	// Token: 0x04000B8C RID: 2956
	internal static Delegate428 delegate428_0;
}
