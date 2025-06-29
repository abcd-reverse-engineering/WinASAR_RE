using System;
using System.Reflection;

// Token: 0x02000233 RID: 563
internal sealed class Delegate35 : MulticastDelegate
{
	// Token: 0x06001860 RID: 6240
	public extern Assembly Invoke(object object_0);

	// Token: 0x06001861 RID: 6241 RVA: 0x000084B9 File Offset: 0x000066B9
	public static Assembly smethod_0(object object_0, Delegate35 delegate35_1)
	{
		return delegate35_1(object_0);
	}

	// Token: 0x06001862 RID: 6242
	public extern Delegate35(object object_0, IntPtr intptr_0);

	// Token: 0x06001863 RID: 6243 RVA: 0x000084C4 File Offset: 0x000066C4
	static Delegate35()
	{
		Class15.smethod_14(typeof(Delegate35).TypeHandle);
	}

	// Token: 0x04000A03 RID: 2563
	internal static Delegate35 delegate35_0;
}
