﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp_dessist
{
    public class LineageObject
    {
        public string LineageId;
        public string DataTableName;
        //public int DataTableColumn;
        public string FieldName;

        public LineageObject(string lineage_id, string table_name, string field_name)
        {
            // TODO: Complete member initialization
            //this.LineageId = outcol.Attributes["lineageId"];
            //this.DataTableName = "component" + component.Attributes["id"];
            LineageId = lineage_id;
            DataTableName = table_name;
            FieldName = field_name;
        }

        public override string ToString()
        {
            return String.Format(@"{0}.Rows[row][""{1}""]", DataTableName, FieldName);
        }
    }
}
