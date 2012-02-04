using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Class_i_er
{
    public class ClassierDataContext : DataContext 
    {
        public static string DBConnectionString = "Data Source=isostore:/Classes.sdf"; 
        // Pass the connection string to the base class. 
        public ClassierDataContext(string connectionString) : base(connectionString) { } 
        // Specify a single table for the to-do items. 
        public Table<ClassItem> ClassItems; 
    }

    [TableAttribute(Name = "ClassItems")]
    public class ClassItem
    {
        [ColumnAttribute(IsPrimaryKey=true)]
        public int id {get; set; }
        public string className {get; set; }
        public string classCode { get; set; }
        public int startTime { get; set; }
        public int endTime { get; set; }
    }
}
