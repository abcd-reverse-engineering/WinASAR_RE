using System;
using System.Xml.Linq;

// Token: 0x02000598 RID: 1432
internal sealed class Delegate904 : MulticastDelegate
{
	// Token: 0x060025F4 RID: 9716
	public extern XName Invoke(string string_0, string string_1);

	// Token: 0x060025F5 RID: 9717 RVA: 0x0000DB2C File Offset: 0x0000BD2C
	public static XName smethod_0(string string_0, string string_1, Delegate904 delegate904_1)
	{
		return delegate904_1(string_0, string_1);
	}

	// Token: 0x060025F6 RID: 9718
	public extern Delegate904(object object_0, IntPtr intptr_0);

	// Token: 0x060025F7 RID: 9719 RVA: 0x0000DB39 File Offset: 0x0000BD39
	static Delegate904()
	{
		Class15.smethod_14(typeof(Delegate904).TypeHandle);
	}

	// Token: 0x04000D68 RID: 3432
	internal static Delegate904 delegate904_0;
}
