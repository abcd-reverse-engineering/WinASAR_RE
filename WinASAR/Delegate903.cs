using System;
using System.Xml.Linq;

// Token: 0x02000597 RID: 1431
internal sealed class Delegate903 : MulticastDelegate
{
	// Token: 0x060025F0 RID: 9712
	public extern XName Invoke(string string_0);

	// Token: 0x060025F1 RID: 9713 RVA: 0x0000DB14 File Offset: 0x0000BD14
	public static XName smethod_0(string string_0, Delegate903 delegate903_1)
	{
		return delegate903_1(string_0);
	}

	// Token: 0x060025F2 RID: 9714
	public extern Delegate903(object object_0, IntPtr intptr_0);

	// Token: 0x060025F3 RID: 9715 RVA: 0x0000DB1F File Offset: 0x0000BD1F
	static Delegate903()
	{
		Class15.smethod_14(typeof(Delegate903).TypeHandle);
	}

	// Token: 0x04000D67 RID: 3431
	internal static Delegate903 delegate903_0;
}
