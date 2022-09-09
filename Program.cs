using dolphindb;
using dolphindb.data;
using dolphindb.io;
using System.Diagnostics;
using System.Linq;

// 模拟写入数据
class MockFactory
{
    private int numDevices = 100;
    private int numPoint = 20;
    private int numFloatPoint = 6;
    private int numLongPoint = 6;
    private int numStringPonit = 8;

    // 模拟Float类型表
    public BasicTable mockFloatData()
    {
        List<string> colNames = new List<string>() { "measurement", "time", "coefficient", "coefficientext", "decimalplaces", "deviceId", "displayname", "displaytype", "id", "label", "originvalue", "type", "typename", "value" };
        List<IVector> cols = new List<IVector>();

        List<String> measurement = new List<String>();
        List<long> time = new List<long>();
        List<float> coefficient = new List<float>();
        List<float> coefficientext = new List<float>();
        List<int> decimalplaces = new List<int>();
        List<String> deviceId = new List<String>();
        List<String> displayname = new List<String>();
        List<String> displaytype = new List<String>();
        List<long> id = new List<long>();
        List<String> label = new List<String>();
        List<long> originvalue = new List<long>();
        List<String> type = new List<String>();
        List<String> typename = new List<String>();
        List<float> value = new List<float>();


        long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds() * 1000000;

        Random random = new Random();
        for (int i = 0; i < numDevices; i++)
        {
            for (int j = 0; j < numFloatPoint; j++)
            {
                measurement.Add("measure" + j);
                time.Add(startTime + i * 1000);
                coefficient.Add(random.Next());
                coefficientext.Add(random.Next());
                decimalplaces.Add(random.Next());
                deviceId.Add("dev" + i);
                displayname.Add("deve" + i);
                displaytype.Add("name" + i);
                id.Add(random.Next());
                label.Add("label_" + i);
                originvalue.Add(random.Next());
                type.Add("type" + i);
                typename.Add("typeName" + i);
                value.Add(random.Next());
            }
        }

        BasicStringVector mstrp = new BasicStringVector(measurement.ToArray());
        cols.Add(mstrp);
        BasicNanoTimestampVector tp = new BasicNanoTimestampVector(time.ToArray());
        //BasicLongVector tp = new BasicLongVector(time.ToArray());
        cols.Add(tp);
        BasicFloatVector cp = new BasicFloatVector(coefficient.ToArray());
        cols.Add(cp);
        BasicFloatVector cpp = new BasicFloatVector(coefficientext.ToArray());
        cols.Add(cpp);
        BasicIntVector ip = new BasicIntVector(decimalplaces.ToArray());
        cols.Add(ip);
        BasicStringVector sp = new BasicStringVector(deviceId.ToArray());
        cols.Add(sp);
        BasicStringVector ssp = new BasicStringVector(displayname.ToArray());
        cols.Add(ssp);
        BasicStringVector sp3 = new BasicStringVector(displaytype.ToArray());
        cols.Add(sp3);
        BasicLongVector ip2 = new BasicLongVector(id.ToArray());
        cols.Add(ip2);
        BasicStringVector sp4 = new BasicStringVector(label.ToArray());
        cols.Add(sp4);
        BasicLongVector fp = new BasicLongVector(originvalue.ToArray());
        cols.Add(fp);
        BasicStringVector tp2 = new BasicStringVector(type.ToArray());
        cols.Add(tp2);
        BasicStringVector tp3 = new BasicStringVector(typename.ToArray());
        cols.Add(tp3);
        BasicFloatVector fp4 = new BasicFloatVector(value.ToArray());
        cols.Add(fp4);

        BasicTable t = new BasicTable(colNames, cols);
        return t;
    }

