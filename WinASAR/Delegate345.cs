using System;
using System.Text;

// Token: 0x02000369 RID: 873
internal sealed class Delegate345 : MulticastDelegate
{
	// Token: 0x06001D38 RID: 7480
	public extern StringBuilder Invoke(object object_0, int int_0);

	// Token: 0x06001D39 RID: 7481 RVA: 0x0000A371 File Offset: 0x00008571
	public static StringBuilder smethod_0(object object_0, int int_0, Delegate345 delegate345_1)
	{
		return delegate345_1(object_0, int_0);
	}

	// Token: 0x06001D3A RID: 7482
	public extern Delegate345(object object_0, IntPtr intptr_0);

	// Token: 0x06001D3B RID: 7483 RVA: 0x0000A37E File Offset: 0x0000857E
	static Delegate345()
	{
		Class15.smethod_14(typeof(Delegate345).TypeHandle);
	}

	// Token: 0x04000B39 RID: 2873
	internal static Delegate345 delegate345_0;
}
