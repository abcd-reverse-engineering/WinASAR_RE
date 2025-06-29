using System;

// Token: 0x020005D3 RID: 1491
internal sealed class Delegate963 : MulticastDelegate
{
	// Token: 0x060026E0 RID: 9952
	public extern void Invoke(object object_0, byte[] byte_0, int int_0, int int_1);

	// Token: 0x060026E1 RID: 9953 RVA: 0x0000E0F0 File Offset: 0x0000C2F0
	public static void smethod_0(object object_0, byte[] byte_0, int int_0, int int_1, Delegate963 delegate963_1)
	{
		delegate963_1(object_0, byte_0, int_0, int_1);
	}

	// Token: 0x060026E2 RID: 9954
	public extern Delegate963(object object_0, IntPtr intptr_0);

	// Token: 0x060026E3 RID: 9955 RVA: 0x0000E101 File Offset: 0x0000C301
	static Delegate963()
	{
		Class15.smethod_14(typeof(Delegate963).TypeHandle);
	}

	// Token: 0x04000DA3 RID: 3491
	internal static Delegate963 delegate963_0;
}
