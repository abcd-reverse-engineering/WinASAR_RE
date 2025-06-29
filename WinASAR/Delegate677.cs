using System;
using System.Reflection;

// Token: 0x020004B5 RID: 1205
internal sealed class Delegate677 : MulticastDelegate
{
	// Token: 0x06002268 RID: 8808
	public extern PropertyInfo Invoke(object object_0, string string_0, BindingFlags bindingFlags_0, Binder binder_0, Type type_0, Type[] type_1, ParameterModifier[] parameterModifier_0);

	// Token: 0x06002269 RID: 8809 RVA: 0x000AE134 File Offset: 0x000AC334
	public static PropertyInfo smethod_0(object object_0, string string_0, BindingFlags bindingFlags_0, Binder binder_0, Type type_0, Type[] type_1, ParameterModifier[] parameterModifier_0, Delegate677 delegate677_1)
	{
		return delegate677_1(object_0, string_0, bindingFlags_0, binder_0, type_0, type_1, parameterModifier_0);
	}

	// Token: 0x0600226A RID: 8810
	public extern Delegate677(object object_0, IntPtr intptr_0);

	// Token: 0x0600226B RID: 8811 RVA: 0x0000C4E1 File Offset: 0x0000A6E1
	static Delegate677()
	{
		Class15.smethod_14(typeof(Delegate677).TypeHandle);
	}

	// Token: 0x04000C85 RID: 3205
	internal static Delegate677 delegate677_0;
}
