﻿using System;
using System.Text;

namespace DynamicArrays
{
    public abstract class IntDynamicArray<T>
    {
        const int ExpandMultiplyFactor = 2;
        protected T[] items;
        protected int count;

        #region Constructor
        protected IntDynamicArray()
        {
            items = new T[4];
            count = 0;
        }

        #endregion
        #region Properties
        public int Count
        {
            get { return count; }
        }

        #endregion

        #region Public methods
        public abstract void Add(T item);
       // public abstract bool Remove(T item);
       // public abstract int IndexOf(T item);

        public void Clear()
        {
            count = 0;
        }

        public override String ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builder.Append(items[i]);
                if (i < count - 1)
                    builder.Append(",");
            }
            return builder.ToString();
        }

        #endregion

        #region Protected methods
        protected void Expand()
        {
            T[] newItems = new T[items.Length * ExpandMultiplyFactor];

            for (int i = 0; i < items.Length; i++)
                newItems[i] = items[i];

            items = newItems;
        }

        #endregion
    }
}