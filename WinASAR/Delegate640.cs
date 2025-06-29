using System;

// Token: 0x02000490 RID: 1168
internal sealed class Delegate640 : MulticastDelegate
{
	// Token: 0x060021D4 RID: 8660
	public extern double Invoke(double double_0, double double_1);

	// Token: 0x060021D5 RID: 8661 RVA: 0x0000C12D File Offset: 0x0000A32D
	public static double smethod_0(double double_0, double double_1, Delegate640 delegate640_1)
	{
		return delegate640_1(double_0, double_1);
	}

	// Token: 0x060021D6 RID: 8662
	public extern Delegate640(object object_0, IntPtr intptr_0);

	// Token: 0x060021D7 RID: 8663 RVA: 0x0000C13A File Offset: 0x0000A33A
	static Delegate640()
	{
		Class15.smethod_14(typeof(Delegate640).TypeHandle);
	}

	// Token: 0x04000C60 RID: 3168
	internal static Delegate640 delegate640_0;
}
