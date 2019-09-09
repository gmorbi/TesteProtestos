using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WF.PROTESTO
{
    class LerArquivo
    {
        public string ProcessarArquivo(string arquivo)
        {
            var csv = new List<string[]>();
            string json;
            var linhas = File.ReadAllLines(arquivo);
            foreach (var linha in linhas)
            {
                csv.Add(linha.Split('\t'));
            }

            var properties = linhas[0].Split('\t');
            var listObjResult = new List<Dictionary<string, string>>();
            for (int i = 1; i < linhas.Length; i++)
            {
                var objResult = new Dictionary<string, string>();
                for (int j = 0; j < properties.Length; j++)
                {
                    objResult.Add(properties[j], csv[i][j]);
                }
                    listObjResult.Add(objResult);
            }
            json = JsonConvert.SerializeObject(listObjResult);

            return json;
        }
    }
}