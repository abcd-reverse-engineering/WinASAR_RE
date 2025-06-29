using System;

// Token: 0x020005D9 RID: 1497
internal sealed class Delegate969 : MulticastDelegate
{
	// Token: 0x060026F8 RID: 9976
	public extern int Invoke(object object_0, byte[] byte_0, int int_0, int int_1, char[] char_0, int int_2);

	// Token: 0x060026F9 RID: 9977 RVA: 0x0000E18A File Offset: 0x0000C38A
	public static int smethod_0(object object_0, byte[] byte_0, int int_0, int int_1, char[] char_0, int int_2, Delegate969 delegate969_1)
	{
		return delegate969_1(object_0, byte_0, int_0, int_1, char_0, int_2);
	}

	// Token: 0x060026FA RID: 9978
	public extern Delegate969(object object_0, IntPtr intptr_0);

	// Token: 0x060026FB RID: 9979 RVA: 0x0000E19F File Offset: 0x0000C39F
	static Delegate969()
	{
		Class15.smethod_14(typeof(Delegate969).TypeHandle);
	}

	// Token: 0x04000DA9 RID: 3497
	internal static Delegate969 delegate969_0;
}
