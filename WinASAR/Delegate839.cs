using System;
using System.Data;

// Token: 0x02000557 RID: 1367
internal sealed class Delegate839 : MulticastDelegate
{
	// Token: 0x060024F0 RID: 9456
	public extern void Invoke(object object_0, DataRow dataRow_0);

	// Token: 0x060024F1 RID: 9457 RVA: 0x0000D4BE File Offset: 0x0000B6BE
	public static void smethod_0(object object_0, DataRow dataRow_0, Delegate839 delegate839_1)
	{
		delegate839_1(object_0, dataRow_0);
	}

	// Token: 0x060024F2 RID: 9458
	public extern Delegate839(object object_0, IntPtr intptr_0);

	// Token: 0x060024F3 RID: 9459 RVA: 0x0000D4CB File Offset: 0x0000B6CB
	static Delegate839()
	{
		Class15.smethod_14(typeof(Delegate839).TypeHandle);
	}

	// Token: 0x04000D27 RID: 3367
	internal static Delegate839 delegate839_0;
}
