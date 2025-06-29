using System;

// Token: 0x020004D9 RID: 1241
internal sealed class Delegate713 : MulticastDelegate
{
	// Token: 0x060022F8 RID: 8952
	public extern bool Invoke(object object_0, Type type_0);

	// Token: 0x060022F9 RID: 8953 RVA: 0x0000C858 File Offset: 0x0000AA58
	public static bool smethod_0(object object_0, Type type_0, Delegate713 delegate713_1)
	{
		return delegate713_1(object_0, type_0);
	}

	// Token: 0x060022FA RID: 8954
	public extern Delegate713(object object_0, IntPtr intptr_0);

	// Token: 0x060022FB RID: 8955 RVA: 0x0000C865 File Offset: 0x0000AA65
	static Delegate713()
	{
		Class15.smethod_14(typeof(Delegate713).TypeHandle);
	}

	// Token: 0x04000CA9 RID: 3241
	internal static Delegate713 delegate713_0;
}
