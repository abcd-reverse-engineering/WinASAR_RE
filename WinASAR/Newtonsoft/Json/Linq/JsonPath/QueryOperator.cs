using System;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200017F RID: 383
	internal enum QueryOperator
	{
		// Token: 0x040007A0 RID: 1952
		None,
		// Token: 0x040007A1 RID: 1953
		Equals,
		// Token: 0x040007A2 RID: 1954
		NotEquals,
		// Token: 0x040007A3 RID: 1955
		Exists,
		// Token: 0x040007A4 RID: 1956
		LessThan,
		// Token: 0x040007A5 RID: 1957
		LessThanOrEquals,
		// Token: 0x040007A6 RID: 1958
		GreaterThan,
		// Token: 0x040007A7 RID: 1959
		GreaterThanOrEquals,
		// Token: 0x040007A8 RID: 1960
		And,
		// Token: 0x040007A9 RID: 1961
		Or,
		// Token: 0x040007AA RID: 1962
		RegexEquals,
		// Token: 0x040007AB RID: 1963
		StrictEquals,
		// Token: 0x040007AC RID: 1964
		StrictNotEquals
	}
}
