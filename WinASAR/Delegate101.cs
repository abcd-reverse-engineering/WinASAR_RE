using System;
using System.Windows.Forms;

// Token: 0x02000275 RID: 629
internal sealed class Delegate101 : MulticastDelegate
{
	// Token: 0x06001968 RID: 6504
	public extern void Invoke(object object_0, ComboBoxStyle comboBoxStyle_0);

	// Token: 0x06001969 RID: 6505 RVA: 0x00008B43 File Offset: 0x00006D43
	public static void smethod_0(object object_0, ComboBoxStyle comboBoxStyle_0, Delegate101 delegate101_1)
	{
		delegate101_1(object_0, comboBoxStyle_0);
	}

	// Token: 0x0600196A RID: 6506
	public extern Delegate101(object object_0, IntPtr intptr_0);

	// Token: 0x0600196B RID: 6507 RVA: 0x00008B50 File Offset: 0x00006D50
	static Delegate101()
	{
		Class15.smethod_14(typeof(Delegate101).TypeHandle);
	}

	// Token: 0x04000A45 RID: 2629
	internal static Delegate101 delegate101_0;
}
