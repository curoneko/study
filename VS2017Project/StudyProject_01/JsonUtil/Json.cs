using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

namespace CommonUtil.Json
{
    public static class Json
    {

        /// <summary>
        /// JSONシリアライズ。
        /// データ(data)をJSON文字列に変換
        /// </summary>
        /// <typeparam name="T">JSON</typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serializer<T>(T data)
        {
            string json = string.Empty;
            try
            {
                DataContractJsonSerializer jSerializer = new DataContractJsonSerializer(typeof(T));
                using (MemoryStream ms = new MemoryStream())
                {
                    jSerializer.WriteObject(ms, data);
                    json = Encoding.UTF8.GetString(ms.ToArray());
                }
                return json;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// JSONデシリアライズ
        /// JSON文字列をデータ(data)に変換
        /// </summary>
        /// <typeparam name="T">JSON格納するオブジェクト</typeparam>
        /// <param name="jsondata">JSON文字列</param>
        /// <returns></returns>
        public static T Deserialization<T>(string jsondata)
        {
            try
            {
                DataContractJsonSerializer jSerializer = new DataContractJsonSerializer(typeof(T));
                byte[] jsonBytes = Encoding.UTF8.GetBytes(jsondata);

                T jsons = default(T);
                using (MemoryStream ms = new MemoryStream(jsonBytes))
                {
                    jsons = (T)jSerializer.ReadObject(ms);
                }
                return jsons;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
