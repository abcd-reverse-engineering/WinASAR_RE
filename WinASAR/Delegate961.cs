using System;

// Token: 0x020005D1 RID: 1489
internal sealed class Delegate961 : MulticastDelegate
{
	// Token: 0x060026D8 RID: 9944
	public extern void Invoke(object object_0, byte[] byte_0);

	// Token: 0x060026D9 RID: 9945 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
	public static void smethod_0(object object_0, byte[] byte_0, Delegate961 delegate961_1)
	{
		delegate961_1(object_0, byte_0);
	}

	// Token: 0x060026DA RID: 9946
	public extern Delegate961(object object_0, IntPtr intptr_0);

	// Token: 0x060026DB RID: 9947 RVA: 0x0000E0C1 File Offset: 0x0000C2C1
	static Delegate961()
	{
		Class15.smethod_14(typeof(Delegate961).TypeHandle);
	}

	// Token: 0x04000DA1 RID: 3489
	internal static Delegate961 delegate961_0;
}
