using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000162 RID: 354
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x0007B744 File Offset: 0x00079944
		public static JTokenEqualityComparer EqualityComparer
		{
			get
			{
				for (;;)
				{
					int num;
					if (JToken.jtokenEqualityComparer_0 != null)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
						{
							break;
						}
						goto IL_0021;
					}
					do
					{
						IL_0003:
						JToken.jtokenEqualityComparer_0 = new JTokenEqualityComparer();
						num = 3;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0);
					IL_0021:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0003;
					}
					break;
				}
				return JToken.jtokenEqualityComparer_0;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00006236 File Offset: 0x00004436
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x0007B7B0 File Offset: 0x000799B0
		[Nullable(2)]
		public JContainer Parent
		{
			[NullableContext(2)]
			get
			{
				return this.jcontainer_0;
			}
			[NullableContext(2)]
			internal set
			{
				for (;;)
				{
					this.jcontainer_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0007B7E8 File Offset: 0x000799E8
		public JToken Root
		{
			get
			{
				JContainer jcontainer;
				for (;;)
				{
					jcontainer = this.Parent;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						goto IL_0003;
					}
					IL_0018:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return this;
					case 3:
						return jcontainer;
					case 4:
						goto IL_005C;
					}
					IL_0003:
					if (jcontainer != null)
					{
						break;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						goto IL_0018;
					}
					return this;
				}
				IL_005C:
				while (jcontainer.Parent != null)
				{
					jcontainer = jcontainer.Parent;
				}
				return jcontainer;
			}
		}

		// Token: 0x06000F5D RID: 3933
		internal abstract JToken CloneToken([Nullable(2)] JsonCloneSettings settings);

		// Token: 0x06000F5E RID: 3934
		internal abstract bool DeepEquals(JToken node);

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000F5F RID: 3935
		public abstract JTokenType Type { get; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000F60 RID: 3936
		public abstract bool HasValues { get; }

		// Token: 0x06000F61 RID: 3937 RVA: 0x0007B85C File Offset: 0x00079A5C
		[NullableContext(2)]
		public static bool DeepEquals(JToken t1, JToken t2)
		{
			IL_0039:
			while (t1 != t2)
			{
				IL_0033:
				while (t1 != null)
				{
					while (t2 != null)
					{
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
						{
							switch (num)
							{
							default:
								continue;
							case 1:
								break;
							case 2:
								goto IL_0033;
							case 3:
								goto IL_0039;
							case 4:
								return false;
							}
						}
						return t1.DeepEquals(t2);
					}
					return false;
				}
				return false;
			}
			return true;
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0000623E File Offset: 0x0000443E
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x0007B8B8 File Offset: 0x00079AB8
		[Nullable(2)]
		public JToken Next
		{
			[NullableContext(2)]
			get
			{
				return this.jtoken_1;
			}
			[NullableContext(2)]
			internal set
			{
				for (;;)
				{
					this.jtoken_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x00006246 File Offset: 0x00004446
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x0007B8F0 File Offset: 0x00079AF0
		[Nullable(2)]
		public JToken Previous
		{
			[NullableContext(2)]
			get
			{
				return this.jtoken_0;
			}
			[NullableContext(2)]
			internal set
			{
				for (;;)
				{
					this.jtoken_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0007B928 File Offset: 0x00079B28
		public string Path
		{
			get
			{
				List<JsonPosition> list;
				for (;;)
				{
					int num;
					if (this.Parent == null)
					{
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
						{
							break;
						}
					}
					else
					{
						list = new List<JsonPosition>();
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
						{
							goto IL_012C;
						}
					}
					IL_0143:
					JToken jtoken;
					switch (num)
					{
					case 0:
						goto IL_0090;
					case 1:
						goto IL_00EB;
					case 2:
					case 8:
					case 9:
						goto IL_0094;
					case 3:
						goto IL_01CD;
					case 4:
						goto IL_01C3;
					case 5:
						continue;
					case 6:
					case 18:
						goto IL_00F4;
					case 7:
						goto IL_0060;
					case 10:
						goto IL_0069;
					case 11:
						IL_012C:
						jtoken = null;
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
						{
							goto IL_0127;
						}
						goto IL_0143;
					case 12:
						goto IL_00AF;
					case 13:
						goto IL_00BF;
					case 14:
						goto IL_0127;
					case 15:
						goto IL_0085;
					case 16:
						goto IL_0119;
					case 17:
						goto IL_00FB;
					case 19:
						break;
					default:
						goto IL_0090;
					}
					IL_0027:
					List<JsonPosition> list2 = list;
					JProperty jproperty;
					JsonPosition jsonPosition = new JsonPosition(JsonContainerType.Object)
					{
						PropertyName = jproperty.Name
					};
					list2.Add(jsonPosition);
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
					{
						break;
					}
					goto IL_0143;
					IL_0119:
					JToken jtoken2;
					jproperty = (JProperty)jtoken2;
					goto IL_0027;
					IL_0085:
					JTokenType type;
					if (type == JTokenType.Property)
					{
						goto IL_0119;
					}
					goto IL_0094;
					IL_0069:
					if (type - JTokenType.Array <= 1)
					{
						goto IL_0090;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
					{
						goto IL_0085;
					}
					goto IL_0143;
					IL_0060:
					type = jtoken2.Type;
					goto IL_0069;
					IL_00F4:
					if (jtoken2 == null)
					{
						goto IL_00FB;
					}
					goto IL_0060;
					IL_0127:
					jtoken2 = this;
					goto IL_00F4;
					IL_00EB:
					jtoken2 = jtoken2.Parent;
					goto IL_00F4;
					IL_0094:
					jtoken = jtoken2;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
					{
						goto IL_00EB;
					}
					goto IL_0143;
					IL_0090:
					if (jtoken == null)
					{
						goto IL_0094;
					}
					goto IL_00AF;
					IL_00BF:
					List<JsonPosition> list3 = list;
					int num2;
					jsonPosition = new JsonPosition(JsonContainerType.Array)
					{
						Position = num2
					};
					list3.Add(jsonPosition);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto IL_00EB;
					}
					goto IL_0143;
					IL_00AF:
					num2 = ((IList<JToken>)jtoken2).IndexOf(jtoken);
					goto IL_00BF;
					IL_00FB:
					list.FastReverse<JsonPosition>();
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
					{
						break;
					}
					goto IL_0143;
				}
				goto IL_01CD;
				IL_01C3:
				return string.Empty;
				IL_01CD:
				return JsonPosition.BuildPath(list, null);
			}
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0004CCB0 File Offset: 0x0004AEB0
		internal JToken()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0007BB14 File Offset: 0x00079D14
		[NullableContext(2)]
		public void AddAfterSelf(object content)
		{
			while (this.jcontainer_0 != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_005F;
					case 3:
						return;
					case 4:
						goto IL_004A;
					}
				}
				int num2 = this.jcontainer_0.IndexOfItem(this);
				IL_004A:
				this.jcontainer_0.TryAddInternal(num2 + 1, content, false, true);
				return;
			}
			IL_005F:
			throw new InvalidOperationException(Class15.smethod_17(698956918 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a));
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0007BB9C File Offset: 0x00079D9C
		[NullableContext(2)]
		public void AddBeforeSelf(object content)
		{
			for (;;)
			{
				int num;
				if (this.jcontainer_0 != null)
				{
					num = this.jcontainer_0.IndexOfItem(this);
					goto IL_0011;
				}
				int num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
				{
					break;
				}
				IL_0033:
				switch (num2)
				{
				case 1:
					goto IL_006D;
				case 2:
					continue;
				case 3:
					IL_0011:
					this.jcontainer_0.TryAddInternal(num, content, false, true);
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
					{
						goto IL_0033;
					}
					break;
				}
				break;
			}
			return;
			IL_006D:
			throw new InvalidOperationException(Class15.smethod_17(1788647972 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1));
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0000624E File Offset: 0x0000444E
		public IEnumerable<JToken> Ancestors()
		{
			return this.GetAncestors(false);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00006257 File Offset: 0x00004457
		public IEnumerable<JToken> AncestorsAndSelf()
		{
			return this.GetAncestors(true);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00006260 File Offset: 0x00004460
		internal IEnumerable<JToken> GetAncestors(bool self)
		{
			for (;;)
			{
				IL_013B:
				int num2;
				int num = num2;
				JToken current;
				for (;;)
				{
					IL_011F:
					int num3 = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
					{
						goto IL_00BF;
					}
					for (;;)
					{
						IL_00D7:
						switch (num3)
						{
						case 1:
							goto IL_0098;
						case 2:
							goto IL_0075;
						case 3:
							goto IL_011F;
						case 4:
							goto IL_013B;
						case 5:
						case 14:
							goto IL_00B4;
						case 6:
							goto IL_00BF;
						case 7:
							goto IL_000D;
						case 8:
							goto IL_015E;
						case 9:
							goto IL_0157;
						case 10:
							goto IL_0161;
						case 11:
						case 13:
							goto IL_0148;
						case 12:
							goto IL_0029;
						case 15:
							if (num == 0)
							{
								goto IL_000D;
							}
							goto IL_0098;
						}
						goto Block_5;
						IL_000D:
						num3 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
						{
							continue;
						}
						IL_0029:
						current = ((!self) ? this.Parent : this);
						num3 = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
						{
							goto Block_2;
						}
						continue;
						IL_0098:
						if (num != 1)
						{
							num3 = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							num3 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
							{
								continue;
							}
						}
						IL_0075:
						current = current.Parent;
						num3 = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
						{
							goto IL_0098;
						}
					}
					IL_00B4:
					if (current != null)
					{
						goto IL_0148;
					}
					IL_00BF:
					current = null;
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto IL_00D7;
					}
					goto IL_0145;
				}
				IL_015E:
				IL_0157:
				continue;
				IL_0148:
				yield return current;
				Block_2:;
			}
			Block_4:
			goto IL_0161;
			Block_5:
			IL_0145:
			yield break;
			IL_0161:
			yield break;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00006277 File Offset: 0x00004477
		public IEnumerable<JToken> AfterSelf()
		{
			JToken.<AfterSelf>d__43 <AfterSelf>d__ = new JToken.<AfterSelf>d__43(-2);
			<AfterSelf>d__.<>4__this = this;
			return <AfterSelf>d__;
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00006287 File Offset: 0x00004487
		public IEnumerable<JToken> BeforeSelf()
		{
			JToken.<BeforeSelf>d__44 <BeforeSelf>d__ = new JToken.<BeforeSelf>d__44(-2);
			<BeforeSelf>d__.<>4__this = this;
			return <BeforeSelf>d__;
		}

		// Token: 0x1700024B RID: 587
		[Nullable(2)]
		public virtual JToken this[object key]
		{
			[return: Nullable(2)]
			get
			{
				throw new InvalidOperationException(Class15.smethod_17(1243236612 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95).FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
			[param: Nullable(2)]
			set
			{
				throw new InvalidOperationException(Class15.smethod_17(1788804813 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c).FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0007BC34 File Offset: 0x00079E34
		[NullableContext(2)]
		public virtual T Value<T>([Nullable(1)] object key)
		{
			JToken jtoken = this[key];
			if (jtoken != null)
			{
				return jtoken.Convert<JToken, T>();
			}
			return default(T);
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x000062EF File Offset: 0x000044EF
		[Nullable(2)]
		public virtual JToken First
		{
			[NullableContext(2)]
			get
			{
				throw new InvalidOperationException(Class15.smethod_17(89019562 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454).FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x0000631B File Offset: 0x0000451B
		[Nullable(2)]
		public virtual JToken Last
		{
			[NullableContext(2)]
			get
			{
				throw new InvalidOperationException(Class15.smethod_17(2048588835 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18).FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00006347 File Offset: 0x00004547
		[return: Nullable(new byte[] { 0, 1 })]
		public virtual JEnumerable<JToken> Children()
		{
			return JEnumerable<JToken>.Empty;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0000634E File Offset: 0x0000454E
		[NullableContext(0)]
		[return: Nullable(new byte[] { 0, 1 })]
		public JEnumerable<T> Children<T>() where T : JToken
		{
			return new JEnumerable<T>(this.Children().OfType<T>());
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00006365 File Offset: 0x00004565
		[NullableContext(2)]
		[return: Nullable(new byte[] { 1, 2 })]
		public virtual IEnumerable<T> Values<T>()
		{
			throw new InvalidOperationException(Class15.smethod_17(538791353 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa).FormatWith(CultureInfo.InvariantCulture, base.GetType()));
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0007BC5C File Offset: 0x00079E5C
		public void Remove()
		{
			while (this.jcontainer_0 != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
				{
					goto IL_0015;
				}
				IL_0033:
				switch (num)
				{
				case 0:
					goto IL_0059;
				case 1:
					IL_0015:
					this.jcontainer_0.RemoveItem(this);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto IL_0033;
					}
					break;
				case 2:
					continue;
				case 3:
					break;
				default:
					goto IL_0059;
				}
				return;
			}
			IL_0059:
			throw new InvalidOperationException(Class15.smethod_17(1788804423 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c));
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0007BCE0 File Offset: 0x00079EE0
		public void Replace(JToken value)
		{
			while (this.jcontainer_0 != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					switch (num)
					{
					case 0:
						goto IL_0047;
					case 1:
						break;
					case 2:
						continue;
					case 3:
						return;
					default:
						goto IL_0047;
					}
				}
				this.jcontainer_0.ReplaceItem(this, value);
				return;
			}
			IL_0047:
			throw new InvalidOperationException(Class15.smethod_17(1802322005 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
		}

		// Token: 0x06000F79 RID: 3961
		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

		// Token: 0x06000F7A RID: 3962 RVA: 0x00006391 File Offset: 0x00004591
		public override string ToString()
		{
			return this.ToString(Formatting.Indented, new JsonConverter[0]);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0007BD50 File Offset: 0x00079F50
		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			for (;;)
			{
				StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0036;
					case 2:
						continue;
					}
					break;
				}
				goto IL_0035;
			}
			string text;
			return text;
			IL_0035:
			IL_0036:
			try
			{
				StringWriter stringWriter;
				JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter);
				for (;;)
				{
					jsonTextWriter.Formatting = formatting;
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
					{
						goto IL_0042;
					}
					IL_005C:
					switch (num2)
					{
					case 1:
						IL_0042:
						this.WriteTo(jsonTextWriter, converters);
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
						{
							goto IL_005C;
						}
						break;
					case 2:
						goto IL_009A;
					case 3:
						continue;
					}
					break;
				}
				text = stringWriter.ToString();
				IL_009A:;
			}
			finally
			{
				StringWriter stringWriter;
				if (stringWriter != null)
				{
					goto IL_00C8;
				}
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
				{
					goto IL_00E1;
				}
				IL_00B4:
				switch (num3)
				{
				case 1:
					IL_00C8:
					((IDisposable)stringWriter).Dispose();
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_00B4;
					}
					break;
				}
				IL_00E1:;
			}
			return text;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0007BE54 File Offset: 0x0007A054
		[return: Nullable(2)]
		private static JValue smethod_0(object object_1)
		{
			for (;;)
			{
				int num;
				JProperty jproperty;
				if (object_1 == null)
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
					{
						goto Block_3;
					}
				}
				else
				{
					jproperty = object_1 as JProperty;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
					{
						goto IL_001D;
					}
				}
				IL_004D:
				switch (num)
				{
				case 1:
					goto IL_0033;
				case 2:
					goto IL_0084;
				case 3:
					continue;
				case 4:
					IL_001D:
					if (jproperty != null)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
						{
							goto IL_0033;
						}
						goto IL_004D;
					}
					break;
				}
				break;
				IL_0033:
				object_1 = jproperty.Value;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
				{
					goto IL_004D;
				}
				break;
			}
			goto IL_00A0;
			Block_3:
			IL_0084:
			throw new ArgumentNullException(Class15.smethod_17(926368931 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
			IL_00A0:
			return object_1 as JValue;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0007BF08 File Offset: 0x0007A108
		private static string smethod_1(JToken jtoken_2)
		{
			for (;;)
			{
				IL_0066:
				ValidationUtils.ArgumentNotNull(jtoken_2, Class15.smethod_17(1603829106 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c));
				for (;;)
				{
					IL_005C:
					JProperty jproperty = jtoken_2 as JProperty;
					for (;;)
					{
						if (jproperty != null)
						{
							goto IL_0003;
						}
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
						{
							goto IL_0083;
						}
						IL_001D:
						switch (num)
						{
						case 1:
							IL_0003:
							jtoken_2 = jproperty.Value;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
							{
								goto IL_001D;
							}
							break;
						case 2:
							goto IL_005C;
						case 3:
							goto IL_0066;
						case 4:
							continue;
						case 5:
							goto IL_008F;
						}
						goto Block_1;
					}
				}
			}
			Block_1:
			IL_0083:
			JTokenType type = jtoken_2.Type;
			IL_008F:
			return type.ToString();
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0007BFB4 File Offset: 0x0007A1B4
		private static bool smethod_2(JToken jtoken_2, object object_1, bool bool_0)
		{
			IL_0057:
			while (Array.IndexOf<JTokenType>(object_1, jtoken_2.Type) == -1)
			{
				for (;;)
				{
					if (bool_0)
					{
						goto IL_0030;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
					{
						break;
					}
					IL_0014:
					switch (num)
					{
					case 1:
						return false;
					case 2:
						continue;
					case 3:
						goto IL_0057;
					case 4:
						IL_0030:
						if (jtoken_2.Type == JTokenType.Null)
						{
							return true;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
						{
							goto IL_0014;
						}
						break;
					}
					break;
				}
				return jtoken_2.Type == JTokenType.Undefined;
			}
			return true;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0007C040 File Offset: 0x0007A240
		public static explicit operator bool(JToken value)
		{
			JValue jvalue;
			BigInteger bigInteger;
			for (;;)
			{
				IL_00A4:
				jvalue = JToken.smethod_0(value);
				int num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto Block_4;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
					case 4:
						goto IL_00D1;
					case 2:
						goto IL_005A;
					case 3:
						goto IL_0021;
					case 5:
						goto IL_004E;
					case 6:
						goto IL_0033;
					case 7:
						if (jvalue != null)
						{
							goto IL_0021;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
						{
							goto Block_2;
						}
						continue;
					case 8:
						goto IL_00A4;
					case 9:
						goto IL_00FC;
					}
					goto Block_3;
					IL_0033:
					object value2 = jvalue.Value;
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
					{
						goto IL_004E;
					}
					continue;
					IL_0021:
					if (JToken.smethod_2(jvalue, JToken.jtokenType_0, false))
					{
						goto IL_0033;
					}
					goto IL_00D1;
					IL_005A:
					bigInteger = (BigInteger)value2;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
					{
						continue;
					}
					goto IL_00C3;
					IL_004E:
					if (value2 is BigInteger)
					{
						goto IL_005A;
					}
					goto IL_00FC;
				}
			}
			Block_2:
			goto IL_00D1;
			Block_3:
			Block_4:
			IL_00C3:
			return Convert.ToBoolean((int)bigInteger);
			IL_00D1:
			throw new ArgumentException(Class15.smethod_17(613136149 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00FC:
			return Convert.ToBoolean(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0007C15C File Offset: 0x0007A35C
		public static explicit operator DateTimeOffset(JToken value)
		{
			JValue jvalue;
			string text;
			DateTimeOffset dateTimeOffset;
			for (;;)
			{
				IL_00C6:
				jvalue = JToken.smethod_0(value);
				IL_00BF:
				while (jvalue != null)
				{
					while (JToken.smethod_2(jvalue, JToken.jtokenType_8, false))
					{
						int num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
						{
							goto IL_0058;
						}
						IL_007A:
						object value2;
						switch (num)
						{
						case 1:
							goto IL_00E2;
						case 2:
							goto IL_00D0;
						case 3:
							goto IL_0061;
						case 4:
							IL_0058:
							value2 = jvalue.Value;
							goto IL_0061;
						case 5:
							goto IL_00BF;
						case 6:
							goto IL_00C6;
						case 7:
							goto IL_0038;
						case 8:
							goto IL_001A;
						case 9:
							continue;
						}
						goto Block_6;
						IL_001A:
						if (text == null)
						{
							goto IL_010D;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
						{
							break;
						}
						goto IL_007A;
						IL_0061:
						if (!(value2 is DateTimeOffset))
						{
							text = jvalue.Value as string;
							goto IL_001A;
						}
						IL_0038:
						dateTimeOffset = (DateTimeOffset)value2;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
						{
							goto Block_4;
						}
						goto IL_007A;
					}
					break;
				}
				break;
			}
			goto IL_00E2;
			Block_4:
			Block_6:
			return dateTimeOffset;
			IL_00D0:
			return DateTimeOffset.Parse(text, CultureInfo.InvariantCulture);
			IL_00E2:
			throw new ArgumentException(Class15.smethod_17(89020306 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_010D:
			return new DateTimeOffset(Convert.ToDateTime(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0007C28C File Offset: 0x0007A48C
		[NullableContext(2)]
		public static explicit operator bool?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_0, true))
			{
				throw new ArgumentException(Class15.smethod_17(1176471786 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new bool?(Convert.ToBoolean((int)bigInteger));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0007C338 File Offset: 0x0007A538
		public static explicit operator long(JToken value)
		{
			JValue jvalue;
			object value2;
			for (;;)
			{
				IL_0079:
				jvalue = JToken.smethod_0(value);
				IL_0072:
				while (jvalue != null)
				{
					while (JToken.smethod_2(jvalue, JToken.jtokenType_1, false))
					{
						value2 = jvalue.Value;
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
						{
							goto IL_001E;
						}
						IL_0038:
						switch (num)
						{
						case 1:
							IL_001E:
							if (!(value2 is BigInteger))
							{
								goto IL_008F;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
							{
								goto IL_0038;
							}
							break;
						case 2:
							goto IL_0072;
						case 3:
							goto IL_0079;
						case 4:
						case 7:
							goto IL_00A1;
						case 5:
							continue;
						case 6:
							goto IL_00CC;
						}
						goto Block_2;
					}
					break;
				}
				goto Block_4;
			}
			Block_2:
			goto IL_0084;
			Block_4:
			goto IL_00A1;
			IL_0084:
			BigInteger bigInteger = (BigInteger)value2;
			goto IL_00CC;
			IL_008F:
			return Convert.ToInt64(jvalue.Value, CultureInfo.InvariantCulture);
			IL_00A1:
			throw new ArgumentException(Class15.smethod_17(2057029481 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00CC:
			return (long)bigInteger;
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0007C418 File Offset: 0x0007A618
		[NullableContext(2)]
		public static explicit operator DateTime?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_8, true))
			{
				throw new ArgumentException(Class15.smethod_17(1985329232 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is DateTimeOffset)
			{
				return new DateTime?(((DateTimeOffset)value2).DateTime);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new DateTime?(Convert.ToDateTime(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0007C4C0 File Offset: 0x0007A6C0
		[NullableContext(2)]
		public static explicit operator DateTimeOffset?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_8, true))
			{
				throw new ArgumentException(Class15.smethod_17(1243236924 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			object value2 = jvalue.Value;
			if (value2 is DateTimeOffset)
			{
				DateTimeOffset dateTimeOffset = (DateTimeOffset)value2;
				return new DateTimeOffset?(dateTimeOffset);
			}
			string text = jvalue.Value as string;
			if (text != null)
			{
				return new DateTimeOffset?(DateTimeOffset.Parse(text, CultureInfo.InvariantCulture));
			}
			return new DateTimeOffset?(new DateTimeOffset(Convert.ToDateTime(jvalue.Value, CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0007C58C File Offset: 0x0007A78C
		[NullableContext(2)]
		public static explicit operator decimal?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_1, true))
			{
				throw new ArgumentException(Class15.smethod_17(1760358401 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new decimal?((decimal)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new decimal?(Convert.ToDecimal(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0007C634 File Offset: 0x0007A834
		[NullableContext(2)]
		public static explicit operator double?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_1, true))
			{
				throw new ArgumentException(Class15.smethod_17(314820491 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new double?((double)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new double?(Convert.ToDouble(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0007C6DC File Offset: 0x0007A8DC
		[NullableContext(2)]
		public static explicit operator char?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_7, true))
			{
				throw new ArgumentException(Class15.smethod_17(1424590412 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new char?((char)(ushort)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new char?(Convert.ToChar(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0007C784 File Offset: 0x0007A984
		public static explicit operator int(JToken value)
		{
			JValue jvalue;
			BigInteger bigInteger;
			for (;;)
			{
				IL_0082:
				jvalue = JToken.smethod_0(value);
				int num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
				{
					goto IL_001C;
				}
				for (;;)
				{
					IL_005A:
					switch (num)
					{
					case 1:
						goto IL_0040;
					case 2:
						goto IL_00D5;
					case 3:
						goto IL_001C;
					case 4:
						goto IL_0034;
					case 5:
						goto IL_00AA;
					case 6:
						if (jvalue == null)
						{
							goto IL_00AA;
						}
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
						{
							goto IL_001C;
						}
						continue;
					case 7:
						goto IL_0082;
					}
					goto Block_3;
				}
				IL_0040:
				object value2;
				bigInteger = (BigInteger)value2;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					goto IL_005A;
				}
				break;
				IL_0034:
				if (value2 is BigInteger)
				{
					goto IL_0040;
				}
				goto IL_00D5;
				IL_001C:
				if (JToken.smethod_2(jvalue, JToken.jtokenType_1, false))
				{
					value2 = jvalue.Value;
					goto IL_0034;
				}
				goto IL_00AA;
			}
			Block_3:
			return (int)bigInteger;
			IL_00AA:
			throw new ArgumentException(Class15.smethod_17(926396909 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00D5:
			return Convert.ToInt32(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0007C878 File Offset: 0x0007AA78
		public static explicit operator short(JToken value)
		{
			JValue jvalue;
			object value2;
			for (;;)
			{
				jvalue = JToken.smethod_0(value);
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
				{
					goto IL_0003;
				}
				IL_0047:
				switch (num)
				{
				case 1:
				case 7:
					goto IL_00BC;
				case 2:
					goto IL_009F;
				case 3:
					goto IL_0096;
				case 4:
					goto IL_00B1;
				case 5:
					IL_0003:
					if (jvalue == null)
					{
						goto IL_00BC;
					}
					break;
				case 6:
					continue;
				case 8:
					goto IL_00E7;
				}
				if (!JToken.smethod_2(jvalue, JToken.jtokenType_1, false))
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
					{
						break;
					}
					goto IL_0047;
				}
				else
				{
					value2 = jvalue.Value;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						goto IL_0047;
					}
					goto IL_0095;
				}
			}
			goto IL_00BC;
			IL_0095:
			IL_0096:
			if (value2 is BigInteger)
			{
				goto IL_00B1;
			}
			IL_009F:
			return Convert.ToInt16(jvalue.Value, CultureInfo.InvariantCulture);
			IL_00B1:
			BigInteger bigInteger = (BigInteger)value2;
			goto IL_00E7;
			IL_00BC:
			throw new ArgumentException(Class15.smethod_17(299908925 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00E7:
			return (short)bigInteger;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0007C974 File Offset: 0x0007AB74
		[CLSCompliant(false)]
		public static explicit operator ushort(JToken value)
		{
			JValue jvalue;
			for (;;)
			{
				IL_0064:
				jvalue = JToken.smethod_0(value);
				while (jvalue != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
					{
						goto IL_0015;
					}
					IL_0035:
					switch (num)
					{
					case 1:
						goto IL_00A0;
					case 2:
						goto IL_007A;
					case 3:
						continue;
					case 4:
						goto IL_0064;
					case 5:
						goto IL_0083;
					case 6:
						goto IL_00CB;
					case 7:
						goto IL_0095;
					}
					IL_0015:
					if (JToken.smethod_2(jvalue, JToken.jtokenType_1, false))
					{
						goto IL_0071;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
					{
						goto IL_0035;
					}
					break;
				}
				break;
			}
			goto IL_00A0;
			IL_0071:
			object value2 = jvalue.Value;
			IL_007A:
			if (value2 is BigInteger)
			{
				goto IL_0095;
			}
			IL_0083:
			return Convert.ToUInt16(jvalue.Value, CultureInfo.InvariantCulture);
			IL_0095:
			BigInteger bigInteger = (BigInteger)value2;
			goto IL_00CB;
			IL_00A0:
			throw new ArgumentException(Class15.smethod_17(89016734 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00CB:
			return (ushort)bigInteger;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0007CA54 File Offset: 0x0007AC54
		[CLSCompliant(false)]
		public static explicit operator char(JToken value)
		{
			JValue jvalue;
			BigInteger bigInteger;
			for (;;)
			{
				IL_009A:
				jvalue = JToken.smethod_0(value);
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
				{
					goto IL_0021;
				}
				for (;;)
				{
					IL_0071:
					switch (num)
					{
					case 1:
					case 4:
						goto IL_00CE;
					case 2:
						goto IL_0021;
					case 3:
						goto IL_003C;
					case 5:
						if (jvalue != null)
						{
							goto IL_0021;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
						{
							goto Block_2;
						}
						continue;
					case 6:
						goto IL_009A;
					case 7:
						goto IL_00F9;
					}
					break;
				}
				goto IL_0057;
				IL_003C:
				object value2;
				if (!(value2 is BigInteger))
				{
					goto IL_00BC;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
				{
					goto IL_0057;
				}
				goto IL_0071;
				IL_0021:
				if (JToken.smethod_2(jvalue, JToken.jtokenType_7, false))
				{
					value2 = jvalue.Value;
					goto IL_003C;
				}
				break;
				IL_0057:
				bigInteger = (BigInteger)value2;
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					goto IL_0071;
				}
			}
			Block_2:
			goto IL_00CE;
			IL_00BC:
			return Convert.ToChar(jvalue.Value, CultureInfo.InvariantCulture);
			IL_00CE:
			throw new ArgumentException(Class15.smethod_17(2008597985 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00F9:
			return (char)(ushort)bigInteger;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0007CB64 File Offset: 0x0007AD64
		public static explicit operator byte(JToken value)
		{
			JValue jvalue;
			BigInteger bigInteger;
			for (;;)
			{
				IL_00A7:
				jvalue = JToken.smethod_0(value);
				IL_009F:
				while (jvalue != null)
				{
					for (;;)
					{
						object value2;
						if (JToken.smethod_2(jvalue, JToken.jtokenType_1, false))
						{
							value2 = jvalue.Value;
							goto IL_006A;
						}
						int num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
						{
							break;
						}
						IL_002E:
						switch (num)
						{
						case 1:
							goto IL_00F2;
						case 2:
							goto IL_009F;
						case 3:
							goto IL_00A7;
						case 4:
							continue;
						case 5:
							goto IL_00C7;
						case 6:
							goto IL_0011;
						case 7:
							IL_006A:
							if (value2 is BigInteger)
							{
								goto IL_0011;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
							{
								goto IL_002E;
							}
							break;
						}
						goto Block_1;
						IL_0011:
						bigInteger = (BigInteger)value2;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
						{
							goto IL_002E;
						}
						goto IL_00C4;
					}
					goto IL_00A7;
				}
				goto IL_00C7;
			}
			Block_1:
			return Convert.ToByte(jvalue.Value, CultureInfo.InvariantCulture);
			IL_00C4:
			goto IL_00F2;
			IL_00C7:
			throw new ArgumentException(Class15.smethod_17(613132699 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00F2:
			return (byte)bigInteger;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0007CC6C File Offset: 0x0007AE6C
		[CLSCompliant(false)]
		public static explicit operator sbyte(JToken value)
		{
			JValue jvalue;
			object value2;
			for (;;)
			{
				jvalue = JToken.smethod_0(value);
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
				{
					goto IL_0040;
				}
				IL_0047:
				switch (num)
				{
				case 1:
					goto IL_00CD;
				case 2:
				case 5:
					goto IL_008F;
				case 3:
					IL_0040:
					if (jvalue == null)
					{
						goto Block_4;
					}
					goto IL_0026;
				case 4:
					continue;
				case 6:
					goto IL_0026;
				case 7:
					goto IL_00D6;
				case 8:
					goto IL_0003;
				}
				break;
				IL_0003:
				if (value2 is BigInteger)
				{
					goto IL_00CD;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
				{
					break;
				}
				goto IL_0047;
				IL_0026:
				if (JToken.smethod_2(jvalue, JToken.jtokenType_1, false))
				{
					value2 = jvalue.Value;
					goto IL_0003;
				}
				goto IL_008F;
			}
			goto IL_00BB;
			Block_4:
			goto IL_008F;
			goto IL_00BB;
			IL_008F:
			throw new ArgumentException(Class15.smethod_17(594385348 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00BB:
			return Convert.ToSByte(jvalue.Value, CultureInfo.InvariantCulture);
			IL_00CD:
			BigInteger bigInteger = (BigInteger)value2;
			IL_00D6:
			return (sbyte)bigInteger;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0007CD58 File Offset: 0x0007AF58
		[NullableContext(2)]
		public static explicit operator int?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_1, true))
			{
				throw new ArgumentException(Class15.smethod_17(124795070 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new int?((int)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new int?(Convert.ToInt32(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0007CE00 File Offset: 0x0007B000
		[NullableContext(2)]
		public static explicit operator short?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_1, true))
			{
				throw new ArgumentException(Class15.smethod_17(1678077260 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new short?((short)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new short?(Convert.ToInt16(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0007CEA8 File Offset: 0x0007B0A8
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator ushort?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_1, true))
			{
				throw new ArgumentException(Class15.smethod_17(543272366 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new ushort?((ushort)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new ushort?(Convert.ToUInt16(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0007CF50 File Offset: 0x0007B150
		[NullableContext(2)]
		public static explicit operator byte?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_1, true))
			{
				throw new ArgumentException(Class15.smethod_17(1471408453 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new byte?((byte)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new byte?(Convert.ToByte(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0007CFF8 File Offset: 0x0007B1F8
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator sbyte?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_1, true))
			{
				throw new ArgumentException(Class15.smethod_17(1760357983 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new sbyte?((sbyte)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new sbyte?(Convert.ToSByte(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0007D0A0 File Offset: 0x0007B2A0
		public static explicit operator DateTime(JToken value)
		{
			JValue jvalue;
			object value2;
			for (;;)
			{
				IL_008C:
				jvalue = JToken.smethod_0(value);
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
				{
					goto Block_7;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (!JToken.smethod_2(jvalue, JToken.jtokenType_8, false))
						{
							goto IL_00C7;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
						{
							goto IL_0024;
						}
						continue;
					case 2:
						goto IL_00C7;
					case 3:
						goto IL_0024;
					case 4:
						if (jvalue == null)
						{
							goto IL_00C7;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
						{
							continue;
						}
						break;
					case 5:
						goto IL_008C;
					case 6:
						goto IL_00FB;
					case 7:
						goto IL_00F2;
					}
					goto Block_6;
					IL_0024:
					value2 = jvalue.Value;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
					{
						goto Block_3;
					}
				}
			}
			Block_3:
			Block_6:
			goto IL_00AC;
			Block_7:
			goto IL_00C7;
			IL_00AC:
			if (!(value2 is DateTimeOffset))
			{
				return Convert.ToDateTime(jvalue.Value, CultureInfo.InvariantCulture);
			}
			goto IL_00F2;
			IL_00C7:
			throw new ArgumentException(Class15.smethod_17(1985329232 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00F2:
			DateTimeOffset dateTimeOffset = (DateTimeOffset)value2;
			IL_00FB:
			return dateTimeOffset.DateTime;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0007D1B0 File Offset: 0x0007B3B0
		[NullableContext(2)]
		public static explicit operator long?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_1, true))
			{
				throw new ArgumentException(Class15.smethod_17(538791633 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new long?((long)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new long?(Convert.ToInt64(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0007D258 File Offset: 0x0007B458
		[NullableContext(2)]
		public static explicit operator float?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_1, true))
			{
				throw new ArgumentException(Class15.smethod_17(974401575 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new float?((float)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new float?(Convert.ToSingle(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0007D300 File Offset: 0x0007B500
		public static explicit operator decimal(JToken value)
		{
			JValue jvalue;
			object value2;
			for (;;)
			{
				IL_0082:
				jvalue = JToken.smethod_0(value);
				IL_007B:
				while (jvalue != null)
				{
					IL_0069:
					while (JToken.smethod_2(jvalue, JToken.jtokenType_1, false))
					{
						for (;;)
						{
							value2 = jvalue.Value;
							int num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
							{
								goto IL_0003;
							}
							IL_0020:
							switch (num)
							{
							case 1:
								goto IL_00AA;
							case 2:
								goto IL_007B;
							case 3:
								goto IL_0082;
							case 4:
								goto IL_0069;
							case 5:
								goto IL_009F;
							case 6:
								continue;
							case 7:
								IL_0003:
								if (value2 is BigInteger)
								{
									goto IL_009F;
								}
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
								{
									goto IL_0020;
								}
								break;
							case 8:
								goto IL_00D5;
							}
							goto Block_2;
						}
					}
					break;
				}
				goto IL_00AA;
			}
			Block_2:
			return Convert.ToDecimal(jvalue.Value, CultureInfo.InvariantCulture);
			IL_009F:
			BigInteger bigInteger = (BigInteger)value2;
			goto IL_00D5;
			IL_00AA:
			throw new ArgumentException(Class15.smethod_17(41461697 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00D5:
			return (decimal)bigInteger;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0007D3EC File Offset: 0x0007B5EC
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator uint?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_1, true))
			{
				throw new ArgumentException(Class15.smethod_17(564876804 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new uint?((uint)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new uint?(Convert.ToUInt32(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0007D494 File Offset: 0x0007B694
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator ulong?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_1, true))
			{
				throw new ArgumentException(Class15.smethod_17(1788797189 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value2;
				return new ulong?((ulong)bigInteger);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new ulong?(Convert.ToUInt64(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0007D53C File Offset: 0x0007B73C
		public static explicit operator double(JToken value)
		{
			JValue jvalue;
			for (;;)
			{
				jvalue = JToken.smethod_0(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a == 0)
				{
					goto IL_0003;
				}
				IL_0018:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0061;
				case 3:
					goto IL_00AD;
				case 4:
					goto IL_00A4;
				case 5:
					goto IL_00BF;
				case 6:
					goto IL_00C8;
				case 7:
					goto IL_0070;
				case 8:
					goto IL_009B;
				}
				IL_0003:
				if (jvalue == null)
				{
					goto IL_0070;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					goto IL_0018;
				}
				break;
			}
			IL_0061:
			if (JToken.smethod_2(jvalue, JToken.jtokenType_1, false))
			{
				goto IL_009B;
			}
			IL_0070:
			throw new ArgumentException(Class15.smethod_17(2048589327 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_009B:
			object value2 = jvalue.Value;
			IL_00A4:
			if (value2 is BigInteger)
			{
				goto IL_00BF;
			}
			IL_00AD:
			return Convert.ToDouble(jvalue.Value, CultureInfo.InvariantCulture);
			IL_00BF:
			BigInteger bigInteger = (BigInteger)value2;
			IL_00C8:
			return (double)bigInteger;
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0007D61C File Offset: 0x0007B81C
		public static explicit operator float(JToken value)
		{
			JValue jvalue;
			object value2;
			for (;;)
			{
				IL_008F:
				jvalue = JToken.smethod_0(value);
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
						goto IL_0018;
					case 2:
						goto IL_008F;
					case 3:
						value2 = jvalue.Value;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
						{
							continue;
						}
						goto IL_00AB;
					case 4:
						goto IL_001C;
					case 5:
						goto IL_00BA;
					case 6:
						goto IL_00C3;
					case 7:
						goto IL_00B1;
					case 8:
						goto IL_00F7;
					}
					goto Block_3;
					IL_001C:
					if (!JToken.smethod_2(jvalue, JToken.jtokenType_1, false))
					{
						goto IL_00CC;
					}
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
					{
						continue;
					}
					IL_0018:
					if (jvalue != null)
					{
						goto IL_001C;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
					{
						goto Block_2;
					}
				}
			}
			Block_2:
			Block_3:
			goto IL_00CC;
			IL_00AB:
			IL_00B1:
			if (!(value2 is BigInteger))
			{
				goto IL_00F7;
			}
			IL_00BA:
			BigInteger bigInteger = (BigInteger)value2;
			IL_00C3:
			return (float)bigInteger;
			IL_00CC:
			throw new ArgumentException(Class15.smethod_17(197534949 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00F7:
			return Convert.ToSingle(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x0007D734 File Offset: 0x0007B934
		[NullableContext(2)]
		public static explicit operator string(JToken value)
		{
			IL_00CF:
			while (value != null)
			{
				JValue jvalue = JToken.smethod_0(value);
				while (jvalue != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto IL_0025;
					}
					IL_008D:
					switch (num)
					{
					case 0:
						goto IL_00D9;
					case 1:
						goto IL_0063;
					case 2:
						break;
					case 3:
						goto IL_010D;
					case 4:
						goto IL_00F6;
					case 5:
						continue;
					case 6:
						goto IL_0073;
					case 7:
						IL_0025:
						if (!JToken.smethod_2(jvalue, JToken.jtokenType_3, true))
						{
							goto IL_010D;
						}
						break;
					case 8:
						goto IL_00FE;
					case 9:
						goto IL_010B;
					case 10:
						goto IL_0138;
					case 11:
						goto IL_00CF;
					default:
						goto IL_00D9;
					}
					if (jvalue.Value == null)
					{
						goto IL_010B;
					}
					byte[] array = jvalue.Value as byte[];
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_0063;
					}
					goto IL_008D;
					IL_0073:
					object value2;
					if (!(value2 is BigInteger))
					{
						return Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture);
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						goto IL_008D;
					}
					goto IL_00D9;
					IL_0063:
					if (array == null)
					{
						value2 = jvalue.Value;
						goto IL_0073;
					}
					goto IL_00F6;
					IL_00D9:
					BigInteger bigInteger = (BigInteger)value2;
					goto IL_00FE;
					IL_00F6:
					return Convert.ToBase64String(array);
					IL_00FE:
					return bigInteger.ToString(CultureInfo.InvariantCulture);
					IL_010B:
					return null;
				}
				IL_010D:
				throw new ArgumentException(Class15.smethod_17(2057034675 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
				IL_0138:
				return null;
			}
			goto IL_0138;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0007D87C File Offset: 0x0007BA7C
		[CLSCompliant(false)]
		public static explicit operator uint(JToken value)
		{
			JValue jvalue;
			BigInteger bigInteger;
			for (;;)
			{
				jvalue = JToken.smethod_0(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
				{
					goto IL_003B;
				}
				IL_0077:
				switch (num)
				{
				case 1:
					goto IL_0054;
				case 2:
					IL_003B:
					if (jvalue == null)
					{
						goto IL_00CB;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
					{
						goto IL_0054;
					}
					goto IL_0077;
				case 3:
					continue;
				case 4:
					goto IL_001B;
				case 5:
					goto IL_000F;
				case 6:
					goto IL_0006;
				case 7:
					goto IL_00CB;
				case 8:
					goto IL_00F6;
				}
				break;
				IL_001B:
				object value2;
				bigInteger = (BigInteger)value2;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					break;
				}
				goto IL_0077;
				IL_000F:
				if (value2 is BigInteger)
				{
					goto IL_001B;
				}
				goto IL_00F6;
				IL_0006:
				value2 = jvalue.Value;
				goto IL_000F;
				IL_0054:
				if (!JToken.smethod_2(jvalue, JToken.jtokenType_1, false))
				{
					goto IL_00CB;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
				{
					goto IL_0006;
				}
				goto IL_0077;
			}
			return (uint)bigInteger;
			IL_00CB:
			throw new ArgumentException(Class15.smethod_17(2128279420 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00F6:
			return Convert.ToUInt32(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0007D990 File Offset: 0x0007BB90
		[CLSCompliant(false)]
		public static explicit operator ulong(JToken value)
		{
			JValue jvalue;
			BigInteger bigInteger;
			for (;;)
			{
				IL_00B3:
				jvalue = JToken.smethod_0(value);
				IL_00A9:
				while (jvalue != null)
				{
					int num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
					{
						goto IL_0064;
					}
					for (;;)
					{
						IL_0081:
						switch (num)
						{
						case 1:
							goto IL_00BE;
						case 2:
							goto IL_0026;
						case 3:
							goto IL_00A9;
						case 4:
							goto IL_00B3;
						case 5:
							goto IL_00C6;
						case 6:
							if (!JToken.smethod_2(jvalue, JToken.jtokenType_1, false))
							{
								goto IL_00C6;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
							{
								continue;
							}
							break;
						case 7:
							goto IL_001A;
						}
						break;
					}
					goto IL_0064;
					IL_0026:
					object value2;
					bigInteger = (BigInteger)value2;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
					{
						goto Block_2;
					}
					goto IL_0081;
					IL_001A:
					if (value2 is BigInteger)
					{
						goto IL_0026;
					}
					goto IL_00F1;
					IL_0064:
					value2 = jvalue.Value;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
					{
						goto IL_001A;
					}
					goto IL_0081;
				}
				goto IL_00C6;
			}
			Block_2:
			IL_00BE:
			return (ulong)bigInteger;
			IL_00C6:
			throw new ArgumentException(Class15.smethod_17(314825173 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_00F1:
			return Convert.ToUInt64(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0007DAA0 File Offset: 0x0007BCA0
		[NullableContext(2)]
		public static explicit operator byte[](JToken value)
		{
			IL_00FC:
			while (value != null)
			{
				JValue jvalue = JToken.smethod_0(value);
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
				{
					goto IL_0089;
				}
				object value2;
				for (;;)
				{
					IL_00C0:
					byte[] array;
					switch (num)
					{
					case 1:
						if (!(value2 is BigInteger))
						{
							array = jvalue.Value as byte[];
							goto IL_0025;
						}
						goto IL_0108;
					case 2:
						goto IL_0111;
					case 3:
						goto IL_0058;
					case 4:
						goto IL_0108;
					case 5:
						goto IL_0089;
					case 6:
						if (JToken.smethod_2(jvalue, JToken.jtokenType_9, false))
						{
							goto IL_0058;
						}
						break;
					case 7:
						return array;
					case 8:
						goto IL_0148;
					case 9:
						goto IL_0160;
					case 10:
						goto IL_0025;
					case 11:
						goto IL_018E;
					case 12:
						goto IL_00FC;
					}
					goto Block_9;
					IL_0025:
					if (array != null)
					{
						return array;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
					{
						break;
					}
					continue;
					IL_0058:
					if (jvalue.Value is string)
					{
						goto IL_0148;
					}
					value2 = jvalue.Value;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						goto Block_5;
					}
				}
				goto IL_0160;
				Block_5:
				Block_9:
				goto IL_011D;
				IL_0108:
				BigInteger bigInteger = (BigInteger)value2;
				IL_0111:
				return bigInteger.ToByteArray();
				IL_0148:
				return Convert.FromBase64String(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
				IL_0160:
				throw new ArgumentException(Class15.smethod_17(552162176 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
				IL_018E:
				return null;
				IL_0089:
				if (jvalue != null)
				{
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						goto IL_00C0;
					}
				}
				IL_011D:
				throw new ArgumentException(Class15.smethod_17(543272808 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			goto IL_018E;
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0007DC3C File Offset: 0x0007BE3C
		public static explicit operator Guid(JToken value)
		{
			JValue jvalue;
			byte[] array;
			for (;;)
			{
				IL_00F8:
				jvalue = JToken.smethod_0(value);
				IL_00F1:
				while (jvalue != null)
				{
					IL_00DC:
					while (JToken.smethod_2(jvalue, JToken.jtokenType_4, false))
					{
						int num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
						{
							goto IL_0084;
						}
						Guid guid;
						for (;;)
						{
							IL_00A1:
							switch (num)
							{
							case 1:
								goto IL_014B;
							case 2:
								goto IL_0084;
							case 3:
								return guid;
							case 4:
							case 5:
								goto IL_0120;
							case 6:
								goto IL_0078;
							case 7:
								goto IL_0105;
							case 8:
								goto IL_00DC;
							case 9:
								array = jvalue.Value as byte[];
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
								{
									continue;
								}
								break;
							case 10:
								goto IL_00F1;
							case 11:
								goto IL_00F8;
							}
							goto Block_6;
						}
						IL_0078:
						object value2;
						if (value2 is Guid)
						{
							goto IL_0084;
						}
						goto IL_0105;
						Block_6:
						IL_003D:
						if (array != null)
						{
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
							{
								goto Block_3;
							}
							goto IL_00A1;
						}
						else
						{
							value2 = jvalue.Value;
							num = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
							{
								break;
							}
							goto IL_00A1;
						}
						IL_0084:
						guid = (Guid)value2;
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
						{
							goto IL_003D;
						}
						goto IL_00A1;
					}
					break;
				}
				goto Block_8;
			}
			Block_3:
			goto IL_014B;
			Block_8:
			goto IL_0120;
			IL_0105:
			return new Guid(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
			IL_0120:
			throw new ArgumentException(Class15.smethod_17(1743156178 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_014B:
			return new Guid(array);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0007DD9C File Offset: 0x0007BF9C
		[NullableContext(2)]
		public static explicit operator Guid?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_4, true))
			{
				throw new ArgumentException(Class15.smethod_17(1571003863 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			byte[] array = jvalue.Value as byte[];
			if (array != null)
			{
				return new Guid?(new Guid(array));
			}
			object value2 = jvalue.Value;
			Guid guid2;
			if (value2 is Guid)
			{
				Guid guid = (Guid)value2;
				guid2 = guid;
			}
			else
			{
				guid2 = new Guid(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
			}
			return new Guid?(guid2);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0007DE60 File Offset: 0x0007C060
		public static explicit operator TimeSpan(JToken value)
		{
			JValue jvalue;
			TimeSpan timeSpan;
			for (;;)
			{
				jvalue = JToken.smethod_0(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
				{
					goto IL_0046;
				}
				IL_0090:
				switch (num)
				{
				case 1:
				case 7:
					goto IL_0107;
				case 2:
					goto IL_0026;
				case 3:
					goto IL_004D;
				case 4:
					goto IL_00DC;
				case 5:
					IL_0046:
					if (jvalue != null)
					{
						goto IL_004D;
					}
					goto IL_00DC;
				case 6:
					continue;
				case 8:
					goto IL_0006;
				}
				break;
				IL_0006:
				object value2;
				if (!(value2 is TimeSpan))
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
					{
						break;
					}
					goto IL_0090;
				}
				IL_0026:
				timeSpan = (TimeSpan)value2;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					break;
				}
				goto IL_0090;
				IL_004D:
				if (!JToken.smethod_2(jvalue, JToken.jtokenType_5, false))
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						goto Block_5;
					}
					goto IL_0090;
				}
				else
				{
					value2 = jvalue.Value;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
					{
						goto IL_0006;
					}
					goto IL_0090;
				}
			}
			return timeSpan;
			Block_5:
			IL_00DC:
			throw new ArgumentException(Class15.smethod_17(432104147 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			IL_0107:
			return ConvertUtils.ParseTimeSpan(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0007DF94 File Offset: 0x0007C194
		[NullableContext(2)]
		public static explicit operator TimeSpan?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.smethod_0(value);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_5, true))
			{
				throw new ArgumentException(Class15.smethod_17(1743156110 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			object value2 = jvalue.Value;
			TimeSpan timeSpan2;
			if (value2 is TimeSpan)
			{
				TimeSpan timeSpan = (TimeSpan)value2;
				timeSpan2 = timeSpan;
			}
			else
			{
				timeSpan2 = ConvertUtils.ParseTimeSpan(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
			}
			return new TimeSpan?(timeSpan2);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0007E038 File Offset: 0x0007C238
		[NullableContext(2)]
		public static explicit operator Uri(JToken value)
		{
			while (value != null)
			{
				JValue jvalue = JToken.smethod_0(value);
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_00AA;
				}
				IL_00C2:
				switch (num)
				{
				case 0:
					goto IL_006C;
				case 1:
				case 2:
					goto IL_0118;
				case 3:
					goto IL_0149;
				case 4:
					goto IL_00FB;
				case 5:
					continue;
				case 6:
					goto IL_008C;
				case 7:
					IL_00AA:
					if (jvalue == null)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
						{
							goto IL_00C2;
						}
						goto IL_0118;
					}
					break;
				case 8:
					return new Uri(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
				case 9:
					break;
				default:
					goto IL_006C;
				}
				if (!JToken.smethod_2(jvalue, JToken.jtokenType_6, true))
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_0118;
					}
					goto IL_00C2;
				}
				else
				{
					if (jvalue.Value == null)
					{
						goto IL_0149;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
					{
						goto IL_00C2;
					}
				}
				IL_006C:
				Uri uri = jvalue.Value as Uri;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
				{
					goto IL_00C2;
				}
				IL_008C:
				if (uri != null)
				{
					return uri;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
				{
					goto IL_0149;
				}
				goto IL_00C2;
				IL_0118:
				throw new ArgumentException(Class15.smethod_17(543272496 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(value)));
				IL_0149:
				return null;
			}
			IL_00FB:
			return null;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0007E190 File Offset: 0x0007C390
		private static BigInteger smethod_3(JToken jtoken_2)
		{
			JValue jvalue;
			for (;;)
			{
				IL_0054:
				jvalue = JToken.smethod_0(jtoken_2);
				while (jvalue != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
					{
						goto IL_0015;
					}
					IL_0035:
					switch (num)
					{
					case 1:
						IL_0015:
						if (JToken.smethod_2(jvalue, JToken.jtokenType_2, false))
						{
							goto IL_008A;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
						{
							goto IL_0035;
						}
						break;
					case 2:
						continue;
					case 3:
						goto IL_0054;
					}
					break;
				}
				break;
			}
			throw new ArgumentException(Class15.smethod_17(1387518956 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(jtoken_2)));
			IL_008A:
			return ConvertUtils.ToBigInteger(jvalue.Value);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0007E234 File Offset: 0x0007C434
		private static BigInteger? smethod_4(JToken jtoken_2)
		{
			JValue jvalue = JToken.smethod_0(jtoken_2);
			if (jvalue == null || !JToken.smethod_2(jvalue, JToken.jtokenType_2, true))
			{
				throw new ArgumentException(Class15.smethod_17(1793901482 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a).FormatWith(CultureInfo.InvariantCulture, JToken.smethod_1(jtoken_2)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new BigInteger?(ConvertUtils.ToBigInteger(jvalue.Value));
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x000063A0 File Offset: 0x000045A0
		public static implicit operator JToken(bool value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x000063A8 File Offset: 0x000045A8
		public static implicit operator JToken(DateTimeOffset value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000063B0 File Offset: 0x000045B0
		public static implicit operator JToken(byte value)
		{
			return new JValue((long)((ulong)value));
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x000063B9 File Offset: 0x000045B9
		public static implicit operator JToken(byte? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x000063C6 File Offset: 0x000045C6
		[CLSCompliant(false)]
		public static implicit operator JToken(sbyte value)
		{
			return new JValue((long)value);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000063CF File Offset: 0x000045CF
		[CLSCompliant(false)]
		public static implicit operator JToken(sbyte? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x000063DC File Offset: 0x000045DC
		public static implicit operator JToken(bool? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x000063E9 File Offset: 0x000045E9
		public static implicit operator JToken(long value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000063F1 File Offset: 0x000045F1
		public static implicit operator JToken(DateTime? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000063FE File Offset: 0x000045FE
		public static implicit operator JToken(DateTimeOffset? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0000640B File Offset: 0x0000460B
		public static implicit operator JToken(decimal? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00006418 File Offset: 0x00004618
		public static implicit operator JToken(double? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x000063C6 File Offset: 0x000045C6
		[CLSCompliant(false)]
		public static implicit operator JToken(short value)
		{
			return new JValue((long)value);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x000063B0 File Offset: 0x000045B0
		[CLSCompliant(false)]
		public static implicit operator JToken(ushort value)
		{
			return new JValue((long)((ulong)value));
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x000063C6 File Offset: 0x000045C6
		public static implicit operator JToken(int value)
		{
			return new JValue((long)value);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00006425 File Offset: 0x00004625
		public static implicit operator JToken(int? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00006432 File Offset: 0x00004632
		public static implicit operator JToken(DateTime value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0000643A File Offset: 0x0000463A
		public static implicit operator JToken(long? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00006447 File Offset: 0x00004647
		public static implicit operator JToken(float? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00006454 File Offset: 0x00004654
		public static implicit operator JToken(decimal value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0000645C File Offset: 0x0000465C
		[CLSCompliant(false)]
		public static implicit operator JToken(short? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00006469 File Offset: 0x00004669
		[CLSCompliant(false)]
		public static implicit operator JToken(ushort? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00006476 File Offset: 0x00004676
		[CLSCompliant(false)]
		public static implicit operator JToken(uint? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00006483 File Offset: 0x00004683
		[CLSCompliant(false)]
		public static implicit operator JToken(ulong? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00006490 File Offset: 0x00004690
		public static implicit operator JToken(double value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00006498 File Offset: 0x00004698
		public static implicit operator JToken(float value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x000064A0 File Offset: 0x000046A0
		public static implicit operator JToken([Nullable(2)] string value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000063B0 File Offset: 0x000045B0
		[CLSCompliant(false)]
		public static implicit operator JToken(uint value)
		{
			return new JValue((long)((ulong)value));
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x000064A8 File Offset: 0x000046A8
		[CLSCompliant(false)]
		public static implicit operator JToken(ulong value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000064B0 File Offset: 0x000046B0
		public static implicit operator JToken(byte[] value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x000064B8 File Offset: 0x000046B8
		public static implicit operator JToken([Nullable(2)] Uri value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000064C0 File Offset: 0x000046C0
		public static implicit operator JToken(TimeSpan value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000064C8 File Offset: 0x000046C8
		public static implicit operator JToken(TimeSpan? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000064D5 File Offset: 0x000046D5
		public static implicit operator JToken(Guid value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x000064DD File Offset: 0x000046DD
		public static implicit operator JToken(Guid? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000064EA File Offset: 0x000046EA
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<JToken>)this).GetEnumerator();
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00073C38 File Offset: 0x00071E38
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
		{
			return this.Children().GetEnumerator();
		}

		// Token: 0x06000FCB RID: 4043
		internal abstract int GetDeepHashCode();

		// Token: 0x1700024E RID: 590
		IJEnumerable<JToken> IJEnumerable<JToken>.this[object key]
		{
			get
			{
				return this[key];
			}
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000064FB File Offset: 0x000046FB
		public JsonReader CreateReader()
		{
			return new JTokenReader(this);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0007E2A8 File Offset: 0x0007C4A8
		internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer)
		{
			JToken token;
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(o, Class15.smethod_17(2128274700 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9));
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
				{
					goto IL_0003;
				}
				IL_002F:
				switch (num)
				{
				case 1:
					IL_0003:
					ValidationUtils.ArgumentNotNull(jsonSerializer, Class15.smethod_17(1270971218 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
					{
						goto IL_002F;
					}
					break;
				case 2:
					continue;
				case 3:
					goto IL_0082;
				case 4:
					return token;
				}
				break;
			}
			JTokenWriter jtokenWriter = new JTokenWriter();
			IL_0082:
			try
			{
				jsonSerializer.Serialize(jtokenWriter, o);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					goto IL_00B8;
				}
				IL_009E:
				token = jtokenWriter.Token;
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
				{
					goto IL_00C9;
				}
				IL_00B8:
				switch (num2)
				{
				case 1:
					goto IL_009E;
				}
				IL_00C9:;
			}
			finally
			{
				if (jtokenWriter == null)
				{
					int num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
					{
						goto IL_00FB;
					}
					switch (num3)
					{
					case 1:
					case 2:
						goto IL_00FB;
					}
				}
				((IDisposable)jtokenWriter).Dispose();
				IL_00FB:;
			}
			return token;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00006503 File Offset: 0x00004703
		public static JToken FromObject(object o)
		{
			return JToken.FromObjectInternal(o, JsonSerializer.CreateDefault());
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00006510 File Offset: 0x00004710
		public static JToken FromObject(object o, JsonSerializer jsonSerializer)
		{
			return JToken.FromObjectInternal(o, jsonSerializer);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00006519 File Offset: 0x00004719
		[NullableContext(2)]
		public T ToObject<T>()
		{
			return (T)((object)this.ToObject(typeof(T)));
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0007E3C4 File Offset: 0x0007C5C4
		[return: Nullable(2)]
		public object ToObject(Type objectType)
		{
			PrimitiveTypeCode typeCode;
			for (;;)
			{
				if (JsonConvert.DefaultSettings == null)
				{
					goto IL_0090;
				}
				int num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
				{
					goto IL_0090;
				}
				IL_0037:
				bool flag;
				switch (num)
				{
				case 1:
					goto IL_0263;
				case 2:
					goto IL_0086;
				case 3:
					goto IL_00C0;
				case 4:
					goto IL_006B;
				case 5:
					goto IL_00D7;
				case 6:
					IL_0090:
					typeCode = ConvertUtils.GetTypeCode(objectType, out flag);
					goto IL_0086;
				case 7:
				case 9:
					goto IL_0232;
				case 8:
					goto IL_007A;
				case 10:
					continue;
				}
				IL_0018:
				if (objectType.IsEnum())
				{
					goto IL_00BD;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_0037;
				}
				goto IL_00BA;
				IL_006B:
				if (this.Type != JTokenType.Integer)
				{
					goto IL_0191;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					goto IL_0018;
				}
				goto IL_0037;
				IL_007A:
				if (this.Type == JTokenType.String)
				{
					break;
				}
				goto IL_006B;
				IL_0086:
				if (flag)
				{
					goto IL_007A;
				}
				goto IL_0191;
			}
			goto IL_00D7;
			IL_00BA:
			goto IL_00C0;
			IL_00BD:
			Type type = objectType;
			goto IL_00C6;
			IL_00C0:
			type = Nullable.GetUnderlyingType(objectType);
			IL_00C6:
			return Enum.ToObject(type, ((JValue)this).Value);
			IL_00D7:
			object obj;
			try
			{
				obj = this.ToObject(objectType, JsonSerializer.CreateDefault());
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
				{
					switch (num2)
					{
					}
				}
			}
			catch (Exception ex)
			{
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 != 0)
				{
					goto IL_013A;
				}
				goto IL_0145;
				IL_011E:
				Type type2 = Nullable.GetUnderlyingType(objectType);
				IL_0124:
				Type type3 = type2;
				num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_015A;
				}
				goto IL_0145;
				IL_013A:
				if (objectType.IsEnum())
				{
					type2 = objectType;
					goto IL_0124;
				}
				goto IL_011E;
				IL_0145:
				switch (num3)
				{
				case 0:
					goto IL_013A;
				case 1:
					IL_015A:
					throw new ArgumentException(Class15.smethod_17(124795678 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719).FormatWith(CultureInfo.InvariantCulture, (string)this, type3.Name), ex);
				case 2:
					goto IL_011E;
				default:
					goto IL_013A;
				}
			}
			return obj;
			IL_0191:
			switch (typeCode)
			{
			case PrimitiveTypeCode.Char:
				return (char)this;
			case PrimitiveTypeCode.CharNullable:
				return (char?)this;
			case PrimitiveTypeCode.Boolean:
				return (bool)this;
			case PrimitiveTypeCode.BooleanNullable:
				IL_0263:
				return (bool?)this;
			case PrimitiveTypeCode.SByte:
				return (sbyte)this;
			case PrimitiveTypeCode.SByteNullable:
				return (sbyte?)this;
			case PrimitiveTypeCode.Int16:
				return (short)this;
			case PrimitiveTypeCode.Int16Nullable:
				return (short?)this;
			case PrimitiveTypeCode.UInt16:
				return (ushort)this;
			case PrimitiveTypeCode.UInt16Nullable:
				return (ushort?)this;
			case PrimitiveTypeCode.Int32:
				return (int)this;
			case PrimitiveTypeCode.Int32Nullable:
				return (int?)this;
			case PrimitiveTypeCode.Byte:
				return (byte)this;
			case PrimitiveTypeCode.ByteNullable:
				return (byte?)this;
			case PrimitiveTypeCode.UInt32:
				return (uint)this;
			case PrimitiveTypeCode.UInt32Nullable:
				return (uint?)this;
			case PrimitiveTypeCode.Int64:
				return (long)this;
			case PrimitiveTypeCode.Int64Nullable:
				return (long?)this;
			case PrimitiveTypeCode.UInt64:
				return (ulong)this;
			case PrimitiveTypeCode.UInt64Nullable:
				return (ulong?)this;
			case PrimitiveTypeCode.Single:
				return (float)this;
			case PrimitiveTypeCode.SingleNullable:
				return (float?)this;
			case PrimitiveTypeCode.Double:
				return (double)this;
			case PrimitiveTypeCode.DoubleNullable:
				return (double?)this;
			case PrimitiveTypeCode.DateTime:
				return (DateTime)this;
			case PrimitiveTypeCode.DateTimeNullable:
				return (DateTime?)this;
			case PrimitiveTypeCode.DateTimeOffset:
				return (DateTimeOffset)this;
			case PrimitiveTypeCode.DateTimeOffsetNullable:
				return (DateTimeOffset?)this;
			case PrimitiveTypeCode.Decimal:
				return (decimal)this;
			case PrimitiveTypeCode.DecimalNullable:
				return (decimal?)this;
			case PrimitiveTypeCode.Guid:
				return (Guid)this;
			case PrimitiveTypeCode.GuidNullable:
				return (Guid?)this;
			case PrimitiveTypeCode.TimeSpan:
				return (TimeSpan)this;
			case PrimitiveTypeCode.TimeSpanNullable:
				return (TimeSpan?)this;
			case PrimitiveTypeCode.BigInteger:
				return JToken.smethod_3(this);
			case PrimitiveTypeCode.BigIntegerNullable:
				return JToken.smethod_4(this);
			case PrimitiveTypeCode.Uri:
				return (Uri)this;
			case PrimitiveTypeCode.String:
				return (string)this;
			default:
				IL_0232:
				return this.ToObject(objectType, JsonSerializer.CreateDefault());
			}
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00006530 File Offset: 0x00004730
		[NullableContext(2)]
		public T ToObject<T>([Nullable(1)] JsonSerializer jsonSerializer)
		{
			return (T)((object)this.ToObject(typeof(T), jsonSerializer));
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0007E7E0 File Offset: 0x0007C9E0
		[NullableContext(2)]
		public object ToObject(Type objectType, [Nullable(1)] JsonSerializer jsonSerializer)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(jsonSerializer, Class15.smethod_17(926397037 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
				{
					IL_0003:
					JTokenReader jtokenReader = new JTokenReader(this);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
					{
						goto IL_001C;
					}
					continue;
				}
				case 2:
					continue;
				case 3:
					goto IL_0067;
				}
				break;
			}
			object obj;
			return obj;
			IL_0067:
			try
			{
				JsonSerializerProxy jsonSerializerProxy = jsonSerializer as JsonSerializerProxy;
				int num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
				{
					goto IL_00E3;
				}
				goto IL_00EA;
				IL_0084:
				JTokenReader jtokenReader;
				CultureInfo cultureInfo;
				DateTimeZoneHandling? dateTimeZoneHandling;
				DateParseHandling? dateParseHandling;
				FloatParseHandling? floatParseHandling;
				int? num3;
				string text;
				jsonSerializerProxy._serializer.SetupReader(jtokenReader, out cultureInfo, out dateTimeZoneHandling, out dateParseHandling, out floatParseHandling, out num3, out text);
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto IL_00EA;
				}
				IL_00B0:
				obj = jsonSerializer.Deserialize(jtokenReader, objectType);
				num2 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					goto IL_00EA;
				}
				IL_00E3:
				if (jsonSerializerProxy == null)
				{
					goto IL_00B0;
				}
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0084;
				}
				IL_00EA:
				switch (num2)
				{
				case 0:
					goto IL_00B0;
				case 1:
					goto IL_00E3;
				case 2:
					break;
				case 3:
					goto IL_0084;
				default:
					goto IL_00B0;
				}
			}
			finally
			{
				JTokenReader jtokenReader;
				if (jtokenReader != null)
				{
					int num4 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
					{
						goto IL_0132;
					}
					IL_011A:
					((IDisposable)jtokenReader).Dispose();
					num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
					{
						goto IL_0143;
					}
					IL_0132:
					switch (num4)
					{
					case 1:
						goto IL_011A;
					}
				}
				IL_0143:;
			}
			return obj;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00006548 File Offset: 0x00004748
		public static JToken ReadFrom(JsonReader reader)
		{
			return JToken.ReadFrom(reader, null);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0007E944 File Offset: 0x0007CB44
		public static JToken ReadFrom(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(reader, Class15.smethod_17(698991538 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a));
				int num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					goto IL_0006;
				}
				IL_002B:
				switch (num)
				{
				case 1:
					goto IL_0182;
				case 2:
				case 14:
					goto IL_00D7;
				case 3:
					goto IL_01DA;
				case 4:
				case 10:
				case 15:
					goto IL_00FF;
				case 5:
					goto IL_00ED;
				case 6:
					goto IL_00C7;
				case 7:
					goto IL_00CF;
				case 8:
					goto IL_0011;
				case 9:
					goto IL_00EA;
				case 11:
				case 17:
				case 21:
					goto IL_0102;
				case 13:
					goto IL_012A;
				case 16:
					goto IL_00F5;
				case 18:
					goto IL_0106;
				case 19:
					IL_0006:
					if (reader.TokenType == JsonToken.None)
					{
						goto IL_0011;
					}
					break;
				case 20:
					continue;
				case 22:
					goto IL_0132;
				}
				break;
				IL_0011:
				if (settings != null)
				{
					goto IL_00C7;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
				{
					goto IL_002B;
				}
				goto IL_00C4;
			}
			goto IL_00E1;
			IL_00C4:
			goto IL_00D7;
			IL_00C7:
			if (settings.CommentHandling != CommentHandling.Ignore)
			{
				goto IL_00D7;
			}
			IL_00CF:
			bool flag = reader.ReadAndMoveToContent();
			goto IL_00DD;
			IL_00D7:
			flag = reader.Read();
			IL_00DD:
			bool flag2 = flag;
			goto IL_0102;
			IL_00E1:
			if (reader.TokenType != JsonToken.Comment)
			{
				goto IL_00FF;
			}
			IL_00EA:
			if (settings == null)
			{
				goto IL_00FF;
			}
			IL_00ED:
			if (settings.CommentHandling != CommentHandling.Ignore)
			{
				goto IL_00FF;
			}
			IL_00F5:
			flag2 = reader.ReadAndMoveToContent();
			goto IL_0102;
			IL_00FF:
			flag2 = true;
			IL_0102:
			if (flag2)
			{
				IJsonLineInfo jsonLineInfo = reader as IJsonLineInfo;
				goto IL_012A;
			}
			IL_0106:
			throw JsonReaderException.Create(reader, Class15.smethod_17(314825705 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
			IL_012A:
			JsonToken tokenType = reader.TokenType;
			IL_0132:
			switch (tokenType)
			{
			case JsonToken.StartObject:
				IL_0182:
				return JObject.Load(reader, settings);
			case JsonToken.StartArray:
				return JArray.Load(reader, settings);
			case JsonToken.StartConstructor:
				return JConstructor.Load(reader, settings);
			case JsonToken.PropertyName:
				return JProperty.Load(reader, settings);
			case JsonToken.Comment:
			{
				JValue jvalue = JValue.CreateComment(reader.Value.ToString());
				IJsonLineInfo jsonLineInfo;
				jvalue.SetLineInfo(jsonLineInfo, settings);
				return jvalue;
			}
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.String:
			case JsonToken.Boolean:
			case JsonToken.Date:
			case JsonToken.Bytes:
			{
				JValue jvalue2 = new JValue(reader.Value);
				IJsonLineInfo jsonLineInfo;
				jvalue2.SetLineInfo(jsonLineInfo, settings);
				return jvalue2;
			}
			case JsonToken.Null:
			{
				JValue jvalue3 = JValue.CreateNull();
				IJsonLineInfo jsonLineInfo;
				jvalue3.SetLineInfo(jsonLineInfo, settings);
				return jvalue3;
			}
			case JsonToken.Undefined:
			{
				JValue jvalue4 = JValue.CreateUndefined();
				IJsonLineInfo jsonLineInfo;
				jvalue4.SetLineInfo(jsonLineInfo, settings);
				return jvalue4;
			}
			}
			IL_01DA:
			throw JsonReaderException.Create(reader, Class15.smethod_17(642186432 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00006551 File Offset: 0x00004751
		public static JToken Parse(string json)
		{
			return JToken.Parse(json, null);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0007EB70 File Offset: 0x0007CD70
		public static JToken Parse(string json, [Nullable(2)] JsonLoadSettings settings)
		{
			for (;;)
			{
				JsonReader jsonReader = new JsonTextReader(new StringReader(json));
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0039;
					case 2:
						continue;
					}
					break;
				}
				break;
			}
			JToken jtoken;
			return jtoken;
			IL_0039:
			try
			{
				JsonReader jsonReader;
				JToken jtoken2 = JToken.ReadFrom(jsonReader, settings);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
				{
					goto IL_0077;
				}
				IL_0059:
				while (jsonReader.Read())
				{
				}
				IL_0062:
				jtoken = jtoken2;
				num2 = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
				{
					goto IL_0090;
				}
				IL_0077:
				switch (num2)
				{
				case 0:
				case 2:
					goto IL_0059;
				case 1:
					goto IL_0062;
				case 3:
					break;
				default:
					goto IL_0059;
				}
				IL_0090:;
			}
			finally
			{
				JsonReader jsonReader;
				if (jsonReader != null)
				{
					goto IL_00BE;
				}
				int num3 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					goto IL_00D7;
				}
				IL_00AA:
				switch (num3)
				{
				case 2:
					IL_00BE:
					((IDisposable)jsonReader).Dispose();
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						goto IL_00AA;
					}
					break;
				}
				IL_00D7:;
			}
			return jtoken;
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0000655A File Offset: 0x0000475A
		public static JToken Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			return JToken.ReadFrom(reader, settings);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00006548 File Offset: 0x00004748
		public static JToken Load(JsonReader reader)
		{
			return JToken.ReadFrom(reader, null);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0007EC68 File Offset: 0x0007CE68
		[NullableContext(2)]
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings)
		{
			for (;;)
			{
				IL_00A6:
				if (settings == null)
				{
					goto IL_0080;
				}
				goto IL_009A;
				int num;
				for (;;)
				{
					IL_005C:
					switch (num)
					{
					case 1:
						return;
					case 2:
						goto IL_0080;
					case 3:
						goto IL_00A6;
					case 4:
						return;
					case 5:
						if (!lineInfo.HasLineInfo())
						{
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
							{
								continue;
							}
						}
						else
						{
							this.SetLineInfo(lineInfo.LineNumber, lineInfo.LinePosition);
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
							{
								continue;
							}
						}
						break;
					case 6:
						goto IL_009A;
					}
					goto Block_4;
				}
				IL_0080:
				if (lineInfo == null)
				{
					return;
				}
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
				{
					break;
				}
				goto IL_005C;
				IL_009A:
				if (settings.LineInfoHandling == LineInfoHandling.Load)
				{
					goto IL_0080;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
				{
					break;
				}
				goto IL_005C;
			}
			Block_4:;
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0007ED30 File Offset: 0x0007CF30
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
			for (;;)
			{
				this.AddAnnotation(new JToken.Class10(lineNumber, linePosition));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00006563 File Offset: 0x00004763
		bool IJsonLineInfo.HasLineInfo()
		{
			return this.Annotation<JToken.Class10>() != null;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0007ED70 File Offset: 0x0007CF70
		int IJsonLineInfo.LineNumber
		{
			get
			{
				JToken.Class10 @class;
				for (;;)
				{
					@class = this.Annotation<JToken.Class10>();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
					{
						goto IL_0003;
					}
					IL_0018:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_004F;
					case 3:
						return 0;
					}
					IL_0003:
					if (@class != null)
					{
						goto IL_004F;
					}
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
					{
						goto IL_0018;
					}
					break;
				}
				return 0;
				IL_004F:
				return @class.int_0;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0007EDD8 File Offset: 0x0007CFD8
		int IJsonLineInfo.LinePosition
		{
			get
			{
				JToken.Class10 @class;
				for (;;)
				{
					@class = this.Annotation<JToken.Class10>();
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
					{
						goto IL_0003;
					}
					IL_0018:
					switch (num)
					{
					case 1:
						IL_0003:
						if (@class == null)
						{
							return 0;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
						{
							goto IL_0018;
						}
						break;
					case 2:
						continue;
					}
					break;
				}
				return @class.int_1;
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0000656E File Offset: 0x0000476E
		[return: Nullable(2)]
		public JToken SelectToken(string path)
		{
			return this.SelectToken(path, null);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0007EE38 File Offset: 0x0007D038
		[return: Nullable(2)]
		public JToken SelectToken(string path, bool errorWhenNoMatch)
		{
			JsonSelectSettings jsonSelectSettings;
			for (;;)
			{
				if (errorWhenNoMatch)
				{
					goto IL_002F;
				}
				goto IL_0003;
				IL_0004:
				object obj;
				jsonSelectSettings = obj;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					break;
				}
				switch (num)
				{
				case 1:
					goto IL_0044;
				case 2:
					goto IL_002F;
				case 3:
					continue;
				}
				IL_0003:
				obj = null;
				goto IL_0004;
				IL_002F:
				(obj = new JsonSelectSettings()).ErrorWhenNoMatch = true;
				goto IL_0004;
			}
			IL_0044:
			return this.SelectToken(path, jsonSelectSettings);
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0007EE94 File Offset: 0x0007D094
		[NullableContext(2)]
		public JToken SelectToken([Nullable(1)] string path, JsonSelectSettings settings)
		{
			JToken jtoken;
			IEnumerator<JToken> enumerator;
			for (;;)
			{
				JPath jpath = new JPath(path);
				jtoken = null;
				enumerator = jpath.Evaluate(this, this, settings).GetEnumerator();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return jtoken;
					}
					break;
				}
				break;
			}
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_0043;
					}
					int num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						break;
					}
					IL_0061:
					switch (num2)
					{
					case 1:
						goto IL_00B6;
					case 2:
						continue;
					}
					IL_0043:
					JToken jtoken2 = enumerator.Current;
					if (jtoken != null)
					{
						goto IL_009B;
					}
					jtoken = jtoken2;
					num2 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_0061;
					}
				}
				goto IL_00B6;
				IL_009B:
				throw new JsonException(Class15.smethod_17(926397763 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
				IL_00B6:;
			}
			finally
			{
				if (enumerator != null)
				{
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						goto IL_00E6;
					}
					IL_00CE:
					enumerator.Dispose();
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
					{
						goto IL_00F7;
					}
					IL_00E6:
					switch (num3)
					{
					case 0:
						goto IL_00CE;
					case 1:
						break;
					default:
						goto IL_00CE;
					}
				}
				IL_00F7:;
			}
			return jtoken;
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00006578 File Offset: 0x00004778
		public IEnumerable<JToken> SelectTokens(string path)
		{
			return this.SelectTokens(path, null);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0007EFAC File Offset: 0x0007D1AC
		public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch)
		{
			object obj;
			if (!errorWhenNoMatch)
			{
				obj = null;
			}
			else
			{
				(obj = new JsonSelectSettings()).ErrorWhenNoMatch = true;
			}
			JsonSelectSettings jsonSelectSettings = obj;
			return this.SelectTokens(path, jsonSelectSettings);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00006582 File Offset: 0x00004782
		public IEnumerable<JToken> SelectTokens(string path, [Nullable(2)] JsonSelectSettings settings)
		{
			return new JPath(path).Evaluate(this, this, settings);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00006592 File Offset: 0x00004792
		protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return new DynamicProxyMetaObject<JToken>(parameter, this, new DynamicProxy<JToken>());
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x000065A0 File Offset: 0x000047A0
		DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
		{
			return this.GetMetaObject(parameter);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x000065A9 File Offset: 0x000047A9
		object ICloneable.Clone()
		{
			return this.DeepClone();
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x000065B1 File Offset: 0x000047B1
		public JToken DeepClone()
		{
			return this.CloneToken(null);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x000065BA File Offset: 0x000047BA
		public JToken DeepClone(JsonCloneSettings settings)
		{
			return this.CloneToken(settings);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0007EFD4 File Offset: 0x0007D1D4
		public void AddAnnotation(object annotation)
		{
			IL_0156:
			while (annotation != null)
			{
				int num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
				{
					goto IL_002A;
				}
				object[] array;
				int num2;
				for (;;)
				{
					IL_0106:
					switch (num)
					{
					case 0:
						goto IL_00DC;
					case 1:
						goto IL_0160;
					case 2:
						goto IL_0072;
					case 3:
						return;
					case 4:
						goto IL_004A;
					case 5:
						return;
					case 6:
						goto IL_007A;
					case 7:
						goto IL_0181;
					case 8:
					case 9:
						goto IL_002A;
					case 10:
						return;
					case 11:
						goto IL_0052;
					case 12:
						goto IL_00C3;
					case 13:
						break;
					case 14:
						goto IL_0024;
					case 15:
						if (this.object_0 != null)
						{
							array = this.object_0 as object[];
							goto IL_00C3;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
						{
							goto Block_5;
						}
						continue;
					case 16:
						goto IL_0156;
					case 17:
						goto IL_001D;
					default:
						goto IL_00DC;
					}
					IL_00C7:
					num2 = 0;
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
					{
						goto IL_00DC;
					}
					continue;
					IL_00C3:
					if (array != null)
					{
						goto IL_00C7;
					}
					IL_00DC:
					this.object_0 = new object[] { this.object_0, annotation };
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
					{
						return;
					}
				}
				Block_5:
				IL_0160:
				object obj;
				if (!(annotation is object[]))
				{
					obj = annotation;
				}
				else
				{
					(obj = new object[1])[0] = annotation;
				}
				this.object_0 = obj;
				return;
				IL_001D:
				if (array[num2] != null)
				{
					goto IL_0024;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
				{
					goto IL_004A;
				}
				goto IL_0106;
				IL_002A:
				if (num2 < array.Length)
				{
					goto IL_001D;
				}
				goto IL_004A;
				IL_0052:
				Array.Resize<object>(ref array, num2 * 2);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
				{
					goto IL_0072;
				}
				goto IL_0106;
				IL_004A:
				if (num2 == array.Length)
				{
					goto IL_0052;
				}
				IL_007A:
				array[num2] = annotation;
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					return;
				}
				goto IL_0106;
				IL_0072:
				this.object_0 = array;
				goto IL_007A;
				IL_0024:
				num2++;
				goto IL_002A;
			}
			IL_0181:
			throw new ArgumentNullException(Class15.smethod_17(543271388 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89));
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0007F180 File Offset: 0x0007D380
		[return: Nullable(2)]
		public T Annotation<T>() where T : class
		{
			if (this.object_0 != null)
			{
				object[] array = this.object_0 as object[];
				if (array == null)
				{
					return this.object_0 as T;
				}
				foreach (object obj in array)
				{
					if (obj == null)
					{
						break;
					}
					T t = obj as T;
					if (t != null)
					{
						return t;
					}
				}
			}
			return default(T);
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0007F1F0 File Offset: 0x0007D3F0
		[return: Nullable(2)]
		public object Annotation(Type type)
		{
			object obj;
			for (;;)
			{
				int num;
				if (type == null)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
					{
						goto Block_9;
					}
				}
				else
				{
					if (this.object_0 != null)
					{
						goto IL_0028;
					}
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						break;
					}
				}
				IL_00AB:
				object[] array;
				switch (num)
				{
				case 0:
					goto IL_0062;
				case 1:
					goto IL_011F;
				case 2:
					continue;
				case 3:
				case 10:
					goto IL_0152;
				case 4:
					goto IL_006E;
				case 5:
					IL_0028:
					array = this.object_0 as object[];
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
					{
						goto IL_00AB;
					}
					break;
				case 6:
				case 13:
					goto IL_0067;
				case 7:
				case 9:
					goto IL_009A;
				case 8:
					return obj;
				case 11:
					goto IL_013D;
				case 12:
					goto IL_0087;
				case 14:
					goto IL_014B;
				case 15:
					break;
				default:
					goto IL_0062;
				}
				if (array == null)
				{
					goto IL_013D;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
				{
					goto IL_0062;
				}
				goto IL_00AB;
				IL_006E:
				if (obj == null)
				{
					goto IL_0152;
				}
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					goto IL_0087;
				}
				goto IL_00AB;
				IL_0067:
				int num2;
				obj = array[num2];
				goto IL_006E;
				IL_009A:
				if (num2 < array.Length)
				{
					goto IL_0067;
				}
				goto IL_0152;
				IL_0087:
				if (!type.IsInstanceOfType(obj))
				{
					num2++;
					goto IL_009A;
				}
				break;
				IL_0062:
				num2 = 0;
				goto IL_009A;
			}
			return obj;
			Block_9:
			IL_011F:
			throw new ArgumentNullException(Class15.smethod_17(642147798 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba));
			IL_013D:
			if (!type.IsInstanceOfType(this.object_0))
			{
				goto IL_0152;
			}
			IL_014B:
			return this.object_0;
			IL_0152:
			return null;
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x000065C3 File Offset: 0x000047C3
		public IEnumerable<T> Annotations<T>() where T : class
		{
			for (;;)
			{
				int num2;
				int num = num2;
				for (;;)
				{
					IL_0226:
					for (;;)
					{
						IL_0210:
						switch (num)
						{
						case 0:
							goto IL_00CF;
						case 1:
							goto IL_01F7;
						case 2:
							goto IL_0251;
						}
						goto Block_11;
						int num3;
						object obj;
						for (;;)
						{
							IL_0133:
							T t;
							switch (num3)
							{
							case 1:
								goto IL_0244;
							case 2:
								goto IL_004E;
							case 3:
								goto IL_024F;
							case 4:
								goto IL_0083;
							case 5:
								goto IL_023D;
							case 6:
								goto IL_0226;
							case 8:
								t = obj as T;
								goto IL_00FB;
							case 9:
							case 19:
								goto IL_01D8;
							case 10:
								goto IL_0258;
							case 11:
								goto IL_0107;
							case 12:
								goto IL_008F;
							case 13:
								goto IL_01EB;
							case 14:
								goto IL_023F;
							case 15:
								goto IL_0210;
							case 16:
								goto IL_01B2;
							case 17:
							case 21:
								goto IL_01BF;
							case 20:
								goto IL_00ED;
							case 22:
								goto IL_00FB;
							case 23:
								goto IL_00CF;
							case 24:
								goto IL_01D1;
							case 25:
								goto IL_00B1;
							case 26:
								goto IL_002C;
							case 27:
								goto IL_01F7;
							}
							goto Block_8;
							IL_00B1:
							num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
							{
								goto Block_5;
							}
							continue;
							IL_0107:
							yield return t;
							num3 = 25;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
							{
								goto IL_00B1;
							}
							continue;
							IL_00FB:
							if (t != null)
							{
								goto IL_0107;
							}
							goto IL_01F7;
						}
						IL_008F:
						T t2;
						yield return t2;
						num3 = 28;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
						{
							break;
						}
						goto IL_0133;
						IL_0083:
						if (t2 != null)
						{
							goto IL_008F;
						}
						goto IL_0244;
						IL_004E:
						object[] annotations;
						if (annotations == null)
						{
							t2 = this.object_0 as T;
							goto IL_0083;
						}
						num3 = 24;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
						{
							goto IL_01D1;
						}
						goto IL_0133;
						IL_002C:
						object obj2;
						annotations = obj2 as object[];
						num3 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
						{
							goto IL_004E;
						}
						goto IL_0133;
						IL_00ED:
						obj2 = this.object_0;
						goto IL_002C;
						IL_00CF:
						if (this.object_0 == null)
						{
							goto IL_023F;
						}
						num3 = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
						{
							goto IL_00ED;
						}
						goto IL_0133;
						IL_01B2:
						if (obj == null)
						{
							goto IL_024F;
						}
						num3 = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
						{
							goto Block_1;
						}
						goto IL_0133;
						IL_01BF:
						int i;
						obj = annotations[i];
						goto IL_01B2;
						IL_01D8:
						if (i < annotations.Length)
						{
							goto IL_01BF;
						}
						goto IL_024F;
						IL_01EB:
						int num4;
						i = num4 + 1;
						goto IL_01D8;
						IL_01F7:
						num4 = i;
						goto IL_01EB;
						IL_01D1:
						i = 0;
						goto IL_01D8;
					}
				}
				Block_5:
				Block_1:
				Block_8:;
			}
			Block_11:
			IL_023D:
			yield break;
			IL_023F:
			yield break;
			IL_0244:
			yield break;
			IL_024F:
			yield break;
			IL_0251:
			IL_0258:
			yield break;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x000065D3 File Offset: 0x000047D3
		public IEnumerable<object> Annotations(Type type)
		{
			JToken.<Annotations>d__180 <Annotations>d__ = new JToken.<Annotations>d__180(-2);
			<Annotations>d__.<>4__this = this;
			<Annotations>d__.<>3__type = type;
			return <Annotations>d__;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0007F350 File Offset: 0x0007D550
		public void RemoveAnnotations<T>() where T : class
		{
			if (this.object_0 != null)
			{
				object[] array = this.object_0 as object[];
				if (array == null)
				{
					if (this.object_0 is T)
					{
						this.object_0 = null;
						return;
					}
				}
				else
				{
					int i = 0;
					int j = 0;
					while (i < array.Length)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (!(obj is T))
						{
							array[j++] = obj;
						}
						i++;
					}
					if (j != 0)
					{
						while (j < i)
						{
							array[j++] = null;
						}
						return;
					}
					this.object_0 = null;
				}
			}
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0007F3CC File Offset: 0x0007D5CC
		public void RemoveAnnotations(Type type)
		{
			IL_019E:
			while (!(type == null))
			{
				IL_0193:
				while (this.object_0 != null)
				{
					object[] array;
					int num2;
					int num3;
					for (;;)
					{
						IL_016C:
						array = this.object_0 as object[];
						int num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
						{
							goto IL_00DA;
						}
						goto IL_00F5;
						IL_00C6:
						while (type.IsInstanceOfType(this.object_0))
						{
							num = 16;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
							{
								goto IL_00F5;
							}
						}
						return;
						for (;;)
						{
							IL_00F5:
							switch (num)
							{
							case 1:
							case 23:
								goto IL_0053;
							case 2:
							case 24:
								goto IL_01B7;
							case 3:
								goto IL_016C;
							case 4:
								goto IL_00F0;
							case 5:
								goto IL_0026;
							case 6:
								goto IL_00DA;
							case 7:
								goto IL_000D;
							case 8:
								return;
							case 9:
								return;
							case 10:
								goto IL_0193;
							case 11:
								goto IL_019E;
							case 12:
								goto IL_01CB;
							case 13:
							case 17:
								goto IL_01C2;
							case 14:
								goto IL_00C6;
							case 15:
								goto IL_009D;
							case 16:
								this.object_0 = null;
								num = 8;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
								{
									goto Block_6;
								}
								continue;
							case 18:
								goto IL_01AF;
							case 19:
							case 22:
								return;
							case 21:
								goto IL_0047;
							case 25:
								goto IL_0061;
							case 26:
								goto IL_0006;
							}
							break;
						}
						goto IL_0059;
						IL_000D:
						object obj;
						if (obj == null)
						{
							goto IL_0061;
						}
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
						{
							goto IL_0026;
						}
						goto IL_00F5;
						IL_0006:
						obj = array[num2];
						goto IL_000D;
						IL_0059:
						if (num2 >= array.Length)
						{
							goto IL_0061;
						}
						goto IL_0006;
						IL_0026:
						if (!type.IsInstanceOfType(obj))
						{
							goto IL_0047;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
						{
							goto IL_0059;
						}
						goto IL_00F5;
						IL_0061:
						if (num3 != 0)
						{
							goto IL_01C2;
						}
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
						{
							break;
						}
						goto IL_00F5;
						IL_009D:
						num3 = 0;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
						{
							goto IL_0059;
						}
						goto IL_00F5;
						IL_00F0:
						num2 = 0;
						goto IL_009D;
						IL_00DA:
						if (array == null)
						{
							goto IL_00C6;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
						{
							goto IL_00F0;
						}
						goto IL_00F5;
						IL_0053:
						num2++;
						goto IL_0059;
						IL_0047:
						array[num3++] = obj;
						goto IL_0053;
					}
					goto IL_01AF;
					Block_6:
					goto IL_01B7;
					IL_01AF:
					this.object_0 = null;
					return;
					IL_01B7:
					array[num3++] = null;
					IL_01C2:
					if (num3 < num2)
					{
						goto IL_01B7;
					}
					return;
				}
				return;
			}
			IL_01CB:
			throw new ArgumentNullException(Class15.smethod_17(197572857 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81));
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0007F5C0 File Offset: 0x0007D7C0
		internal void CopyAnnotations(JToken target, JToken source)
		{
			object[] array;
			for (;;)
			{
				array = source.object_0 as object[];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
				{
					goto IL_0003;
				}
				IL_0018:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_005C;
				case 3:
					return;
				case 4:
					return;
				case 5:
					goto IL_006A;
				}
				IL_0003:
				if (array != null)
				{
					goto IL_005C;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
				{
					goto IL_0018;
				}
				break;
			}
			goto IL_006A;
			IL_005C:
			target.object_0 = array.ToArray<object>();
			return;
			IL_006A:
			target.object_0 = source.object_0;
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0007F644 File Offset: 0x0007D844
		static JToken()
		{
			for (;;)
			{
				IL_0209:
				for (;;)
				{
					IL_0205:
					for (;;)
					{
						IL_01DE:
						JToken.jtokenType_0 = new JTokenType[]
						{
							JTokenType.Integer,
							JTokenType.Float,
							JTokenType.String,
							JTokenType.Comment,
							JTokenType.Raw,
							JTokenType.Boolean
						};
						for (;;)
						{
							IL_01A5:
							JToken.jtokenType_1 = new JTokenType[]
							{
								JTokenType.Integer,
								JTokenType.Float,
								JTokenType.String,
								JTokenType.Comment,
								JTokenType.Raw,
								JTokenType.Boolean
							};
							int num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
							{
								goto Block_6;
							}
							for (;;)
							{
								IL_0169:
								switch (num)
								{
								case 1:
									for (;;)
									{
										JToken.jtokenType_2 = new JTokenType[]
										{
											JTokenType.Integer,
											JTokenType.Float,
											JTokenType.String,
											JTokenType.Comment,
											JTokenType.Raw,
											JTokenType.Boolean,
											JTokenType.Bytes
										};
										num = 4;
										if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
										{
											goto IL_0169;
										}
									}
									break;
								case 2:
									return;
								case 3:
									goto IL_00F2;
								case 4:
									JToken.jtokenType_3 = new JTokenType[]
									{
										JTokenType.Date,
										JTokenType.Integer,
										JTokenType.Float,
										JTokenType.String,
										JTokenType.Comment,
										JTokenType.Raw,
										JTokenType.Boolean,
										JTokenType.Bytes,
										JTokenType.Guid,
										JTokenType.TimeSpan,
										JTokenType.Uri
									};
									goto IL_00F2;
								case 5:
									goto IL_01A5;
								case 6:
									goto IL_0205;
								case 7:
									goto IL_0209;
								case 8:
									goto IL_0023;
								case 9:
									goto IL_0043;
								case 10:
									goto IL_007A;
								case 11:
									goto IL_01DE;
								case 12:
									JToken.jtokenType_6 = new JTokenType[]
									{
										JTokenType.String,
										JTokenType.Comment,
										JTokenType.Raw,
										JTokenType.Uri
									};
									goto IL_0023;
								}
								goto Block_5;
								IL_0043:
								JToken.jtokenType_8 = new JTokenType[]
								{
									JTokenType.Date,
									JTokenType.String,
									JTokenType.Comment,
									JTokenType.Raw
								};
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
								{
									goto Block_1;
								}
								continue;
								IL_0023:
								JToken.jtokenType_7 = new JTokenType[]
								{
									JTokenType.Integer,
									JTokenType.Float,
									JTokenType.String,
									JTokenType.Comment,
									JTokenType.Raw
								};
								goto IL_0043;
								IL_007A:
								JToken.jtokenType_5 = new JTokenType[]
								{
									JTokenType.String,
									JTokenType.Comment,
									JTokenType.Raw,
									JTokenType.TimeSpan
								};
								num = 12;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
								{
									goto Block_2;
								}
								continue;
								IL_00F2:
								JToken.jtokenType_4 = new JTokenType[]
								{
									JTokenType.String,
									JTokenType.Comment,
									JTokenType.Raw,
									JTokenType.Guid,
									JTokenType.Bytes
								};
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
								{
									goto IL_007A;
								}
							}
						}
					}
				}
				Block_2:;
			}
			Block_1:
			Block_5:
			Block_6:
			JToken.jtokenType_9 = new JTokenType[]
			{
				JTokenType.Bytes,
				JTokenType.String,
				JTokenType.Comment,
				JTokenType.Raw,
				JTokenType.Integer
			};
		}

		// Token: 0x040006EA RID: 1770
		[Nullable(2)]
		private static JTokenEqualityComparer jtokenEqualityComparer_0;

		// Token: 0x040006EB RID: 1771
		[Nullable(2)]
		private JContainer jcontainer_0;

		// Token: 0x040006EC RID: 1772
		[Nullable(2)]
		private JToken jtoken_0;

		// Token: 0x040006ED RID: 1773
		[Nullable(2)]
		private JToken jtoken_1;

		// Token: 0x040006EE RID: 1774
		[Nullable(2)]
		private object[] object_0;

		// Token: 0x040006EF RID: 1775
		private static readonly JTokenType[] jtokenType_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly JTokenType[] jtokenType_1;

		// Token: 0x040006F1 RID: 1777
		private static readonly JTokenType[] jtokenType_2;

		// Token: 0x040006F2 RID: 1778
		private static readonly JTokenType[] jtokenType_3;

		// Token: 0x040006F3 RID: 1779
		private static readonly JTokenType[] jtokenType_4;

		// Token: 0x040006F4 RID: 1780
		private static readonly JTokenType[] jtokenType_5;

		// Token: 0x040006F5 RID: 1781
		private static readonly JTokenType[] jtokenType_6;

		// Token: 0x040006F6 RID: 1782
		private static readonly JTokenType[] jtokenType_7;

		// Token: 0x040006F7 RID: 1783
		private static readonly JTokenType[] jtokenType_8;

		// Token: 0x040006F8 RID: 1784
		private static readonly JTokenType[] jtokenType_9;

		// Token: 0x02000163 RID: 355
		[NullableContext(0)]
		private class Class10
		{
			// Token: 0x06000FF6 RID: 4086 RVA: 0x0007F884 File Offset: 0x0007DA84
			public Class10(int int_2, int int_3)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
				{
					goto IL_0032;
				}
				IL_001A:
				this.int_0 = int_2;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
				{
					goto IL_0047;
				}
				IL_0032:
				switch (num)
				{
				case 1:
					goto IL_001A;
				case 2:
					return;
				}
				IL_0047:
				this.int_1 = int_3;
			}

			// Token: 0x040006FA RID: 1786
			internal readonly int int_0;

			// Token: 0x040006FB RID: 1787
			internal readonly int int_1;
		}
	}
}
