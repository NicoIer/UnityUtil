﻿using System;

namespace Nico.Data
{
    public interface IMetaDataContainer
    {
        public void AddData(IMetaData metaData);
        public IMetaData GetMetaData(int idx);

        public Type GetMetaType();
    }
}