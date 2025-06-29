using System;
using System.Collections.Generic;

// Token: 0x0200045C RID: 1116
internal sealed class Delegate588 : MulticastDelegate
{
	// Token: 0x06002104 RID: 8452
	public extern IEnumerable<string> Invoke(object object_0);

	// Token: 0x06002105 RID: 8453 RVA: 0x0000BBF7 File Offset: 0x00009DF7
	public static IEnumerable<string> smethod_0(object object_0, Delegate588 delegate588_1)
	{
		return delegate588_1(object_0);
	}

	// Token: 0x06002106 RID: 8454
	public extern Delegate588(object object_0, IntPtr intptr_0);

	// Token: 0x06002107 RID: 8455 RVA: 0x0000BC02 File Offset: 0x00009E02
	static Delegate588()
	{
		Class15.smethod_14(typeof(Delegate588).TypeHandle);
	}

	// Token: 0x04000C2C RID: 3116
	internal static Delegate588 delegate588_0;
}
