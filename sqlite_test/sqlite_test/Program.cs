//using System;
//using System.Data.SQLite;

//namespace sqlite_test
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            SQLiteConnection conn = null;

//            string dbPath = "Data Source =" + Environment.CurrentDirectory + "/test.db";
//            conn = new SQLiteConnection(dbPath);//创建数据库实例，指定文件位置  
//            conn.Open();//打开数据库，若文件不存在会自动创建  

//            string sql = "CREATE TABLE IF NOT EXISTS student(id integer, name varchar(20), sex varchar(2));";//建表语句  
//            SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
//            cmdCreateTable.ExecuteNonQuery();//如果表不存在，创建数据表  

//            SQLiteCommand cmdInsert = new SQLiteCommand(conn);
//            cmdInsert.CommandText = "INSERT INTO student VALUES(1, '小红', '男')";//插入几条数据  
//            cmdInsert.ExecuteNonQuery();
//            cmdInsert.CommandText = "INSERT INTO student VALUES(2, '小李', '女')";
//            cmdInsert.ExecuteNonQuery();
//            cmdInsert.CommandText = "INSERT INTO student VALUES(3, '小明', '男')";
//            cmdInsert.ExecuteNonQuery();

//            conn.Close();
//            Console.WriteLine("Hello World!");
//            Console.Read();
//            Console.Read();
//            Console.Read();
//        }
//    }
//}

using System;
delegate double Function(double x);
class Multiplier
{
    double factor;
    public Multiplier(double factor)
    {
        this.factor = factor;
    }
    public double Multiply(double x)
    {
        return x * factor;
    }
}
class DelegateExample
{
    static double Square(double x)
    {
        return x * x;
    }
    static double[] Apply(double[] a, Function f)
    {
        double[] result = new double[a.Length];
        for (int i = 0; i < a.Length; i++) result[i] = f(a[i]);
        return result;
    }
    static void Main()
    {
        double[] a = { 0.0, 0.5, 1.0 };
        double[] squares = Apply(a, Square);
        double[] sines = Apply(a, Math.Sin);
        Multiplier m = new Multiplier(2.0);
        double[] doubles = Apply(a, m.Multiply);
        Type widgetType = typeof(Widget);

        //Gets every HelpAttribute defined for the Widget type
        object[] widgetClassAttributes = widgetType.GetCustomAttributes(typeof(HelpAttribute), false);

        if (widgetClassAttributes.Length > 0)
        {
            HelpAttribute attr = (HelpAttribute)widgetClassAttributes[0];
            Console.WriteLine($"Widget class help URL : {attr.Url} - Related topic : {attr.Topic}");
        }

        System.Reflection.MethodInfo displayMethod = widgetType.GetMethod(nameof(Widget.Display));

        //Gets every HelpAttribute defined for the Widget.Display method
        object[] displayMethodAttributes = displayMethod.GetCustomAttributes(typeof(HelpAttribute), false);

        if (displayMethodAttributes.Length > 0)
        {
            HelpAttribute attr = (HelpAttribute)displayMethodAttributes[0];
            Console.WriteLine($"Display method help URL : {attr.Url} - Related topic : {attr.Topic}");
        }

        Console.ReadLine();

        Console.Read();

    }

    public class HelpAttribute : Attribute
    {
        string url;
        string topic;
        public HelpAttribute(string url)
        {
            this.url = url;
        }

        public string Url => url;

        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }
    }
    [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/attributes")]
    public class Widget
    {
        [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/attributes",
                 Topic = "Display")]
        public void Display(string text) { }

    }

}

