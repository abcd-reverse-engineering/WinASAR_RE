using System;
using System.Reflection;

// Token: 0x0200061E RID: 1566
internal sealed class Delegate1038 : MulticastDelegate
{
	// Token: 0x0600280C RID: 10252
	public extern FieldInfo Invoke(object object_0, int int_0);

	// Token: 0x0600280D RID: 10253 RVA: 0x0000E880 File Offset: 0x0000CA80
	public static FieldInfo smethod_0(object object_0, int int_0, Delegate1038 delegate1038_1)
	{
		return delegate1038_1(object_0, int_0);
	}

	// Token: 0x0600280E RID: 10254
	public extern Delegate1038(object object_0, IntPtr intptr_0);

	// Token: 0x0600280F RID: 10255 RVA: 0x0000E88D File Offset: 0x0000CA8D
	static Delegate1038()
	{
		Class15.smethod_14(typeof(Delegate1038).TypeHandle);
	}

	// Token: 0x04000DEE RID: 3566
	internal static Delegate1038 delegate1038_0;
}
