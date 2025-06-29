using System;
using System.Data;

// Token: 0x02000549 RID: 1353
internal sealed class Delegate825 : MulticastDelegate
{
	// Token: 0x060024B8 RID: 9400
	public extern DataTable Invoke(object object_0, string string_0);

	// Token: 0x060024B9 RID: 9401 RVA: 0x0000D35E File Offset: 0x0000B55E
	public static DataTable smethod_0(object object_0, string string_0, Delegate825 delegate825_1)
	{
		return delegate825_1(object_0, string_0);
	}

	// Token: 0x060024BA RID: 9402
	public extern Delegate825(object object_0, IntPtr intptr_0);

	// Token: 0x060024BB RID: 9403 RVA: 0x0000D36B File Offset: 0x0000B56B
	static Delegate825()
	{
		Class15.smethod_14(typeof(Delegate825).TypeHandle);
	}

	// Token: 0x04000D19 RID: 3353
	internal static Delegate825 delegate825_0;
}
