using System;

// Token: 0x020005C5 RID: 1477
internal sealed class Delegate949 : MulticastDelegate
{
	// Token: 0x060026A8 RID: 9896
	public extern string Invoke(DateTimeOffset dateTimeOffset_0);

	// Token: 0x060026A9 RID: 9897 RVA: 0x0000DF84 File Offset: 0x0000C184
	public static string smethod_0(DateTimeOffset dateTimeOffset_0, Delegate949 delegate949_1)
	{
		return delegate949_1(dateTimeOffset_0);
	}

	// Token: 0x060026AA RID: 9898
	public extern Delegate949(object object_0, IntPtr intptr_0);

	// Token: 0x060026AB RID: 9899 RVA: 0x0000DF8F File Offset: 0x0000C18F
	static Delegate949()
	{
		Class15.smethod_14(typeof(Delegate949).TypeHandle);
	}

	// Token: 0x04000D95 RID: 3477
	internal static Delegate949 delegate949_0;
}
