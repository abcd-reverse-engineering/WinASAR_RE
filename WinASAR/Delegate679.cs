using System;
using System.Reflection;

// Token: 0x020004B7 RID: 1207
internal sealed class Delegate679 : MulticastDelegate
{
	// Token: 0x06002270 RID: 8816
	public extern FieldInfo[] Invoke(object object_0, BindingFlags bindingFlags_0);

	// Token: 0x06002271 RID: 8817 RVA: 0x0000C50C File Offset: 0x0000A70C
	public static FieldInfo[] smethod_0(object object_0, BindingFlags bindingFlags_0, Delegate679 delegate679_1)
	{
		return delegate679_1(object_0, bindingFlags_0);
	}

	// Token: 0x06002272 RID: 8818
	public extern Delegate679(object object_0, IntPtr intptr_0);

	// Token: 0x06002273 RID: 8819 RVA: 0x0000C519 File Offset: 0x0000A719
	static Delegate679()
	{
		Class15.smethod_14(typeof(Delegate679).TypeHandle);
	}

	// Token: 0x04000C87 RID: 3207
	internal static Delegate679 delegate679_0;
}