    // 模拟Long类型表
    public BasicTable mockLongData()
    {
        List<string> colNames = new List<string>() { "measurement", "time", "coefficient", "coefficientext", "decimalplaces", "deviceId", "displayname", "displaytype", "id", "label", "originvalue", "type", "typename", "value" };
        List<IVector> cols = new List<IVector>();

        List<String> measurement = new List<String>();
        List<long> time = new List<long>();
        List<float> coefficient = new List<float>();
        List<float> coefficientext = new List<float>();
        List<int> decimalplaces = new List<int>();
        List<String> deviceId = new List<String>();
        List<String> displayname = new List<String>();
        List<String> displaytype = new List<String>();
        List<long> id = new List<long>();
        List<String> label = new List<String>();
        List<long> originvalue = new List<long>();
        List<String> type = new List<String>();
        List<String> typename = new List<String>();
        List<long> value = new List<long>();


        long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds() * 1000000;
    
        Random random = new Random();
        for (int i = 0; i < numDevices; i++)
        {
            for (int j = 0; j < numLongPoint; j++)
            {
                measurement.Add("measure" + j);
                time.Add(startTime + i * 1000);
                coefficient.Add(random.Next());
                coefficientext.Add(random.Next());
                decimalplaces.Add(random.Next());
                deviceId.Add("dev" + i);
                displayname.Add("deve" + i);
                displaytype.Add("name" + i);
                id.Add(random.Next());
                label.Add("label_" + i);
                originvalue.Add(random.Next());
                type.Add("type" + i);
                typename.Add("typeName" + i);
                value.Add(random.Next());
            }
        }


        BasicStringVector mstrp = new BasicStringVector(measurement.ToArray());
        cols.Add(mstrp);
        BasicNanoTimestampVector tp = new BasicNanoTimestampVector(time.ToArray());
        //BasicLongVector tp = new BasicLongVector(time.ToArray());
        cols.Add(tp);
        BasicFloatVector cp = new BasicFloatVector(coefficient.ToArray());
        cols.Add(cp);
        BasicFloatVector cpp = new BasicFloatVector(coefficientext.ToArray());
        cols.Add(cpp);
        BasicIntVector ip = new BasicIntVector(decimalplaces.ToArray());
        cols.Add(ip);
        BasicStringVector sp = new BasicStringVector(deviceId.ToArray());
        cols.Add(sp);
        BasicStringVector ssp = new BasicStringVector(displayname.ToArray());
        cols.Add(ssp);
        BasicStringVector sp3 = new BasicStringVector(displaytype.ToArray());
        cols.Add(sp3);
        BasicLongVector ip2 = new BasicLongVector(id.ToArray());
        cols.Add(ip2);
        BasicStringVector sp4 = new BasicStringVector(label.ToArray());
        cols.Add(sp4);
        BasicLongVector fp = new BasicLongVector(originvalue.ToArray());
        cols.Add(fp);
        BasicStringVector tp2 = new BasicStringVector(type.ToArray());
        cols.Add(tp2);
        BasicStringVector tp3 = new BasicStringVector(typename.ToArray());
        cols.Add(tp3);
        BasicLongVector fp4 = new BasicLongVector(value.ToArray());
        cols.Add(fp4);

        BasicTable t = new BasicTable(colNames, cols);
        return t;
    }

