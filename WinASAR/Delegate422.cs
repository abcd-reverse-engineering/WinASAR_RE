using System;
using System.Reflection;

// Token: 0x020003B6 RID: 950
internal sealed class Delegate422 : MulticastDelegate
{
	// Token: 0x06001E6C RID: 7788
	public extern bool Invoke(ConstructorInfo constructorInfo_0, ConstructorInfo constructorInfo_1);

	// Token: 0x06001E6D RID: 7789 RVA: 0x0000AB3F File Offset: 0x00008D3F
	public static bool smethod_0(ConstructorInfo constructorInfo_0, ConstructorInfo constructorInfo_1, Delegate422 delegate422_1)
	{
		return delegate422_1(constructorInfo_0, constructorInfo_1);
	}

	// Token: 0x06001E6E RID: 7790
	public extern Delegate422(object object_0, IntPtr intptr_0);

	// Token: 0x06001E6F RID: 7791 RVA: 0x0000AB4C File Offset: 0x00008D4C
	static Delegate422()
	{
		Class15.smethod_14(typeof(Delegate422).TypeHandle);
	}

	// Token: 0x04000B86 RID: 2950
	internal static Delegate422 delegate422_0;
}
