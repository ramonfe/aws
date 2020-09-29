using Amazon.DynamoDBv2.DataModel;

namespace AmazonDynamoDB.Models
{
    [DynamoDBTable("Student")]
    public class Student
    {
        public string studentId { get; set; }
        public string studentName { get; set; }
        public string collegeName { get; set; }
        public string className { get; set; }
        public int isActive { get; set; } 
    }
    public class banxico
    {
        public string transId { get; set; }
        public string date { get; set; }
        public float buy { get; set; }
        public float sell { get; set; }
        public float fix { get; set; }
        public float prev_buy { get; set; }
        public float prev_sell { get; set; }
    }
}
