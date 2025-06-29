using System;

// Token: 0x0200051A RID: 1306
internal sealed class Delegate778 : MulticastDelegate
{
	// Token: 0x060023FC RID: 9212
	public extern string Invoke(object object_0);

	// Token: 0x060023FD RID: 9213 RVA: 0x0000CEB6 File Offset: 0x0000B0B6
	public static string smethod_0(object object_0, Delegate778 delegate778_1)
	{
		return delegate778_1(object_0);
	}

	// Token: 0x060023FE RID: 9214
	public extern Delegate778(object object_0, IntPtr intptr_0);

	// Token: 0x060023FF RID: 9215 RVA: 0x0000CEC1 File Offset: 0x0000B0C1
	static Delegate778()
	{
		Class15.smethod_14(typeof(Delegate778).TypeHandle);
	}

	// Token: 0x04000CEA RID: 3306
	internal static Delegate778 delegate778_0;
}
