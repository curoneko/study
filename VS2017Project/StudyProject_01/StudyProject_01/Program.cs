using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

using CommonUtil.Json;
using StudyProject_01.data;


namespace StudyProject_01
{
    class Program
    {
        static void Main(string[] args)
        {
            HowToJsonUtil();
            RestSharpSample();

            Console.ReadLine();
        }
        
        /// <summary>
        /// JsonUtilクラスのシリアライズ/デシリアライズの使い方
        /// </summary>
        static void HowToJsonUtil()
        {
            JsonTestData data = new JsonTestData()
            {
                id = 10,
                name = "Arisugawa Tsubasa",
                age = 16,
                height = 150.3,
                whight = 35.5,
            };
            
            // シリアライズ
            String json = Json.Serializer<JsonTestData>(data);
            Console.WriteLine("Serializer :{0}",json);

            // デシリアライズ
            JsonTestData dataDes = Json.Deserialization<JsonTestData>(json);
            Console.WriteLine("dataDes.id :{0}", dataDes.id);
            Console.WriteLine("dataDes.name :{0}", dataDes.name);
            Console.WriteLine("dataDes.age :{0}", dataDes.age);
            Console.WriteLine("dataDes.height :{0}", dataDes.height);
            Console.WriteLine("dataDes.whight :{0}", dataDes.whight);

        }

        static void RestSharpSample()
        {
            var client = new RestClient("https://example/rest/updateInfo");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json; charset=UTF-8");
            request.AddHeader("accept-charset", "Shift_JIS, UTF-8");
            request.AddParameter("application/json; charset=UTF-8", "{\"id\": 10, \"name\": \"Arisugawa Tsubasa\",\"age\": 16}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            
            Console.WriteLine(response.Content);
        }
    }
}
