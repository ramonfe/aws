using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using AmazonDynamoDB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AmazonDynamoDB
{
    public partial class FrmDynamoDB : Form
    {
        private const string accessKey = "";
        private const string secretKey = "";

        string tableName = "banxico";
        string hashKey = "transId";
        AmazonDynamoDBClient client;
        DynamoDBContext context;

        public FrmDynamoDB()
        {
            InitializeComponent();
        }

        private void FrmDynamoDB_Load(object sender, EventArgs e)
        {
            CreateTable();
        }

        private void CreateTable()
        {
            var credentials = new BasicAWSCredentials(accessKey, secretKey);
            client = new AmazonDynamoDBClient(credentials, RegionEndpoint.USWest1);

            var tableResponse = client.ListTables();
            if (!tableResponse.TableNames.Contains(tableName))
            {
                MessageBox.Show("Table not found, creating table => " + tableName);
                client.CreateTable(new CreateTableRequest
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
                            AttributeName = hashKey,
                            KeyType = KeyType.HASH
                        }
                    },
                    AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = hashKey, AttributeType=ScalarAttributeType.S }
                    }
                });

                bool isTableAvailable = false;
                while (!isTableAvailable)
                {
                    Console.WriteLine("Waiting for table to be active...");
                    Thread.Sleep(5000);
                    var tableStatus = client.DescribeTable(tableName);
                    isTableAvailable = tableStatus.Table.TableStatus == "ACTIVE";
                }
                MessageBox.Show("DynamoDB Table Created Successfully!");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Set a local DB context
            context = new DynamoDBContext(client);

            //Create an Student object to save
            banxico currentState = new banxico
            {
                transId = Guid.NewGuid().ToString(),
                date = DateTime.Now.ToShortDateString(),
                buy = 10.5f,
                sell = 11.1f,
                fix = 12.5f,
                prev_buy = 9.9f,
                prev_sell = 10f
            };

            ////Create an Student object to save
            //Student currentState = new Student
            //{
            //    studentId = Guid.NewGuid().ToString(),
            //    studentName = TxtStudentName.Text,
            //    collegeName = TxtCollegeName.Text,
            //    className = TxtClassName.Text,
            //    isActive = 1
            //};

            //Save an Student object
            context.Save<banxico>(currentState);

            MessageBox.Show("Student Record Inserted Successfully!");

            PnlInsert.Visible = false;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            TxtStudentName.Text = string.Empty;
            TxtCollegeName.Text = string.Empty;
            TxtClassName.Text = string.Empty;
            PnlInsert.Visible = true;
        }

        private void BtnCancel1_Click(object sender, EventArgs e)
        {
            PnlInsert.Visible = false;
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            //Set a local DB context
            context = new DynamoDBContext(client);

            Table StudentTable = Table.LoadTable(client, tableName);

            ScanFilter scanFilter = new ScanFilter();
            scanFilter.AddCondition("buy", ScanOperator.GreaterThanOrEqual, 1);

            Search search = StudentTable.Scan(scanFilter);

            List<Document> documentList = new List<Document>();

            DGV.Rows.Clear();
            DGV.ColumnCount = 4;

            DGV.Columns[0].Width = 270;

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(DGV);
            row.Cells[0].Value = "Student Id";
            row.Cells[1].Value = "Student Name";
            row.Cells[2].Value = "College Name";
            row.Cells[3].Value = "Class Name";
            row.DefaultCellStyle.BackColor = Color.Blue;
            row.DefaultCellStyle.ForeColor = Color.White;
            DGV.Rows.Add(row);
            do
            {
                documentList = search.GetNextSet();
                foreach (var document in documentList)
                {
                    row = new DataGridViewRow();
                    row.CreateCells(DGV);
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
                        if (attribute == "date")
                        {
                            row.Cells[0].Value = stringValue;
                        }
                        else if (attribute == "buy")
                        {
                            row.Cells[1].Value = stringValue;
                        }
                        else if (attribute == "sell")
                        {
                            row.Cells[2].Value = stringValue;
                        }
                        else if (attribute == "fix")
                        {
                            row.Cells[3].Value = stringValue;
                        }
                    }
                    DGV.Rows.Add(row);


                }
            } while (!search.IsDone);

            foreach (DataGridViewColumn c in DGV.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            }

            PnlGrid.Visible = true;
        }

        private void BtnCancel2_Click(object sender, EventArgs e)
        {
            PnlGrid.Visible = false;
        }
    }
}
