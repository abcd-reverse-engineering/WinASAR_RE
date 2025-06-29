using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000090 RID: 144
	[NullableContext(1)]
	[Nullable(0)]
	internal class DictionaryWrapper<[Nullable(2)] TKey, [Nullable(2)] TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, Interface1, IDictionary, ICollection
	{
		// Token: 0x06000627 RID: 1575 RVA: 0x000460F4 File Offset: 0x000442F4
		public DictionaryWrapper(IDictionary dictionary)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
			{
				goto IL_0037;
			}
			goto IL_0054;
			IL_001C:
			this.idictionary_0 = dictionary;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
			{
				return;
			}
			goto IL_0054;
			IL_0037:
			ValidationUtils.ArgumentNotNull(dictionary, Class15.smethod_17(2128245308 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9));
			goto IL_001C;
			IL_0054:
			switch (num)
			{
			case 1:
				goto IL_0037;
			case 2:
				goto IL_001C;
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000039CC File Offset: 0x00001BCC
		public DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
		{
			ValidationUtils.ArgumentNotNull(dictionary, Class15.smethod_17(2008571647 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
			this.idictionary_1 = dictionary;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x000039F8 File Offset: 0x00001BF8
		internal IDictionary<TKey, TValue> GenericDictionary
		{
			get
			{
				return this.idictionary_1;
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00003A00 File Offset: 0x00001C00
		public void Add(TKey key, TValue value)
		{
			if (this.idictionary_0 != null)
			{
				this.idictionary_0.Add(key, value);
				return;
			}
			if (this.idictionary_1 == null)
			{
				throw new NotSupportedException();
			}
			this.idictionary_1.Add(key, value);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00003A3D File Offset: 0x00001C3D
		public bool ContainsKey(TKey key)
		{
			if (this.idictionary_0 != null)
			{
				return this.idictionary_0.Contains(key);
			}
			return this.GenericDictionary.ContainsKey(key);
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00003A65 File Offset: 0x00001C65
		public ICollection<TKey> Keys
		{
			get
			{
				if (this.idictionary_0 != null)
				{
					return this.idictionary_0.Keys.Cast<TKey>().ToList<TKey>();
				}
				return this.GenericDictionary.Keys;
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00003A90 File Offset: 0x00001C90
		public bool Remove(TKey key)
		{
			if (this.idictionary_0 == null)
			{
				return this.GenericDictionary.Remove(key);
			}
			if (this.idictionary_0.Contains(key))
			{
				this.idictionary_0.Remove(key);
				return true;
			}
			return false;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0004616C File Offset: 0x0004436C
		public bool TryGetValue(TKey key, [Nullable(2)] out TValue value)
		{
			if (this.idictionary_0 == null)
			{
				return this.GenericDictionary.TryGetValue(key, out value);
			}
			if (!this.idictionary_0.Contains(key))
			{
				value = default(TValue);
				return false;
			}
			value = (TValue)((object)this.idictionary_0[key]);
			return true;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00003ACE File Offset: 0x00001CCE
		public ICollection<TValue> Values
		{
			get
			{
				if (this.idictionary_0 != null)
				{
					return this.idictionary_0.Values.Cast<TValue>().ToList<TValue>();
				}
				return this.GenericDictionary.Values;
			}
		}

		// Token: 0x170000ED RID: 237
		public TValue this[TKey key]
		{
			get
			{
				if (this.idictionary_0 != null)
				{
					return (TValue)((object)this.idictionary_0[key]);
				}
				return this.GenericDictionary[key];
			}
			set
			{
				if (this.idictionary_0 != null)
				{
					this.idictionary_0[key] = value;
					return;
				}
				this.GenericDictionary[key] = value;
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00003B55 File Offset: 0x00001D55
		public void Add([Nullable(new byte[] { 0, 1, 1 })] KeyValuePair<TKey, TValue> item)
		{
			if (this.idictionary_0 != null)
			{
				((IList)this.idictionary_0).Add(item);
				return;
			}
			IDictionary<TKey, TValue> dictionary = this.idictionary_1;
			if (dictionary == null)
			{
				return;
			}
			dictionary.Add(item);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000461C8 File Offset: 0x000443C8
		public void Clear()
		{
			for (;;)
			{
				int num;
				if (this.idictionary_0 != null)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
					{
						goto Block_2;
					}
				}
				else
				{
					this.GenericDictionary.Clear();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
					{
						break;
					}
				}
				switch (num)
				{
				case 1:
					goto IL_0057;
				case 2:
					continue;
				case 3:
					return;
				}
				break;
			}
			return;
			Block_2:
			IL_0057:
			this.idictionary_0.Clear();
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00003B88 File Offset: 0x00001D88
		public bool Contains([Nullable(new byte[] { 0, 1, 1 })] KeyValuePair<TKey, TValue> item)
		{
			if (this.idictionary_0 != null)
			{
				return ((IList)this.idictionary_0).Contains(item);
			}
			return this.GenericDictionary.Contains(item);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0004623C File Offset: 0x0004443C
		public void CopyTo([Nullable(new byte[] { 1, 0, 1, 1 })] KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			for (;;)
			{
				if (this.idictionary_0 != null)
				{
					goto IL_0003;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					break;
				}
				IL_0024:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_006C;
				case 3:
				{
					IL_0003:
					IDictionaryEnumerator enumerator = this.idictionary_0.GetEnumerator();
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
					{
						goto IL_0024;
					}
					break;
				}
				case 5:
					return;
				}
				break;
			}
			goto IL_012F;
			IL_006C:
			try
			{
				IL_00DD:
				IDictionaryEnumerator enumerator;
				while (enumerator.MoveNext())
				{
					for (;;)
					{
						IL_00BF:
						DictionaryEntry entry = enumerator.Entry;
						int num2 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
						{
							for (;;)
							{
								switch (num2)
								{
								default:
									goto IL_00BF;
								case 1:
									goto IL_00DD;
								case 2:
									array[arrayIndex++] = new KeyValuePair<TKey, TValue>((TKey)((object)entry.Key), (TValue)((object)entry.Value));
									num2 = 1;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
									{
										goto IL_00DC;
									}
									break;
								case 3:
									goto IL_00E6;
								}
							}
						}
					}
					IL_00DC:;
				}
				IL_00E6:
				return;
			}
			finally
			{
				IDictionaryEnumerator enumerator;
				IDisposable disposable = enumerator as IDisposable;
				int num3;
				if (disposable != null)
				{
					disposable.Dispose();
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						goto IL_012D;
					}
				}
				else
				{
					num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
					{
						goto IL_012D;
					}
				}
				switch (num3)
				{
				default:
					IL_012D:
					break;
				}
			}
			IL_012F:
			this.GenericDictionary.CopyTo(array, arrayIndex);
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00046398 File Offset: 0x00044598
		public int Count
		{
			get
			{
				while (this.idictionary_0 != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return this.idictionary_0.Count;
				}
				return this.GenericDictionary.Count;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x000463EC File Offset: 0x000445EC
		public bool IsReadOnly
		{
			get
			{
				while (this.idictionary_0 != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return this.idictionary_0.IsReadOnly;
				}
				return this.GenericDictionary.IsReadOnly;
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00046440 File Offset: 0x00044640
		public bool Remove([Nullable(new byte[] { 0, 1, 1 })] KeyValuePair<TKey, TValue> item)
		{
			if (this.idictionary_0 == null)
			{
				return this.GenericDictionary.Remove(item);
			}
			if (!this.idictionary_0.Contains(item.Key))
			{
				return true;
			}
			if (object.Equals(this.idictionary_0[item.Key], item.Value))
			{
				this.idictionary_0.Remove(item.Key);
				return true;
			}
			return false;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000464C4 File Offset: 0x000446C4
		[return: Nullable(new byte[] { 1, 0, 1, 1 })]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			if (this.idictionary_0 != null)
			{
				return this.idictionary_0.Cast<DictionaryEntry>().Select(new Func<DictionaryEntry, KeyValuePair<TKey, TValue>>(DictionaryWrapper<TKey, TValue>.<>c.<>c_0.method_0)).GetEnumerator();
			}
			return this.GenericDictionary.GetEnumerator();
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00003BB5 File Offset: 0x00001DB5
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0004651C File Offset: 0x0004471C
		void IDictionary.Add(object key, [Nullable(2)] object value)
		{
			for (;;)
			{
				if (this.idictionary_0 != null)
				{
					goto IL_0047;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
				{
					goto IL_0003;
				}
				IL_002B:
				switch (num)
				{
				case 1:
					return;
				case 2:
					IL_0047:
					this.idictionary_0.Add(key, value);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
					{
						goto IL_002B;
					}
					break;
				case 3:
					IL_0003:
					this.GenericDictionary.Add((TKey)((object)key), (TValue)((object)value));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto IL_002B;
					}
					break;
				case 4:
					continue;
				}
				break;
			}
		}

		// Token: 0x170000F0 RID: 240
		[Nullable(2)]
		object IDictionary.this[object key]
		{
			[return: Nullable(2)]
			get
			{
				while (this.idictionary_0 != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return this.idictionary_0[key];
				}
				return this.GenericDictionary[(TKey)((object)key)];
			}
			[param: Nullable(2)]
			set
			{
				for (;;)
				{
					if (this.idictionary_0 != null)
					{
						goto IL_002E;
					}
					this.GenericDictionary[(TKey)((object)key)] = (TValue)((object)value);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						break;
					}
					IL_004C:
					switch (num)
					{
					case 1:
						return;
					case 2:
						IL_002E:
						this.idictionary_0[key] = value;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
						{
							goto IL_004C;
						}
						return;
					case 3:
						continue;
					}
					break;
				}
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00046698 File Offset: 0x00044898
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			while (this.idictionary_0 != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return this.idictionary_0.GetEnumerator();
			}
			return new DictionaryWrapper<TKey, TValue>.Struct0<TKey, TValue>(this.GenericDictionary.GetEnumerator());
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000466F8 File Offset: 0x000448F8
		bool IDictionary.Contains(object key)
		{
			while (this.idictionary_1 != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return this.idictionary_1.ContainsKey((TKey)((object)key));
			}
			return this.idictionary_0.Contains(key);
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00046754 File Offset: 0x00044954
		bool IDictionary.IsFixedSize
		{
			get
			{
				while (this.idictionary_1 == null)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						switch (num)
						{
						case 0:
							return false;
						case 1:
							break;
						case 2:
							continue;
						default:
							return false;
						}
					}
					return this.idictionary_0.IsFixedSize;
				}
				return false;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x000467A4 File Offset: 0x000449A4
		ICollection IDictionary.Keys
		{
			get
			{
				while (this.idictionary_1 != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return this.idictionary_1.Keys.ToList<TKey>();
				}
				return this.idictionary_0.Keys;
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00046800 File Offset: 0x00044A00
		public void Remove(object key)
		{
			for (;;)
			{
				int num;
				if (this.idictionary_0 != null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
					{
						goto IL_0029;
					}
				}
				else
				{
					this.GenericDictionary.Remove((TKey)((object)key));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
					{
						break;
					}
				}
				IL_0046:
				switch (num)
				{
				case 1:
					return;
				case 2:
					IL_0029:
					this.idictionary_0.Remove(key);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
					{
						goto IL_0046;
					}
					break;
				case 3:
					continue;
				}
				goto Block_2;
			}
			return;
			Block_2:;
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00046890 File Offset: 0x00044A90
		ICollection IDictionary.Values
		{
			get
			{
				while (this.idictionary_1 != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return this.idictionary_1.Values.ToList<TValue>();
				}
				return this.idictionary_0.Values;
			}
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000468EC File Offset: 0x00044AEC
		void ICollection.CopyTo(Array array, int index)
		{
			for (;;)
			{
				int num;
				if (this.idictionary_0 != null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
					{
						break;
					}
				}
				else
				{
					this.GenericDictionary.CopyTo((KeyValuePair<TKey, TValue>[])array, index);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						return;
					}
				}
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				case 3:
					return;
				}
				break;
			}
			this.idictionary_0.CopyTo(array, index);
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00046968 File Offset: 0x00044B68
		bool ICollection.IsSynchronized
		{
			get
			{
				while (this.idictionary_0 != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return this.idictionary_0.IsSynchronized;
				}
				return false;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000469B4 File Offset: 0x00044BB4
		object ICollection.SyncRoot
		{
			get
			{
				for (;;)
				{
					if (this.object_0 == null)
					{
						goto IL_0003;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
					{
						break;
					}
					IL_0026:
					switch (num)
					{
					case 1:
					case 2:
						goto IL_0061;
					case 3:
						continue;
					}
					IL_0003:
					Interlocked.CompareExchange(ref this.object_0, new object(), null);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						goto IL_0026;
					}
					break;
				}
				IL_0061:
				return this.object_0;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00046A28 File Offset: 0x00044C28
		public object UnderlyingDictionary
		{
			get
			{
				while (this.idictionary_0 == null)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
					{
						break;
					}
					switch (num)
					{
					case 0:
						goto IL_003B;
					case 1:
						return this.GenericDictionary;
					case 2:
						break;
					default:
						goto IL_003B;
					}
				}
				IL_003B:
				return this.idictionary_0;
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00003BBD File Offset: 0x00001DBD
		internal static bool smethod_0()
		{
			return DictionaryWrapper<TKey, TValue>.object_1 == null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00003BC7 File Offset: 0x00001DC7
		internal static object smethod_1()
		{
			return DictionaryWrapper<TKey, TValue>.object_1;
		}

		// Token: 0x040003CA RID: 970
		[Nullable(2)]
		private readonly IDictionary idictionary_0;

		// Token: 0x040003CB RID: 971
		[Nullable(new byte[] { 2, 1, 1 })]
		private readonly IDictionary<TKey, TValue> idictionary_1;

		// Token: 0x040003CC RID: 972
		[Nullable(2)]
		private object object_0;

		// Token: 0x040003CD RID: 973
		internal static object object_1;

		// Token: 0x02000091 RID: 145
		[Nullable(0)]
		private readonly struct Struct0<[Nullable(2)] V, [Nullable(2)] W> : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x0600064B RID: 1611 RVA: 0x00003BCE File Offset: 0x00001DCE
			public Struct0([Nullable(new byte[] { 1, 0, 1, 1 })] IEnumerator<KeyValuePair<V, W>> e)
			{
				ValidationUtils.ArgumentNotNull(e, Class15.smethod_17(1743150202 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8));
				this.ienumerator_0 = e;
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x0600064C RID: 1612 RVA: 0x00003BF4 File Offset: 0x00001DF4
			public DictionaryEntry Entry
			{
				get
				{
					return (DictionaryEntry)this.Current;
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x0600064D RID: 1613 RVA: 0x00046A78 File Offset: 0x00044C78
			public object Key
			{
				get
				{
					DictionaryEntry entry;
					for (;;)
					{
						entry = this.Entry;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
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
					return entry.Key;
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x0600064E RID: 1614 RVA: 0x00046AB8 File Offset: 0x00044CB8
			[Nullable(2)]
			public object Value
			{
				[NullableContext(2)]
				get
				{
					DictionaryEntry entry;
					for (;;)
					{
						entry = this.Entry;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
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
					return entry.Value;
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x0600064F RID: 1615 RVA: 0x00046AF8 File Offset: 0x00044CF8
			public object Current
			{
				get
				{
					KeyValuePair<V, W> keyValuePair;
					for (;;)
					{
						keyValuePair = this.ienumerator_0.Current;
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
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
					object obj = keyValuePair.Key;
					keyValuePair = this.ienumerator_0.Current;
					return new DictionaryEntry(obj, keyValuePair.Value);
				}
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x00003C01 File Offset: 0x00001E01
			public bool MoveNext()
			{
				return this.ienumerator_0.MoveNext();
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x00046B64 File Offset: 0x00044D64
			public void Reset()
			{
				for (;;)
				{
					this.ienumerator_0.Reset();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
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

			// Token: 0x06000652 RID: 1618 RVA: 0x00002C18 File Offset: 0x00000E18
			internal static bool smethod_0()
			{
				return true;
			}

			// Token: 0x06000653 RID: 1619 RVA: 0x00003C0E File Offset: 0x00001E0E
			internal static object smethod_1()
			{
				return null;
			}

			// Token: 0x040003CE RID: 974
			[Nullable(new byte[] { 1, 0, 1, 1 })]
			private readonly IEnumerator<KeyValuePair<V, W>> ienumerator_0;
		}
	}
}
