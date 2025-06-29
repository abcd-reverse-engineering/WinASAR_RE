using System;
using System.Windows.Forms;

// Token: 0x0200026B RID: 619
internal sealed class Delegate91 : MulticastDelegate
{
	// Token: 0x06001940 RID: 6464
	public extern void Invoke(object object_0, DialogResult dialogResult_0);

	// Token: 0x06001941 RID: 6465 RVA: 0x00008A45 File Offset: 0x00006C45
	public static void smethod_0(object object_0, DialogResult dialogResult_0, Delegate91 delegate91_1)
	{
		delegate91_1(object_0, dialogResult_0);
	}

	// Token: 0x06001942 RID: 6466
	public extern Delegate91(object object_0, IntPtr intptr_0);

	// Token: 0x06001943 RID: 6467 RVA: 0x00008A52 File Offset: 0x00006C52
	static Delegate91()
	{
		Class15.smethod_14(typeof(Delegate91).TypeHandle);
	}

	// Token: 0x04000A3B RID: 2619
	internal static Delegate91 delegate91_0;
}
