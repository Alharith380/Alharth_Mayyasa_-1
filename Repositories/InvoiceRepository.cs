using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using project.Classes;

namespace project.Repositories
{
    public sealed class InvoiceRepository
    {
        private const string _invoicesDir = "Data\\Invoices";
        private static readonly object _lock = new object();

        public InvoiceRepository()
        {
            if (!Directory.Exists(_invoicesDir))
                Directory.CreateDirectory(_invoicesDir);
        }

        //=================================== تحميل جميع الفواتير كـ Dictionary =======================================
        public Dictionary<int, Invoice> LoadAllAsDictionary()
        {
            lock (_lock)
            {
                string[] files = Directory.GetFiles(_invoicesDir, "*.inv");
                Dictionary<int, Invoice> invoices = new Dictionary<int, Invoice>();

                foreach (string file in files)
                {
                    try
                    {
                        string json = File.ReadAllText(file);
                        Invoice invoice = JsonConvert.DeserializeObject<Invoice>(json);
                        if (invoice != null && !invoices.ContainsKey(invoice.Id))
                        {
                            invoices.Add(invoice.Id, invoice);
                        }
                    }
                    catch
                    {
                        /* تجاهل الملفات التالفة */
                    }
                }

                return invoices;
            }
        }

        //=================================== تحميل جميع الفواتير كـ List (للتوفيق مع الكود القديم) =======================================
        public List<Invoice> LoadAll()
        {
            var invoicesDict = LoadAllAsDictionary();
            return new List<Invoice>(invoicesDict.Values);
        }

        //=================================== تحميل فاتورة حسب الرقم =======================================
        public Invoice LoadById(int id)
        {
            string path = Path.Combine(_invoicesDir, id + ".inv");
            if (!File.Exists(path)) return null;

            try
            {
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<Invoice>(json);
            }
            catch
            {
                return null; // تجاهل الملفات التالفة
            }
        }

        //=================================== حفظ فاتورة =======================================
        public void Save(Invoice invoice)
        {
            lock (_lock)
            {
                if (invoice.Id <= 0)
                    invoice.Id = GetNextId();

                string path = Path.Combine(_invoicesDir, invoice.Id + ".inv");
                string json = JsonConvert.SerializeObject(invoice, Formatting.Indented);
                File.WriteAllText(path, json);
            }
        }

        //=================================== حذف فاتورة =======================================
        public void Delete(int id)
        {
            string path = Path.Combine(_invoicesDir, id + ".inv");
            if (File.Exists(path))
                File.Delete(path);
        }

        //=================================== الحصول على الرقم التالي =======================================
        
    

public int GetNextId()
            {
                string[] files = Directory.GetFiles(_invoicesDir, "*.inv");
                if (files.Length == 0)
                    return 1;

                int maxId = 0;
                foreach (string f in files)
                {
                    string name = Path.GetFileNameWithoutExtension(f);
                    int id; // ← الإعلان خارج (لتوافق C# القديم)
                    if (int.TryParse(name, out id) && id > maxId)
                        maxId = id;
                }
                return maxId + 1;
            }
        }
    }