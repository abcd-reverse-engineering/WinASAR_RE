using System;

// Token: 0x02000388 RID: 904
internal sealed class Delegate376 : MulticastDelegate
{
	// Token: 0x06001DB4 RID: 7604
	public extern int Invoke(object object_0, char[] char_0, int int_0, int int_1);

	// Token: 0x06001DB5 RID: 7605 RVA: 0x0000A6A7 File Offset: 0x000088A7
	public static int smethod_0(object object_0, char[] char_0, int int_0, int int_1, Delegate376 delegate376_1)
	{
		return delegate376_1(object_0, char_0, int_0, int_1);
	}

	// Token: 0x06001DB6 RID: 7606
	public extern Delegate376(object object_0, IntPtr intptr_0);

	// Token: 0x06001DB7 RID: 7607 RVA: 0x0000A6B8 File Offset: 0x000088B8
	static Delegate376()
	{
		Class15.smethod_14(typeof(Delegate376).TypeHandle);
	}

	// Token: 0x04000B58 RID: 2904
	internal static Delegate376 delegate376_0;
}
