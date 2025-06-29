using System;
using System.Reflection;

// Token: 0x02000452 RID: 1106
internal sealed class Delegate578 : MulticastDelegate
{
	// Token: 0x060020DC RID: 8412
	public extern ConstructorInfo Invoke(object object_0, BindingFlags bindingFlags_0, Binder binder_0, Type[] type_0, ParameterModifier[] parameterModifier_0);

	// Token: 0x060020DD RID: 8413 RVA: 0x0000BAF3 File Offset: 0x00009CF3
	public static ConstructorInfo smethod_0(object object_0, BindingFlags bindingFlags_0, Binder binder_0, Type[] type_0, ParameterModifier[] parameterModifier_0, Delegate578 delegate578_1)
	{
		return delegate578_1(object_0, bindingFlags_0, binder_0, type_0, parameterModifier_0);
	}

	// Token: 0x060020DE RID: 8414
	public extern Delegate578(object object_0, IntPtr intptr_0);

	// Token: 0x060020DF RID: 8415 RVA: 0x0000BB06 File Offset: 0x00009D06
	static Delegate578()
	{
		Class15.smethod_14(typeof(Delegate578).TypeHandle);
	}

	// Token: 0x04000C22 RID: 3106
	internal static Delegate578 delegate578_0;
}
