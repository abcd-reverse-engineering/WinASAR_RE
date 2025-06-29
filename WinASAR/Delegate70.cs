using System;
using System.Windows.Forms;

// Token: 0x02000256 RID: 598
internal sealed class Delegate70 : MulticastDelegate
{
	// Token: 0x060018EC RID: 6380
	public extern void Invoke(object object_0, FormBorderStyle formBorderStyle_0);

	// Token: 0x060018ED RID: 6381 RVA: 0x00008831 File Offset: 0x00006A31
	public static void smethod_0(object object_0, FormBorderStyle formBorderStyle_0, Delegate70 delegate70_1)
	{
		delegate70_1(object_0, formBorderStyle_0);
	}

	// Token: 0x060018EE RID: 6382
	public extern Delegate70(object object_0, IntPtr intptr_0);

	// Token: 0x060018EF RID: 6383 RVA: 0x0000883E File Offset: 0x00006A3E
	static Delegate70()
	{
		Class15.smethod_14(typeof(Delegate70).TypeHandle);
	}

	// Token: 0x04000A26 RID: 2598
	internal static Delegate70 delegate70_0;
}
