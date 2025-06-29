using System;
using System.Collections.Generic;

// Token: 0x020002B5 RID: 693
internal sealed class Delegate165 : MulticastDelegate
{
	// Token: 0x06001A68 RID: 6760
	public extern IEnumerable<int> Invoke(int int_0, int int_1);

	// Token: 0x06001A69 RID: 6761 RVA: 0x00009183 File Offset: 0x00007383
	public static IEnumerable<int> smethod_0(int int_0, int int_1, Delegate165 delegate165_1)
	{
		return delegate165_1(int_0, int_1);
	}

	// Token: 0x06001A6A RID: 6762
	public extern Delegate165(object object_0, IntPtr intptr_0);

	// Token: 0x06001A6B RID: 6763 RVA: 0x00009190 File Offset: 0x00007390
	static Delegate165()
	{
		Class15.smethod_14(typeof(Delegate165).TypeHandle);
	}

	// Token: 0x04000A85 RID: 2693
	internal static Delegate165 delegate165_0;
}
