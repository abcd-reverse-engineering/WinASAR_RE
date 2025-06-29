using System;

// Token: 0x0200039A RID: 922
internal sealed class Delegate394 : MulticastDelegate
{
	// Token: 0x06001DFC RID: 7676
	public extern void Invoke(object object_0, char[] char_0, int int_0, int int_1);

	// Token: 0x06001DFD RID: 7677 RVA: 0x0000A869 File Offset: 0x00008A69
	public static void smethod_0(object object_0, char[] char_0, int int_0, int int_1, Delegate394 delegate394_1)
	{
		delegate394_1(object_0, char_0, int_0, int_1);
	}

	// Token: 0x06001DFE RID: 7678
	public extern Delegate394(object object_0, IntPtr intptr_0);

	// Token: 0x06001DFF RID: 7679 RVA: 0x0000A87A File Offset: 0x00008A7A
	static Delegate394()
	{
		Class15.smethod_14(typeof(Delegate394).TypeHandle);
	}

	// Token: 0x04000B6A RID: 2922
	internal static Delegate394 delegate394_0;
}
