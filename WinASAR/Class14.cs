using System;
using System.Reflection;

// Token: 0x020001CE RID: 462
internal class Class14
{
	// Token: 0x060013F4 RID: 5108 RVA: 0x0009B720 File Offset: 0x00099920
	internal static void smethod_0(int typemdt)
	{
		Type type = Class14.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo methodInfo = (MethodInfo)Class14.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, methodInfo));
		}
	}

	// Token: 0x040008A0 RID: 2208
	internal static Module module_0 = typeof(Class14).Assembly.ManifestModule;

	// Token: 0x020001CF RID: 463
	// (Invoke) Token: 0x060013FA RID: 5114
	internal delegate void Delegate1(object o);
}