    // 模拟String类型表
    public BasicTable mockStringData()
    {
        List<string> colNames = new List<string>() { "measurement", "time", "coefficient", "coefficientext", "decimalplaces", "deviceId", "displayname", "displaytype", "id", "label", "originvalue", "type", "typename", "value" };
        List<IVector> cols = new List<IVector>();

        List<String> measurement = new List<String>();
        List<long> time = new List<long>();
        List<float> coefficient = new List<float>();
        List<float> coefficientext = new List<float>();
        List<int> decimalplaces = new List<int>();
        List<String> deviceId = new List<String>();
        List<String> displayname = new List<String>();
        List<String> displaytype = new List<String>();
        List<long> id = new List<long>();
        List<String> label = new List<String>();
        List<long> originvalue = new List<long>();
        List<String> type = new List<String>();
        List<String> typename = new List<String>();
        List<String> value = new List<String>();


        long startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds() * 1000000;
  
        Random random = new Random();
        for (int i = 0; i < numDevices; i++)
        {
            for (int j = 0; j < numStringPonit; j++)
            {
                measurement.Add("measure" + j);
                time.Add(startTime + i * 1000);
                coefficient.Add(random.Next());
                coefficientext.Add(random.Next());
                decimalplaces.Add(random.Next());
                deviceId.Add("dev" + i);
                displayname.Add("deve" + i);
                displaytype.Add("name" + i);
                id.Add(random.Next());
                label.Add("label_" + i);
                originvalue.Add(random.Next());
                type.Add("type" + i);
                typename.Add("typeName" + i);
                value.Add("str" + random.Next());
            }
        }

        BasicStringVector mstrp = new BasicStringVector(measurement.ToArray());
        cols.Add(mstrp);

        BasicNanoTimestampVector tp = new BasicNanoTimestampVector(time.ToArray());
        //BasicLongVector tp = new BasicLongVector(time.ToArray());
        cols.Add(tp);
        BasicFloatVector cp = new BasicFloatVector(coefficient.ToArray());
        cols.Add(cp);
        BasicFloatVector cpp = new BasicFloatVector(coefficientext.ToArray());
        cols.Add(cpp);
        BasicIntVector ip = new BasicIntVector(decimalplaces.ToArray());
        cols.Add(ip);
        BasicStringVector sp = new BasicStringVector(deviceId.ToArray());
        cols.Add(sp);
        BasicStringVector ssp = new BasicStringVector(displayname.ToArray());
        cols.Add(ssp);
        BasicStringVector sp3 = new BasicStringVector(displaytype.ToArray());
        cols.Add(sp3);
        BasicLongVector ip2 = new BasicLongVector(id.ToArray());
        cols.Add(ip2);
        BasicStringVector sp4 = new BasicStringVector(label.ToArray());
        cols.Add(sp4);
        BasicLongVector fp = new BasicLongVector(originvalue.ToArray());
        cols.Add(fp);
        BasicStringVector tp2 = new BasicStringVector(type.ToArray());
        cols.Add(tp2);
        BasicStringVector tp3 = new BasicStringVector(typename.ToArray());
        cols.Add(tp3);
        BasicStringVector fp4 = new BasicStringVector(value.ToArray());
        cols.Add(fp4);

        BasicTable t = new BasicTable(colNames, cols);
        return t;
    }
}

// 测试写入
class Writer
{
    static string HOST = "192.193.168.2";
    static int PORT = 3302;
    static string USER = "admin";
    static string PASSWORD = "123456";

    private int seconds;
    private int tbId;

    private MockFactory mk;
    private DBConnection conn;

    private int okNum = 0;
    private int errNum = 0;
    private int rows = 0;

    bool init()
    {
        string[] sites = { "183.136.170.168:3302", "183.136.170.179:3302", "115.239.209.253:3302" };
        conn = new DBConnection();

        bool ret = conn.connect("183.136.170.168", 3302, "admin", "123456", "");
        if (!ret)
        {
            Console.WriteLine("Failed to connect to the server");
            return false;
        }

        return true;
    }

    public Writer(int seconds, int tbId)
    {
        this.seconds = seconds;
        this.tbId = tbId;
        this.mk = new MockFactory();
    }

    public int getOkNum()
    {
        return okNum;
    }

    public int getErrNum()
    {
        return errNum;
    }
    public int getRows()
    {
        return rows;
    }

    public void run()
    {
        bool ret = init();
        if (!ret) return;

        long currTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();

        long endTime = currTime + seconds * 1000;

        do
        {
            try
            {
                BasicTable st = mk.mockStringData();
                List<IEntity> args = new List<IEntity>(1);
                args.Add(st);
                BasicInt et = (BasicInt)conn.run("tableInsert{StringSTable" + tbId + "}", args);
                rows += et.getInt();



                BasicTable ft = mk.mockFloatData();
                List<IEntity> args2 = new List<IEntity>();
                args2.Add(ft);
                BasicInt et2 = (BasicInt)conn.run("tableInsert{FloatSTable" + tbId + "}", args2);
                rows += et2.getInt();

                BasicTable lt = mk.mockLongData();
                List<IEntity> args3 = new List<IEntity>();
                args3.Add(ft);
                BasicInt et3 = (BasicInt)conn.run("tableInsert{LongSTable" + tbId + "}", args3);
                rows += et3.getInt();


                okNum++;
            }
            catch (Exception e)
            {
                errNum++;
                Console.WriteLine("ERROR:" + e.Message);
            }


            long currentTime2 = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            int elapsed = (int)(currentTime2 - currTime);
            if (elapsed < 1000)
            {
                Thread.Sleep(1000 - elapsed);
            }
            else
            {
                Console.WriteLine("takes:" + elapsed);
            }
            currTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
        } while (currTime < endTime);

        return;
    }
}


