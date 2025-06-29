using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200015C RID: 348
	[NullableContext(1)]
	[Nullable(new byte[] { 0, 1 })]
	internal class JPropertyKeyedCollection : Collection<JToken>
	{
		// Token: 0x06000F1B RID: 3867 RVA: 0x0007A618 File Offset: 0x00078818
		public JPropertyKeyedCollection()
			: base(new List<JToken>())
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0007A650 File Offset: 0x00078850
		private void method_0(string string_0, JToken jtoken_0)
		{
			for (;;)
			{
				IL_0035:
				this.method_2();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.dictionary_0[string_0] = jtoken_0;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0035;
					}
					return;
				}
			}
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0007A6B0 File Offset: 0x000788B0
		protected void ChangeItemKey(JToken item, string newKey)
		{
			for (;;)
			{
				string text;
				if (this.method_1(item))
				{
					text = this.method_3(item);
					goto IL_006E;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto Block_5;
				}
				IL_002D:
				switch (num)
				{
				case 1:
					goto IL_00A4;
				case 2:
					continue;
				case 3:
					goto IL_0011;
				case 4:
					goto IL_0059;
				case 6:
					IL_006E:
					if (!JPropertyKeyedCollection.iequalityComparer_0.Equals(text, newKey))
					{
						goto IL_0068;
					}
					break;
				case 7:
					goto IL_0061;
				case 8:
					goto IL_0068;
				}
				break;
				IL_0011:
				this.method_4(text);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
				{
					goto IL_002D;
				}
				break;
				IL_0061:
				if (text == null)
				{
					break;
				}
				goto IL_0011;
				IL_0068:
				if (newKey == null)
				{
					goto IL_0061;
				}
				IL_0059:
				this.method_0(newKey, item);
				goto IL_0061;
			}
			return;
			Block_5:
			IL_00A4:
			throw new ArgumentException(Class15.smethod_17(1270965714 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112));
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0007A780 File Offset: 0x00078980
		protected override void ClearItems()
		{
			Dictionary<string, JToken> dictionary;
			for (;;)
			{
				base.ClearItems();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
				{
					goto IL_0003;
				}
				IL_001E:
				switch (num)
				{
				case 1:
					IL_0003:
					dictionary = this.dictionary_0;
					if (dictionary != null)
					{
						goto IL_0052;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
					{
						goto IL_001E;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				break;
			}
			return;
			IL_0052:
			dictionary.Clear();
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0007A7E4 File Offset: 0x000789E4
		public bool Contains(string key)
		{
			while (key != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto IL_0015;
				}
				IL_002E:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_006C;
				case 3:
					goto IL_0051;
				}
				IL_0015:
				if (this.dictionary_0 == null)
				{
					return false;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
				{
					goto IL_002E;
				}
				IL_006C:
				return this.dictionary_0.ContainsKey(key);
			}
			IL_0051:
			throw new ArgumentNullException(Class15.smethod_17(1176461986 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af));
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0007A86C File Offset: 0x00078A6C
		private bool method_1(JToken jtoken_0)
		{
			string text;
			for (;;)
			{
				int num;
				if (this.dictionary_0 == null)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
					{
						break;
					}
				}
				else
				{
					text = this.method_3(jtoken_0);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
					{
						break;
					}
				}
				switch (num)
				{
				case 1:
					return false;
				case 2:
					continue;
				}
				break;
			}
			JToken jtoken;
			return this.dictionary_0.TryGetValue(text, out jtoken);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0007A8E0 File Offset: 0x00078AE0
		private void method_2()
		{
			while (this.dictionary_0 == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					goto IL_0015;
				}
				IL_0036:
				switch (num)
				{
				case 0:
					return;
				case 1:
					IL_0015:
					this.dictionary_0 = new Dictionary<string, JToken>(JPropertyKeyedCollection.iequalityComparer_0);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
					{
						goto IL_0036;
					}
					return;
				case 2:
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x000061A7 File Offset: 0x000043A7
		private string method_3(JToken jtoken_0)
		{
			return ((JProperty)jtoken_0).Name;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0007A944 File Offset: 0x00078B44
		protected override void InsertItem(int index, JToken item)
		{
			for (;;)
			{
				this.method_0(this.method_3(item), item);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				base.InsertItem(index, item);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
				{
					goto IL_001C;
				}
				break;
			}
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0007A9A4 File Offset: 0x00078BA4
		public bool Remove(string key)
		{
			while (key != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
				{
					goto IL_003B;
				}
				IL_0046:
				switch (num)
				{
				case 0:
					goto IL_006B;
				case 1:
					IL_003B:
					if (this.dictionary_0 == null)
					{
						return false;
					}
					break;
				case 2:
					continue;
				case 3:
					break;
				case 4:
					goto IL_0074;
				default:
					goto IL_006B;
				}
				JToken jtoken;
				if (!this.dictionary_0.TryGetValue(key, out jtoken))
				{
					return false;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
				{
					goto IL_0046;
				}
				IL_006B:
				return base.Remove(jtoken);
			}
			IL_0074:
			throw new ArgumentNullException(Class15.smethod_17(1807881392 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3));
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0007AA44 File Offset: 0x00078C44
		protected override void RemoveItem(int index)
		{
			for (;;)
			{
				string text = this.method_3(base.Items[index]);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_005D;
				case 3:
					return;
				}
				IL_0003:
				this.method_4(text);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
				{
					goto IL_001C;
				}
				break;
			}
			IL_005D:
			base.RemoveItem(index);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0007AAB8 File Offset: 0x00078CB8
		private void method_4(string string_0)
		{
			for (;;)
			{
				Dictionary<string, JToken> dictionary = this.dictionary_0;
				int num;
				if (dictionary != null)
				{
					dictionary.Remove(string_0);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
					{
						goto IL_004B;
					}
				}
				else
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						break;
					}
				}
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				break;
			}
			return;
			IL_004B:;
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0007AB14 File Offset: 0x00078D14
		protected override void SetItem(int index, JToken item)
		{
			for (;;)
			{
				IL_00FA:
				string text = this.method_3(item);
				for (;;)
				{
					IL_00E4:
					string text2 = this.method_3(base.Items[index]);
					for (;;)
					{
						IL_00D1:
						if (JPropertyKeyedCollection.iequalityComparer_0.Equals(text2, text))
						{
							goto IL_00A3;
						}
						goto IL_00B1;
						int num;
						for (;;)
						{
							IL_0022:
							switch (num)
							{
							case 1:
							case 6:
							case 11:
								goto IL_0006;
							case 2:
								goto IL_00D1;
							case 3:
								goto IL_00A3;
							case 4:
								if (text2 == null)
								{
									num = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
									{
										goto Block_3;
									}
									continue;
								}
								break;
							case 5:
								goto IL_00B1;
							case 7:
								return;
							case 8:
								goto IL_005A;
							case 9:
								goto IL_00E4;
							case 10:
								goto IL_00FA;
							}
							goto Block_1;
						}
						Block_3:
						goto IL_0006;
						IL_0082:
						this.method_4(text2);
						goto IL_0006;
						Block_1:
						goto IL_0082;
						IL_0006:
						base.SetItem(index, item);
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
						{
							goto IL_0022;
						}
						return;
						IL_00B1:
						this.method_0(text, item);
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
						{
							goto IL_00A3;
						}
						goto IL_0022;
						IL_005A:
						this.dictionary_0[text] = item;
						goto IL_0006;
						IL_00A3:
						if (this.dictionary_0 == null)
						{
							goto IL_0006;
						}
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
						{
							goto IL_005A;
						}
						goto IL_0022;
					}
				}
			}
		}

		// Token: 0x17000238 RID: 568
		public JToken this[string key]
		{
			get
			{
				IL_0037:
				while (key != null)
				{
					while (this.dictionary_0 != null)
					{
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
						{
							switch (num)
							{
							case 1:
								goto IL_0046;
							case 2:
								continue;
							case 3:
								goto IL_0037;
							}
						}
						return this.dictionary_0[key];
					}
					throw new KeyNotFoundException();
				}
				IL_0046:
				throw new ArgumentNullException(Class15.smethod_17(1176461986 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af));
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0007ACA4 File Offset: 0x00078EA4
		public bool TryGetValue(string key, [Nullable(2)] [NotNullWhen(true)] out JToken value)
		{
			while (this.dictionary_0 == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
				{
					goto IL_0015;
				}
				IL_0029:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return false;
				}
				IL_0015:
				value = null;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					goto IL_0029;
				}
				return false;
			}
			return this.dictionary_0.TryGetValue(key, out value);
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x000061B4 File Offset: 0x000043B4
		public ICollection<string> Keys
		{
			get
			{
				this.method_2();
				return this.dictionary_0.Keys;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x000061C7 File Offset: 0x000043C7
		public ICollection<JToken> Values
		{
			get
			{
				this.method_2();
				return this.dictionary_0.Values;
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000061DA File Offset: 0x000043DA
		public int IndexOfReference(JToken t)
		{
			return ((List<JToken>)base.Items).IndexOfReference(t);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0007AD0C File Offset: 0x00078F0C
		public bool Compare(JPropertyKeyedCollection other)
		{
			while (this != other)
			{
				Dictionary<string, JToken> dictionary = this.dictionary_0;
				int num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
				{
					goto IL_0020;
				}
				IL_0086:
				Dictionary<string, JToken> dictionary2;
				switch (num)
				{
				case 0:
					goto IL_003A;
				case 1:
					goto IL_0246;
				case 2:
					goto IL_0065;
				case 3:
					break;
				case 4:
					return true;
				case 5:
					continue;
				case 6:
					goto IL_005E;
				case 7:
					goto IL_00E3;
				case 8:
					return true;
				case 9:
					goto IL_0057;
				case 10:
					goto IL_003E;
				case 11:
					IL_0020:
					dictionary2 = other.dictionary_0;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
					{
						goto IL_003A;
					}
					goto IL_0086;
				case 12:
					goto IL_0251;
				case 13:
					return false;
				default:
					goto IL_003A;
				}
				return true;
				IL_003E:
				if (dictionary2 == null)
				{
					return true;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
				{
					goto IL_0057;
				}
				goto IL_0086;
				IL_003A:
				if (dictionary == null)
				{
					goto IL_003E;
				}
				goto IL_0057;
				IL_0065:
				if (dictionary.Count == dictionary2.Count)
				{
					Dictionary<string, JToken>.Enumerator enumerator = dictionary.GetEnumerator();
					goto IL_00E3;
				}
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
				{
					goto IL_0086;
				}
				return false;
				IL_005E:
				if (dictionary2 != null)
				{
					goto IL_0065;
				}
				goto IL_0246;
				IL_0057:
				if (dictionary != null)
				{
					goto IL_005E;
				}
				goto IL_0251;
				IL_00E3:
				bool flag;
				try
				{
					JProperty jproperty2;
					for (;;)
					{
						Dictionary<string, JToken>.Enumerator enumerator;
						if (enumerator.MoveNext())
						{
							goto IL_01D1;
						}
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
						{
							goto Block_13;
						}
						goto IL_0148;
						IL_011E:
						JProperty jproperty;
						if (jproperty.Value.DeepEquals(jproperty2.Value))
						{
							continue;
						}
						goto IL_00EA;
						IL_0139:
						if (jproperty.Value == null)
						{
							goto Block_9;
						}
						goto IL_011E;
						IL_018C:
						JToken jtoken;
						jproperty2 = (JProperty)jtoken;
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
						{
							goto IL_0139;
						}
						goto IL_0148;
						IL_01A9:
						KeyValuePair<string, JToken> keyValuePair;
						jproperty = (JProperty)keyValuePair.Value;
						goto IL_018C;
						IL_0148:
						switch (num2)
						{
						case 0:
							goto IL_01A9;
						case 1:
							goto IL_0200;
						case 2:
							goto IL_0139;
						case 3:
							goto IL_011E;
						case 4:
							goto IL_018C;
						case 5:
							break;
						case 6:
						case 11:
							continue;
						case 7:
							goto IL_0203;
						case 8:
							goto IL_0214;
						case 9:
							goto IL_01B9;
						case 10:
							goto IL_0205;
						case 12:
							goto IL_0211;
						case 13:
							IL_01D1:
							keyValuePair = enumerator.Current;
							goto IL_01B9;
						case 14:
							goto IL_00EA;
						default:
							goto IL_01A9;
						}
						IL_0104:
						flag = false;
						num2 = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
						{
							break;
						}
						goto IL_0148;
						IL_00EA:
						flag = false;
						num2 = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
						{
							break;
						}
						goto IL_0148;
						IL_01B9:
						if (!dictionary2.TryGetValue(keyValuePair.Key, out jtoken))
						{
							goto IL_0104;
						}
						goto IL_01A9;
					}
					goto IL_0203;
					Block_9:
					goto IL_0205;
					Block_13:
					IL_0200:
					return true;
					IL_0203:
					return flag;
					IL_0205:
					flag = jproperty2.Value == null;
					IL_0211:
					IL_0214:;
				}
				finally
				{
					Dictionary<string, JToken>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
					{
						switch (num3)
						{
						}
					}
				}
				return flag;
				IL_0246:
				return dictionary.Count == 0;
				IL_0251:
				return dictionary2.Count == 0;
			}
			return true;
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0007AF94 File Offset: 0x00079194
		static JPropertyKeyedCollection()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					goto IL_001F;
				}
				IL_0034:
				switch (num)
				{
				case 0:
					goto IL_001F;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					break;
				default:
					goto IL_001F;
				}
				IL_0003:
				JPropertyKeyedCollection.iequalityComparer_0 = StringComparer.Ordinal;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
				{
					goto IL_0034;
				}
				IL_001F:
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					goto IL_0003;
				}
				goto IL_0034;
			}
		}

		// Token: 0x040006D9 RID: 1753
		private static readonly IEqualityComparer<string> iequalityComparer_0;

		// Token: 0x040006DA RID: 1754
		[Nullable(new byte[] { 2, 1, 1 })]
		private Dictionary<string, JToken> dictionary_0;
	}
}
