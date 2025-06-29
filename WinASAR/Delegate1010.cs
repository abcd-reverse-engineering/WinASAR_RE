using System;
using System.IO;

// Token: 0x02000602 RID: 1538
internal sealed class Delegate1010 : MulticastDelegate
{
	// Token: 0x0600279C RID: 10140
	public extern Stream Invoke(object object_0, string string_0);

	// Token: 0x0600279D RID: 10141 RVA: 0x0000E5CA File Offset: 0x0000C7CA
	public static Stream smethod_0(object object_0, string string_0, Delegate1010 delegate1010_1)
	{
		return delegate1010_1(object_0, string_0);
	}

	// Token: 0x0600279E RID: 10142
	public extern Delegate1010(object object_0, IntPtr intptr_0);

	// Token: 0x0600279F RID: 10143 RVA: 0x0000E5D7 File Offset: 0x0000C7D7
	static Delegate1010()
	{
		Class15.smethod_14(typeof(Delegate1010).TypeHandle);
	}

	// Token: 0x04000DD2 RID: 3538
	internal static Delegate1010 delegate1010_0;
}
