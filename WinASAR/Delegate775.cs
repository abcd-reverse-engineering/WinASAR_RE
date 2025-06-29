using System;
using System.ComponentModel;

// Token: 0x02000517 RID: 1303
internal sealed class Delegate775 : MulticastDelegate
{
	// Token: 0x060023F0 RID: 9200
	public extern PropertyDescriptorCollection Invoke(object object_0);

	// Token: 0x060023F1 RID: 9201 RVA: 0x0000CE6C File Offset: 0x0000B06C
	public static PropertyDescriptorCollection smethod_0(object object_0, Delegate775 delegate775_1)
	{
		return delegate775_1(object_0);
	}

	// Token: 0x060023F2 RID: 9202
	public extern Delegate775(object object_0, IntPtr intptr_0);

	// Token: 0x060023F3 RID: 9203 RVA: 0x0000CE77 File Offset: 0x0000B077
	static Delegate775()
	{
		Class15.smethod_14(typeof(Delegate775).TypeHandle);
	}

	// Token: 0x04000CE7 RID: 3303
	internal static Delegate775 delegate775_0;
}
