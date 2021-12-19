using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json;

namespace TgaCase.SharedKernel.Utilities
{
    public static  class TranslateUtil
    {
        public static string TurkishToEnglish(string comment)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                "tr", "en", Uri.EscapeUriString(comment));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);
            var translationItems = jsonData[0]; 
            string translation = "";

            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;

                IEnumerator translationLineString = translationLineObject.GetEnumerator();

                translationLineString.MoveNext();

                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            httpClient.Dispose();
            return translation;
        }
    }
}