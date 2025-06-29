using System;
using System.Reflection;

// Token: 0x02000453 RID: 1107
internal sealed class Delegate579 : MulticastDelegate
{
	// Token: 0x060020E0 RID: 8416
	public extern MethodInfo Invoke(object object_0, bool bool_0);

	// Token: 0x060020E1 RID: 8417 RVA: 0x0000BB13 File Offset: 0x00009D13
	public static MethodInfo smethod_0(object object_0, bool bool_0, Delegate579 delegate579_1)
	{
		return delegate579_1(object_0, bool_0);
	}

	// Token: 0x060020E2 RID: 8418
	public extern Delegate579(object object_0, IntPtr intptr_0);

	// Token: 0x060020E3 RID: 8419 RVA: 0x0000BB20 File Offset: 0x00009D20
	static Delegate579()
	{
		Class15.smethod_14(typeof(Delegate579).TypeHandle);
	}

	// Token: 0x04000C23 RID: 3107
	internal static Delegate579 delegate579_0;
}
