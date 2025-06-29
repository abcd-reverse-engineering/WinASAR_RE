using System;

// Token: 0x020005D2 RID: 1490
internal sealed class Delegate962 : MulticastDelegate
{
	// Token: 0x060026DC RID: 9948
	public extern int Invoke(object object_0, string string_0, int int_0, int int_1, byte[] byte_0, int int_2);

	// Token: 0x060026DD RID: 9949 RVA: 0x0000E0CE File Offset: 0x0000C2CE
	public static int smethod_0(object object_0, string string_0, int int_0, int int_1, byte[] byte_0, int int_2, Delegate962 delegate962_1)
	{
		return delegate962_1(object_0, string_0, int_0, int_1, byte_0, int_2);
	}

	// Token: 0x060026DE RID: 9950
	public extern Delegate962(object object_0, IntPtr intptr_0);

	// Token: 0x060026DF RID: 9951 RVA: 0x0000E0E3 File Offset: 0x0000C2E3
	static Delegate962()
	{
		Class15.smethod_14(typeof(Delegate962).TypeHandle);
	}

	// Token: 0x04000DA2 RID: 3490
	internal static Delegate962 delegate962_0;
}
