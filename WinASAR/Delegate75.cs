using System;
using System.Windows.Forms;

// Token: 0x0200025B RID: 603
internal sealed class Delegate75 : MulticastDelegate
{
	// Token: 0x06001900 RID: 6400
	public extern void Invoke(object object_0, FormStartPosition formStartPosition_0);

	// Token: 0x06001901 RID: 6401 RVA: 0x000088B3 File Offset: 0x00006AB3
	public static void smethod_0(object object_0, FormStartPosition formStartPosition_0, Delegate75 delegate75_1)
	{
		delegate75_1(object_0, formStartPosition_0);
	}

	// Token: 0x06001902 RID: 6402
	public extern Delegate75(object object_0, IntPtr intptr_0);

	// Token: 0x06001903 RID: 6403 RVA: 0x000088C0 File Offset: 0x00006AC0
	static Delegate75()
	{
		Class15.smethod_14(typeof(Delegate75).TypeHandle);
	}

	// Token: 0x04000A2B RID: 2603
	internal static Delegate75 delegate75_0;
}
