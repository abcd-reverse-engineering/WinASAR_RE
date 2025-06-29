using System;
using System.Text;

// Token: 0x0200062D RID: 1581
internal sealed class Delegate1053 : MulticastDelegate
{
	// Token: 0x06002848 RID: 10312
	public extern StringBuilder Invoke(object object_0, string string_0, object object_1);

	// Token: 0x06002849 RID: 10313 RVA: 0x0000E9FE File Offset: 0x0000CBFE
	public static StringBuilder smethod_0(object object_0, string string_0, object object_1, Delegate1053 delegate1053_1)
	{
		return delegate1053_1(object_0, string_0, object_1);
	}

	// Token: 0x0600284A RID: 10314
	public extern Delegate1053(object object_0, IntPtr intptr_0);

	// Token: 0x0600284B RID: 10315 RVA: 0x0000EA0D File Offset: 0x0000CC0D
	static Delegate1053()
	{
		Class15.smethod_14(typeof(Delegate1053).TypeHandle);
	}

	// Token: 0x04000DFD RID: 3581
	internal static Delegate1053 delegate1053_0;
}