class WriterDFS
{
    static string HOST = "192.193.168.2";
    static int PORT = 3302;
    static string USER = "admin";
    static string PASSWORD = "123456";

    private int seconds;
    private int tbId;

    private MockFactory mk;
    private DBConnection conn;

    private int okNum = 0;
    private int errNum = 0;
    private int rows = 0;

    bool init()
    {
        string[] sites = { "183.136.170.168:3302", "183.136.170.179:3302", "115.239.209.253:3302" };
        conn = new DBConnection();

        bool ret = conn.connect("183.136.170.168", 3302, "admin", "123456", "");
        if (!ret)
        {
            Console.WriteLine("Failed to connect to the server");
            return false;
        }

        return true;
    }

    public WriterDFS(int seconds, int tbId)
    {
        this.seconds = seconds;
        this.tbId = tbId;
        this.mk = new MockFactory();
    }

    public int getOkNum()
    {
        return okNum;
    }

    public int getErrNum()
    {
        return errNum;
    }
    public int getRows()
    {
        return rows;
    }

    public void run()
    {
        bool ret = init();
        if (!ret) return;

        long currTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
        long endTime = currTime + seconds * 1000;

        do
        {
            try
            {
                BasicTable st = mk.mockStringData();
                List<IEntity> args = new List<IEntity>(1);
                args.Add(st);
                BasicInt et = (BasicInt)conn.run("tableInsert{loadTable('dfs://POC"+tbId+"', 'StringTable')}", args);
                rows += et.getInt();

                BasicTable ft = mk.mockFloatData();
                List<IEntity> args2 = new List<IEntity>();
                args2.Add(ft);
                BasicInt et2 = (BasicInt)conn.run("tableInsert{loadTable('dfs://POC"+tbId+"', 'FloatTable')}", args2);
                rows += et2.getInt();

                BasicTable lt = mk.mockLongData();
                List<IEntity> args3 = new List<IEntity>();
                args3.Add(lt);
                BasicInt et3 = (BasicInt)conn.run("tableInsert{loadTable('dfs://POC"+tbId+"', 'LongTable')}", args3);
                rows += et3.getInt();

                okNum++;
            }
            catch (Exception e)
            {
                errNum++;
                Console.WriteLine("ERROR:" + e.Message);
            }

            long currentTime2 = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            int elapsed = (int)(currentTime2 - currTime);
            if (elapsed < 1000)
            {
                Thread.Sleep(1000 - elapsed);
            }
            else
            {
                Console.WriteLine("takes:" + elapsed);
            }
            currTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
        } while (currTime < endTime);

        return;
    }
}


// 测试查询
class Query
{
    static string HOST = "183.136.170.168";
    static int PORT = 3302;
    static string USER = "admin";
    static string PASSWORD = "123456";

    private int minutes;
    private string tableName;

    private int okNums = 0;
    private int errNums = 0;
    private int rows = 0;

    private DBConnection conn;
    public Query(int minutes, string tableName)
    {
        this.minutes = minutes;
        this.tableName = tableName;
    }

    public bool init()
    {
        string[] sites = { "183.136.170.168:3302", "183.136.170.179:3302", "115.239.209.253:3302" };
        conn = new DBConnection();

        bool ret = conn.connect("183.136.170.168", 3302, "admin", "123456", "");
        if (!ret)
        {
            Console.WriteLine("Failed to connect to the server");
            return false;
        }

        return true;
    }

    public int getOkNum()
    {
        return okNums;
    }

    public int getErrNum()
    {
        return errNums;
    }
    
    public int getRows() {
        return rows;
    }
    public void run()
    {
        if (!init())
        {
            Console.WriteLine("init failed");
            return;
        }

        long currTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();

        long endTime = currTime + minutes * 60 * 1000;

        int index = 0;
        do
        {
            try
            {
                int randIndex = index % 50 + 1;
                int randDevId = index % 6 + 1;

                string script = "select last(value) from " + tableName + randIndex + " where deviceId='dev" + randDevId + "'";
                //Console.WriteLine(script);
                BasicTable t = (BasicTable)conn.run(script);
                int ct = t.rows();

                rows += ct;
                if (ct < 1)
                {
                    Console.WriteLine("ct less than 1");
                }

                okNums++;
            }
            catch (Exception e)
            {
                errNums++;
            }

            currTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            ++index;
        } while (currTime < endTime);
    }

}

