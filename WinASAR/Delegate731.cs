using System;

// Token: 0x020004EB RID: 1259
internal sealed class Delegate731 : MulticastDelegate
{
	// Token: 0x06002340 RID: 9024
	public extern Type Invoke(string string_0);

	// Token: 0x06002341 RID: 9025 RVA: 0x0000CA12 File Offset: 0x0000AC12
	public static Type smethod_0(string string_0, Delegate731 delegate731_1)
	{
		return delegate731_1(string_0);
	}

	// Token: 0x06002342 RID: 9026
	public extern Delegate731(object object_0, IntPtr intptr_0);

	// Token: 0x06002343 RID: 9027 RVA: 0x0000CA1D File Offset: 0x0000AC1D
	static Delegate731()
	{
		Class15.smethod_14(typeof(Delegate731).TypeHandle);
	}

	// Token: 0x04000CBB RID: 3259
	internal static Delegate731 delegate731_0;
}
