using System;

// Token: 0x020003AF RID: 943
internal sealed class Delegate415 : MulticastDelegate
{
	// Token: 0x06001E50 RID: 7760
	public extern int Invoke(byte[] byte_0, int int_0, int int_1, char[] char_0, int int_2);

	// Token: 0x06001E51 RID: 7761 RVA: 0x0000AA8B File Offset: 0x00008C8B
	public static int smethod_0(byte[] byte_0, int int_0, int int_1, char[] char_0, int int_2, Delegate415 delegate415_1)
	{
		return delegate415_1(byte_0, int_0, int_1, char_0, int_2);
	}

	// Token: 0x06001E52 RID: 7762
	public extern Delegate415(object object_0, IntPtr intptr_0);

	// Token: 0x06001E53 RID: 7763 RVA: 0x0000AA9E File Offset: 0x00008C9E
	static Delegate415()
	{
		Class15.smethod_14(typeof(Delegate415).TypeHandle);
	}

	// Token: 0x04000B7F RID: 2943
	internal static Delegate415 delegate415_0;
}
