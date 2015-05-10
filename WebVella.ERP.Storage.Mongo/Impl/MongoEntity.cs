﻿using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using WebVella.ERP.Storage;
using WebVella.ERP.Storage.Mongo.Impl;

namespace WebVella.ERP.Storage.Mongo
{
    internal class MongoEntity : MongoDocumentBase, IStorageEntity
    {
        public string Name { get; set; }

        public string Label { get; set; }

        public string PluralLabel { get; set; }

        public bool System { get; set; }

        public List<IStorageField> Fields { get; set; }

        public List<IStorageView> Views { get; set; }

        public List<IStorageForm> Forms { get; set; }

        public MongoEntity()
        {
            Fields = new List<IStorageField>();
            Views = new List<IStorageView>();
            Forms = new List<IStorageForm>();
        }
    }
}