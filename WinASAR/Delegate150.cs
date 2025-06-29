using System;
using System.Windows.Forms;

// Token: 0x020002A6 RID: 678
internal sealed class Delegate150 : MulticastDelegate
{
	// Token: 0x06001A2C RID: 6700
	public extern DialogResult Invoke(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	// Token: 0x06001A2D RID: 6701 RVA: 0x00009007 File Offset: 0x00007207
	public static DialogResult smethod_0(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, Delegate150 delegate150_1)
	{
		return delegate150_1(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	// Token: 0x06001A2E RID: 6702
	public extern Delegate150(object object_0, IntPtr intptr_0);

	// Token: 0x06001A2F RID: 6703 RVA: 0x00009018 File Offset: 0x00007218
	static Delegate150()
	{
		Class15.smethod_14(typeof(Delegate150).TypeHandle);
	}

	// Token: 0x04000A76 RID: 2678
	internal static Delegate150 delegate150_0;
}