class DolphinDBPOC
{
    //测试查询QPS
    public static void testQPS()
    {
        int numThreads = 50;
        int minutes = 1;

        string[] tableNames = { "FloatSTable", "LongSTable", "StringSTable" };

        List<Query> queries = new List<Query>();
        List<Thread> ths = new List<Thread>();
        Random rand = new Random();

        for (int i = 0; i < numThreads; i++)

        {
            Query tmp = new Query(minutes, tableNames[rand.Next(0, 3)]);
            queries.Add(tmp);
        }

        for (int i = 0; i < numThreads; i++)
        {
            Thread tmp = new Thread(queries[i].run);
            ths.Add(tmp);
        }

        for (int i = 0; i < numThreads; i++)
        {
            ths[i].Start();
        }

        for (int i = 0; i < numThreads; i++)
        {
            ths[i].Join();
        }

        int totalOks = 0;
        int totalErrs = 0;
        int totalRows = 0;

        for (int i = 0; i < numThreads; i++)
        {
            totalOks += queries[i].getOkNum();
            totalErrs += queries[i].getErrNum();
            totalRows += queries[i].getRows();
        }

        Console.WriteLine("oks:" + totalOks);
        Console.WriteLine("errs:" + totalErrs);
        Console.WriteLine("rows:" + totalRows);
        Console.WriteLine("QPS:" + totalOks / minutes / 60);
        Console.WriteLine("test end");

    }

    // 模拟数据写入DFS表
    public static void testWriteDFS() {
        // 模拟50个工厂
        int facNum = 50;
        List<WriterDFS> lr = new List<WriterDFS>();
        List<Thread> ths = new List<Thread>();

        for (int i = 1; i <= facNum; i++)
        {
            WriterDFS r = new WriterDFS(60, i);
            lr.Add(r);
        }

        for (int i = 0; i < facNum; i++)
        {
            Thread tmp = new Thread(lr[i].run);
            ths.Add(tmp);
        }

        for (int i = 0; i < facNum; i++)
        {
            ths[i].Start();
        }

        for (int i = 0; i < facNum; i++)
        {
            ths[i].Join();
        }

        int totalOk = 0;
        int totalErr = 0;
        int totalOkRows = 0;

        for (int i = 0; i < facNum; i++)
        {
            totalOk += lr[i].getOkNum();
            totalErr += lr[i].getErrNum();
            totalOkRows += lr[i].getRows();
        }


        Console.WriteLine("totalOk:" + totalOk);
        Console.WriteLine("totalErr:" + totalErr);
        Console.WriteLine("totalOkRows:" + totalOkRows);
        Console.WriteLine("test finished");
    }

    //模拟数据写入流表    
    public static void testWriteStreamTable() {
        // 模拟50个工厂
        int facNum = 50;
        List<Writer> lr = new List<Writer>();
        List<Thread> ths = new List<Thread>();

        for (int i = 1; i <= facNum; i++)
        {
            Writer r = new Writer(60, i);
            lr.Add(r);
        }

        for (int i = 0; i < facNum; i++)
        {
            Thread tmp = new Thread(lr[i].run);
            ths.Add(tmp);
        }

        for (int i = 0; i < facNum; i++)
        {
            ths[i].Start();
        }

        for (int i = 0; i < facNum; i++)
        {
            ths[i].Join();
        }

        int totalOk = 0;
        int totalErr = 0;
        int totalOkRows = 0;

        for (int i = 0; i < facNum; i++)
        {
            totalOk += lr[i].getOkNum();
            totalErr += lr[i].getErrNum();
            totalOkRows += lr[i].getRows();
        }


        Console.WriteLine("totalOk:" + totalOk);
        Console.WriteLine("totalErr:" + totalErr);
        Console.WriteLine("totalOkRows:" + totalOkRows);
        Console.WriteLine("test finished");
    }
    
    public static void Main()
    {
        //testQPS();
        //testWriteStreamTable();
        testWriteDFS();
    }
}