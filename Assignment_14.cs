using System;
using System.Collections.Generic;
using System.IO;

namespace Vivek_Assignment_FAI
{
    class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public double BillAmount { get; set; }

        // Constructor
        public Patient(int id, string name, string phoneNo, double billAmount)
        {
            ID = id;
            Name = name;
            PhoneNo = phoneNo;
            BillAmount = billAmount;
        }

        // Write patient details to a CSV file
        public static void WriteToFile(List<Patient> patients, string filePath)
        {
            try
            {
                // Open the file for writing
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write header
                    writer.WriteLine("ID,Name,Phone No,Bill Amount");

                    // Write patient details
                    foreach (Patient p in patients)
                    {
                        writer.WriteLine("{0},{1},{2},{3}", p.ID, p.Name, p.PhoneNo, p.BillAmount);
                    }
                }
                Console.WriteLine("Patient details written to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while writing to file: {0}", ex.Message);
            }
        }

        // Read patient details from a CSV file
        public static List<Patient> ReadFromFile(string filePath)
        {
            List<Patient> patients = new List<Patient>();
            try
            {
                // Open the file for reading
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read header
                    string header = reader.ReadLine();

                    // Read patient details
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        int id = int.Parse(values[0]);
                        string name = values[1];
                        string phoneNo = values[2];
                        double billAmount = double.Parse(values[3]);
                        patients.Add(new Patient(id, name, phoneNo, billAmount));
                    }
                }
                Console.WriteLine("Patient details read from file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while reading from file: {0}", ex.Message);
            }
            return patients;
        }
    }
}
