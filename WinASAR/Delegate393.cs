using System;

// Token: 0x02000399 RID: 921
internal sealed class Delegate393 : MulticastDelegate
{
	// Token: 0x06001DF8 RID: 7672
	public extern int Invoke(int int_0, int int_1);

	// Token: 0x06001DF9 RID: 7673 RVA: 0x0000A84F File Offset: 0x00008A4F
	public static int smethod_0(int int_0, int int_1, Delegate393 delegate393_1)
	{
		return delegate393_1(int_0, int_1);
	}

	// Token: 0x06001DFA RID: 7674
	public extern Delegate393(object object_0, IntPtr intptr_0);

	// Token: 0x06001DFB RID: 7675 RVA: 0x0000A85C File Offset: 0x00008A5C
	static Delegate393()
	{
		Class15.smethod_14(typeof(Delegate393).TypeHandle);
	}

	// Token: 0x04000B69 RID: 2921
	internal static Delegate393 delegate393_0;
}
