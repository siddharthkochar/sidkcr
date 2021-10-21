using System;
using System.Collections.Generic;
using System.Data;

namespace OneLevelIndentationPerMethod
{
    public class Cache
    {
        public List<object> CachedObjects { get; } = new();

        public void BuildCache()
        {
            var dt = new DataTable("table");
            var cache = new List<object>();

            foreach(DataRow row in dt.Rows)
            {
                if(row.HasErrors)
                {
                    continue;
                }

                foreach(DataColumn column in dt.Columns)
                {
                    var cell = row[column].ToString();

                    if(cell != "text")
                    {
                        cache.Add(cell);
                    }
                }
            }

            CachedObjects.AddRange(cache);
        }
    }
}