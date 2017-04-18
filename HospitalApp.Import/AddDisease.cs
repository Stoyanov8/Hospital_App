using System;
using System.Collections.Generic;
using System.IO;
using HospitalApp.Data;
using HospitalApp.Data.Dtos;
using Models;
using Newtonsoft.Json;

namespace HospitalApp.Import
{
    public class AddDisease
    {
        public static void AddDiseases()
        {
            var json = File.ReadAllText("../../../datasets/disease.json");
            var diseases = JsonConvert.DeserializeObject<IEnumerable<DiseaseDto>>(json);
            AddDisease.AddDiseases(diseases);
        }

        public static void AddDiseases(IEnumerable<DiseaseDto> diseases)
        {
            using (var context = new HospitalAppEntities())
            {
                foreach (var disease in diseases)
                {
                    context.Diseases.Add(new Disease
                    {
                        Name = disease.Name,
                        Description = disease.Description,
                        Complexity = disease.Complexity

                    });

                    Console.WriteLine($"Added new disease : {disease.Name}");
                    
                }


                context.SaveChanges();
            }
        }
    }
}