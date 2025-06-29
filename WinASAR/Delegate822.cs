using System;
using System.Data;

// Token: 0x02000546 RID: 1350
internal sealed class Delegate822 : MulticastDelegate
{
	// Token: 0x060024AC RID: 9388
	public extern DataTableCollection Invoke(object object_0);

	// Token: 0x060024AD RID: 9389 RVA: 0x0000D316 File Offset: 0x0000B516
	public static DataTableCollection smethod_0(object object_0, Delegate822 delegate822_1)
	{
		return delegate822_1(object_0);
	}

	// Token: 0x060024AE RID: 9390
	public extern Delegate822(object object_0, IntPtr intptr_0);

	// Token: 0x060024AF RID: 9391 RVA: 0x0000D321 File Offset: 0x0000B521
	static Delegate822()
	{
		Class15.smethod_14(typeof(Delegate822).TypeHandle);
	}

	// Token: 0x04000D16 RID: 3350
	internal static Delegate822 delegate822_0;
}
