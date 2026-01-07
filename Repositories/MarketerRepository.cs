using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using project.Classes;
using project.Classes.project.Classes;

namespace project.Repositories
{

        public sealed class MarketerRepository
        {
            private const string FilePath = "Data/marketers.json";
            private static readonly object _lock = new object();

            public MarketerRepository()
            {
                string dir = Path.GetDirectoryName(FilePath);
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                if (!File.Exists(FilePath))
                    File.WriteAllText(FilePath, "[]");
            }

            public List<Marketer> LoadAll()
            {
                lock (_lock)
                {
                    string json = File.ReadAllText(FilePath);
                    return JsonConvert.DeserializeObject<List<Marketer>>(json) ?? new List<Marketer>();
                }
            }

            public void Save(Marketer marketer)
            {
                lock (_lock)
                {
                    List<Marketer> marketers = LoadAll();
                    Marketer existing = marketers.Find(m => m.Id == marketer.Id);
                    if (existing != null)
                    {
                        int index = marketers.IndexOf(existing);
                        marketers[index] = marketer;
                    }
                    else
                    {
                        marketer.Id = GetNextId(marketers);
                        marketers.Add(marketer);
                    }
                    string json = JsonConvert.SerializeObject(marketers, Formatting.Indented);
                    File.WriteAllText(FilePath, json);
                }
            }

            public void Delete(int id)
            {
                lock (_lock)
                {
                    List<Marketer> marketers = LoadAll();
                    marketers.RemoveAll(m => m.Id == id);
                    string json = JsonConvert.SerializeObject(marketers, Formatting.Indented);
                    File.WriteAllText(FilePath, json);
                }
            }

            private static int GetNextId(List<Marketer> marketers)
            {
                return marketers.Count == 0 ? 1 : marketers[marketers.Count - 1].Id + 1;
            }
        }
    }