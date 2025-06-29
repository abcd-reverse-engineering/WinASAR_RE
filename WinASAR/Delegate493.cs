using System;

// Token: 0x020003FD RID: 1021
internal sealed class Delegate493 : MulticastDelegate
{
	// Token: 0x06001F88 RID: 8072
	public extern void Invoke(object object_0, int int_0, char[] char_0, int int_1, int int_2);

	// Token: 0x06001F89 RID: 8073 RVA: 0x0000B26F File Offset: 0x0000946F
	public static void smethod_0(object object_0, int int_0, char[] char_0, int int_1, int int_2, Delegate493 delegate493_1)
	{
		delegate493_1(object_0, int_0, char_0, int_1, int_2);
	}

	// Token: 0x06001F8A RID: 8074
	public extern Delegate493(object object_0, IntPtr intptr_0);

	// Token: 0x06001F8B RID: 8075 RVA: 0x0000B282 File Offset: 0x00009482
	static Delegate493()
	{
		Class15.smethod_14(typeof(Delegate493).TypeHandle);
	}

	// Token: 0x04000BCD RID: 3021
	internal static Delegate493 delegate493_0;
}
