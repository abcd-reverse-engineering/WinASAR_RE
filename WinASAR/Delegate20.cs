using System;
using System.Windows.Forms;

// Token: 0x02000224 RID: 548
internal sealed class Delegate20 : MulticastDelegate
{
	// Token: 0x06001824 RID: 6180
	public extern void Invoke(Form form_0);

	// Token: 0x06001825 RID: 6181 RVA: 0x00008349 File Offset: 0x00006549
	public static void smethod_0(Form form_0, Delegate20 delegate20_1)
	{
		delegate20_1(form_0);
	}

	// Token: 0x06001826 RID: 6182
	public extern Delegate20(object object_0, IntPtr intptr_0);

	// Token: 0x06001827 RID: 6183 RVA: 0x00008354 File Offset: 0x00006554
	static Delegate20()
	{
		Class15.smethod_14(typeof(Delegate20).TypeHandle);
	}

	// Token: 0x040009F4 RID: 2548
	internal static Delegate20 delegate20_0;
}
