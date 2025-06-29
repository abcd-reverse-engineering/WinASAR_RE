using System;

// Token: 0x02000470 RID: 1136
internal sealed class Delegate608 : MulticastDelegate
{
	// Token: 0x06002154 RID: 8532
	public extern int Invoke(object object_0, char char_0, int int_0);

	// Token: 0x06002155 RID: 8533 RVA: 0x0000BDEF File Offset: 0x00009FEF
	public static int smethod_0(object object_0, char char_0, int int_0, Delegate608 delegate608_1)
	{
		return delegate608_1(object_0, char_0, int_0);
	}

	// Token: 0x06002156 RID: 8534
	public extern Delegate608(object object_0, IntPtr intptr_0);

	// Token: 0x06002157 RID: 8535 RVA: 0x0000BDFE File Offset: 0x00009FFE
	static Delegate608()
	{
		Class15.smethod_14(typeof(Delegate608).TypeHandle);
	}

	// Token: 0x04000C40 RID: 3136
	internal static Delegate608 delegate608_0;
}
