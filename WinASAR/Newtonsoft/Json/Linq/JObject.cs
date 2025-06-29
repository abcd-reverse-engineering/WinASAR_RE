using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000153 RID: 339
	[Nullable(0)]
	[NullableContext(1)]
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00005F07 File Offset: 0x00004107
		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return this.jpropertyKeyedCollection_0;
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000E76 RID: 3702 RVA: 0x00077B84 File Offset: 0x00075D84
		// (remove) Token: 0x06000E77 RID: 3703 RVA: 0x00077C28 File Offset: 0x00075E28
		[Nullable(2)]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			[NullableContext(2)]
			add
			{
				for (;;)
				{
					IL_0089:
					PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
					for (;;)
					{
						IL_0083:
						PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						for (;;)
						{
							PropertyChangedEventHandler propertyChangedEventHandler3 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
							int num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
							{
								goto IL_0006;
							}
							IL_0040:
							switch (num)
							{
							case 1:
								IL_0006:
								propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, propertyChangedEventHandler3, propertyChangedEventHandler2);
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
								{
									goto IL_0040;
								}
								break;
							case 2:
								return;
							case 3:
								goto IL_0083;
							case 4:
								goto IL_0089;
							case 5:
								continue;
							}
							if (propertyChangedEventHandler != propertyChangedEventHandler2)
							{
								break;
							}
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
							{
								goto IL_0040;
							}
							return;
						}
					}
				}
			}
			[CompilerGenerated]
			[NullableContext(2)]
			remove
			{
				for (;;)
				{
					IL_0076:
					PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
					{
						goto IL_0028;
					}
					PropertyChangedEventHandler propertyChangedEventHandler2;
					PropertyChangedEventHandler propertyChangedEventHandler3;
					for (;;)
					{
						IL_0056:
						switch (num)
						{
						case 1:
							goto IL_0028;
						case 2:
							goto IL_0076;
						case 3:
							return;
						case 4:
							goto IL_002C;
						case 5:
							propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, propertyChangedEventHandler2, propertyChangedEventHandler3);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
							{
								continue;
							}
							break;
						}
						break;
					}
					goto IL_004D;
					IL_002C:
					propertyChangedEventHandler2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler3, value);
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
					{
						goto IL_004D;
					}
					goto IL_0056;
					IL_0028:
					propertyChangedEventHandler3 = propertyChangedEventHandler;
					goto IL_002C;
					IL_004D:
					if (propertyChangedEventHandler == propertyChangedEventHandler3)
					{
						break;
					}
					goto IL_0028;
				}
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000E78 RID: 3704 RVA: 0x00077CC8 File Offset: 0x00075EC8
		// (remove) Token: 0x06000E79 RID: 3705 RVA: 0x00077D6C File Offset: 0x00075F6C
		[Nullable(2)]
		public event PropertyChangingEventHandler PropertyChanging
		{
			[CompilerGenerated]
			[NullableContext(2)]
			add
			{
				for (;;)
				{
					IL_008C:
					PropertyChangingEventHandler propertyChangingEventHandler = this.propertyChangingEventHandler_0;
					for (;;)
					{
						PropertyChangingEventHandler propertyChangingEventHandler2 = propertyChangingEventHandler;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
						{
							goto IL_0031;
						}
						goto IL_0054;
						IL_0017:
						if (propertyChangingEventHandler != propertyChangingEventHandler2)
						{
							continue;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
						{
							return;
						}
						goto IL_0054;
						IL_0006:
						PropertyChangingEventHandler propertyChangingEventHandler3;
						propertyChangingEventHandler = Interlocked.CompareExchange<PropertyChangingEventHandler>(ref this.propertyChangingEventHandler_0, propertyChangingEventHandler3, propertyChangingEventHandler2);
						goto IL_0017;
						IL_0031:
						propertyChangingEventHandler3 = (PropertyChangingEventHandler)Delegate.Combine(propertyChangingEventHandler2, value);
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
						{
							goto IL_0006;
						}
						IL_0054:
						switch (num)
						{
						case 0:
							goto IL_0031;
						case 1:
							return;
						case 2:
							goto IL_0017;
						case 3:
							break;
						case 4:
							goto IL_008C;
						case 5:
							goto IL_0006;
						default:
							goto IL_0031;
						}
					}
				}
			}
			[CompilerGenerated]
			[NullableContext(2)]
			remove
			{
				for (;;)
				{
					PropertyChangingEventHandler propertyChangingEventHandler = this.propertyChangingEventHandler_0;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
					{
						goto IL_0003;
					}
					IL_0062:
					switch (num)
					{
					case 1:
						goto IL_003A;
					case 2:
						goto IL_0019;
					case 3:
						goto IL_004B;
					case 4:
						goto IL_0003;
					case 5:
						continue;
					}
					break;
					IL_0003:
					PropertyChangingEventHandler propertyChangingEventHandler2 = propertyChangingEventHandler;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
					{
						goto IL_0019;
					}
					goto IL_0062;
					IL_004B:
					if (propertyChangingEventHandler != propertyChangingEventHandler2)
					{
						goto IL_0003;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						goto IL_0062;
					}
					break;
					IL_003A:
					PropertyChangingEventHandler propertyChangingEventHandler3;
					propertyChangingEventHandler = Interlocked.CompareExchange<PropertyChangingEventHandler>(ref this.propertyChangingEventHandler_0, propertyChangingEventHandler3, propertyChangingEventHandler2);
					goto IL_004B;
					IL_0019:
					propertyChangingEventHandler3 = (PropertyChangingEventHandler)Delegate.Remove(propertyChangingEventHandler2, value);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
					{
						goto IL_003A;
					}
					goto IL_0062;
				}
			}
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00077E1C File Offset: 0x0007601C
		public JObject()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00077E5C File Offset: 0x0007605C
		public JObject(JObject other)
			: base(other, null)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00077E9C File Offset: 0x0007609C
		internal JObject(JObject other, [Nullable(2)] JsonCloneSettings settings)
			: base(other, settings)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00077EDC File Offset: 0x000760DC
		public JObject(params object[] content)
			: this(content)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00077F10 File Offset: 0x00076110
		public JObject(object content)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
			{
				goto IL_003D;
			}
			IL_0025:
			this.Add(content);
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
			{
				return;
			}
			IL_003D:
			switch (num)
			{
			case 0:
				goto IL_0025;
			case 1:
				break;
			default:
				goto IL_0025;
			}
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00077F6C File Offset: 0x0007616C
		internal override bool DeepEquals(JToken node)
		{
			JObject jobject;
			for (;;)
			{
				IL_002C:
				jobject = node as JObject;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (jobject != null)
						{
							goto IL_004B;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_002C;
					}
					return false;
				}
			}
			return false;
			IL_004B:
			return this.jpropertyKeyedCollection_0.Compare(jobject.jpropertyKeyedCollection_0);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00077FD8 File Offset: 0x000761D8
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item)
		{
			while (item != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
				{
					switch (num)
					{
					case 0:
						return -1;
					case 1:
						break;
					case 2:
						continue;
					default:
						return -1;
					}
				}
				return this.jpropertyKeyedCollection_0.IndexOfReference(item);
			}
			return -1;
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00078024 File Offset: 0x00076224
		[NullableContext(2)]
		internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			for (;;)
			{
				if (item != null)
				{
					goto IL_002C;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
				{
					goto Block_3;
				}
				IL_0014:
				switch (num)
				{
				case 1:
					goto IL_0058;
				case 2:
					continue;
				case 3:
					IL_002C:
					if (item.Type != JTokenType.Comment)
					{
						goto IL_0058;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
					{
						goto IL_0014;
					}
					break;
				}
				break;
			}
			return false;
			Block_3:
			IL_0058:
			return base.InsertItem(index, item, skipParentCheck, copyAnnotations);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00078094 File Offset: 0x00076294
		internal override void ValidateToken(JToken o, [Nullable(2)] JToken existing)
		{
			JProperty jproperty;
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(o, Class15.smethod_17(2057030211 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
				{
					goto IL_005A;
				}
				IL_0070:
				switch (num)
				{
				case 0:
					goto IL_005A;
				case 1:
					continue;
				case 2:
					goto IL_00FD;
				case 3:
					return;
				case 4:
					goto IL_0051;
				case 5:
					goto IL_0035;
				case 6:
					goto IL_00CB;
				case 7:
					break;
				case 8:
					goto IL_0114;
				default:
					goto IL_005A;
				}
				IL_0006:
				JProperty jproperty2;
				if (jproperty.Name == jproperty2.Name)
				{
					return;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
				{
					break;
				}
				goto IL_0070;
				IL_0035:
				jproperty2 = (JProperty)existing;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
				{
					goto IL_0006;
				}
				goto IL_0070;
				IL_0051:
				if (existing != null)
				{
					goto IL_0035;
				}
				break;
				IL_005A:
				if (o.Type != JTokenType.Property)
				{
					goto Block_5;
				}
				jproperty = (JProperty)o;
				goto IL_0051;
			}
			goto IL_00FD;
			Block_5:
			IL_00CB:
			throw new ArgumentException(Class15.smethod_17(1793905438 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a).FormatWith(CultureInfo.InvariantCulture, o.GetType(), base.GetType()));
			IL_00FD:
			if (!this.jpropertyKeyedCollection_0.TryGetValue(jproperty.Name, out existing))
			{
				return;
			}
			IL_0114:
			throw new ArgumentException(Class15.smethod_17(2071445970 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808).FormatWith(CultureInfo.InvariantCulture, jproperty.Name, base.GetType()));
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000781E8 File Offset: 0x000763E8
		internal override void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings)
		{
			JObject jobject;
			for (;;)
			{
				IL_0037:
				jobject = content as JObject;
				while (jobject == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
					{
						switch (num)
						{
						case 1:
							return;
						case 2:
							continue;
						case 3:
							goto IL_0037;
						case 4:
							goto IL_004C;
						}
						return;
					}
					return;
				}
				goto IL_0043;
			}
			return;
			IL_0043:
			IEnumerator<KeyValuePair<string, JToken>> enumerator = jobject.GetEnumerator();
			IL_004C:
			try
			{
				for (;;)
				{
					IL_01FF:
					if (enumerator.MoveNext())
					{
						goto IL_01A2;
					}
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						break;
					}
					KeyValuePair<string, JToken> keyValuePair;
					JProperty jproperty;
					for (;;)
					{
						IL_0145:
						switch (num2)
						{
						case 1:
						case 2:
							if (keyValuePair.Value != null)
							{
								goto IL_008F;
							}
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
							{
								continue;
							}
							goto IL_01BF;
						case 3:
							goto IL_01D2;
						case 4:
							goto IL_00CE;
						case 5:
							goto IL_0108;
						case 6:
							goto IL_00B2;
						case 7:
						case 14:
							goto IL_00F1;
						case 8:
						case 9:
						case 12:
						case 17:
						case 20:
							goto IL_01FF;
						case 10:
							goto IL_01A2;
						case 11:
							goto IL_0102;
						case 13:
							goto IL_00B6;
						case 15:
							goto IL_006E;
						case 16:
							goto IL_01C2;
						case 18:
							goto IL_008F;
						case 19:
							jproperty = this.Property(keyValuePair.Key, (settings == null) ? StringComparison.Ordinal : settings.PropertyNameComparison);
							goto IL_006E;
						}
						goto Block_14;
						JContainer jcontainer;
						for (;;)
						{
							IL_00CE:
							jcontainer.Merge(keyValuePair.Value, settings);
							num2 = 12;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
							{
								goto IL_0145;
							}
						}
						IL_006E:
						if (jproperty == null)
						{
							goto IL_01D2;
						}
						num2 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
						{
							goto Block_8;
						}
						continue;
						IL_008F:
						jcontainer = jproperty.Value as JContainer;
						num2 = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
						{
							goto IL_00B2;
						}
						continue;
						IL_00B6:
						if (jcontainer.Type != keyValuePair.Value.Type)
						{
							goto IL_00F1;
						}
						goto IL_00CE;
						IL_00B2:
						if (jcontainer != null)
						{
							goto IL_00B6;
						}
						goto IL_00F1;
						IL_0108:
						if (settings.MergeNullValueHandling != MergeNullValueHandling.Merge)
						{
							break;
						}
						num2 = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
						{
							goto Block_12;
						}
						continue;
						IL_0102:
						if (settings != null)
						{
							goto IL_0108;
						}
						break;
						IL_00F1:
						if (JObject.smethod_6(keyValuePair.Value))
						{
							goto IL_0102;
						}
						goto IL_01C2;
					}
					IL_01BF:
					continue;
					IL_01C2:
					jproperty.Value = keyValuePair.Value;
					continue;
					Block_12:
					goto IL_01A2;
					IL_01D2:
					this.Add(keyValuePair.Key, keyValuePair.Value);
					continue;
					IL_01A2:
					keyValuePair = enumerator.Current;
					num2 = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
					{
						goto IL_01D2;
					}
					goto IL_0145;
				}
				Block_8:
				Block_14:;
			}
			finally
			{
				if (enumerator != null)
				{
					int num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
					{
						for (;;)
						{
							switch (num3)
							{
							case 1:
								enumerator.Dispose();
								num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
								{
									continue;
								}
								break;
							}
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00078464 File Offset: 0x00076664
		private static bool smethod_6(JToken jtoken_2)
		{
			JValue jvalue;
			for (;;)
			{
				int num;
				if (jtoken_2.Type == JTokenType.Null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f != 0)
					{
						break;
					}
				}
				else
				{
					jvalue = jtoken_2 as JValue;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
					{
						goto IL_001D;
					}
				}
				IL_0032:
				switch (num)
				{
				case 1:
					return true;
				case 2:
					continue;
				case 3:
				case 4:
					return false;
				case 5:
					return true;
				case 6:
					goto IL_007F;
				}
				IL_001D:
				if (jvalue != null)
				{
					goto IL_007F;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto IL_0032;
				}
				goto IL_007A;
			}
			return true;
			IL_007A:
			return false;
			IL_007F:
			if (jvalue.Value == null)
			{
				return true;
			}
			return false;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x000784FC File Offset: 0x000766FC
		internal void InternalPropertyChanged(JProperty childProperty)
		{
			for (;;)
			{
				this.OnPropertyChanged(childProperty.Name);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
				{
					goto IL_005F;
				}
				goto IL_006A;
				IL_0006:
				this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, childProperty, childProperty, this.IndexOfItem(childProperty)));
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					continue;
				}
				goto IL_006A;
				IL_0054:
				if (this._collectionChanged == null)
				{
					break;
				}
				goto IL_0006;
				IL_002F:
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, this.IndexOfItem(childProperty)));
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
				{
					goto IL_0054;
				}
				IL_006A:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0054;
				case 3:
				case 6:
					return;
				case 4:
					goto IL_002F;
				case 5:
					goto IL_0006;
				}
				IL_005F:
				if (this._listChanged != null)
				{
					goto IL_002F;
				}
				goto IL_0054;
			}
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x000785B8 File Offset: 0x000767B8
		internal void InternalPropertyChanging(JProperty childProperty)
		{
			for (;;)
			{
				this.OnPropertyChanging(childProperty.Name);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
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

		// Token: 0x06000E87 RID: 3719 RVA: 0x00005F0F File Offset: 0x0000410F
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings)
		{
			return new JObject(this, settings);
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00002C18 File Offset: 0x00000E18
		public override JTokenType Type
		{
			get
			{
				return JTokenType.Object;
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00005F18 File Offset: 0x00004118
		public IEnumerable<JProperty> Properties()
		{
			return this.jpropertyKeyedCollection_0.Cast<JProperty>();
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00005F25 File Offset: 0x00004125
		[return: Nullable(2)]
		public JProperty Property(string name)
		{
			return this.Property(name, StringComparison.Ordinal);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x000785F4 File Offset: 0x000767F4
		[return: Nullable(2)]
		public JProperty Property(string name, StringComparison comparison)
		{
			IL_00C9:
			while (name != null)
			{
				IL_00B6:
				JToken jtoken;
				while (!this.jpropertyKeyedCollection_0.TryGetValue(name, out jtoken))
				{
					while (comparison != StringComparison.Ordinal)
					{
						int num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
						{
							goto IL_006A;
						}
						goto IL_006F;
						IL_0047:
						int num2;
						if (num2 < this.jpropertyKeyedCollection_0.Count)
						{
							goto IL_001A;
						}
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
						{
							continue;
						}
						goto IL_006F;
						IL_0041:
						num2++;
						goto IL_0047;
						IL_002E:
						JProperty jproperty;
						if (!string.Equals(jproperty.Name, name, comparison))
						{
							goto IL_0041;
						}
						return jproperty;
						IL_001A:
						jproperty = (JProperty)this.jpropertyKeyedCollection_0[num2];
						goto IL_002E;
						IL_006F:
						switch (num)
						{
						case 1:
							goto IL_00DC;
						case 2:
							goto IL_0041;
						case 3:
							continue;
						case 4:
							goto IL_00DA;
						case 5:
							goto IL_00B6;
						case 6:
							goto IL_00C9;
						case 7:
						case 12:
							goto IL_0047;
						case 8:
							goto IL_002E;
						case 9:
							goto IL_001A;
						case 10:
							IL_006A:
							num2 = 0;
							goto IL_0047;
						case 11:
							goto IL_00CF;
						}
						return jproperty;
					}
					goto IL_00DA;
					IL_00CF:
					return (JProperty)jtoken;
					IL_00DA:
					return null;
				}
				goto IL_00CF;
			}
			IL_00DC:
			return null;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00005F2F File Offset: 0x0000412F
		[return: Nullable(new byte[] { 0, 1 })]
		public JEnumerable<JToken> PropertyValues()
		{
			return new JEnumerable<JToken>(this.Properties().Select(new Func<JProperty, JToken>(JObject.<>c.<>c_0.method_0)));
		}

		// Token: 0x17000224 RID: 548
		[Nullable(2)]
		public override JToken this[object key]
		{
			[return: Nullable(2)]
			get
			{
				string text;
				for (;;)
				{
					ValidationUtils.ArgumentNotNull(key, Class15.smethod_17(82309886 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
					{
						goto IL_0003;
					}
					IL_001C:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0068;
					case 3:
						goto IL_0097;
					case 4:
						goto IL_006C;
					}
					IL_0003:
					text = key as string;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
					{
						goto IL_001C;
					}
					break;
				}
				IL_0068:
				if (text != null)
				{
					goto IL_0097;
				}
				IL_006C:
				throw new ArgumentException(Class15.smethod_17(613134843 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6).FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				IL_0097:
				return this[text];
			}
			[param: Nullable(2)]
			set
			{
				string text;
				for (;;)
				{
					IL_0053:
					ValidationUtils.ArgumentNotNull(key, Class15.smethod_17(1243259062 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
					{
						goto IL_001E;
					}
					for (;;)
					{
						IL_0037:
						switch (num)
						{
						case 1:
							goto IL_001E;
						case 2:
							goto IL_0053;
						case 3:
							return;
						case 4:
							if (text != null)
							{
								goto IL_00B1;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
							{
								continue;
							}
							break;
						}
						goto Block_3;
					}
					IL_001E:
					text = key as string;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
					{
						goto IL_0037;
					}
					break;
				}
				Block_3:
				throw new ArgumentException(Class15.smethod_17(1953634483 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f).FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				IL_00B1:
				this[text] = value;
			}
		}

		// Token: 0x17000225 RID: 549
		[Nullable(2)]
		public JToken this[string propertyName]
		{
			[return: Nullable(2)]
			get
			{
				JProperty jproperty;
				for (;;)
				{
					ValidationUtils.ArgumentNotNull(propertyName, Class15.smethod_17(1807939904 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						goto IL_0003;
					}
					IL_0020:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_006C;
					}
					IL_0003:
					jproperty = this.Property(propertyName, StringComparison.Ordinal);
					if (jproperty != null)
					{
						goto IL_0066;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto IL_0020;
					}
					break;
				}
				goto IL_006C;
				IL_0066:
				return jproperty.Value;
				IL_006C:
				return null;
			}
			[param: Nullable(2)]
			set
			{
				for (;;)
				{
					IL_007A:
					JProperty jproperty = this.Property(propertyName, StringComparison.Ordinal);
					for (;;)
					{
						if (jproperty == null)
						{
							goto IL_001E;
						}
						goto IL_0057;
						IL_002F:
						int num;
						switch (num)
						{
						case 1:
							return;
						case 2:
							goto IL_0025;
						case 3:
							IL_001E:
							this.OnPropertyChanging(propertyName);
							goto IL_0025;
						case 4:
							IL_0057:
							jproperty.Value = value;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
							{
								goto IL_002F;
							}
							break;
						case 5:
							goto IL_0003;
						case 6:
							continue;
						case 7:
							goto IL_007A;
						}
						goto Block_2;
						IL_0003:
						this.OnPropertyChanged(propertyName);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
						{
							goto Block_1;
						}
						goto IL_002F;
						IL_0025:
						this.Add(propertyName, value);
						goto IL_0003;
					}
				}
				Block_1:
				Block_2:;
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00005F60 File Offset: 0x00004160
		public new static JObject Load(JsonReader reader)
		{
			return JObject.Load(reader, null);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00078968 File Offset: 0x00076B68
		public new static JObject Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			for (;;)
			{
				IL_0090:
				ValidationUtils.ArgumentNotNull(reader, Class15.smethod_17(594377344 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b));
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_00BD;
				}
				for (;;)
				{
					IL_006C:
					switch (num)
					{
					case 1:
						while (reader.TokenType != JsonToken.StartObject)
						{
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
							{
								goto IL_006C;
							}
						}
						goto IL_010E;
					case 2:
						goto IL_002D;
					case 3:
						goto IL_000E;
					case 4:
						goto IL_00BD;
					case 5:
						if (reader.TokenType == JsonToken.None)
						{
							goto IL_000E;
						}
						goto IL_002D;
					case 6:
						goto IL_0090;
					}
					goto Block_5;
					IL_000E:
					if (!reader.Read())
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
						{
							goto Block_2;
						}
						continue;
					}
					IL_002D:
					reader.MoveToContent();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 != 0)
					{
						goto Block_3;
					}
				}
			}
			Block_2:
			Block_3:
			Block_5:
			goto IL_00F2;
			IL_00BD:
			throw JsonReaderException.Create(reader, Class15.smethod_17(89019252 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			IL_00F2:
			throw JsonReaderException.Create(reader, Class15.smethod_17(1471411103 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e));
			IL_010E:
			JObject jobject = new JObject();
			jobject.SetLineInfo(reader as IJsonLineInfo, settings);
			jobject.ReadTokenFrom(reader, settings);
			return jobject;
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00005F69 File Offset: 0x00004169
		public new static JObject Parse(string json)
		{
			return JObject.Parse(json, null);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00078AA0 File Offset: 0x00076CA0
		public new static JObject Parse(string json, [Nullable(2)] JsonLoadSettings settings)
		{
			JsonReader jsonReader;
			JObject jobject;
			for (;;)
			{
				jsonReader = new JsonTextReader(new StringReader(json));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return jobject;
					}
					break;
				}
				break;
			}
			try
			{
				JObject jobject2 = JObject.Load(jsonReader, settings);
				int num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					goto IL_0077;
				}
				IL_006B:
				while (jsonReader.Read())
				{
				}
				IL_0053:
				jobject = jobject2;
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
				{
					goto IL_008C;
				}
				IL_0077:
				switch (num2)
				{
				case 1:
					goto IL_006B;
				case 2:
					goto IL_0053;
				}
				IL_008C:;
			}
			finally
			{
				if (jsonReader != null)
				{
					int num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
					{
						goto IL_00BC;
					}
					IL_00A4:
					((IDisposable)jsonReader).Dispose();
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
					{
						goto IL_00CD;
					}
					IL_00BC:
					switch (num3)
					{
					case 1:
						goto IL_00A4;
					}
				}
				IL_00CD:;
			}
			return jobject;
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00005F72 File Offset: 0x00004172
		public new static JObject FromObject(object o)
		{
			return JObject.FromObject(o, JsonSerializer.CreateDefault());
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00078B90 File Offset: 0x00076D90
		public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
		{
			JToken jtoken;
			for (;;)
			{
				jtoken = JToken.FromObjectInternal(o, jsonSerializer);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
				{
					goto IL_0003;
				}
				IL_001E:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0050;
				}
				IL_0003:
				if (jtoken.Type == JTokenType.Object)
				{
					goto IL_0081;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					goto IL_001E;
				}
				break;
			}
			IL_0050:
			throw new ArgumentException(Class15.smethod_17(1802323663 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4).FormatWith(CultureInfo.InvariantCulture, jtoken.Type));
			IL_0081:
			return (JObject)jtoken;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00078C28 File Offset: 0x00076E28
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			for (;;)
			{
				writer.WriteStartObject();
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
				{
					goto IL_0018;
				}
				IL_006D:
				int num2;
				switch (num)
				{
				case 0:
					goto IL_003E;
				case 1:
				case 2:
					break;
				case 3:
					return;
				case 4:
					goto IL_00B6;
				case 5:
					num2 = 0;
					goto IL_0056;
				case 6:
					continue;
				case 7:
				case 8:
					goto IL_0056;
				default:
					goto IL_003E;
				}
				IL_0018:
				this.jpropertyKeyedCollection_0[num2].WriteTo(writer, converters);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
				{
					goto IL_006D;
				}
				IL_003E:
				num2++;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					goto IL_006D;
				}
				IL_0056:
				if (num2 >= this.jpropertyKeyedCollection_0.Count)
				{
					break;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					goto IL_0018;
				}
				goto IL_006D;
			}
			IL_00B6:
			writer.WriteEndObject();
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00005F7F File Offset: 0x0000417F
		[NullableContext(2)]
		public JToken GetValue(string propertyName)
		{
			return this.GetValue(propertyName, StringComparison.Ordinal);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00078CF4 File Offset: 0x00076EF4
		[NullableContext(2)]
		public JToken GetValue(string propertyName, StringComparison comparison)
		{
			JProperty jproperty;
			for (;;)
			{
				int num;
				if (propertyName == null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
					{
						break;
					}
				}
				else
				{
					jproperty = this.Property(propertyName, comparison);
					if (jproperty != null)
					{
						goto IL_0056;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
					{
						break;
					}
				}
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0051;
				}
				break;
			}
			goto IL_0054;
			IL_0051:
			return null;
			IL_0054:
			return null;
			IL_0056:
			return jproperty.Value;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00078D5C File Offset: 0x00076F5C
		public bool TryGetValue(string propertyName, StringComparison comparison, [Nullable(2)] [NotNullWhen(true)] out JToken value)
		{
			for (;;)
			{
				value = this.GetValue(propertyName, comparison);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
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
			return value != null;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00078D9C File Offset: 0x00076F9C
		public void Add(string propertyName, [Nullable(2)] JToken value)
		{
			for (;;)
			{
				this.Add(new JProperty(propertyName, value));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
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

		// Token: 0x06000E9C RID: 3740 RVA: 0x00078DDC File Offset: 0x00076FDC
		public bool ContainsKey(string propertyName)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(propertyName, Class15.smethod_17(1802322983 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
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
			return this.jpropertyKeyedCollection_0.Contains(propertyName);
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00005F89 File Offset: 0x00004189
		ICollection<string> IDictionary<string, JToken>.Keys
		{
			get
			{
				return this.jpropertyKeyedCollection_0.Keys;
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00078E34 File Offset: 0x00077034
		public bool Remove(string propertyName)
		{
			for (;;)
			{
				JProperty jproperty = this.Property(propertyName, StringComparison.Ordinal);
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
				{
					goto IL_0003;
				}
				IL_0033:
				switch (num)
				{
				case 1:
					return false;
				case 2:
					IL_0003:
					if (jproperty == null)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
						{
							goto Block_2;
						}
						goto IL_0033;
					}
					else
					{
						jproperty.Remove();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
						{
							goto IL_0033;
						}
					}
					break;
				case 3:
					continue;
				}
				goto Block_3;
			}
			Block_2:
			return false;
			Block_3:
			return true;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00078EB0 File Offset: 0x000770B0
		public bool TryGetValue(string propertyName, [NotNullWhen(true)] [Nullable(2)] out JToken value)
		{
			JProperty jproperty;
			for (;;)
			{
				jproperty = this.Property(propertyName, StringComparison.Ordinal);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_001A;
				}
				IL_0021:
				switch (num)
				{
				case 1:
					IL_001A:
					if (jproperty == null)
					{
						goto IL_0003;
					}
					goto IL_005B;
				case 2:
					continue;
				case 3:
					return true;
				case 4:
					goto IL_0003;
				}
				break;
				IL_0003:
				value = null;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					break;
				}
				goto IL_0021;
			}
			return false;
			IL_005B:
			value = jproperty.Value;
			return true;
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x00005F96 File Offset: 0x00004196
		[Nullable(new byte[] { 1, 2 })]
		ICollection<JToken> IDictionary<string, JToken>.Values
		{
			[return: Nullable(new byte[] { 1, 2 })]
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00005F9D File Offset: 0x0000419D
		void ICollection<KeyValuePair<string, JToken>>.Add([Nullable(new byte[] { 0, 1, 2 })] KeyValuePair<string, JToken> item)
		{
			this.Add(new JProperty(item.Key, item.Value));
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00005FB8 File Offset: 0x000041B8
		void ICollection<KeyValuePair<string, JToken>>.Clear()
		{
			base.RemoveAll();
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00078F28 File Offset: 0x00077128
		bool ICollection<KeyValuePair<string, JToken>>.Contains([Nullable(new byte[] { 0, 1, 2 })] KeyValuePair<string, JToken> item)
		{
			JProperty jproperty = this.Property(item.Key, StringComparison.Ordinal);
			return jproperty != null && jproperty.Value == item.Value;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00078F58 File Offset: 0x00077158
		void ICollection<KeyValuePair<string, JToken>>.CopyTo([Nullable(new byte[] { 1, 0, 1, 2 })] KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
			IL_00C1:
			while (array != null)
			{
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
				{
					goto IL_0061;
				}
				for (;;)
				{
					IL_0089:
					switch (num)
					{
					case 1:
						goto IL_004A;
					case 2:
						goto IL_00D1;
					case 3:
						goto IL_011D;
					case 4:
					{
						IEnumerator<JToken> enumerator = this.jpropertyKeyedCollection_0.GetEnumerator();
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
						{
							continue;
						}
						goto IL_00CD;
					}
					case 5:
						goto IL_0061;
					case 6:
						goto IL_00C1;
					case 7:
						goto IL_0044;
					case 8:
						return;
					case 9:
						goto IL_001A;
					case 10:
						goto IL_0138;
					case 11:
						goto IL_01E8;
					}
					break;
				}
				goto IL_00ED;
				IL_00CD:
				IL_0138:
				int num2;
				try
				{
					IL_019D:
					IEnumerator<JToken> enumerator;
					while (enumerator.MoveNext())
					{
						for (;;)
						{
							IL_0186:
							JProperty jproperty = (JProperty)enumerator.Current;
							for (;;)
							{
								array[arrayIndex + num2] = new KeyValuePair<string, JToken>(jproperty.Name, jproperty.Value);
								int num3 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
								{
									switch (num3)
									{
									case 1:
										goto IL_0186;
									case 2:
										goto IL_01A6;
									case 3:
										continue;
									case 4:
										goto IL_019D;
									}
									goto Block_12;
								}
								goto IL_0196;
							}
						}
						IL_0197:
						num2++;
						continue;
						Block_12:
						IL_0196:
						goto IL_0197;
					}
					IL_01A6:
					return;
				}
				finally
				{
					IEnumerator<JToken> enumerator;
					if (enumerator != null)
					{
						int num4 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
						{
							goto IL_01D6;
						}
						IL_01BE:
						enumerator.Dispose();
						num4 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
						{
							break;
						}
						IL_01D6:
						switch (num4)
						{
						case 0:
							goto IL_01BE;
						case 1:
							break;
						default:
							goto IL_01BE;
						}
					}
				}
				break;
				IL_001A:
				if (base.Count > array.Length - arrayIndex)
				{
					goto IL_011D;
				}
				num2 = 0;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
				{
					goto IL_00ED;
				}
				goto IL_0089;
				IL_0044:
				if (arrayIndex >= array.Length)
				{
					goto IL_004A;
				}
				goto IL_001A;
				IL_0061:
				if (arrayIndex >= 0)
				{
					goto IL_0044;
				}
				goto IL_00ED;
				IL_004A:
				if (arrayIndex == 0)
				{
					goto IL_001A;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					goto IL_0089;
				}
				IL_00D1:
				throw new ArgumentException(Class15.smethod_17(1387514582 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923));
				IL_00ED:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(642181794 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba), Class15.smethod_17(698954692 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a));
				IL_011D:
				throw new ArgumentException(Class15.smethod_17(1042140129 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad));
			}
			IL_01E8:
			throw new ArgumentNullException(Class15.smethod_17(1471381775 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e));
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00003453 File Offset: 0x00001653
		bool ICollection<KeyValuePair<string, JToken>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00005FC0 File Offset: 0x000041C0
		bool ICollection<KeyValuePair<string, JToken>>.Remove([Nullable(new byte[] { 0, 1, 2 })] KeyValuePair<string, JToken> item)
		{
			if (!((ICollection<KeyValuePair<string, JToken>>)this).Contains(item))
			{
				return false;
			}
			((IDictionary<string, JToken>)this).Remove(item.Key);
			return true;
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00005D7C File Offset: 0x00003F7C
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00005FDC File Offset: 0x000041DC
		[return: Nullable(new byte[] { 1, 0, 1, 2 })]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			JObject.<GetEnumerator>d__61 <GetEnumerator>d__ = new JObject.<GetEnumerator>d__61(0);
			<GetEnumerator>d__.<>4__this = this;
			return <GetEnumerator>d__;
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00079178 File Offset: 0x00077378
		protected virtual void OnPropertyChanged(string propertyName)
		{
			for (;;)
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				int num;
				if (propertyChangedEventHandler != null)
				{
					propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						break;
					}
				}
				else
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						goto Block_2;
					}
				}
				switch (num)
				{
				case 1:
					return;
				case 2:
					continue;
				}
				break;
			}
			return;
			Block_2:;
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x000791D8 File Offset: 0x000773D8
		protected virtual void OnPropertyChanging(string propertyName)
		{
			for (;;)
			{
				PropertyChangingEventHandler propertyChangingEventHandler = this.propertyChangingEventHandler_0;
				int num;
				if (propertyChangingEventHandler == null)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						break;
					}
				}
				else
				{
					propertyChangingEventHandler(this, new PropertyChangingEventArgs(propertyName));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						break;
					}
				}
				switch (num)
				{
				case 1:
					return;
				case 2:
					continue;
				}
				break;
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00005FEB File Offset: 0x000041EB
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return ((ICustomTypeDescriptor)this).GetProperties(null);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00079238 File Offset: 0x00077438
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties([Nullable(new byte[] { 2, 1 })] Attribute[] attributes)
		{
			PropertyDescriptor[] array;
			int num;
			IEnumerator<KeyValuePair<string, JToken>> enumerator;
			for (;;)
			{
				IL_004F:
				array = new PropertyDescriptor[base.Count];
				for (;;)
				{
					num = 0;
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
					{
						goto IL_0003;
					}
					IL_001C:
					switch (num2)
					{
					case 1:
						goto IL_005F;
					case 2:
						continue;
					case 3:
						goto IL_004F;
					case 4:
						goto IL_012A;
					}
					IL_0003:
					enumerator = this.GetEnumerator();
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
					{
						goto IL_001C;
					}
					goto IL_005E;
				}
			}
			IL_005E:
			IL_005F:
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_00A1;
					}
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
					{
						break;
					}
					IL_0085:
					KeyValuePair<string, JToken> keyValuePair;
					switch (num3)
					{
					case 1:
						goto IL_00BF;
					case 2:
						continue;
					case 3:
						goto IL_0063;
					case 4:
						IL_00A1:
						keyValuePair = enumerator.Current;
						num3 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
						{
							goto IL_0063;
						}
						goto IL_0085;
					}
					break;
					IL_0063:
					array[num] = new GClass0(keyValuePair.Key);
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
					{
						goto IL_0085;
					}
					IL_00BF:
					num++;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
					{
						goto IL_0118;
					}
					IL_0100:
					enumerator.Dispose();
					num4 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						goto IL_0129;
					}
					IL_0118:
					switch (num4)
					{
					case 1:
						goto IL_0100;
					}
				}
				IL_0129:;
			}
			IL_012A:
			return new PropertyDescriptorCollection(array);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00005FF4 File Offset: 0x000041F4
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return AttributeCollection.Empty;
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00003C0E File Offset: 0x00001E0E
		[NullableContext(2)]
		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00003C0E File Offset: 0x00001E0E
		[NullableContext(2)]
		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00005FFB File Offset: 0x000041FB
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return new TypeConverter();
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00003C0E File Offset: 0x00001E0E
		[NullableContext(2)]
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00003C0E File Offset: 0x00001E0E
		[NullableContext(2)]
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00003C0E File Offset: 0x00001E0E
		[return: Nullable(2)]
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00006002 File Offset: 0x00004202
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents([Nullable(new byte[] { 2, 1 })] Attribute[] attributes)
		{
			return EventDescriptorCollection.Empty;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00006002 File Offset: 0x00004202
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return EventDescriptorCollection.Empty;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00079388 File Offset: 0x00077588
		[NullableContext(2)]
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			while (pd is GClass0)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return this;
			}
			return null;
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00006009 File Offset: 0x00004209
		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return new DynamicProxyMetaObject<JObject>(parameter, this, new JObject.Class3());
		}

		// Token: 0x040006BF RID: 1727
		private readonly JPropertyKeyedCollection jpropertyKeyedCollection_0 = new JPropertyKeyedCollection();

		// Token: 0x040006C0 RID: 1728
		[Nullable(2)]
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x040006C1 RID: 1729
		[CompilerGenerated]
		[Nullable(2)]
		private PropertyChangingEventHandler propertyChangingEventHandler_0;

		// Token: 0x02000154 RID: 340
		[Nullable(new byte[] { 0, 1 })]
		private class Class3 : DynamicProxy<JObject>
		{
			// Token: 0x06000EBB RID: 3771 RVA: 0x000793C8 File Offset: 0x000775C8
			public override bool TryGetMember(JObject instance, GetMemberBinder binder, [Nullable(2)] out object result)
			{
				for (;;)
				{
					result = instance[binder.Name];
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
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
				return true;
			}

			// Token: 0x06000EBC RID: 3772 RVA: 0x00079408 File Offset: 0x00077608
			public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value)
			{
				for (;;)
				{
					IL_0079:
					JToken jtoken = value as JToken;
					for (;;)
					{
						if (jtoken == null)
						{
							goto IL_0042;
						}
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
						{
							goto IL_0003;
						}
						IL_0022:
						switch (num)
						{
						case 1:
							return true;
						case 3:
							IL_0042:
							jtoken = new JValue(value);
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
							{
								goto IL_0022;
							}
							break;
						case 4:
							continue;
						case 5:
							goto IL_0079;
						}
						IL_0003:
						instance[binder.Name] = jtoken;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
						{
							goto IL_0022;
						}
						return true;
					}
				}
				return true;
			}

			// Token: 0x06000EBD RID: 3773 RVA: 0x00006017 File Offset: 0x00004217
			public override IEnumerable<string> GetDynamicMemberNames(JObject instance)
			{
				return instance.Properties().Select(new Func<JProperty, string>(JObject.Class3.<>c.<>c_0.method_0));
			}

			// Token: 0x06000EBE RID: 3774 RVA: 0x0007949C File Offset: 0x0007769C
			public Class3()
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
				{
					switch (num)
					{
					}
				}
			}
		}
	}
}
