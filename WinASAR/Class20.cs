using System;

// Token: 0x020001E1 RID: 481
internal class Class20
{
	// Token: 0x060014D5 RID: 5333 RVA: 0x000077BB File Offset: 0x000059BB
	internal static RuntimeTypeHandle smethod_0(int token)
	{
		return Class20.moduleHandle_0.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	// Token: 0x060014D6 RID: 5334 RVA: 0x000077C8 File Offset: 0x000059C8
	internal static RuntimeFieldHandle smethod_1(int token)
	{
		return Class20.moduleHandle_0.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	// Token: 0x040008D0 RID: 2256
	internal static ModuleHandle moduleHandle_0 = typeof(Class20).Assembly.GetModules()[0].ModuleHandle;
}
