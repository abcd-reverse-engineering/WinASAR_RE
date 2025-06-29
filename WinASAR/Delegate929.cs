using System;
using System.Xml.Linq;

// Token: 0x020005B1 RID: 1457
internal sealed class Delegate929 : MulticastDelegate
{
	// Token: 0x06002658 RID: 9816
	public extern XNamespace Invoke(string string_0);

	// Token: 0x06002659 RID: 9817 RVA: 0x0000DD94 File Offset: 0x0000BF94
	public static XNamespace smethod_0(string string_0, Delegate929 delegate929_1)
	{
		return delegate929_1(string_0);
	}

	// Token: 0x0600265A RID: 9818
	public extern Delegate929(object object_0, IntPtr intptr_0);

	// Token: 0x0600265B RID: 9819 RVA: 0x0000DD9F File Offset: 0x0000BF9F
	static Delegate929()
	{
		Class15.smethod_14(typeof(Delegate929).TypeHandle);
	}

	// Token: 0x04000D81 RID: 3457
	internal static Delegate929 delegate929_0;
}
