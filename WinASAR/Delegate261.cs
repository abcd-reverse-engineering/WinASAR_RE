using System;
using System.Text;

// Token: 0x02000315 RID: 789
internal sealed class Delegate261 : MulticastDelegate
{
	// Token: 0x06001BE8 RID: 7144
	public extern Encoding Invoke();

	// Token: 0x06001BE9 RID: 7145 RVA: 0x00009B01 File Offset: 0x00007D01
	public static Encoding smethod_0(Delegate261 delegate261_1)
	{
		return delegate261_1();
	}

	// Token: 0x06001BEA RID: 7146
	public extern Delegate261(object object_0, IntPtr intptr_0);

	// Token: 0x06001BEB RID: 7147 RVA: 0x00009B0A File Offset: 0x00007D0A
	static Delegate261()
	{
		Class15.smethod_14(typeof(Delegate261).TypeHandle);
	}

	// Token: 0x04000AE5 RID: 2789
	internal static Delegate261 delegate261_0;
}
