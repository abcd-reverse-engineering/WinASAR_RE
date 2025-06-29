using System;
using System.Reflection;

// Token: 0x020004B2 RID: 1202
internal sealed class Delegate674 : MulticastDelegate
{
	// Token: 0x0600225C RID: 8796
	public extern Attribute[] Invoke(ParameterInfo parameterInfo_0, Type type_0, bool bool_0);

	// Token: 0x0600225D RID: 8797 RVA: 0x0000C48F File Offset: 0x0000A68F
	public static Attribute[] smethod_0(ParameterInfo parameterInfo_0, Type type_0, bool bool_0, Delegate674 delegate674_1)
	{
		return delegate674_1(parameterInfo_0, type_0, bool_0);
	}

	// Token: 0x0600225E RID: 8798
	public extern Delegate674(object object_0, IntPtr intptr_0);

	// Token: 0x0600225F RID: 8799 RVA: 0x0000C49E File Offset: 0x0000A69E
	static Delegate674()
	{
		Class15.smethod_14(typeof(Delegate674).TypeHandle);
	}

	// Token: 0x04000C82 RID: 3202
	internal static Delegate674 delegate674_0;
}
