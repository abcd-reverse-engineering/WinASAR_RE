using System;
using System.Drawing;

// Token: 0x020002EB RID: 747
internal sealed class Delegate219 : MulticastDelegate
{
	// Token: 0x06001B40 RID: 6976
	public extern void Invoke(object object_0, Size size_0);

	// Token: 0x06001B41 RID: 6977 RVA: 0x000096D5 File Offset: 0x000078D5
	public static void smethod_0(object object_0, Size size_0, Delegate219 delegate219_1)
	{
		delegate219_1(object_0, size_0);
	}

	// Token: 0x06001B42 RID: 6978
	public extern Delegate219(object object_0, IntPtr intptr_0);

	// Token: 0x06001B43 RID: 6979 RVA: 0x000096E2 File Offset: 0x000078E2
	static Delegate219()
	{
		Class15.smethod_14(typeof(Delegate219).TypeHandle);
	}

	// Token: 0x04000ABB RID: 2747
	internal static Delegate219 delegate219_0;
}
