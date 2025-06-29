using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace WinASAR.Common.Models
{
	// Token: 0x02000022 RID: 34
	public class ListComparer<T> : IComparer<T> where T : class
	{
		// Token: 0x06000184 RID: 388 RVA: 0x000242FC File Offset: 0x000224FC
		public ListComparer(string sortFieldName, SortOrder sortDirectionType = SortOrder.Ascending, string groupFieldName = null, SortOrder groupDirectionType = SortOrder.Descending, List<string> topmostGroupItems = null)
		{
			this.string_1 = groupFieldName;
			this.string_0 = sortFieldName;
			this.sortOrder_1 = groupDirectionType;
			this.sortOrder_0 = sortDirectionType;
			if (topmostGroupItems != null)
			{
				this.list_0.AddRange(topmostGroupItems);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0002434C File Offset: 0x0002254C
		public int Compare(T x, T y)
		{
			if (x == null || y == null)
			{
				throw new ArgumentException(Class15.smethod_17(1802349575 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
			}
			int num;
			if (!string.IsNullOrEmpty(this.string_1))
			{
				PropertyInfo property = x.GetType().GetProperty(this.string_1);
				object obj = ((property != null) ? property.GetValue(x, null) : null);
				PropertyInfo property2 = y.GetType().GetProperty(this.string_1);
				object obj2 = ((property2 != null) ? property2.GetValue(y, null) : null);
				if (obj != null && obj2 != null)
				{
					string text = obj.ToString();
					string text2 = obj2.ToString();
					bool flag = this.list_0.Contains(text);
					bool flag2 = this.list_0.Contains(text2);
					if (flag ^ flag2)
					{
						if (!flag)
						{
							return 1;
						}
						return -1;
					}
				}
				num = this.method_0(obj, obj2, this.sortOrder_1);
				if (num != 0)
				{
					return num;
				}
			}
			PropertyInfo property3 = x.GetType().GetProperty(this.string_0);
			object obj3 = ((property3 != null) ? property3.GetValue(x, null) : null);
			PropertyInfo property4 = y.GetType().GetProperty(this.string_0);
			object obj4 = ((property4 != null) ? property4.GetValue(y, null) : null);
			num = this.method_0(obj3, obj4, this.sortOrder_0);
			if (num != 0)
			{
				return num;
			}
			return 0;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000244B4 File Offset: 0x000226B4
		private int method_0(object object_1, object object_2, SortOrder sortOrder_2)
		{
			for (;;)
			{
				if (object_1 == null)
				{
					goto IL_0052;
				}
				goto IL_006C;
				IL_0014:
				int num;
				switch (num)
				{
				case 1:
				case 4:
					goto IL_0052;
				case 2:
					goto IL_004C;
				case 3:
					return 1;
				case 5:
					continue;
				case 6:
					return 0;
				case 7:
					return -1;
				case 9:
					goto IL_0079;
				case 10:
					goto IL_009B;
				case 11:
					IL_006C:
					if (object_2 == null)
					{
						goto IL_0052;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto Block_4;
					}
					goto IL_0014;
				}
				break;
				IL_004C:
				if (object_2 == null)
				{
					return 0;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
				{
					goto IL_0014;
				}
				break;
				IL_0052:
				if (object_1 != null)
				{
					break;
				}
				goto IL_004C;
			}
			goto IL_0090;
			Block_4:
			IL_0079:
			return Comparer.Default.Compare(object_1, object_2) * ((sortOrder_2 == SortOrder.Ascending) ? 1 : (-1));
			IL_0090:
			if (object_1 == null)
			{
				goto IL_009B;
			}
			if (sortOrder_2 == SortOrder.Ascending)
			{
				return 1;
			}
			return -1;
			IL_009B:
			if (sortOrder_2 == SortOrder.Ascending)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002899 File Offset: 0x00000A99
		internal static bool smethod_0()
		{
			return ListComparer<T>.object_0 == null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000028A3 File Offset: 0x00000AA3
		internal static object smethod_1()
		{
			return ListComparer<T>.object_0;
		}

		// Token: 0x0400011A RID: 282
		private readonly string string_0;

		// Token: 0x0400011B RID: 283
		private readonly SortOrder sortOrder_0;

		// Token: 0x0400011C RID: 284
		private readonly string string_1;

		// Token: 0x0400011D RID: 285
		private readonly SortOrder sortOrder_1;

		// Token: 0x0400011E RID: 286
		private readonly List<string> list_0 = new List<string>();

		// Token: 0x0400011F RID: 287
		private static object object_0;
	}
}
