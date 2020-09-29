using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;

namespace ConsoleApp1
{
    [DynamoDBTable("Student")]
    public class Student
    {
        public string date { get; set; }
        public float buy { get; set; }
        public float sell { get; set; }
        public float fix { get; set; }
        public float prev_buy { get; set; }
        public float prev_sell { get; set; }
    }
    public class Core
    {

        BasicAWSCredentials credentials = new BasicAWSCredentials("", "");
        AmazonDynamoDBClient client;
        DynamoDBContext context;
        string tableName = "banxico";
        public Core()
        {
            client = new AmazonDynamoDBClient(credentials, RegionEndpoint.USWest1);
        }
        public void CreateTable()
        {
            var tableResponse = client.ListTablesAsync().Result;
            if (!tableResponse.TableNames.Contains(tableName))
            {
                Console.WriteLine($"Table not found, creating table => {tableName}");
                client.CreateTableAsync(new CreateTableRequest
                {
                    TableName = tableName,
                    ProvisionedThroughput = new ProvisionedThroughput
                    {
                        ReadCapacityUnits = 3,
                        WriteCapacityUnits = 1
                    },
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement
                        {
                            AttributeName = "hashKey",
                            KeyType = KeyType.HASH
                        }
                    },
                    AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "hashKey", AttributeType=ScalarAttributeType.S }
                    }
                });

                bool isTableAvailable = false;
                while (!isTableAvailable)
                {
                    Console.WriteLine("Waiting for table to be active...");
                    Thread.Sleep(5000);
                    var tableStatus = client.DescribeTableAsync("tableName").Result;
                    isTableAvailable = tableStatus.Table.TableStatus == "ACTIVE";
                }
                Console.WriteLine("DynamoDB Table Created Successfully!");
            }
        }
        public void InsertItem()
        {
            {
                //Set a local DB context  
                var context = new DynamoDBContext(client);

                //Create an Student object to save  
                Student currentState = new Student
                {
                    //Id = Guid.NewGuid().ToString(),
                    date = DateTime.Now.ToShortDateString(),
                    buy = 10.5f,
                    sell = 11.1f,
                    fix = 12.5f,
                    prev_buy = 9.9f,
                    prev_sell = 10f
                };

                //Save an Student object  
                context.SaveAsync<Student>(currentState);

                Console.WriteLine("Student Record Inserted Successfully!");

            }
        }
        public void GetData()
        {
            //Set a local DB context  
            var context = new DynamoDBContext(client);

            Table StudentTable = Table.LoadTable(client, tableName);

            ScanFilter scanFilter = new ScanFilter();
            scanFilter.AddCondition("buy", ScanOperator.GreaterThanOrEqual, 1);

            Search search = StudentTable.Scan(scanFilter);

            List<Document> documentList = new List<Document>();

            //DGV.Rows.Clear();
            //DGV.ColumnCount = 4;

            //DGV.Columns[0].Width = 270;

            //DataGridViewRow row = new DataGridViewRow();
            //row.CreateCells(DGV);
            //row.Cells[0].Value = "Student Id";
            //row.Cells[1].Value = "Student Name";
            //row.Cells[2].Value = "College Name";
            //row.Cells[3].Value = "Class Name";
            //row.DefaultCellStyle.BackColor = Color.Blue;
            //row.DefaultCellStyle.ForeColor = Color.White;
            //DGV.Rows.Add(row);
            do
            {
                documentList = search.GetNextSetAsync().Result;
                foreach (var document in documentList)
                {
                    //row = new DataGridViewRow();
                    //row.CreateCells(DGV);
                    foreach (var attribute in document.GetAttributeNames())
                    {
                        string stringValue = null;
                        var value = document[attribute];
                        if (value is Primitive)
                            stringValue = value.AsPrimitive().Value.ToString();
                        else if (value is PrimitiveList)
                            stringValue = string.Join(",", (from primitive
                                            in value.AsPrimitiveList().Entries
                                                            select primitive.Value).ToArray());
                        if (attribute == "studentId")
                        {
                            //row.Cells[0].Value = stringValue;
                        }
                        else if (attribute == "studentName")
                        {
                            //row.Cells[1].Value = stringValue;
                        }
                        else if (attribute == "collegeName")
                        {
                            //row.Cells[2].Value = stringValue;
                        }
                        else if (attribute == "className")
                        {
                            //row.Cells[3].Value = stringValue;
                        }
                    }
                    //DGV.Rows.Add(row);


                }
            } while (!search.IsDone);

            //foreach (DataGridViewColumn c in DGV.Columns)
            //{
            //    c.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            //}

            //PnlGrid.Visible = true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Core core = new Core();
            //core.CreateTable();
            //core.InsertItem();
            core.GetData();
            //var options = new CredentialProfileOptions
            //{
            //    AccessKey = "",
            //    SecretKey = ""
            //};
            //var profile = new CredentialProfile("basic_profile", options);
            //profile.Region = RegionEndpoint.USWest1;
            //var netSDKFile = new NetSDKCredentialsFile();
            //netSDKFile.RegisterProfile(profile);

            //AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
            //clientConfig.RegionEndpoint = RegionEndpoint.USWest1;
            //AmazonDynamoDBClient client = new AmazonDynamoDBClient(clientConfig);

            //Console.WriteLine("Hello World!");
        }
    }
}
