using System;

// Token: 0x02000493 RID: 1171
internal sealed class Delegate643 : MulticastDelegate
{
	// Token: 0x060021E0 RID: 8672
	public extern int Invoke(ref byte byte_0, byte byte_1);

	// Token: 0x060021E1 RID: 8673 RVA: 0x0000C17B File Offset: 0x0000A37B
	public static int smethod_0(ref byte byte_0, byte byte_1, Delegate643 delegate643_1)
	{
		return delegate643_1(ref byte_0, byte_1);
	}

	// Token: 0x060021E2 RID: 8674
	public extern Delegate643(object object_0, IntPtr intptr_0);

	// Token: 0x060021E3 RID: 8675 RVA: 0x0000C188 File Offset: 0x0000A388
	static Delegate643()
	{
		Class15.smethod_14(typeof(Delegate643).TypeHandle);
	}

	// Token: 0x04000C63 RID: 3171
	internal static Delegate643 delegate643_0;
}
