using System;
using System.Text;

// Token: 0x02000314 RID: 788
internal sealed class Delegate260 : MulticastDelegate
{
	// Token: 0x06001BE4 RID: 7140
	public extern Encoding Invoke(string string_0);

	// Token: 0x06001BE5 RID: 7141 RVA: 0x00009AE9 File Offset: 0x00007CE9
	public static Encoding smethod_0(string string_0, Delegate260 delegate260_1)
	{
		return delegate260_1(string_0);
	}

	// Token: 0x06001BE6 RID: 7142
	public extern Delegate260(object object_0, IntPtr intptr_0);

	// Token: 0x06001BE7 RID: 7143 RVA: 0x00009AF4 File Offset: 0x00007CF4
	static Delegate260()
	{
		Class15.smethod_14(typeof(Delegate260).TypeHandle);
	}

	// Token: 0x04000AE4 RID: 2788
	internal static Delegate260 delegate260_0;
}
