using System;

// Token: 0x020005D8 RID: 1496
internal sealed class Delegate968 : MulticastDelegate
{
	// Token: 0x060026F4 RID: 9972
	public extern bool Invoke(byte byte_0);

	// Token: 0x060026F5 RID: 9973 RVA: 0x0000E172 File Offset: 0x0000C372
	public static bool smethod_0(byte byte_0, Delegate968 delegate968_1)
	{
		return delegate968_1(byte_0);
	}

	// Token: 0x060026F6 RID: 9974
	public extern Delegate968(object object_0, IntPtr intptr_0);

	// Token: 0x060026F7 RID: 9975 RVA: 0x0000E17D File Offset: 0x0000C37D
	static Delegate968()
	{
		Class15.smethod_14(typeof(Delegate968).TypeHandle);
	}

	// Token: 0x04000DA8 RID: 3496
	internal static Delegate968 delegate968_0;
}
